using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Sql;
using FinalProject.Classes;


namespace FinalProject.Database
{
	class DbMySQL : DBConnection
	{
		// Fields
		private static string connectionString;
		private static DbMySQL instance;

		// Constructor
		private DbMySQL(string connectionString) : base(connectionString) { }

		public static DbMySQL Instance
		{
			get
			{
				if (instance == null)
					instance = new DbMySQL(connectionString);
				return instance;
			}
		}

		public static string ConnectionString
		{
			get { return connectionString; }
			set
			{
				connectionString = string.Format("Server=localhost; database=" + value + "; UID=root; password=");
			}
		}

		// Authenticates Password through LogIn ID
		public string AuthenticatePassword(LogIn p)
		{
			string str = "";
			string cmdStr = "SELECT * FROM login WHERE id = " + "'" + p.ID + "'";
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						str = reader.GetString(1); // get password
					else
						str = "Empty";
				}
				Disconnect();
				return str;
			}
		}

		// Authenticates Employee through ID
		public Employee AuthenticateEmployee(string id)
		{
			Employee emp = null;
			string cmdStr = "SELECT * FROM employee WHERE id = '" + id + "'";
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						emp = new Employee(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), int.Parse(reader.GetString(9)));
				}
				Disconnect();
				return emp;
			}
		}

		// Finds and gathers Employee info from Database
		public Employee[] findEmployee(string id)
		{
			Employee[] emp = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT * FROM employee WHERE id Like '%" + id + "%'";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				emp = new Employee[dt.Rows.Count];
				for (int i = 0; i < emp.Length; i++)
				{
					emp[i] = new Employee(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), double.Parse(dt.Rows[i][9].ToString()));
				}
			}
			return emp;
		}

		// Updates the Employee info
		public void UpdateEmployee(Employee Item)
		{
			string cmdStr = "UPDATE employee SET firstName = @firstName, lastName = @lastName, mail = @mail, city = @city, " +
			"street = @street, numberhouse = @numberhouse, mobile = @mobile, role = @role WHERE id = @id";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", Item.ID);
				command.Parameters.AddWithValue("@firstName", Item.FirstName);
				command.Parameters.AddWithValue("@lastName", Item.LastName);
				command.Parameters.AddWithValue("@mail", Item.Mail);
				command.Parameters.AddWithValue("@city", Item.City);
				command.Parameters.AddWithValue("@street", Item.Street);
				command.Parameters.AddWithValue("@numberhouse", Item.HouseNumber);
				command.Parameters.AddWithValue("@mobile", Item.PhoneNumber);
				command.Parameters.AddWithValue("@role", Item.Role);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers Lot info from Database and stores list of cars from lot to array
		public Lot[] findParking(string comand) // TODO: 0 references
		{
			DataSet ds = new DataSet();
			Lot[] lot = null;
			string cmdStr = comand;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				lot = new Lot[dt.Rows.Count];
				Car c;
				for (int i = 0; i < lot.Length; i++)
				{
					c = new Car(dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), (int)dt.Rows[i][11], dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), (DateTime)dt.Rows[i][15], dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), dt.Rows[i][18].ToString(), (DateTime)dt.Rows[i][20], (double)dt.Rows[i][19]);
					lot[i] = new Lot((int)dt.Rows[i][0], c, (DateTime)dt.Rows[i][2], (int)dt.Rows[i][3], dt.Rows[i][4].ToString());
				}
			}
			return lot;
		}

		// Updates the Password through ID and password
		public void UpdatePassword(string ID, string password)
		{
			string cmdStr = "UPDATE login SET password = @password WHERE id = @id";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", ID);
				command.Parameters.AddWithValue("@password", password);
				base.ExecuteSimpleQuery(command);
			}
		}


		public int GetGridSize(string str) // TODO: 0 references
		{
			int result;
			string cmdStr = "SELECT COUNT(*) FROM " + str;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				result = ExecuteScalarIntQuery(command);
			}
			return result;
		}

		// Gathers Lot info from Database and stores list of cars to array
		public Lot[] ParkingList()
		{
			DataSet ds = new DataSet();
			Lot[] lot = null;
			string cmdStr = "SELECT `lot`.*,`car`.* FROM `lot` JOIN `car` WHERE `lot`.`LicenceNumber`=`car`.`license_number`";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				lot = new Lot[dt.Rows.Count];
				Car c;
				for (int i = 0; i < lot.Length; i++)
				{
					c = new Car(dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), (int)dt.Rows[i][11], dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), (DateTime)dt.Rows[i][15], dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), dt.Rows[i][18].ToString(), (DateTime)dt.Rows[i][20], (double)dt.Rows[i][19]);
					lot[i] = new Lot((int)dt.Rows[i][0], c, (DateTime)dt.Rows[i][2], (int)dt.Rows[i][3], dt.Rows[i][4].ToString());
				}
			}
			return lot;
		}

		// Gathers Contract info from Database and stores list of cars and constumers with
		// specific constumer ID to array
		public Contract[] ContractList(string id)
		{
			DataSet ds = new DataSet();
			Contract[] contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`contract`.CostumerID=`customers`.ID)AND(`contract`.`CostumerID`=" + id + ")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contract = new Contract[dt.Rows.Count];
				Car c;
				Costumer cos;
				for (int i = 0; i < contract.Length; i++)
				{
					cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][14], dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contract[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
				}
			}
			return contract;
		}

		// Gathers Contract info from Database and stores car with specific constumer to dataType Contract
		public Contract ContractCar(string licenseNumber)
		{
			DataSet ds = new DataSet();
			Contract contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`contract`.CostumerID=`customers`.ID)AND(`contract`.`LicenseNumber`=" + licenseNumber + ")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				Costumer cos = new Costumer(dt.Rows[0][21].ToString(), dt.Rows[0][22].ToString(), dt.Rows[0][23].ToString(), dt.Rows[0][26].ToString(), dt.Rows[0][25].ToString(), dt.Rows[0][24].ToString());
				Car c = new Car(dt.Rows[0][4].ToString(), (int)dt.Rows[0][5], dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), (int)dt.Rows[0][10], dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), (DateTime)dt.Rows[0][14], dt.Rows[0][15].ToString(), dt.Rows[0][16].ToString(), dt.Rows[0][17].ToString(), (DateTime)dt.Rows[0][19], (double)dt.Rows[0][18]);
				contract = new Contract(c, cos, (int)dt.Rows[0][0], (DateTime)dt.Rows[0][3]);
			}
			return contract;
		}

		// Gathers Contract info from Database and stores list of sold cars on contracts to array
		public Contract[] ContractList()
		{
			DataSet ds = new DataSet();
			Contract[] contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`contract`.CostumerID=`customers`.ID)AND(`car`.`status`!='נמכר')";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contract = new Contract[dt.Rows.Count];
				Car c;
				Costumer cos;
				for (int i = 0; i < contract.Length; i++)
				{
					cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][14], dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contract[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
				}
			}
			return contract;
		}


		public void UpdateCar(string millage, string carNumber) // TODO: 0 references
		{
			string cmdStr = "UPDATE Car SET	(millage) VALUES(@millage) WHERE car.licenseNumber = " + carNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@millage", millage);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Inserts mission through contact number, mission and fault description
		public void InsertMission(string id, int cNumber, string mission, string fDescripion)
		{
			string cmdStr = "INSERT INTO mission (id, ContractNumber, Mission, FaultDescription, DateMission)" +
				"VALUES(@id, @ContractNumber, @Mission, @FaultDescription, @DateMission)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", id);
				command.Parameters.AddWithValue("@ContractNumber", cNumber);
				command.Parameters.AddWithValue("@Mission", mission);
				command.Parameters.AddWithValue("@FaultDescription", fDescripion);
				command.Parameters.AddWithValue("@DateMission", DateTime.Now.Date);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds Candidate info to Database
		public void InsertCandidate(Candidate Item)
		{
			string cmdStr = "INSERT INTO Candidate (id, firstName, lastName, mail, city, street, numberhouse, mobile, role, experience, password)" +
				"VALUES(@id, @firstName, @lastName, @mail, @city, @street, @numberhouse, @mobile, @role, @experience, @password)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", Item.ID);
				command.Parameters.AddWithValue("@firstName", Item.FirstName);
				command.Parameters.AddWithValue("@lastName", Item.LastName);
				command.Parameters.AddWithValue("@mail", Item.Mail);
				command.Parameters.AddWithValue("@city", Item.City);
				command.Parameters.AddWithValue("@street", Item.Street);
				command.Parameters.AddWithValue("@numberhouse", Item.HouseNumber);
				command.Parameters.AddWithValue("@mobile", Item.PhoneNumber);
				command.Parameters.AddWithValue("@role", Item.Role);
				command.Parameters.AddWithValue("@experience", Item.Experience);
				command.Parameters.AddWithValue("@password", Item.Password);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds Car info to Database
		public void InsertCar(Car Item)
		{
			string cmdStr = "INSERT INTO Car (MVA_number, license_number, visible_brand, visible_model,	Engine_capacity,color, year_of_car, millage, cod_in_car, status, date_of_test, purpose_of_car, data_of_car, name_of_company, date_of_last_car_care,price)" +
				"VALUES(@MVA_number, @license_number, @visible_brand, @visible_model,@engi_capacity,@color, @year_of_car, @millage, @cod_in_car, @status, @date_of_test, @purpose_of_car, @data_of_car, @name_of_company, @date_of_last_car_care,@price)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@MVA_number", Item.MVANumber);
				command.Parameters.AddWithValue("@license_number", Item.LicenseNumber);
				command.Parameters.AddWithValue("@visible_brand", Item.Brand);
				command.Parameters.AddWithValue("@visible_model", Item.Model);
				command.Parameters.AddWithValue("@engi_capacity", Item.Engi_capacity);
				command.Parameters.AddWithValue("@color", Item.Color);
				command.Parameters.AddWithValue("@year_of_car", Item.YearOfCar);
				command.Parameters.AddWithValue("@millage", Item.Mileage);
				command.Parameters.AddWithValue("@cod_in_car", Item.CodeInCar);
				command.Parameters.AddWithValue("@status", Item.Status);
				command.Parameters.AddWithValue("@date_of_test", Item.DateOfTest);
				command.Parameters.AddWithValue("@purpose_of_car", Item.PurposeOfCar);
				command.Parameters.AddWithValue("@data_of_car", Item.DataOfCar);
				command.Parameters.AddWithValue("@name_of_company", Item.NameOfCompany);
				command.Parameters.AddWithValue("@date_of_last_car_care", Item.DateOfLastCarCare);
				command.Parameters.AddWithValue("@price", Item.Price);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds Candidate Car to Database
		public void InsertCandidateCar(Car Item)
		{
			string cmdStr = "INSERT INTO candidate_car (MVA_number, license_number, visible_brande, visible_model,Engine_capacity,color, year_of_car, millage, cod_in_car, status, date_of_test, purpose_of_car, data_of_car, name_of_company, date_of_last_car_care,price)" +
				"VALUES(@MVA_number, @license_number, @visible_brand, @visible_model,@engi_capacity,@color, @year_of_car, @millage, @cod_in_car, @status, @date_of_test, @purpose_of_car, @data_of_car, @name_of_company, @date_of_last_car_care,@price)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@MVA_number", Item.MVANumber);
				command.Parameters.AddWithValue("@license_number", Item.LicenseNumber);
				command.Parameters.AddWithValue("@visible_brand", Item.Brand);
				command.Parameters.AddWithValue("@visible_model", Item.Model);
				command.Parameters.AddWithValue("@engi_capacity", Item.Engi_capacity);
				command.Parameters.AddWithValue("@color", Item.Color);
				command.Parameters.AddWithValue("@year_of_car", Item.YearOfCar);
				command.Parameters.AddWithValue("@millage", Item.Mileage);
				command.Parameters.AddWithValue("@cod_in_car", Item.CodeInCar);
				command.Parameters.AddWithValue("@status", Item.Status);
				command.Parameters.AddWithValue("@date_of_test", Item.DateOfTest);
				command.Parameters.AddWithValue("@purpose_of_car", Item.PurposeOfCar);
				command.Parameters.AddWithValue("@data_of_car", Item.DataOfCar);
				command.Parameters.AddWithValue("@name_of_company", Item.NameOfCompany);
				command.Parameters.AddWithValue("@date_of_last_car_care", Item.DateOfLastCarCare);
				command.Parameters.AddWithValue("@price", Item.Price);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds Parking lot info to Database
		public void InsertParking(Car Item, int parkNum)
		{
			string cmdStr = "INSERT INTO lot(ParkingNumber,TypeCar, days_in_lot, LicenceNumber, Comments) VALUES(@ParkingNumber,@Type_car,@days_in_lot,@LicenceNumber,@Comments)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@ParkingNumber", parkNum);
				command.Parameters.AddWithValue("@Type_Car", Item.Status);
				command.Parameters.AddWithValue("@days_in_lot", DateTime.Today);
				command.Parameters.AddWithValue("@LicenceNumber", Item.LicenseNumber);
				command.Parameters.AddWithValue("@Comments", Item.PurposeOfCar);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds Meeting info to Database
		public void InsertMeeting(string id, string description, DateTime date)
		{
			string cmdStr = "INSERT INTO requests (Id, DateToComunity, explanationOfRequest)" +
				"VALUES(@Id, @DateToComunity, @explanationOfRequest)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@Id", id);
				command.Parameters.AddWithValue("@DateToComunity", date);
				command.Parameters.AddWithValue("@explanationOfRequest", description);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers Lot info from Database and stores list of cars to array
		public Lot[] ParkingList(string query)
		{
			DataSet ds = new DataSet();
			Lot[] lot = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				lot = new Lot[dt.Rows.Count];
				Car c;
				for (int i = 0; i < lot.Length; i++)
				{
					c = new Car(dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), (int)dt.Rows[i][11], dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), (DateTime)dt.Rows[i][15], dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), dt.Rows[i][18].ToString(), (DateTime)dt.Rows[i][20], (double)dt.Rows[i][19]);
					lot[i] = new Lot((int)dt.Rows[i][0], c, (DateTime)dt.Rows[i][2], (int)dt.Rows[i][3], dt.Rows[i][4].ToString());
				}
			}
			return lot;
		}

		// Gathers Lot info from Database and stores list of cars to array
		public Lot[] ParkingList(int licencenum)
		{
			DataSet ds = new DataSet();
			Lot[] lot = null;
			string cmdStr = "SELECT `lot`.*,`car`.*FROM `lot` JOIN `car` WHERE(`lot`.`LicenceNumber`=`car`.`license_number`)AND(`car`.`purpose_of_car`Like\"%מכירה%\")AND(`lot`.`LicenceNumber` LIKE '%" + licencenum + "%')";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				lot = new Lot[dt.Rows.Count];
				Car c;
				for (int i = 0; i < lot.Length; i++)
				{
					c = new Car(dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), (int)dt.Rows[i][11], dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), (DateTime)dt.Rows[i][15], dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), dt.Rows[i][18].ToString(), (DateTime)dt.Rows[i][20], (double)dt.Rows[i][19]);
					lot[i] = new Lot((int)dt.Rows[i][0], c, (DateTime)dt.Rows[i][2], (int)dt.Rows[i][3], dt.Rows[i][4].ToString());
				}
			}
			return lot;
		}

		// Utility function for Search cars to sell
		public string bildQueryForCarsToSell(string name, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "SELECT `lot`.*,`car`.* FROM `lot` JOIN `car` WHERE(`lot`.`LicenceNumber`=`car`.`license_number`)AND(`car`.`purpose_of_car`Like\"%מכירה%\")";
			spliter = name.Split('-');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split('-');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("licenseNum"))
					query += "AND(`lot`.`LicenceNumber`LIKE\"%" + splitInfo[i] + "%\")";
				if (splitNames[i].Equals("milegeNum"))
					query += "AND(`car`.`millage`<=" + splitInfo[i] + ")";
				if (splitNames[i].Equals("prices"))
					query += "AND(`car`.`price`<=" + splitInfo[i] + ")";
				if (splitNames[i].Equals("Brand_Model"))
				{
					string[] str;
					str = splitInfo[i].Split(' ');
					if (str.Length == 2 && str[0] != "" && str[1] != "")
						query += "AND((car.visible_model LIKE\"%" + str[1] + "%\")AND(car.visible_brand LIKE \"%" + str[0] + "%\"))";
					else
						query += "AND(`car`.`visible_brand` LIKE\"%" + splitInfo[i] + "%\")";
				}
			}
			return query;
		}

		// Utility function for Search contracts 
		public string bildQueryTofindContractSecutery(string name, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN `car`,`customers` WHERE (`contract`.`LicenseNumber`=`car`.`license_number`)AND(`contract`.`CostumerID`=`customers`.`ID`)AND(`car`.`status`='נמכר')";
			spliter = name.Split('-');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split('-');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("licenseNum"))
					query += "AND(`contract`.`LicenseNumber`LIKE\"%" + splitInfo[i] + "%\")";
				if (splitNames[i].Equals("ID"))
					query += "AND(`customers`.'ID'='" + splitInfo[i] + "')";
				if (splitNames[i].Equals("PhoneNumber"))
					query += "AND(`contract`.`PhoneNumber`='" + splitInfo[i] + "')";
				if (splitNames[i].Equals("ContractNum"))
					query += "AND(`contract`.`ContractNum`='" + splitInfo[i] + "')";
			}
			return query;
		}

		// Gathers Car info from Database and stores cars status (non) to array
		public Car[] CarToChange()
		{
			DataSet ds = new DataSet();
			Car[] chengCar = null;
			string cmdStr = "SELECT * FROM `candidate_car` WHERE `candidate_car`.`status`='Non'";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				chengCar = new Car[dt.Rows.Count];
				Car c;
				for (int i = 0; i < chengCar.Length; i++)
				{
					c = new Car(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (DateTime)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][15], (double)dt.Rows[i][14]);
					chengCar[i] = c;
				}
			}
			return chengCar;
		}

		// Deletes Candidate Car in Database
		public void deleteCandidateCar(int license_number)
		{
			string cmdStr = "DELETE FROM `candidate_car` WHERE `license_number`=@license_number";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@license_number", license_number);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers Lot info from Database and stores cars for sell to array
		public Lot[] ParkingListSell()
		{
			DataSet ds = new DataSet();
			Lot[] lot = null;
			string cmdStr = "SELECT `lot`.*,`car`.* FROM `lot` JOIN `car` WHERE (`lot`.`LicenceNumber`=`car`.`license_number`)AND(`car`.`purpose_of_car`Like\"%מכירה%\")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				lot = new Lot[dt.Rows.Count];
				Car c;
				for (int i = 0; i < lot.Length; i++)
				{
					c = new Car(dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), (int)dt.Rows[i][11], dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), (DateTime)dt.Rows[i][15], dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), dt.Rows[i][18].ToString(), (DateTime)dt.Rows[i][20], (double)dt.Rows[i][19]);
					lot[i] = new Lot((int)dt.Rows[i][0], c, (DateTime)dt.Rows[i][2], (int)dt.Rows[i][3], dt.Rows[i][4].ToString());
				}
			}
			return lot;
		}

		// Gathers Lot info from Database and stores list of cars to rent to array
		public Lot[] ParkingListRend()
		{
			DataSet ds = new DataSet();
			Lot[] lot = null;
			string cmdStr = "SELECT `lot`.*,`car`.* FROM `lot` JOIN `car` WHERE (`lot`.`LicenceNumber`=`car`.`license_number`)AND(`car`.`purpose_of_car`Like\"%השכרה%\")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				lot = new Lot[dt.Rows.Count];
				Car c;
				for (int i = 0; i < lot.Length; i++)
				{
					c = new Car(dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), (int)dt.Rows[i][11], dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), (DateTime)dt.Rows[i][15], dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), dt.Rows[i][18].ToString(), (DateTime)dt.Rows[i][20], (double)dt.Rows[i][19]);
					lot[i] = new Lot((int)dt.Rows[i][0], c, (DateTime)dt.Rows[i][2], (int)dt.Rows[i][3], dt.Rows[i][4].ToString());
				}
			}
			return lot;
		}

		// Gathers Contract info from Database and stores Sold cars to array
		public Contract[] ContractListSell()
		{
			DataSet ds = new DataSet();
			Contract[] contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`contract`.CostumerID=`customers`.ID)AND(`car`.`status`='נמכר')";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contract = new Contract[dt.Rows.Count];
				Car c;
				Costumer cos;
				for (int i = 0; i < contract.Length; i++)
				{
					cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][14], dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contract[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
				}
			}
			return contract;
		}

		// Gathers Contract info from Database and stores list of Contracts to array
		public Contract[] ContractListFind(string query)
		{
			DataSet ds = new DataSet();
			Contract[] contract = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contract = new Contract[dt.Rows.Count];
				Car c;
				Costumer cos;
				for (int i = 0; i < contract.Length; i++)
				{
					cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][14], dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contract[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
				}
			}
			return contract;
		}

		// Gathers Contract info from Database and stores in list of contracts with
		// specific car's license number
		public Contract[] ContractListFind(int licenceNum)
		{
			DataSet ds = new DataSet();
			Contract[] contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`car`.`license_number`=" + licenceNum + ")AND(`contract`.CostumerID=`customers`.ID)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contract = new Contract[dt.Rows.Count];
				Car c;
				Costumer cos;
				for (int i = 0; i < contract.Length; i++)
				{
					cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][14], dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contract[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
				}
			}
			return contract;
		}

		// Gathers Contract info from Database and stores list of contracts in array
		public Contract[] ContractToMissionListFind(int ContractNumber)
		{
			DataSet ds = new DataSet();
			Contract[] contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`contract`.`ContractNum`=" + ContractNumber + ")AND(`contract`.CostumerID=`customers`.ID)"; ;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contract = new Contract[dt.Rows.Count];
				Car c;
				Costumer cos;
				for (int i = 0; i < contract.Length; i++)
				{
					cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][14], dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contract[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
				}
			}
			return contract;
		}

		// Gathers Mission list from Database
		public MissionList[] missionEvents()
		{
			DataSet ds = new DataSet();
			MissionList[] missions = null;
			string cmdStr = "SELECT * FROM missionlist WHERE GARAGEID is NOT null";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				missions = new MissionList[dt.Rows.Count];
				MissionList mish;
				for (int i = 0; i < missions.Length; i++)
				{
					if (dt.Rows[i][3].ToString() != "")
						mish = new MissionList((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), (DateTime)dt.Rows[i][2], (DateTime)dt.Rows[i][3], (int)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]);
					else
						mish = new MissionList((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), (DateTime)dt.Rows[i][2], ((DateTime)dt.Rows[i][2]).AddDays(-1), (int)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]);

					missions[i] = mish;
				}
			}
			return missions;
		}

		// Utility function for Search in List of missions
		public MissionList[] missionEvents(string query)
		{
			DataSet ds = new DataSet();
			MissionList[] missions = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				missions = new MissionList[dt.Rows.Count];
				MissionList mish;
				for (int i = 0; i < missions.Length; i++)
				{
					if (dt.Rows[i][3].ToString() != "")
						mish = new MissionList((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), (DateTime)dt.Rows[i][2], (DateTime)dt.Rows[i][3], (int)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]);
					else
						mish = new MissionList((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), (DateTime)dt.Rows[i][2], ((DateTime)dt.Rows[i][2]).AddDays(-1), (int)dt.Rows[i][4], (int)dt.Rows[i][5], (int)dt.Rows[i][6]);

					missions[i] = mish;
				}
			}
			return missions;
		}

		// Gathers Mission info from Database and stores list of missions in array with
		// specific mission id
		public Mission[] MissionFinish(string id)
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE (`mission`.`id` IS NOT NULL)AND(`mission`.`Houers`>0)AND(`mission`.`id`=" + id + ")AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Gathers Mission info from Database and stores list of missions in array
		public Mission[] MissionFinish()
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE (`mission`.`id` IS NOT NULL) AND(`mission`.`Houers`>0) AND(`contract`.`ContractNum`=`mission`.`ContractNumber`) AND(`contract`.`LicenseNumber`=`car`.`license_number`) AND(mission.EventNumber NOT IN(SELECT EventNumber FROM missionlist WHERE 1))";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Utility function for Search in List of missions
		public Mission[] MissionFinishQ(string query)
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Gathers Mission info from Database and stores list of missions
		public Mission[] PersonalMission(string id)
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE (`mission`.`id` IS NOT NULL)AND(`mission`.`Houers`=0)AND(`mission`.`id`=" + id + ")AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Gathers Constumer info from Database and stores with specific contract number to dataType Constumer
		public Costumer FindCostumer(int contractNum)
		{
			DataSet ds = new DataSet();
			Costumer cos = null;
			string cmdStr = "SELECT `customers`.* FROM `contract` JOIN `customers` WHERE(contract.`ContractNum`=" + contractNum + ")AND(`contract`.`CostumerID`=`customers`.`ID`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					//Console.WriteLine("connected to database");
					if (reader.Read())
						cos = new Costumer(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(5), reader.GetString(4), reader.GetString(3));
					Disconnect();
				}
			}
			return cos;
		}

		// Gathers Mission info from Database and stores list of missions
		public Mission[] MissionEveryOne()
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE (`mission`.`id` IS NULL)AND(`mission`.`Houers`=0)AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Gathers Mission info from Database and stores list of missions
		public Mission[] AllMissions()
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE (`mission`.`Houers`=0)AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Utility function for Search in List of missions
		public Mission[] AllMissions(string query)
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Gathers Mission info from Database and stores list of missions
		public Mission[] AllEvents()
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car`,`missionlist` WHERE (`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)AND(`missionlist`.`EventNumber`=`mission`.`EventNumber`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Utility function for Search in List of missions
		public Mission[] AllEvents(string query)
		{
			DataSet ds = new DataSet();
			Mission[] myMission = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				myMission = new Mission[dt.Rows.Count];
				Mission mish;
				for (int i = 0; i < myMission.Length; i++)
				{
					if (dt.Rows[i][0].ToString() != "")
						mish = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], 0);
					else
						mish = new Mission("", (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], 0);
					myMission[i] = mish;
				}
			}
			return myMission;
		}

		// Gathers Mission info from Database and stores with specific mission number to dataType Mission
		public Mission ExitToMission(int missionNum)
		{
			DataSet ds = new DataSet();
			Mission ExitMission = null;
			string cmdStr = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE (`mission`.`Houers`=0)AND(`mission`.`EventNumber`=" + missionNum + ")AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				Mission[] myMission = new Mission[dt.Rows.Count];
				for (int i = 0; i < myMission.Length; i++)
					ExitMission = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][8]);
			}
			return ExitMission;
		}

		// Updates mission info with specific parameters given
		public void finishMission(Mission miss, string workId, int houers)
		{
			string cmdStr = "UPDATE `mission` SET `id`=@id, `Mission`= @Mission, `FaultDescription`=@FaultDescription,`Houers`=@Houers" +
				" WHERE `mission`.`EventNumber`=" + miss.MissionID;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@Mission", miss.Status);
				command.Parameters.AddWithValue("@FaultDescription", miss.Description);
				command.Parameters.AddWithValue("@id", workId);
				command.Parameters.AddWithValue("@Houers", houers);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Updates mission info with specific parameters given
		public void finishMissionWhisChengeCar(Mission miss, string workId, int houers, int chengeCar)
		{
			string cmdStr = "UPDATE `mission` SET `id`=@id, `Mission`= @Mission, `FaultDescription`=@FaultDescription,`Houers`=@Houers,license_number_of_Chenge_car=@license_number_of_Chenge_car" +
				" WHERE `mission`.`EventNumber`=" + miss.MissionID;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@Mission", miss.Status);
				command.Parameters.AddWithValue("@FaultDescription", miss.Description);
				command.Parameters.AddWithValue("@id", workId);
				command.Parameters.AddWithValue("@Houers", houers);
				command.Parameters.AddWithValue("@license_number_of_Chenge_car", chengeCar);
				base.ExecuteSimpleQuery(command);
			}
		}


		// Gathers Car info from Database and stores with specific license number to dataType Car
		public Car CheckCarOnParking(int licenceNum)
		{
			Car car = null;
			string cmdStr = "SELECT `car`.* FROM `lot` JOIN `car` WHERE (`lot`.`LicenceNumber`=" + licenceNum + ")AND(`car`.`license_number`=`lot`.`LicenceNumber`)";
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						car = new Car(reader.GetString(0), int.Parse(reader.GetString(1)), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), int.Parse(reader.GetString(6)), reader.GetString(7), reader.GetString(8), reader.GetString(9), DateTime.Parse(reader.GetString(10)), reader.GetString(11), reader.GetString(12), reader.GetString(13), DateTime.Parse(reader.GetString(14)), double.Parse(reader.GetString(15)));
				}
				Disconnect();
				return car;
			}
		}


		// Gathers Car info from Database and stores with specific id to dataType Car
		public Car FindWorkerCar(string id)
		{
			Car car = null;
			string cmdStr = "SELECT `car`.* FROM `car` WHERE (`car`.`license_number`in(SELECT license_number FROM cars_empl WHERE id=" + id + "))";
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						car = new Car(reader.GetString(0), int.Parse(reader.GetString(1)), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), int.Parse(reader.GetString(6)), reader.GetString(7), reader.GetString(8), reader.GetString(9), DateTime.Parse(reader.GetString(10)), reader.GetString(11), reader.GetString(12), reader.GetString(13), DateTime.Parse(reader.GetString(15)), double.Parse(reader.GetString(14)));
				}
				Disconnect();
				return car;
			}
		}

		// Deletes lot with specific license number from Database
		public void exitCarFromParking(int licenceNum)
		{
			string cmdStr = "DELETE FROM `lot` WHERE `LicenceNumber`=@license_number";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@license_number", licenceNum);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers Total amount of Contract number and stores in dataType integer
		public int lastContract()
		{
			DataSet ds = new DataSet();
			int lastcontractNum = 0;
			string cmdStr = "SELECT MAX(ContractNum) FROM `contract` WHERE 1";
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						lastcontractNum = int.Parse(reader.GetString(0));
					Disconnect();
				}
			}
			return lastcontractNum;
		}

		// Gathers Contract info from Database and stores with specific contract number to dataType Contract
		public Contract ContractClient(int cotNum)
		{
			DataSet ds = new DataSet();
			Contract contract = null;
			string cmdStr = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN car,customers WHERE (`contract`.LicenseNumber=`car`.license_number)AND(`contract`.CostumerID=`customers`.ID)AND(`contract`.`ContractNum`=" + cotNum + ")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				Costumer cos = new Costumer(dt.Rows[0][21].ToString(), dt.Rows[0][22].ToString(), dt.Rows[0][23].ToString(), dt.Rows[0][26].ToString(), dt.Rows[0][25].ToString(), dt.Rows[0][24].ToString());
				Car c = new Car(dt.Rows[0][4].ToString(), (int)dt.Rows[0][5], dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), (int)dt.Rows[0][10], dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), (DateTime)dt.Rows[0][14], dt.Rows[0][15].ToString(), dt.Rows[0][16].ToString(), dt.Rows[0][17].ToString(), (DateTime)dt.Rows[0][19], (double)dt.Rows[0][18]);
				contract = new Contract(c, cos, (int)dt.Rows[0][0], (DateTime)dt.Rows[0][3]);
			}
			return contract;
		}

		// Gathers Costumer info from Database and stores with specific person id to dataType Costumer
		public Costumer findPerson(string personId)
		{
			Costumer cos = null;
			string cmdStr = "SELECT `customers`.* FROM `customers` WHERE `customers`.`ID`=" + personId;
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						cos = new Costumer(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(5), reader.GetString(4), reader.GetString(3));
				}
				Disconnect();
			}
			return cos;
		}

		// Updates Car info from Database
		public void UpdateCar(Car Item)
		{
			string cmdStr = "UPDATE `car` SET  millage=@millage, cod_in_car= @cod_in_car, status= @status, date_of_test= @date_of_test, purpose_of_car=@purpose_of_car, data_of_car= @data_of_car, name_of_company='Avic', date_of_last_car_care=@date_of_last_car_care,price=@price WHERE `license_number`=" + Item.LicenseNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@millage", Item.Mileage);
				command.Parameters.AddWithValue("@cod_in_car", Item.CodeInCar);
				command.Parameters.AddWithValue("@status", Item.Status);
				command.Parameters.AddWithValue("@date_of_test", Item.DateOfTest);
				command.Parameters.AddWithValue("@purpose_of_car", Item.PurposeOfCar);
				command.Parameters.AddWithValue("@data_of_car", Item.DataOfCar);
				command.Parameters.AddWithValue("@date_of_last_car_care", Item.DateOfLastCarCare);
				command.Parameters.AddWithValue("@price", Item.Price);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Deletes Contract with specific license number and contract number from Database
		public void DropContract(int licenceNum, int contNumb)
		{
			string cmdStr = "DELETE FROM `contract` WHERE (`ContractNum`= @ContractNum)AND(`LicenseNumber`=@license_number)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@license_number", licenceNum);
				command.Parameters.AddWithValue("@ContractNum", contNumb);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds New costumer to Database
		public void NewCostumer(Costumer item)
		{
			string cmdStr = "INSERT INTO `customers`(`ID`, `FirstName`, `LastName`, `city`, `street`, `PhoneNumber`) VALUES (@ID,@FirstName,@LastName,@city,@street,@PhoneNumber)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@ID", item.ID);
				command.Parameters.AddWithValue("@FirstName", item.FirstName);
				command.Parameters.AddWithValue("@LastName", item.LastName);
				command.Parameters.AddWithValue("@city", item.City);
				command.Parameters.AddWithValue("@street", item.Street);
				command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds employee car to Database
		public void carLinkage(int licensNum, string id)
		{
			string cmdStr = "INSERT INTO `cars_empl`(`id`, `license_number`) VALUES (@id,@license_number)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", id);
				command.Parameters.AddWithValue("@license_number", licensNum);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Updates car license number with specific license number and id
		public void ChengeCar(int licensNum, string id)
		{
			string cmdStr = "UPDATE `cars_empl` SET `license_number`=@license_number WHERE `id`=" + id;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@license_number", licensNum);
				base.ExecuteSimpleQuery(command);
			}
		}

		public void updateCostumer(Costumer item) // TODO: 0 references
		{
			string cmdStr = "UPDATE `customers` SET `FirstName`= @FirstName, `LastName`=@LastName, `city`=@city, `street`=@street, `PhoneNumber`=@PhoneNumber WHERE `ID`=" + item.ID;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@FirstName", item.FirstName);
				command.Parameters.AddWithValue("@LastName", item.LastName);
				command.Parameters.AddWithValue("@city", item.City);
				command.Parameters.AddWithValue("@street", item.Street);
				command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers diagram info from Database 
		public string[] ParkingDiagram()
		{
			string[] floor = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `diagram` FROM `parkingdiagram` WHERE 1";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				floor = new string[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					floor[i] = dt.Rows[i][0].ToString();
			}
			Disconnect();
			return floor;
		}

		// Adds Contract info to Database
		public void insertContract(Contract item)
		{
			string cmdStr = "INSERT INTO `contract`(`ContractNum`, `CostumerID`, `LicenseNumber`, `DateBuy`) VALUES (@ContractNum,@CostumerID,@LicenseNumber,@DateBuy)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@ContractNum", item.ContractNumber);
				command.Parameters.AddWithValue("@CostumerID", item.Person.ID);
				command.Parameters.AddWithValue("@LicenseNumber", item.CosCar.LicenseNumber);
				command.Parameters.AddWithValue("@DateBuy", DateTime.Now.Date);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers garage phone number from Database
		public string SelectGaragePhone(int garageID)
		{
			string str = "";
			string cmdStr = "SELECT garage.`PhoneNumber` FROM garage JOIN missionlist WHERE `missionlist`.GARAGEID =" + garageID;
			using (MySqlCommand command = new MySqlCommand(cmdStr, connection))
			{
				Connect();
				MySqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
						str = reader.GetString(0);
				}
				Disconnect();
			}
			return str;
		}

		// Gathers Car info from Database and stores 
		public Car[] CheckCarOnParkingToRend(int licenceNum)
		{
			Car[] car = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `car`.* FROM `lot` JOIN `car` WHERE (`lot`.`LicenceNumber`LIKE '%" + licenceNum + "%' )AND(`car`.`license_number`=`lot`.`LicenceNumber`)AND(`car`.`purpose_of_car`=\"רכב השכרה\")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				car = new Car[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					car[i] = new Car(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (DateTime)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][15], (double)dt.Rows[i][14]);
			}
			Disconnect();
			return car;
		}

		// Gathers Car info from Database and stores in list of cars with specific license number
		public Car[] CheckCarOnParkingToWork(int licenceNum)
		{
			Car[] car = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `car`.* FROM `lot` JOIN `car` WHERE (`lot`.`LicenceNumber`LIKE '%" + licenceNum + "%' )AND(`car`.`license_number`=`lot`.`LicenceNumber`)AND(`car`.`purpose_of_car`=\"רכב עבודה\")AND(car.license_number not IN(SELECT cars_empl.license_number FROM cars_empl WHERE 1))";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				car = new Car[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					car[i] = new Car(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (DateTime)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][15], (double)dt.Rows[i][14]);
			}
			Disconnect();
			return car;
		}

		// Gathers Car info from Database and stores in list of cars with specific license number
		public Car[] CheckCar(int licenceNum)
		{
			Car[] car = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `car`.* FROM `car` WHERE (car.license_number LIKE '%" + licenceNum + "%' )AND(car.license_number not IN(SELECT `LicenceNumber` FROM `lot` WHERE 1))";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				car = new Car[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					car[i] = new Car(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (DateTime)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][15], (double)dt.Rows[i][14]);
			}
			Disconnect();
			return car;
		}

		// Deletes employee car with specific id
		public void returnCar(string id)
		{
			string cmdStr = "DELETE FROM `cars_empl` WHERE id=@id";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", id);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Checks for empty contracts
		public bool[] EmptyContracts(int start, int limit)
		{
			DataSet ds = new DataSet();
			bool[] contract = new bool[1000];
			for (int i = 0; i < 1000; i++)
				contract[i] = true;
			string cmdStr = "SELECT `ContractNum` FROM `contract` WHERE `ContractNum`>=" + start + " AND `ContractNum`<=" + limit;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
					contract[int.Parse(dt.Rows[i][0].ToString())] = false;
			}
			return contract;
		}

		// Gathers list of candidate's car info with status Wait
		public Car[] ListOfCandidateCars()
		{
			Car[] cars = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT * FROM `candidate_car` WHERE `status`='Wait'";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				cars = new Car[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					cars[i] = new Car(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (DateTime)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][15], (double)dt.Rows[i][14]);
			}
			Disconnect();
			return cars;
		}

		// Updates candidate car status to non with specific license number
		public void ChangeCandidateCarStatusAfterRefuse(int licenseNumber)
		{
			string cmdStr = "UPDATE `candidate_car` SET `status`=@status WHERE `license_number`=" + licenseNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@status", "Non");
				base.ExecuteSimpleQuery(command);
			}
		}

		// Updates candidate car status to ready with specific license number
		public void ChangeCandidateCarInfoAfterAccept(int licenseNumber)
		{
			string cmdStr = "UPDATE `car` SET `status`=@status,`purpose_of_car`=@purpose_of_car WHERE `license_number`=" + licenseNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@status", "Ready");
				command.Parameters.AddWithValue("@purpose_of_car", "רכב עבודה");
				base.ExecuteSimpleQuery(command);
			}
		}

		// Deletes candidate car from Database with specific license number
		public void DeleteCandidateCarAfterAccept(int licenseNumber)
		{
			string cmdStr = "DELETE FROM `candidate_car` WHERE `license_number`=@license_number";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@license_number", licenseNumber);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers Mission info from Database and stores list of exception hours in array
		public ExceptionHours[] ListOfWorkingHours(DateTime dateTime)
		{
			ExceptionHours[] exceptionHours = null;
			DataSet ds = new DataSet();
			DateTime limit = dateTime;
			limit = limit.AddMonths(1);
			string cmdStr = "SELECT `mission`.*,`employee`.* FROM `mission` JOIN `employee` WHERE (`Houers`>=510)AND(`mission`.`id`=`employee`.`id`)AND(`mission`.`DateMission`>=\"" + dateTime.Date.ToString("yyyy-MM-dd") + "\")AND(`mission`.`DateMission`<\"" + limit.Date.ToString("yyyy-MM-dd") + "\")";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				exceptionHours = new ExceptionHours[dt.Rows.Count];
				Mission m;
				Employee e;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					m = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][3].ToString(), "בוצע", (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], 0);
					e = new Employee(dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), (double)dt.Rows[i][17]);
					exceptionHours[i] = new ExceptionHours(m, e);
				}
			}
			Disconnect();
			return exceptionHours;
		}

		// Gathers Employee info from Database with specific parameter given
		public Employee[] ListOfRequests(ref Request[] r)
		{
			Employee[] emp = null;
			r = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `employee`.*,`requests`.* FROM `employee` JOIN `requests` WHERE `employee`.id=`requests`.Id";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				emp = new Employee[dt.Rows.Count];
				r = new Request[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					emp[i] = new Employee(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), (double)dt.Rows[i][9]);
					r[i] = new Request((int)dt.Rows[i][10], dt.Rows[i][11].ToString(), (DateTime)dt.Rows[i][12], dt.Rows[i][13].ToString());
				}
			}
			Disconnect();
			return emp;
		}

		// Gathers list of candidates from Database and stores in the array
		public Candidate[] ListOfCandidateEmployees()
		{
			Candidate[] cad = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT * FROM `candidate`";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				cad = new Candidate[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					cad[i] = new Candidate(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), (double)dt.Rows[i][9], dt.Rows[i][10].ToString());
			}
			Disconnect();
			return cad;
		}

		// Deletes candidate with specific id from Database
		public void DeleteCandidateEmployeeAfterAcceptOrReject(string ID)
		{
			string cmdStr = "DELETE FROM `candidate` WHERE `id`=@id";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", ID);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds employee info to Database
		public void InsertEmployeeFromCandidate(Candidate Item)
		{
			string cmdStr = "INSERT INTO `employee` (id, firstName, lastName, mail, city, street, numberhouse, mobile, role, experience)" +
				"VALUES(@id, @firstName, @lastName, @mail, @city, @street, @numberhouse, @mobile, @role, @experience)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", Item.ID);
				command.Parameters.AddWithValue("@firstName", Item.FirstName);
				command.Parameters.AddWithValue("@lastName", Item.LastName);
				command.Parameters.AddWithValue("@mail", Item.Mail);
				command.Parameters.AddWithValue("@city", Item.City);
				command.Parameters.AddWithValue("@street", Item.Street);
				command.Parameters.AddWithValue("@numberhouse", Item.HouseNumber);
				command.Parameters.AddWithValue("@mobile", Item.PhoneNumber);
				command.Parameters.AddWithValue("@role", Item.Role);
				command.Parameters.AddWithValue("@experience", Item.Experience);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds login info with specific id to Database
		public void InsertEmployeeLogin(string ID)
		{
			string cmdStr = "INSERT INTO `login` (id, password)" +
				"VALUES(@id, @password)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@id", ID);
				command.Parameters.AddWithValue("@password", "000");
				base.ExecuteSimpleQuery(command);
			}
		}

		// Gathers manager settings info from Database
		public ManagerSettings[] InsertOptions()
		{
			ManagerSettings[] ms = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT * FROM `manager_settings`";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				ms = new ManagerSettings[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					ms[i] = new ManagerSettings((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), (int)dt.Rows[i][3]);
			}
			Disconnect();
			return ms;
		}

		// Updates manager settings value
		public void UpdateOptions(ManagerSettings ms)
		{
			string cmdStr = "UPDATE `manager_settings` SET `limitation`=@limitation WHERE `GuideLineNumber`=" + ms.GuideLineNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@limitation", ms.Limitation * 60 + 30);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Utility function for Search in List of cars
		public Car[] CandidateCarList(string query)
		{
			DataSet ds = new DataSet();
			Car[] cars = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable();// object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0];// refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				cars = new Car[dt.Rows.Count];
				for (int i = 0; i < cars.Length; i++)
					cars[i] = new Car(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), (int)dt.Rows[i][6], dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (DateTime)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), (DateTime)dt.Rows[i][15], (double)dt.Rows[i][14]);
			}
			return cars;
		}

		// Gathers Employee info form Database with specific query
		public Employee[] MeetingList(string query, Request[] r)
		{
			DataSet ds = new DataSet();
			Employee[] emp = null;
			r = null;
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				emp = new Employee[dt.Rows.Count];
				r = new Request[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					emp[i] = new Employee(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), (double)dt.Rows[i][9]);
					r[i] = new Request((int)dt.Rows[i][10], dt.Rows[i][11].ToString(), (DateTime)dt.Rows[i][12], dt.Rows[i][13].ToString());
				}
			}
			Disconnect();
			return emp;
		}

		// Utility function for Search in Monthly exception hours
		public ExceptionHours[] ExceptionHoursList(string query)
		{
			ExceptionHours[] exceptionHours = null;
			DataSet ds = new DataSet();
			//DateTime limit = dateTime;
			//limit = limit.AddMonths(1);
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				exceptionHours = new ExceptionHours[dt.Rows.Count];
				Mission m;
				Employee e;
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					m = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][3].ToString(), "בוצע", (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], 0);
					e = new Employee(dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), (double)dt.Rows[i][17]);
					exceptionHours[i] = new ExceptionHours(m, e);
				}
			}
			Disconnect();
			return exceptionHours;
		}

		// Gathers Garage info from Database to store to list of garages
		public Garage[] ListOfGarages()
		{
			Garage[] garage = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT * FROM `garage`";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				garage = new Garage[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					garage[i] = new Garage((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
			}
			Disconnect();
			return garage;
		}

		// Utility function for Search in List of garages
		public Garage[] FilteredListOfGarages(string query)
		{
			Garage[] garage = null;
			DataSet ds = new DataSet();
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				garage = new Garage[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					garage[i] = new Garage((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
			}
			Disconnect();
			return garage;
		}

		public Mission[] ListOfJobs(ref Employee[] emp) // TODO: 0 references
		{
			Mission[] mission = null;
			emp = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `mission`.*,`employee`.* FROM `mission` JOIN `employee` WHERE (mission.id=employee.id)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				mission = new Mission[dt.Rows.Count];
				emp = new Employee[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					mission[i] = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][7]);
					emp[i] = new Employee(dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), (double)dt.Rows[i][17]);
				}
			}
			Disconnect();
			return mission;
		}

		public Mission[] ListOfJobs(string query, ref Employee[] emp) // TODO: 0 references
		{
			Mission[] mission = null;
			emp = null;
			DataSet ds = new DataSet();
			string cmdStr = query;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				mission = new Mission[dt.Rows.Count];
				emp = new Employee[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					mission[i] = new Mission(dt.Rows[i][0].ToString(), (int)dt.Rows[i][1], dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), (int)dt.Rows[i][4], (DateTime)dt.Rows[i][5], (int)dt.Rows[i][6], (int)dt.Rows[i][7]);
					emp[i] = new Employee(dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[i][13].ToString(), dt.Rows[i][14].ToString(), dt.Rows[i][15].ToString(), dt.Rows[i][16].ToString(), (double)dt.Rows[i][17]);
				}
			}
			Disconnect();
			return mission;
		}

		// Gathers Garage info from Database with specific car's license number
		public Garage ListOfCarsInGarage(int licenseNumber)
		{
			Garage garage = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT `garage`.* from `garage` WHERE `garage`.`Id` IN (SELECT `car`.`GARAGEID` FROM `car` JOIN `mission`,`missionlist` WHERE (`car`.`GARAGEID` IS NOT NULL)AND(`car`.`license_number`=" + licenseNumber + ") AND(`car`.`license_number` IN (SELECT `contract`.`LicenseNumber` FROM `contract` WHERE `contract`.`ContractNum` IN (SELECT `mission`.`ContractNumber` FROM `mission` WHERE (`mission`.`EventNumber` IN (SELECT `missionlist`.`EventNumber` FROM `missionlist` WHERE 1))))))";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				garage = new Garage((int)dt.Rows[0][0], dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
			}
			Disconnect();
			return garage;
		}

		// Gathers garage info from Database and stores in array of garage
		public Garage[] ListOfGarage()
		{
			Garage[] garage = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT * FROM `garage`";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				garage = new Garage[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
					garage[i] = new Garage((int)dt.Rows[i][0], dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
			}
			Disconnect();
			return garage;
		}

		// Gathers Car info from Database with specific parameters given
		public Contract[] ListOfCarsInGarage(ref int[] EventNumber)
		{
			Contract[] contracts = null;
			DataSet ds = new DataSet();
			string cmdStr = "SELECT contract.*,car.*,customers.*,mission.EventNumber FROM `car` JOIN `garage`,`missionlist`,`mission`,`contract`,`customers` WHERE (car.GARAGEID=garage.Id)AND(missionlist.EventNumber=mission.EventNumber)AND(contract.ContractNum=mission.ContractNumber)AND(contract.CostumerID=customers.ID)AND(car.license_number=contract.LicenseNumber)AND(missionlist.GARAGEID IS NOT NULL)AND(`missionlist`.`ReadyDays` IS NOT NULL)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contracts = new Contract[dt.Rows.Count];
				EventNumber = new int[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					Costumer cos = new Costumer(dt.Rows[i][21].ToString(), dt.Rows[i][22].ToString(), dt.Rows[i][23].ToString(), dt.Rows[i][26].ToString(), dt.Rows[i][25].ToString(), dt.Rows[i][24].ToString());
					Car c = new Car(dt.Rows[i][4].ToString(), (int)dt.Rows[i][5], dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), (int)dt.Rows[i][10], dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), dt.Rows[0][13].ToString(), (DateTime)dt.Rows[0][14], dt.Rows[0][15].ToString(), dt.Rows[i][16].ToString(), dt.Rows[i][17].ToString(), (DateTime)dt.Rows[i][19], (double)dt.Rows[i][18]);
					contracts[i] = new Contract(c, cos, (int)dt.Rows[i][0], (DateTime)dt.Rows[i][3]);
					EventNumber[i] = (int)dt.Rows[i][27];
				}
			}
			Disconnect();
			return contracts;
		}

		// Gathers Customer info from Database with specific parameters given
		public Costumer[] FindCustumersToBuy(ref double[] prices, ref int[] FixNum) 
		{
			string cmdStr = "SELECT customers.*,cars_after_fix.price,cars_after_fix.FixNumber FROM customers JOIN cars_after_fix,mission WHERE(cars_after_fix.FixNumber = mission.EventNumber)AND(customers.ID IN(SELECT contract.CostumerID FROM  contract WHERE(contract.ContractNum IN(SELECT mission.ContractNumber FROM mission JOIN cars_after_fix WHERE(mission.EventNumber = cars_after_fix.FixNumber)AND(cars_after_fix.ToCharge = \"לקוח\")AND(cars_after_fix.price > 0)))))";
			Costumer[] contracts = null;
			DataSet ds = new DataSet();
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contracts = new Costumer[dt.Rows.Count];
				prices = new double[dt.Rows.Count];
				FixNum = new int[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					contracts[i] = new Costumer(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][3].ToString());
					prices[i] = (double)dt.Rows[i][6];
					FixNum[i] = (int)dt.Rows[i][7];
				}
			}
			Disconnect();
			return contracts;
		}

		// Gathers customer info from Database with specific parameters given
		public Costumer[] FindCustumers(ref double[] prices, ref int[] FixNum, string queryInfo)
		{
			string cmdStr = "SELECT customers.*,cars_after_fix.price,cars_after_fix.FixNumber FROM customers JOIN cars_after_fix,mission WHERE(cars_after_fix.FixNumber = mission.EventNumber)AND(customers.ID IN(SELECT contract.CostumerID FROM  contract WHERE(contract.ContractNum IN(SELECT mission.ContractNumber FROM mission JOIN cars_after_fix WHERE(mission.EventNumber = cars_after_fix.FixNumber)AND(cars_after_fix.ToCharge = \"לקוח\")AND(cars_after_fix.price > 0)))))" + queryInfo;
			Costumer[] contracts = null;
			DataSet ds = new DataSet();
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				contracts = new Costumer[dt.Rows.Count];
				prices = new double[dt.Rows.Count];
				FixNum = new int[dt.Rows.Count];
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					contracts[i] = new Costumer(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][3].ToString());
					prices[i] = (double)dt.Rows[i][6];
					FixNum[i] = (int)dt.Rows[i][7];
				}
			}
			Disconnect();
			return contracts;
		}

		// Utility function for Search in list of cars after fix 
		public string BildQueryTofindCostumer(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "";
			spliter = names.Split(':');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("IDCostumer"))
					query += "AND(customers.ID=" + splitInfo[i] + ")";
				if (splitNames[i].Equals("priceToByed"))
					query += "AND(cars_after_fix.price<=" + splitInfo[i] + ")";
			}
			return query;
		}

		// Updates cars after fix with specific fix number and price
		public void paidUp(int fixNumber, double price)
		{
			string cmdStr = "UPDATE `cars_after_fix` SET `price`=@price WHERE `FixNumber`=" + fixNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@price", price);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Adds Cars after fix with specific parameters to Database
		public void InsertCarAfterFix(int fixNumber, string explainOfStatus, double price, string toCharge, int licenseNumber)
		{
			string cmdStr = "INSERT INTO `cars_after_fix` (FixNumber, ExplainOfStatus, price, ToCharge, license_number)" +
				"VALUES(@FixNumber, @ExplainOfStatus, @price, @ToCharge, @license_number)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@FixNumber", fixNumber);
				command.Parameters.AddWithValue("@ExplainOfStatus", explainOfStatus);
				command.Parameters.AddWithValue("@price", price);
				command.Parameters.AddWithValue("@ToCharge", toCharge);
				command.Parameters.AddWithValue("@license_number", licenseNumber);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Updates mission list with specific mission list
		public void UpdateMissionList(MissionList missionList)
		{
			string cmdStr = "UPDATE `missionlist` SET `CurrantActivity`=@CurrantActivity,`ReadyDays`=@ReadyDays,`ComponentStatusToOrder`=@ComponentStatusToOrder,`ComponentStatusReady`=@ComponentStatusReady, WHERE `EventNumber`=" + missionList.EventNumber;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@CurrantActivity", missionList.CurrentActivity);
				if (missionList.ComponentStatusToOrder == missionList.ComponentStatusReady)
					command.Parameters.AddWithValue("@ReadyDays", missionList.ReadyDays.ToString("yyyy-MM-dd"));
				else
					command.Parameters.AddWithValue("@ReadyDays", null);
				command.Parameters.AddWithValue("@ComponentStatusToOrder", missionList.ComponentStatusToOrder);
				command.Parameters.AddWithValue("@ComponentStatusReady", missionList.ComponentStatusReady);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Checks for empty parking space
		public bool[] emptyParking()
		{
			DataSet ds = new DataSet();
			bool[] parking = new bool[250];
			for (int i = 0; i < 250; i++)
				parking[i] = true;
			string cmdStr = "SELECT `lot`.`ParkingNumber` FROM `lot` WHERE `lot`.`ParkingNumber`>=1 AND `lot`.`ParkingNumber`<=250";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				ds = GetMultipleQuery(command); // set dataset object with command query object 
			}
			DataTable dt = new DataTable(); // object to hold 1 table from data base
			try
			{
				dt = ds.Tables[0]; // refernce for the query result table
			}
			catch { }
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
					parking[int.Parse(dt.Rows[i][0].ToString())] = false;
			}
			return parking;
		}

		// Adds Mission list info to Database
		public void insertMissionList(MissionList missionList)
		{
			string cmdStr = "INSERT INTO `missionlist`(`EventNumber`, `CurrantActivity`, `DaysOfState`, `ReadyDays`, `ComponentStatusToOrder`, `ComponentStatusReady`, `GARAGEID`)" +
				"VALUES(@EventNumber,@CurrantActivity,@DaysOfState,@ReadyDays,@ComponentStatusToOrder,@ComponentStatusReady,@GARAGEID)";
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@EventNumber", missionList.EventNumber);
				command.Parameters.AddWithValue("@CurrantActivity", missionList.CurrentActivity);
				command.Parameters.AddWithValue("@DaysOfState", missionList.DaysOfState.ToString("yyyy-MM-dd"));
				if (missionList.ComponentStatusToOrder == missionList.ComponentStatusReady)
					command.Parameters.AddWithValue("@ReadyDays", missionList.ReadyDays.ToString("yyyy-MM-dd"));
				else
					command.Parameters.AddWithValue("@ReadyDays", null);
				command.Parameters.AddWithValue("@ComponentStatusToOrder", missionList.ComponentStatusToOrder);
				command.Parameters.AddWithValue("@ComponentStatusReady", missionList.ComponentStatusReady);
				command.Parameters.AddWithValue("@GARAGEID", missionList.GarageID);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Updates car with specific license number and garage id
		public void insertExitGarage(int licenceNum, int garageId)
		{
			string cmdStr = "UPDATE `car` SET `GARAGEID`=@GARAGEID WHERE `license_number`=" + licenceNum;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				if (garageId > 0)
					command.Parameters.AddWithValue("@GARAGEID", garageId);
				else
					command.Parameters.AddWithValue("@GARAGEID", null);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Updates mission list with specific event number and garage id
		public void finishCarInMissionList(int eventNum, int garageId)
		{
			string cmdStr = "UPDATE `missionlist` SET `GARAGEID`=@GARAGEID WHERE EventNumber=" + eventNum;
			using (MySqlCommand command = new MySqlCommand(cmdStr))
			{
				if (garageId > 0)
					command.Parameters.AddWithValue("@GARAGEID", garageId);
				else
					command.Parameters.AddWithValue("@GARAGEID", null);
				base.ExecuteSimpleQuery(command);
			}
		}

		// Utility function for Search in Secretary Main
		public string SecuteryMainChouseQueryParking(string chouse, string info)
		{
			string[] str;
			string query = "SELECT `lot`.*,`car`.*FROM `lot` JOIN `car` WHERE(`lot`.`LicenceNumber`=`car`.`license_number`)";
			string ch = chouse;
			if (ch.Equals("רישוי"))
				query += "AND(`lot`.`LicenceNumber` LIKE '%" + info + "%')";
			else if (ch.Equals("יצרן/דגם"))
			{
				str = info.Split(' ');
				if (str.Length == 2 && str[0] != "" && str[1] != "")
					query += "AND((car.visible_model LIKE\"%" + str[1] + "%\")AND(car.visible_brand LIKE \"%" + str[0] + "%\"))";
				else
					query += "AND(`car`.`visible_brand` LIKE\"%" + info + "%\")";
			}
			else if (ch.Equals("מס' חנייה"))
			{
				int parknum;
				if (int.TryParse(info, out parknum))
					query += "AND(lot.ParkingNumber=" + parknum + ")";
			}
			else if (ch.Equals("ימים במגרש"))
			{
				int daySub;
				if (int.TryParse(info, out daySub))
				{
					DateTime temp = DateTime.Now.AddDays(-daySub);
					query += "AND( lot.`days_in_lot`<='" + temp.Year + "-" + temp.Month + "-" + temp.Day + "')";
				}
				else
					return "מספר שגוי";
			}
			else if (ch.Equals("קילומטראז'"))
			{
				int mil;
				if (int.TryParse(info, out mil))
					query += "AND(car.millage LIKE '%" + mil + "%')";
			}
			else if (ch.Equals("רכבי מכירה"))
			{
				query += "AND(`car`.`purpose_of_car`Like\"%מכירה%\")";
			}
			else if (ch.Equals("רכבי השכרה"))
			{
				query += "AND(`car`.`purpose_of_car`Like\"%השכרה%\")";
			}
			return query;
		}

		// Utility function for Search in Secretary Main
		public string SecuteryMainChouseQueryCustumers(int chouse, string info)
		{
			string query = "SELECT contract.*,car.*,customers.* FROM `contract` JOIN `car`,`customers` WHERE(`contract`.`LicenseNumber`=`car`.`license_number`)AND(`contract`.`CostumerID`=`customers`.`ID`)";
			string[] split;
			if (info != string.Empty)
				switch (chouse)
				{
					case 0: query += "AND(`contract`.`LicenseNumber` LIKE '%" + info + "%')"; break;
					case 1:
						split = info.Split(' ');
						if (split.Length == 2 && split[0] != "" && split[1] != "")
							query += "AND(`car`.`visible_brand`='" + split[0] + "')AND(`car`.`visible_model`='" + split[1] + "')";
						else
							if (split.Length == 1 && split[0] != "")
							query += "AND(`car`.`visible_brand`='" + split[0] + "')";
						else
							return "נתון שגוי";
						break;
					case 2: query += "AND(car.millage LIKE '%" + info + "%')"; break;
					case 3:
						split = info.Split(' ');
						if (split.Length == 2)
							query += "AND(`customers`.`FirstName`='" + split[0] + "')AND(`customers`.`LastName`='" + split[1] + "')";
						else if (split.Length == 1)
							query += "AND(`customers`.`FirstName`='" + split[0] + "')";
						else
							return "נתון שגו";
						break;
					case 4: query += "AND(`customers`.`PhoneNumber`=" + info + ")"; break;
					default: query = ""; return "נתון שגוי";
				}
			else
				return "נתון שגוי";

			return query;
		}

		// Utility function for Search in Seller or Renter main
		public string CheckQueryForSeller(string role)
		{
			string query = "";
			if (role.Equals("נציג מכירות"))
				query = "SELECT `lot`.*,`car`.* FROM `lot` JOIN `car` WHERE (`lot`.`LicenceNumber`=`car`.`license_number`)AND(`car`.`purpose_of_car`Like\"%מכירה%\")";
			else
				if (role.Equals("נציג השכרה"))
				query = "SELECT `lot`.*,`car`.*FROM `lot` JOIN `car` WHERE(`lot`.`LicenceNumber`=`car`.`license_number`)AND(`car`.`purpose_of_car`Like\"%השכרה%\")";
			return query;
		}

		// Utility function for Search in Seller or Renter main
		public string bildQueryForSellerOrRenter(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "";
			spliter = names.Split('-');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split('-');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("licenseNum"))
					query += "AND(`lot`.`LicenceNumber`LIKE\"%" + splitInfo[i] + "%\")";
				if (splitNames[i].Equals("milegeNum"))
					query += "AND(`car`.`millage`<=" + splitInfo[i] + ")";
				if (splitNames[i].Equals("prices"))
					query += "AND(`car`.`price`<=" + splitInfo[i] + ")";
				if (splitNames[i].Equals("Brand_Model"))
				{
					string[] str;
					str = splitInfo[i].Split(' ');
					if (str.Length == 2 && str[0] != "" && str[1] != "")
						query += "AND((car.visible_model LIKE\"%" + str[1] + "%\")AND(car.visible_brand LIKE \"%" + str[0] + "%\"))";
					else
						query += "AND(`car`.`visible_brand` LIKE\"%" + splitInfo[i] + "%\")";
				}
			}
			return query;
		}

		// Utility function for Search in list of repaired cars
		public string bildqueryListOfRepairedCars(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "";
			string[] splitter;
			spliter = names.Split(':');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textEventNumber"))
					query += "AND(`mission`.`EventNumber` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textLicenseNumber"))
					query += "AND(`car`.`license_number` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textBrandAndModel"))
				{
					splitter = splitInfo[i].Split('/');
					if (splitter[0] != string.Empty && splitter[1] != string.Empty)
						query += "AND(`visible_brande` LIKE '%" + splitter[0] + "%')AND(`visible_model`LIKE '%" + splitter[1] + "%')";
					else if (splitter[0] != string.Empty)
						query += "AND(`visible_brande` LIKE '%" + splitter[0] + "%')";
				}
				if (splitNames[i].Equals("comboGarageID"))
				{
					splitter = splitInfo[i].Split('-');
					query += "AND(`garage`.`NameOfGarage`=\"" + splitter[0] + "\")AND(`garage`.`Id`=" + splitter[1] + ")";
				}
				if (splitNames[i].Equals("textDaysOfState"))
				{
					int days = int.Parse(splitInfo[i]);
					DateTime date = DateTime.Now - TimeSpan.FromDays(days);
					query += "AND(`missionlist`.`DaysOfState`=\"" + new DateTime(date.Year, date.Month, date.Day).ToString("yyyy-MM-dd") + "\")";
				}
				if (splitNames[i].Equals("textReadyDays"))
				{
					DateTime date = DateTime.Now;
					int days = int.Parse(splitInfo[i]);
					date.AddDays(days * -1);
					query += "AND(`missionlist`.`ReadyDays`=\"" + new DateTime(date.Year, date.Month, date.Day).ToString("yyyy-MM-dd") + "\")";
				}
				if (splitNames[i].Equals("Ready"))
					query += "AND(`missionlist`.`ReadyDays` IS NOT NULL)";

			}
			return query;
		}

		// Utility function for Search in exception list
		public string bildBaseQueryListOfRepairedCars(string name)
		{
			if (name.Equals("missions"))
				return "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car`,`missionlist`,`garage`,`customers` WHERE (`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)AND(`missionlist`.`EventNumber`=`mission`.`EventNumber`)AND(`garage`.`Id`=`missionlist`.`GARAGEID`)AND(`contract`.`CostumerID`=`customers`.`ID`)"; ;
			if (name.Equals("missionLists"))
				return "SELECT * FROM `missionlist` JOIN `garage`,`customers`,`contract`,`mission`,`car` WHERE(`garage`.`Id`=`missionlist`.`GARAGEID`)AND(`contract`.`CostumerID`=`customers`.`ID`)AND(`car`.`GARAGEID`=`garage`.`id`)AND(`car`.`GARAGEID` is NOT null)AND(`car`.`license_number`=`contract`.`LicenseNumber`)AND(`missionlist`.`EventNumber`=`mission`.`EventNumber`)AND(`customers`.`ID` IN(SELECT `contract`.`CostumerID` FROM `mission` JOIN `missionlist`,`contract` WHERE `missionlist`.`EventNumber`=`mission`.`EventNumber`)AND(`contract`.`ContractNum`= mission.ContractNumber)";
			return "";
		}

		// Utility function for Search in inserting car to garage
		public string bildQuetFindCarToGarage(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car` WHERE(`mission`.`id` IS NOT NULL)AND(`mission`.`Houers`> 0)AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)";
			spliter = names.Split('-');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split('-');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textEventNumber"))
					query += "AND(`mission`.`EventNumber` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textLicenseNumber"))
					query += "AND(`car`.`license_number` LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}

		// Utility function for Search in Tester and Safety Manager main
		public string bildQueryToFindGarage(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "SELECT * FROM `garage` WHERE (1) ";
			spliter = names.Split('-');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split('-');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textGarageName"))
					query += "AND(`NameOfGarage` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textCity"))
					query += "AND(`city` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textAddress"))
					query += "AND(`street` LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}

		// Utility function for Search in monthly exception hours
		public string bildQueryToFindEmployee(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			string query = "SELECT `mission`.*,`employee`.* FROM `mission` JOIN `employee` WHERE (`Houers`>=510)AND(`mission`.`id`=`employee`.`id`) ";
			spliter = names.Split('-');
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textID"))
					query += "AND(`employee`.`id` LIKE '%" + splitInfo[i] + " %')";
				if (splitNames[i].Equals("textRole"))
					query += "AND(`employee`.`role` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textPhoneNumber"))
					query += "AND(`employee`.`mobile` LIKE '%" + splitInfo[i] + " % ')";
				if (splitNames[i].Equals("comboMonths"))
					query += "AND(`mission`.`DateMission`>=\"" + splitInfo[0] + "\")AND(`mission`.`DateMission`<=\"" + splitInfo[1] + "\")";
			}
			return query;
		}

		// Utility function for Search in Exception list
		public string bildQueryForExceptionList(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			spliter = names.Split(':');
			string query = "";
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textEventNumber"))
					query += "AND(`mission`.`EventNumber` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textLicenseNumber"))
					query += "AND(`car`.`license_number` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textBrandAndModel"))
				{
					spliter = splitInfo[i].Split('/');
					if (spliter[0] != string.Empty && spliter[1] != string.Empty)
						query += "AND(`visible_brande` LIKE '%" + spliter[0] + "%')AND(`visible_model`LIKE '%" + spliter[1] + "%')";
					else if (spliter[0] != string.Empty)
						query += "AND(`visible_brande` LIKE '%" + spliter[0] + "%')";
				}
				if (splitNames[i].Equals("textName"))
				{
					spliter = splitInfo[i].Split(' ');
					if (spliter[0] != string.Empty && spliter[1] != string.Empty)
						query += "AND(`customers`.`FirstName` LIKE '%" + spliter[0] + "%')AND(`customers`.`LastName` LIKE '%" + spliter[1] + "%')";
					else if (spliter[0] != string.Empty)
						query += "AND(`customers`.`FirstName` LIKE '%" + spliter[0] + "%')";
				}
				if (splitNames[i].Equals("textCurrentActivity"))
					query += "AND(`missionlist`.`CurrantActivity` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textDaysOfState"))
				{
					int days = int.Parse(splitInfo[i]);
					DateTime date = DateTime.Now - TimeSpan.FromDays(days);
					query += "AND(`missionlist`.`DaysOfState`=\"" + new DateTime(date.Year, date.Month, date.Day).ToString("yyyy-MM-dd") + "\")";
				}
				if (splitNames[i].Equals("textGaragePhoneNumber"))
					query += "AND(`garage`.`PhoneNumber`=\"" + splitInfo[i] + "\")";
				if (splitNames[i].Equals("textComponentStatusToOrder"))
					query += "AND(`missionlist`.`ComponentStatusToOrder` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textComponentStatusReady"))
					query += "AND(`missionlist`.`ComponentStatusReady` LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}

		// Utility function for Search in mission list
		public string bildQuerySearchMissions(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			spliter = names.Split(':');
			string query = "SELECT `mission`.*,`car`.`license_number` FROM `mission` JOIN `contract`,`car`,`customers` WHERE (`mission`.`Houers`= 0)AND(`contract`.`ContractNum`=`mission`.`ContractNumber`)AND(`contract`.`LicenseNumber`=`car`.`license_number`)AND(`customers`.`ID`=`contract`.`CostumerID`)";
			splitNames = new string[spliter.Length - 1];
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textLicenseNumberM"))
					query += "AND(`car`.`license_number` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textEventNumberM"))
					query += "AND(`mission`.`EventNumber` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textPhoneNumber"))
					query += "AND(`customers`.`PhoneNumber` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textContractNumber"))
					query += "AND(`contract`.`ContractNum` LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}

		// Utility function for Search in list of cars to be approved
		public string bildQueryFindCartoApproved(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			spliter = names.Split(':');
			splitNames = new string[spliter.Length - 1];
			string query = "SELECT * FROM `candidate_car` WHERE `status`='Wait'";
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textLicenseNumber"))
					query += "AND(`license_number`LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textMilege"))
					query += "AND(`millage`LIKE '%" + splitInfo[i] + "')";
				if (splitNames[i].Equals("textBrandAndModel"))
				{
					spliter = splitInfo[i].Split('/');
					if (spliter[0] != string.Empty && spliter[1] != string.Empty)
						query += "AND(`visible_brande`LIKE '%" + spliter[0] + "%')AND(`visible_model`LIKE '%" + spliter[1] + "%')";
					else if (spliter[0] != string.Empty)
						query += "AND(`visible_brande`LIKE '%" + spliter[0] + "%')";
				}
				if (splitNames[i].Equals("textPrice"))
					query += "AND(`price`LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}

		// Utility function for Search in list of meetings
		public string bildQueryFindListOfMeetings(string names, string info)
		{
			string[] splitNames, splitInfo, spliter;
			spliter = names.Split(':');
			splitNames = new string[spliter.Length - 1];
			string query = "SELECT `employee`.*,`requests`.* FROM `employee` JOIN `requests` WHERE (`employee`.id=`requests`.Id)";
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textID"))
					query += "AND(`employee`.`id` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textFirstName"))
					query += "AND(`employee`.`firstname` LIKE '%" + splitInfo[i] + "')";
				if (splitNames[i].Equals("textLastName"))
					query += "AND(`employee`.`lastname` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textRole"))
					query += "AND(`employee`.`role` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textInfoRequest"))
					query += "AND(`requests`.`explanationOfRequest` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textPhoneNumber"))
					query += "AND(`employee`.`mobile` LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}

		// Utility function for Search in Job Manager
		public string JobManagerMain(string names, string info)
		{

			string[] splitNames, splitInfo, spliter;
			spliter = names.Split(':');
			splitNames = new string[spliter.Length - 1];
			string query = "SELECT `mission`.*,`employee`.* FROM `mission` JOIN `employee` WHERE (mission.id=employee.id)";
			for (int i = 0, j = 0; i < spliter.Length; i++)
				if (spliter[i] != "")
					splitNames[j++] = spliter[i];
			splitInfo = info.Split(':');
			for (int i = 0; i < splitNames.Length; i++)
			{
				if (splitNames[i].Equals("textID"))
					query += "AND(`employee`.`id` LIKE '%" + splitInfo[i] + "%')";
				if (splitNames[i].Equals("textFirstName"))
					query += "AND(`employee`.`firstname` LIKE '%" + splitInfo[i] + "')";
				if (splitNames[i].Equals("textLastName"))
					query += "AND(`employee`.`lastname` LIKE '%" + splitInfo[i] + "%')";
			}
			return query;
		}
	}
}

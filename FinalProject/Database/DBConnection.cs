using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Sql;

namespace FinalProject.Database
{
	public class DBConnection
	{
		#region Constructor + Members
		protected MySqlConnection connection = null;
		public DBConnection(string connectionString)
		{
			connection = new MySqlConnection(connectionString);
		}
		#endregion

		#region Protected Methods
		protected void Connect()
		{
			if (connection.State != ConnectionState.Open)
				try
				{
					connection.Open();
				}
				catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
		}
		protected void Disconnect()
		{
			connection.Close();
		}
		protected void ExecuteSimpleQuery(MySqlCommand command)
		{
			lock (connection)
			{
				Connect();
				command.Connection = connection;
				try
				{
					command.ExecuteNonQuery();
				}
				finally
				{
					Disconnect();
				}
			}
		}
		protected int ExecuteScalarIntQuery(MySqlCommand command)
		{
			int ret = -1;
			lock (connection)
			{
				Connect();
				command.Connection = connection;
				try
				{
					//Console.WriteLine(command.ExecuteScalar() + " " + command.ExecuteScalar().GetType());
					/// Changed from (int)command.ExecuteScalar()
					/// to Convert.ToInt32(command.ExecuteScalar())
					/// because in function ParkingList in DbMySQL
					/// gives exception "Specified cast is not valid"
					ret = Convert.ToInt32(command.ExecuteScalar());
				}
				finally
				{
					Disconnect();
				}
			}
			return ret;
		}
		protected DataSet GetMultipleQuery(MySqlCommand command)
		{
			DataSet dataset = new DataSet();
			lock (connection)
			{
				Connect();
				command.Connection = connection; // reference for execute queries
				try
				{
					MySqlDataAdapter adapter = new MySqlDataAdapter(); // object for fill tables of the databases using query object
					adapter.SelectCommand = command; // reference to query object
					adapter.Fill(dataset); // fill data set object with the queries results
				}
				catch (TypedDataSetGeneratorException e) // data values error
				{
					Console.WriteLine(e.Message);
					System.Windows.Forms.MessageBox.Show(e.Message);
				}
				catch (DataException e) // names spaces error
				{
					Console.WriteLine(e.Message);
					System.Windows.Forms.MessageBox.Show(e.Message);
				}
				catch (Exception e) // general exception 
				{
					Console.WriteLine(e.Message);
					System.Windows.Forms.MessageBox.Show(e.Message);
				}
				finally
				{
					Disconnect();
				}
			}
			return dataset;
		}
		#endregion
	}
}

-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Ноя 16 2020 г., 12:20
-- Версия сервера: 10.4.11-MariaDB
-- Версия PHP: 7.2.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `avic`
--
CREATE DATABASE IF NOT EXISTS `avic` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `avic`;

-- --------------------------------------------------------

--
-- Структура таблицы `candidate`
--

CREATE TABLE `candidate` (
  `id` varchar(9) NOT NULL,
  `firstname` varchar(250) NOT NULL,
  `lastname` varchar(250) NOT NULL,
  `mail` varchar(250) NOT NULL,
  `city` varchar(250) NOT NULL,
  `street` varchar(250) NOT NULL,
  `numberhouse` varchar(4) NOT NULL,
  `mobile` varchar(12) NOT NULL,
  `role` varchar(250) NOT NULL,
  `experience` double NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `candidate`
--

INSERT INTO `candidate` (`id`, `firstname`, `lastname`, `mail`, `city`, `street`, `numberhouse`, `mobile`, `role`, `experience`, `password`) VALUES
('315789641', 'אליס', 'מיקולין', 'iliyabelo1995@gmail.com', 'חיפה', 'דגניה ', '40א', '0507789379', 'מנהל משימות', 4, 'QkLJdBYE3/8=');

-- --------------------------------------------------------

--
-- Структура таблицы `candidate_car`
--

CREATE TABLE `candidate_car` (
  `MVA_number` varchar(10) NOT NULL,
  `license_number` int(8) NOT NULL,
  `visible_brande` varchar(250) NOT NULL,
  `visible_model` varchar(250) NOT NULL,
  `Engine_capacity` varchar(20) NOT NULL,
  `color` varchar(255) NOT NULL,
  `year_of_car` int(4) NOT NULL,
  `millage` varchar(6) NOT NULL,
  `cod_in_car` varchar(10) NOT NULL,
  `status` varchar(250) DEFAULT NULL,
  `date_of_test` date NOT NULL,
  `purpose_of_car` varchar(250) NOT NULL,
  `data_of_car` varchar(1000) NOT NULL,
  `name_of_company` varchar(250) NOT NULL,
  `price` double NOT NULL,
  `date_of_last_car_care` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `candidate_car`
--

INSERT INTO `candidate_car` (`MVA_number`, `license_number`, `visible_brande`, `visible_model`, `Engine_capacity`, `color`, `year_of_car`, `millage`, `cod_in_car`, `status`, `date_of_test`, `purpose_of_car`, `data_of_car`, `name_of_company`, `price`, `date_of_last_car_care`) VALUES
('ABC78', 1248745, 'Volvo', 'E340', '1.8', 'כחול', 2019, '21500', '#784512', 'Wait', '2020-07-27', 'dsada', 'sadadsa', 'Avic', 1200000, '2020-07-12'),
('ACD11', 1178421, 'Volvo', 'E340', '1.8', 'כחול', 2019, '21500', '#784512', 'Non', '2020-07-27', 'dsada', 'sadadsa', 'Avic', 1200000, '2020-07-12'),
('ACD98', 5478421, 'Volvo', 'E340', '1.8', 'כחול', 2019, '21500', '#784512', 'Non', '2020-07-27', 'dsada', 'sadadsa', 'Avic', 1200000, '2020-07-12');

-- --------------------------------------------------------

--
-- Структура таблицы `car`
--

CREATE TABLE `car` (
  `MVA_number` varchar(10) NOT NULL,
  `license_number` int(8) NOT NULL,
  `visible_brand` varchar(250) NOT NULL,
  `visible_model` varchar(250) NOT NULL,
  `Engine_capacity` varchar(20) NOT NULL,
  `color` varchar(255) NOT NULL,
  `year_of_car` int(4) NOT NULL,
  `millage` varchar(6) NOT NULL,
  `cod_in_car` varchar(10) NOT NULL,
  `status` varchar(250) NOT NULL,
  `date_of_test` date NOT NULL,
  `purpose_of_car` varchar(250) NOT NULL,
  `data_of_car` varchar(1000) NOT NULL,
  `name_of_company` varchar(250) NOT NULL,
  `price` double NOT NULL,
  `date_of_last_car_care` date NOT NULL,
  `GARAGEID` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `car`
--

INSERT INTO `car` (`MVA_number`, `license_number`, `visible_brand`, `visible_model`, `Engine_capacity`, `color`, `year_of_car`, `millage`, `cod_in_car`, `status`, `date_of_test`, `purpose_of_car`, `data_of_car`, `name_of_company`, `price`, `date_of_last_car_care`, `GARAGEID`) VALUES
('ABC78', 1111745, 'Volvo', 'E340', '1.4 turbo', 'ירוק מנטה', 2019, '21500', '#784512', 'Ready', '2020-07-27', 'רכב עבודה', 'Rend car', 'Avic', 1500, '2020-07-12', NULL),
('ABC78', 1245678, 'Volvo', 'E340', '1.6 Turbo', 'אדום', 2019, '21500', '#784512', 'Ready', '2020-07-13', 'רכב עבודה', 'Rend car', 'Avic', 1500, '2020-04-13', NULL),
('ABC78', 1255578, 'Reno', 'Clio', '1.4', 'לבן', 2019, '21500', '#784512', 'Ready', '2020-06-26', 'רכב השכרה', 'Rend car', 'Avic', 400, '2020-07-10', NULL),
('ABC78', 1255611, 'Mercedes', 'Bens', '2.0', 'לבן', 2019, '21500', '#784512', 'Ready', '2020-06-26', 'רכב השכרה', 'Rend car', 'Avic', 1200, '2020-07-10', NULL),
('ABC78', 1255678, 'Volvo', 'E340', '1.4', 'ירוק', 2019, '21500', '#784512', 'Ready', '2020-06-26', 'רכב מכירה', 'Rend car', 'Avic', 120000, '2020-07-10', NULL),
('ABC78', 1445787, 'KIA', 'Rio', '1.4', 'שחור', 2019, '21500', '#7821', 'Ready', '2020-06-26', 'רכב השכרה', 'Rend car', 'Avic', 600, '2020-07-10', NULL),
('ASD47', 2273769, 'Mazda', '3', '2.0 Turbo', 'שחור', 2019, '45789', '*2564', 'Ready', '2021-06-18', 'רכב השכרה', 'רכב השכרה', 'Avic', 1200, '2022-10-20', NULL),
('ASD47', 2277369, 'Mazda', '3', '2.0 Turbo', 'צהוב', 2019, '45789', '*2564', 'נמכר', '2021-06-18', 'רכב מכירה', 'נמכראין נתונים חדשים לאחר מכירה', 'Avic', 37000, '2022-10-20', 500),
('ABC78', 3355611, 'KIA', 'cread', '1.0', 'לבן', 2019, '21500', '#784512', 'Ready', '2020-06-26', 'רכב מכירה', 'Rend car', 'Avic', 45000, '2020-07-10', NULL),
('A12BCD', 4630851, 'Reno', 'Megan', '1.2 Turbo', 'לבן', 2019, '58000', '*5891', 'Ready', '2020-06-25', 'רכב מכירה', 'Rend car', 'Avic', 120000, '2020-06-30', NULL),
('A12BCE', 4630852, 'Reno', 'Clio', '1.2 Turbo', 'לבן', 2019, '58000', '*5891', 'Ready', '2020-06-25', 'רכב מכירה', 'Rend car', 'Avic', 120000, '2020-06-30', NULL),
('QWE321', 7455464, 'KIA', 'RIO', '\'1.4\'', 'אפור', 2020, '10250', '*75895', 'רכב בשימוש ', '2022-06-07', 'רכב עבודה', 'רכב עבודה ', 'Avic', 0, '2020-06-07', NULL),
('ARE789', 7458711, 'volkswagen', 'Polo gti', '\"1.2 Turbo\"', 'אפור', 2019, '78000', '*554321', 'נמכר', '2020-07-23', 'רכב מכירה', 'אין נתונים חדשים לאחר מכירה', 'רכב מכור', 39000, '2020-07-19', 500),
('ASD44', 7845612, 'Reno', 'Megan', '1.4', 'אפור', 2019, '77452', '*7745', 'Ready', '2020-12-23', 'רכב השכרה', 'Rend car', 'Avic', 800, '2021-04-15', NULL),
('ABB456', 8830662, 'Chevrolet', 'Optra', '\'1.6\'', 'אפור', 2006, '220365', '*2552', 'Ready For using', '2020-06-09', 'רכב השכרה\r\n', 'blablabla sdsfsfsfsdasadsadsadasdsadasdsadsasdsadsadsadsadsadsadsadsadsadsa', 'Fenix', 400, '2020-06-09', NULL),
('ARE789', 8854696, 'volkswagen', 'golf gt', '\"1.2 Turbo\"', 'אפור', 2018, '150000', '*554321', 'Blulu', '2020-07-23', 'מכירה', 'היום יום חמישי יום מסודר ויפה ואני סתם רושם נתונים בשביל לבדוק כמה חסר לי באמת', 'Avic', 100000, '2020-07-19', NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `cars_after_fix`
--

CREATE TABLE `cars_after_fix` (
  `FixNumber` int(9) NOT NULL,
  `ExplainOfStatus` varchar(255) NOT NULL,
  `price` double NOT NULL,
  `ToCharge` varchar(255) NOT NULL,
  `license_number` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cars_after_fix`
--

INSERT INTO `cars_after_fix` (`FixNumber`, `ExplainOfStatus`, `price`, `ToCharge`, `license_number`) VALUES
(15, 'רכב מוכן', 15000, 'לקוח', 7458711);

-- --------------------------------------------------------

--
-- Структура таблицы `cars_empl`
--

CREATE TABLE `cars_empl` (
  `id` varchar(9) NOT NULL,
  `license_number` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `contract`
--

CREATE TABLE `contract` (
  `ContractNum` int(4) NOT NULL,
  `CostumerID` varchar(9) NOT NULL,
  `LicenseNumber` int(8) NOT NULL,
  `DateBuy` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `contract`
--

INSERT INTO `contract` (`ContractNum`, `CostumerID`, `LicenseNumber`, `DateBuy`) VALUES
(1020, '056511243', 2277369, '2020-03-10'),
(1021, '311543243', 8830662, '2020-06-17'),
(1028, '316478813', 7458711, '2019-12-16');

-- --------------------------------------------------------

--
-- Структура таблицы `customers`
--

CREATE TABLE `customers` (
  `ID` varchar(9) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `street` varchar(255) NOT NULL,
  `PhoneNumber` varchar(14) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `customers`
--

INSERT INTO `customers` (`ID`, `FirstName`, `LastName`, `city`, `street`, `PhoneNumber`) VALUES
('056511243', 'אלכס', 'מינצמן', 'חיפה', 'אלכסנדר זייד', '0524567811'),
('311543243', 'משה', 'כוהן', 'חיפה', 'בת גלים', '0541475516'),
('316478813', 'גילי', 'דודו', 'טירת כרמל', 'זלמן הרם', '0553214412'),
('336511240', 'מוחמד', 'מחגנה', 'אוספיה', 'צרניחובסקי', '0524567811'),
('336511243', 'מוחמד', 'ג\'ברין', 'אוספיה', 'צרניחובסקי', '0524567810');

-- --------------------------------------------------------

--
-- Структура таблицы `employee`
--

CREATE TABLE `employee` (
  `id` varchar(9) NOT NULL,
  `firstname` varchar(250) NOT NULL,
  `lastname` varchar(250) NOT NULL,
  `mail` varchar(250) NOT NULL,
  `city` varchar(250) NOT NULL,
  `street` varchar(250) NOT NULL,
  `numberhouse` varchar(4) NOT NULL,
  `mobile` varchar(12) NOT NULL,
  `role` varchar(250) NOT NULL,
  `experience` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `employee`
--

INSERT INTO `employee` (`id`, `firstname`, `lastname`, `mail`, `city`, `street`, `numberhouse`, `mobile`, `role`, `experience`) VALUES
('316469121', 'Felix', 'Longo', 'iliyabelo1995@gmail.com', 'Haifa', 'Vardia', '51', '0541234567', 'טסטר', 2),
('320447551', 'טל', 'סלילת', 'iliyabelo1995@gmail.com', 'חיפה', 'אחי אילת', '4 ג', '0523654424', 'נציג מכירות', 10),
('336551501', 'אנטון', 'שסטון', 'iliyabelo1995@gmail.com', 'חיפה', 'אחי אילת', '41d', '0523654424', 'מנהל משימות', 2),
('336551502', 'איליה', 'בלוצרקובסקי', 'iliyabelo1995@gmail.com', 'חיפה', 'דגניה', '41ד', '0523654478', 'מזכיר', 2),
('336551504', 'אולג', 'מלניק', 'iliyabelo1995@gmail.com', 'חיפה', 'אחי אילת', '41d', '0523654424', 'נהג', 2),
('336551505', 'יוןב', 'שבילי', 'iliyabelo1995@gmail.com', 'חיפה', 'אחי אילת', '41d', '0523654424', 'מנהל', 2),
('987654321', 'אליס', 'מיקולין', 'iliyabelo1995@gmail.com', 'חיפה', 'זיב', '21', '01234567', 'נציג השכרה', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `garage`
--

CREATE TABLE `garage` (
  `Id` int(4) NOT NULL,
  `NameOfGarage` varchar(255) NOT NULL,
  `PhoneNumber` varchar(12) NOT NULL,
  `street` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `NumberHouse` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `garage`
--

INSERT INTO `garage` (`Id`, `NameOfGarage`, `PhoneNumber`, `street`, `city`, `NumberHouse`) VALUES
(500, 'צ\'מפוינס מוטורס', '0541234567', 'בני ברק', 'חיפה', '4ב'),
(600, 'יונדאי צפון', '0549876543', 'בעלי מלאכה', 'חיפה', '43');

-- --------------------------------------------------------

--
-- Структура таблицы `login`
--

CREATE TABLE `login` (
  `id` varchar(9) NOT NULL,
  `password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `login`
--

INSERT INTO `login` (`id`, `password`) VALUES
('316469121', '7tVpQWX96w4='),
('320447551', 'TVkAAJSiBBs='),
('336551501', '1A5hV7722Ik='),
('336551502', '1A5hV7722Ik='),
('336551504', '9E8QARvlkGY='),
('336551505', '1A5hV7722Ik='),
('987654321', 'Y6Nl6M0p8DM=');

-- --------------------------------------------------------

--
-- Структура таблицы `lot`
--

CREATE TABLE `lot` (
  `ParkingNumber` int(4) NOT NULL,
  `TypeCar` varchar(255) NOT NULL,
  `days_in_lot` date NOT NULL,
  `LicenceNumber` int(8) NOT NULL,
  `Comments` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `lot`
--

INSERT INTO `lot` (`ParkingNumber`, `TypeCar`, `days_in_lot`, `LicenceNumber`, `Comments`) VALUES
(1, 'Rend', '2020-05-12', 4630852, 'kuku'),
(2, 'Rend car', '2020-06-19', 7845612, 'ulululu'),
(3, 'Rend', '2020-07-16', 4630851, 'kuku'),
(10, 'Ready', '2020-10-08', 1245678, 'רכב עבודה'),
(14, 'Ready', '2020-06-21', 1255578, 'sadadsa'),
(15, 'Ready', '2020-06-21', 1255611, 'sadadsa'),
(16, 'Ready', '2020-06-21', 1255678, 'sadadsa'),
(17, 'Ready', '2020-06-21', 1445787, 'sadadsa'),
(18, 'Ready', '2020-06-21', 3355611, 'sadadsa'),
(19, 'מחירה', '2020-06-19', 8854696, 'היום יום שני טעיתי ורשמתי את זה במקום הלא נכון עכשיו נדעה כמה תכנס באמת לתוכנה וצריך לבדוק מה עושים אם זה לא נראה טוב '),
(36, 'Ready', '2020-10-08', 1111745, 'רכב עבודה');

-- --------------------------------------------------------

--
-- Структура таблицы `manager_settings`
--

CREATE TABLE `manager_settings` (
  `GuideLineNumber` int(10) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Limitation` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `manager_settings`
--

INSERT INTO `manager_settings` (`GuideLineNumber`, `Name`, `Description`, `Limitation`) VALUES
(1, 'סה\"כ שעות משימה בחודש', 'סה\"כ שעות משימה שניתן לבצע בחודש', 13230),
(2, 'הגבלות שעות ביצוע משימות', 'הגבלת שעות ביצוע משימה מסויימת הוגבל ע\"ג שדה שרשום', 510);

-- --------------------------------------------------------

--
-- Структура таблицы `mission`
--

CREATE TABLE `mission` (
  `id` varchar(9) DEFAULT NULL,
  `EventNumber` int(9) NOT NULL,
  `Mission` varchar(255) NOT NULL,
  `FaultDescription` varchar(255) NOT NULL,
  `ContractNumber` int(4) NOT NULL,
  `DateMission` date NOT NULL,
  `Houers` int(5) NOT NULL,
  `license_number_of_Chenge_car` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `mission`
--

INSERT INTO `mission` (`id`, `EventNumber`, `Mission`, `FaultDescription`, `ContractNumber`, `DateMission`, `Houers`, `license_number_of_Chenge_car`) VALUES
('336551504', 3, 'גרירת רכב', 'רכב בולת עשן גרירה למוסח ', 1020, '2020-08-05', 600, NULL),
('336551504', 5, 'החלפת רכב', 'החלפת רכב והספקת רכב לסניף לטובת הטסט', 1021, '2020-09-03', 520, NULL),
('336551504', 6, 'גרירת רכב', 'גרירת רכבל לפנצריה יש פנצרים בשלושה גלגלים', 1028, '2020-08-05', 70, NULL),
('336551504', 15, 'החלפת רכב', 'החלפת רכב והספקת רכב לסניף לטובת הטסט', 1028, '2020-09-02', 530, NULL),
('336551504', 16, 'גרירת רכב', 'רכב בולת עשן גרירה למוסח ', 1020, '2020-08-05', 650, NULL),
('336551504', 18, 'גרירת רכב', 'רכב בולת עשן גרירה למוסח ', 1020, '2020-08-05', 0, NULL),
(NULL, 20, 'הוספת רכב', 'בדיקה', 1021, '2020-08-24', 0, NULL),
('336551504', 21, 'גרירת רכב', 'בדיקה', 1021, '2020-08-24', 0, NULL),
(NULL, 24, 'גרירת רכב', 'בדיקה נכונה', 1021, '2020-08-24', 0, NULL),
(NULL, 25, 'החזרת רכב ללקוח לאחר תיקון', 'sadadas', 1020, '2020-09-14', 0, NULL),
(NULL, 26, 'החזרת רכב ללקוח לאחר תיקון', 'dsdadasdas', 1020, '2020-09-14', 0, NULL),
(NULL, 27, 'החזרת רכב ללקוח לאחר תיקון', 'sdadsada', 1020, '2020-09-14', 0, NULL),
(NULL, 28, 'החזרת רכב ללקוח לאחר תיקון', 'זה משנכנס רק לרכב ', 1020, '2020-10-01', 0, NULL),
(NULL, 29, 'החזרת רכב ללקוח לאחר תיקון', 'זה משנכנס לרכב רק', 1020, '2020-10-01', 0, NULL),
(NULL, 30, 'החזרת רכב ללקוח לאחר תיקון', 'זה צריך להדכן רכב', 1020, '2020-10-01', 0, NULL),
(NULL, 31, 'החזרת רכב ללקוח לאחר תיקון', 'zxcxzcxzc', 1028, '2020-10-01', 0, NULL),
(NULL, 32, 'החזרת רכב ללקוח לאחר תיקון', 'saddasda', 1028, '2020-10-01', 0, NULL),
(NULL, 33, 'החזרת רכב ללקוח לאחר תיקון', 'wdadasdas', 1028, '2020-10-01', 0, NULL),
(NULL, 34, 'החזרת רכב ללקוח לאחר תיקון', 'גדשגשגדש', 1028, '2020-10-01', 0, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `missionlist`
--

CREATE TABLE `missionlist` (
  `EventNumber` int(9) NOT NULL,
  `CurrantActivity` varchar(255) NOT NULL,
  `DaysOfState` date NOT NULL,
  `ReadyDays` date DEFAULT NULL,
  `ComponentStatusToOrder` int(11) NOT NULL,
  `ComponentStatusReady` int(11) NOT NULL,
  `GARAGEID` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `missionlist`
--

INSERT INTO `missionlist` (`EventNumber`, `CurrantActivity`, `DaysOfState`, `ReadyDays`, `ComponentStatusToOrder`, `ComponentStatusReady`, `GARAGEID`) VALUES
(3, 'tested', '2020-08-25', '2020-09-16', 2, 2, 500),
(6, 'test', '2020-09-14', NULL, 12, 2, 500),
(15, '78', '2020-09-14', '2020-10-01', 87, 87, NULL);

-- --------------------------------------------------------

--
-- Структура таблицы `parkingdiagram`
--

CREATE TABLE `parkingdiagram` (
  `floor` int(4) NOT NULL,
  `diagram` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `parkingdiagram`
--

INSERT INTO `parkingdiagram` (`floor`, `diagram`) VALUES
(0, '..\\..\\parkingDiagram\\Avic.jpg'),
(1, '..\\..\\parkingDiagram\\floorOne.png'),
(2, '..\\..\\parkingDiagram\\floorTwo.png');

-- --------------------------------------------------------

--
-- Структура таблицы `requests`
--

CREATE TABLE `requests` (
  `NumberRequest` int(9) NOT NULL,
  `Id` varchar(9) NOT NULL,
  `DateToComunity` date NOT NULL,
  `explanationOfRequest` varchar(255) NOT NULL,
  `requestHouers` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `requests`
--

INSERT INTO `requests` (`NumberRequest`, `Id`, `DateToComunity`, `explanationOfRequest`, `requestHouers`) VALUES
(3, '336551502', '2020-11-28', 'בדיקה', '9:45');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `candidate_car`
--
ALTER TABLE `candidate_car`
  ADD PRIMARY KEY (`MVA_number`,`license_number`) USING BTREE;

--
-- Индексы таблицы `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`license_number`),
  ADD KEY `GARAGEID` (`GARAGEID`);

--
-- Индексы таблицы `cars_after_fix`
--
ALTER TABLE `cars_after_fix`
  ADD PRIMARY KEY (`FixNumber`),
  ADD UNIQUE KEY `license_number` (`license_number`);

--
-- Индексы таблицы `cars_empl`
--
ALTER TABLE `cars_empl`
  ADD PRIMARY KEY (`id`,`license_number`),
  ADD KEY `license_number` (`license_number`);

--
-- Индексы таблицы `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`ContractNum`),
  ADD UNIQUE KEY `LicenseNumber` (`LicenseNumber`),
  ADD KEY `CostumerID` (`CostumerID`) USING BTREE;

--
-- Индексы таблицы `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `garage`
--
ALTER TABLE `garage`
  ADD PRIMARY KEY (`Id`);

--
-- Индексы таблицы `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `lot`
--
ALTER TABLE `lot`
  ADD PRIMARY KEY (`ParkingNumber`),
  ADD KEY `LicenceNumber` (`LicenceNumber`) USING BTREE;

--
-- Индексы таблицы `manager_settings`
--
ALTER TABLE `manager_settings`
  ADD PRIMARY KEY (`GuideLineNumber`);

--
-- Индексы таблицы `mission`
--
ALTER TABLE `mission`
  ADD PRIMARY KEY (`EventNumber`),
  ADD UNIQUE KEY `EventNumber` (`EventNumber`),
  ADD UNIQUE KEY `id` (`id`,`EventNumber`),
  ADD KEY `ContractNumber` (`ContractNumber`);

--
-- Индексы таблицы `missionlist`
--
ALTER TABLE `missionlist`
  ADD PRIMARY KEY (`EventNumber`) USING BTREE,
  ADD UNIQUE KEY `EventNumber` (`EventNumber`),
  ADD KEY `GARAGEID` (`GARAGEID`);

--
-- Индексы таблицы `parkingdiagram`
--
ALTER TABLE `parkingdiagram`
  ADD PRIMARY KEY (`floor`);

--
-- Индексы таблицы `requests`
--
ALTER TABLE `requests`
  ADD PRIMARY KEY (`NumberRequest`) USING BTREE,
  ADD KEY `Id` (`Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `contract`
--
ALTER TABLE `contract`
  MODIFY `ContractNum` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1031;

--
-- AUTO_INCREMENT для таблицы `lot`
--
ALTER TABLE `lot`
  MODIFY `ParkingNumber` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT для таблицы `mission`
--
ALTER TABLE `mission`
  MODIFY `EventNumber` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT для таблицы `missionlist`
--
ALTER TABLE `missionlist`
  MODIFY `EventNumber` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `requests`
--
ALTER TABLE `requests`
  MODIFY `NumberRequest` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `car`
--
ALTER TABLE `car`
  ADD CONSTRAINT `car_ibfk_1` FOREIGN KEY (`GARAGEID`) REFERENCES `garage` (`Id`);

--
-- Ограничения внешнего ключа таблицы `cars_after_fix`
--
ALTER TABLE `cars_after_fix`
  ADD CONSTRAINT `cars_after_fix_ibfk_1` FOREIGN KEY (`license_number`) REFERENCES `car` (`license_number`),
  ADD CONSTRAINT `cars_after_fix_ibfk_2` FOREIGN KEY (`FixNumber`) REFERENCES `missionlist` (`EventNumber`);

--
-- Ограничения внешнего ключа таблицы `cars_empl`
--
ALTER TABLE `cars_empl`
  ADD CONSTRAINT `cars_empl_ibfk_1` FOREIGN KEY (`id`) REFERENCES `employee` (`id`),
  ADD CONSTRAINT `cars_empl_ibfk_2` FOREIGN KEY (`license_number`) REFERENCES `car` (`license_number`);

--
-- Ограничения внешнего ключа таблицы `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `contract_ibfk_1` FOREIGN KEY (`LicenseNumber`) REFERENCES `car` (`license_number`),
  ADD CONSTRAINT `contract_ibfk_2` FOREIGN KEY (`CostumerID`) REFERENCES `customers` (`ID`);

--
-- Ограничения внешнего ключа таблицы `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`id`) REFERENCES `employee` (`id`);

--
-- Ограничения внешнего ключа таблицы `lot`
--
ALTER TABLE `lot`
  ADD CONSTRAINT `lot_ibfk_1` FOREIGN KEY (`LicenceNumber`) REFERENCES `car` (`license_number`);

--
-- Ограничения внешнего ключа таблицы `mission`
--
ALTER TABLE `mission`
  ADD CONSTRAINT `mission_ibfk_1` FOREIGN KEY (`id`) REFERENCES `employee` (`id`),
  ADD CONSTRAINT `mission_ibfk_2` FOREIGN KEY (`ContractNumber`) REFERENCES `contract` (`ContractNum`);

--
-- Ограничения внешнего ключа таблицы `missionlist`
--
ALTER TABLE `missionlist`
  ADD CONSTRAINT `missionlist_ibfk_2` FOREIGN KEY (`GARAGEID`) REFERENCES `garage` (`Id`),
  ADD CONSTRAINT `missionlist_ibfk_4` FOREIGN KEY (`EventNumber`) REFERENCES `mission` (`EventNumber`);

--
-- Ограничения внешнего ключа таблицы `requests`
--
ALTER TABLE `requests`
  ADD CONSTRAINT `requests_ibfk_1` FOREIGN KEY (`Id`) REFERENCES `employee` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

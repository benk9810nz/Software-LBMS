/*
SQLyog Community v13.1.5  (64 bit)
MySQL - 10.3.22-MariaDB-0+deb10u1 : Database - library
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`library` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `library`;

/*Table structure for table `BOOKCOPIES` */

DROP TABLE IF EXISTS `BOOKCOPIES`;

CREATE TABLE `BOOKCOPIES` (
  `Book_Barcode` decimal(20,0) NOT NULL,
  `Book_ID` int(11) DEFAULT NULL,
  `Retailer_ID` int(11) DEFAULT NULL,
  `Purchase_Price` decimal(19,4) DEFAULT NULL,
  `RFID_Tag` varchar(30) DEFAULT NULL,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Book_Barcode`),
  KEY `Book_ID` (`Book_ID`),
  KEY `Retailers` (`Retailer_ID`),
  CONSTRAINT `BOOKCOPIES_ibfk_1` FOREIGN KEY (`Book_ID`) REFERENCES `BOOKS` (`Book_ID`) ON DELETE SET NULL,
  CONSTRAINT `Retailers` FOREIGN KEY (`Retailer_ID`) REFERENCES `RETAILERS` (`Retailer_ID`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `BOOKCOPIES` */

insert  into `BOOKCOPIES`(`Book_Barcode`,`Book_ID`,`Retailer_ID`,`Purchase_Price`,`RFID_Tag`,`Updated_Date`) values 
(9876543,11,3,35.0000,'09876543','15-Jun-20 6:12:36 PM'),
(10010001,12,4,0.0100,'cthulhufhtagn','16-Jun-20 10:50:01 PM'),
(19000190,11,2,31.0000,'123456','15-Jun-20 6:11:03 PM'),
(2871227962,1,1,65.0000,'abc123','8/05/2020 10:44:47 pm'),
(9780123456781,1,1,21.0000,'0102ac6aa5','8/5/2020 8:25:20 pm'),
(9780123456782,2,1,25.0000,'dsjh13','8/5/2020 8:25:20 pm'),
(9780123456783,3,3,12.2000,'01068e2866','8/5/2020 8:25:20 pm'),
(9780123456784,4,3,50.2000,'dsjh15','8/5/2020 8:25:20 pm'),
(9780123456785,5,2,50.5000,'01024c7327','8/5/2020 8:25:20 pm'),
(9780123456786,6,1,120.2000,'dsjh17','8/5/2020 8:25:20 pm'),
(9780123456787,7,2,34.0000,'dsjh18','8/5/2020 8:25:20 pm'),
(9780123456788,8,3,35.0000,'dsjh19','8/5/2020 8:25:20 pm'),
(9780123456789,9,2,12.0000,'010b0a3129','8/5/2020 8:25:20 pm'),
(9780123456790,10,3,22.0000,'dsjh22','8/5/2020 8:25:20 pm'),
(9780123456791,11,1,28.0000,'9780123456791','15-Jun-20 6:03:25 PM'),
(9780123456792,1,3,21.0000,'dsjh122','8/5/2020 8:25:20 pm'),
(9780123456793,3,1,89.0000,'dsjh123','8/5/2020 8:25:20 pm'),
(9780123456794,4,1,12.0000,'dsjh121','8/5/2020 8:25:20 pm'),
(9780123456795,2,2,43.0000,'dsjh126','8/5/2020 8:25:20 pm'),
(9780123456796,3,3,23.0000,'dsjh12','8/5/2020 8:25:20 pm'),
(9780123456797,1,2,42.0000,'dsjh132','8/5/2020 8:25:20 pm'),
(9780123456798,4,3,42.0000,'dsjh112','8/5/2020 8:25:20 pm'),
(9780123456799,5,3,12.0000,'dsjh198','8/5/2020 8:25:20 pm');

/*Table structure for table `BOOKS` */

DROP TABLE IF EXISTS `BOOKS`;

CREATE TABLE `BOOKS` (
  `Book_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Author_Name` varchar(50) NOT NULL,
  `Publication_Date` date NOT NULL,
  `Publisher_ID` int(11) DEFAULT NULL,
  `Genre_ID` int(11) DEFAULT NULL,
  `Description` varchar(1000) NOT NULL,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Book_ID`),
  KEY `Publisher_ID` (`Publisher_ID`),
  KEY `Genre_ID` (`Genre_ID`),
  CONSTRAINT `BOOKS_ibfk_1` FOREIGN KEY (`Publisher_ID`) REFERENCES `PUBLISHERS` (`Publisher_ID`) ON DELETE SET NULL,
  CONSTRAINT `BOOKS_ibfk_2` FOREIGN KEY (`Genre_ID`) REFERENCES `GENRES` (`Genre_ID`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;

/*Data for the table `BOOKS` */

insert  into `BOOKS`(`Book_ID`,`Name`,`Author_Name`,`Publication_Date`,`Publisher_ID`,`Genre_ID`,`Description`,`Updated_Date`) values 
(1,'Harry Potter & the Deathly Hallows','J.K. Rowling','2007-07-21',1,1,'Harry Potter and the Deathly Hallows is a fantasy novel written by British author J. K. Rowling and the seventh and final novel of the Harry Potter series. It was released on 21 July 2007 in the United Kingdom by Bloomsbury Publishing, in the United States by Scholastic, and in Canada by Raincoast Books.','2020-06-15 15:14:33.977802'),
(2,'Rock Wars','Robert Muchamore','2014-02-27',2,1,'Rock War is the first book in the series. It was published on 27 February 2014. It features the main character in the series, Jay Thomas. Other characters in the book are his older brothers Theo and Adam Richardson, who each cause mayhem around places. This book also stars Jay\'s younger brother, Hank. At the start of the book Jay plays in a band named Brontobyte, with members Tristan, Salman and Alfie. He later gets kicked out of the band, and makes a new band with Jay\'s older brothers and lead drummer Babatunde. The novel also features Summer Smith, who lives in a flat with her old grandmother, and Dylan, a lazy boy who goes to Yellocote boarding school. The three characters\' bands all take part in reality show Rock War.\r\n','8/5/2020 8:25:20 pm'),
(3,'The Recruit','Robert Muchamore','2004-04-30',1,2,'The Recruit is the first novel in the CHERUB series, written by Robert Muchamore. It introduces most of the main characters, such as James Adams, Lauren Adams, Kyle Blueman, and Kerry Chang','8/5/2020 8:25:20 pm'),
(4,'Crash Landing','Robert Muchamore','2015-10-05',2,2,'Don\'t miss the last episode of international bestseller Robert Muchamore\'s ROCK WAR series! Jay, Summer and Dylan are fresh out of the biggest reality show there is. But they\'re about to discover what fame and fortune are really about.','8/5/2020 8:25:20 pm'),
(5,'FEAR','Micheal Grant','2012-03-23',3,3,'The fifth book in the bestselling Gone series by Michael Grant continues the page-turning saga of Sam, Astrid, and Drake in their terrifying post-apocalyptic world.It\'s been one year since all the adults disappeared. .','8/5/2020 8:25:20 pm'),
(6,'Harry Potter & the Half Blood Prince','J.K. Rowling','2005-07-16',3,2,'Harry Potter and the Half-Blood Prince is a fantasy novel written by British author J.K. Rowling and the sixth and penultimate novel in the Harry Potter series.','8/5/2020 8:25:20 pm'),
(7,'GONE','Micheal Grant','2008-01-01',3,1,'The first in New York Times bestselling author Michael Grant\'s breathtaking dystopian sci-fi saga, Gone is a page-turning thriller that invokes the classic The Lord of the Flies along with the horror of Stephen King.In the blink of an eye, everyone disappears. Gone. Except for the young.','8/5/2020 8:25:20 pm'),
(8,'Private Oz','James Patterson','2012-10-01',1,2,'Private Down Under is the seventh book of Patterson\'s Private series. This novel was written by Patterson and Michael White and was first published in 2012 by Random House Australia under the title Private Oz.','8/5/2020 8:25:20 pm'),
(9,'Class A','Robert Muchamore','2004-10-14',2,1,'Class A, published as The Dealer in the United States, and as The Mission for 5000 prints, is the second book in the Robert Muchamore\'s novel series CHERUB. It continues the story of teenager James Adams and his fellow CHERUB agents as they try to bring down a drug gang led by Keith Moore.','8/5/2020 8:25:20 pm'),
(10,'IT','Stephen King','2986-09-15',3,2,'It is a 1986 horror novel by American author Stephen King. It was his 22nd book, and his 17th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey.','8/5/2020 8:25:20 pm'),
(11,'Under the Dome','Stephen King','2009-10-01',1,2,'Under the Dome is a science fiction novel by the American author, Stephen King. Under the Dome is the 58th book published by Stephen King, and it is his 48th novel','8/5/2020 8:25:20 pm'),
(12,'Necronomicon','Unknown','1953-01-01',4,6,'68747470733a2f2f737465656d6974696d616765732e636f6d2f44516d616a36414d444d345758524c324a33654751344a4a3447486d6f675a36565837714c3757735938346e6b6a4a2f6d792d6e616d652d69732d637468756c68752e676966','2020-06-16 22:39:14.754358');

/*Table structure for table `BOOKSISSUED` */

DROP TABLE IF EXISTS `BOOKSISSUED`;

CREATE TABLE `BOOKSISSUED` (
  `Issue_Number` int(11) NOT NULL AUTO_INCREMENT,
  `Customer_ID` int(11) DEFAULT NULL,
  `Issue_Date` date NOT NULL,
  `Due_Date` date NOT NULL,
  `Returned_Date` date DEFAULT NULL,
  `Book_Barcode` decimal(20,0) DEFAULT NULL,
  PRIMARY KEY (`Issue_Number`),
  KEY `Book_Barcode` (`Book_Barcode`),
  KEY `Customer_ID` (`Customer_ID`),
  CONSTRAINT `BOOKSISSUED_ibfk_1` FOREIGN KEY (`Book_Barcode`) REFERENCES `BOOKCOPIES` (`Book_Barcode`) ON DELETE SET NULL,
  CONSTRAINT `BOOKSISSUED_ibfk_2` FOREIGN KEY (`Customer_ID`) REFERENCES `CUSTOMERS` (`Customer_ID`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4;

/*Data for the table `BOOKSISSUED` */

insert  into `BOOKSISSUED`(`Issue_Number`,`Customer_ID`,`Issue_Date`,`Due_Date`,`Returned_Date`,`Book_Barcode`) values 
(1,1,'2020-03-04','2020-03-18','2020-06-09',NULL),
(2,1,'2020-05-08','2020-05-27','2020-06-09',9780123456781),
(3,2,'2020-01-15','2020-05-19','2020-06-16',9780123456783),
(4,3,'2020-05-01','2020-05-18','2020-06-09',9780123456786),
(5,1,'2020-05-01','2020-08-14','2020-06-09',9780123456786),
(6,1,'2020-05-01','2020-06-24',NULL,9780123456799),
(7,3,'2020-05-01','2020-06-12',NULL,9780123456798),
(8,1,'2020-05-01','2020-06-24',NULL,9780123456796),
(9,4,'2020-06-02','2020-06-17',NULL,9780123456784),
(10,4,'2020-06-02','2020-06-17',NULL,9780123456788),
(11,4,'2020-06-02','2020-06-17',NULL,9780123456792),
(12,3,'2020-06-03','2020-07-01',NULL,9780123456785),
(13,3,'2020-06-03','2020-07-01',NULL,9780123456798),
(14,1,'2020-06-03','2020-07-01',NULL,9780123456798),
(15,3,'2020-06-10','2020-07-08','2020-06-09',9780123456786),
(16,3,'2020-06-10','2020-07-08','2020-06-09',9780123456789),
(17,3,'2020-06-16','2020-07-14','2020-06-09',9780123456781),
(18,3,'2020-06-16','2020-07-14',NULL,9780123456785),
(19,3,'2020-06-16','2020-07-14',NULL,2871227962),
(20,3,'2020-06-16','2020-07-14','2020-06-09',9780123456781),
(21,3,'2020-06-16','2020-07-14','2020-06-09',9780123456789),
(22,1,'2020-06-16','2020-07-14','2020-06-16',9780123456789),
(23,1,'2020-06-16','2020-07-14','2020-06-09',9780123456781),
(24,3,'2020-06-16','2020-07-14','2020-06-16',9780123456781),
(25,1,'2020-06-16','2020-07-14',NULL,9780123456783),
(26,3,'2020-06-17','2020-07-15',NULL,9780123456781),
(27,3,'2020-06-17','2020-07-15','2020-06-17',9780123456789);

/*Table structure for table `BOOKSONHOLD` */

DROP TABLE IF EXISTS `BOOKSONHOLD`;

CREATE TABLE `BOOKSONHOLD` (
  `Hold_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Book_Barcode` decimal(20,0) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Customer_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`Hold_ID`),
  KEY `Book_Barcode` (`Book_Barcode`),
  KEY `Customer_ID` (`Customer_ID`),
  CONSTRAINT `BOOKSONHOLD_ibfk_1` FOREIGN KEY (`Book_Barcode`) REFERENCES `BOOKCOPIES` (`Book_Barcode`),
  CONSTRAINT `BOOKSONHOLD_ibfk_2` FOREIGN KEY (`Customer_ID`) REFERENCES `CUSTOMERS` (`Customer_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

/*Data for the table `BOOKSONHOLD` */

insert  into `BOOKSONHOLD`(`Hold_ID`,`Book_Barcode`,`Date`,`Customer_ID`) values 
(1,2871227962,'2020-05-10',1),
(2,2871227962,'2020-05-10',2),
(3,9780123456781,'2020-05-10',1),
(4,9780123456783,'2020-05-12',1),
(5,9780123456783,'2020-06-08',1),
(6,9780123456783,'2020-06-08',1),
(7,9780123456788,'2020-06-08',1),
(8,9780123456792,'2020-06-08',1),
(9,9780123456788,'2020-06-16',1),
(10,9780123456783,'2020-06-16',1),
(11,9780123456783,'2020-06-16',1),
(12,9780123456789,'2020-06-16',4),
(13,9780123456784,'2020-06-16',2);

/*Table structure for table `CUSTOMERS` */

DROP TABLE IF EXISTS `CUSTOMERS`;

CREATE TABLE `CUSTOMERS` (
  `Customer_ID` int(11) NOT NULL AUTO_INCREMENT,
  `First_Name` varchar(30) NOT NULL,
  `Last_Name` varchar(30) NOT NULL,
  `Address_Line1` varchar(50) NOT NULL,
  `Address_Line2` varchar(50) NOT NULL,
  `City` varchar(30) NOT NULL,
  `Phone_Number` decimal(15,0) DEFAULT NULL,
  `DOB` date NOT NULL,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

/*Data for the table `CUSTOMERS` */

insert  into `CUSTOMERS`(`Customer_ID`,`First_Name`,`Last_Name`,`Address_Line1`,`Address_Line2`,`City`,`Phone_Number`,`DOB`,`Updated_Date`) values 
(1,'Ben','King','123 Example Street','Hargest','Invercargill',640279328043,'1999-08-17','8/5/2020 8:25:20 pm'),
(2,'Henry','Sly','213 Street Street','Glensdale','Invercargill',1238278911,'2010-05-13','9/05/2020 10:17:26 pm'),
(3,'Sharmaine','Rufford','122 Example Road','CBD','Wellington',640274590498,'2004-04-27','8/5/2020 8:25:20 pm'),
(4,'User','Name','111 Tay Street','CBD','Gore',83938329382,'1980-02-03','16-Jun-20 12:59:14 AM'),
(5,'Nick','Jones','Example Street 1','Suburb','Invercargill',32122321,'1820-12-12','8/05/2020 9:54:33 pm'),
(6,'Josh','Smithy','22 Jsmithy Street','Waverley','Invercargill',98234343,'2020-05-09','9/05/2020 10:16:41 pm'),
(9,'customer','customer','customer','customer','customer',12345678,'2020-06-03','03-Jun-20 11:18:50 AM'),
(10,'Random','Customer','Nowhere','In','Particular',12345678,'2020-06-10','10-Jun-20 10:56:05 PM');

/*Table structure for table `GENRES` */

DROP TABLE IF EXISTS `GENRES`;

CREATE TABLE `GENRES` (
  `Genre_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `Minimum_Age` int(11) NOT NULL,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Genre_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `GENRES` */

insert  into `GENRES`(`Genre_ID`,`Name`,`Description`,`Minimum_Age`,`Updated_Date`) values 
(1,'Adult Action','Adult Books full of Action',16,'08-Jun-20 10:11:35 AM'),
(2,'Adult Horror','Adult books full of Spooky Stuff',18,'2020-04-17 14:00:22.930677'),
(3,'Comedy','Comedy suitable for Teens and Adults',12,'2020-04-17 14:01:27.277535'),
(4,'Adventure','Books featuring fun Adventures',0,'2020-04-17 14:02:30.491720'),
(5,'Children_Horror','Books full of Horror suitable for Children',5,'2020-04-17 14:05:18.921427'),
(6,'Redrum','All work no play makes Jack a dull boy. All work no play makes Jack a dull boy. All work no play makes Jack a dull boy. All work no play makes Jack a dull boy. All work no play makes Jack a dull boy. ',20,'15-Jun-20 4:45:23 PM');

/*Table structure for table `PUBLISHERS` */

DROP TABLE IF EXISTS `PUBLISHERS`;

CREATE TABLE `PUBLISHERS` (
  `Publisher_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) NOT NULL,
  `Address_Line1` varchar(50) NOT NULL,
  `Address_Line2` varchar(50) DEFAULT NULL,
  `Suburb` varchar(30) DEFAULT NULL,
  `City` varchar(30) NOT NULL,
  `Postcode` decimal(9,0) DEFAULT NULL,
  `Phone_Number` decimal(15,0) NOT NULL,
  `Website_URL` varchar(150) DEFAULT NULL,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Publisher_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `PUBLISHERS` */

insert  into `PUBLISHERS`(`Publisher_ID`,`Name`,`Address_Line1`,`Address_Line2`,`Suburb`,`City`,`Postcode`,`Phone_Number`,`Website_URL`,`Updated_Date`) values 
(1,'Hodder & Stoughton','I am editing this address','','','London',9821,205505305,'https://www.hodder.co.uk','15-Jun-20 4:45:49 PM'),
(2,'Pengiun Random House','74 Taharoto Road\r\n',NULL,'Takapuna','Auckland',622,94427400,'https://www.penguin.co.nz/contact',NULL),
(3,'Crown Publishing Group\r\n','1745 Broadway','','','New York',10019,8007333000,'http://crownpublishing.com','15-Jun-20 4:57:48 PM'),
(4,'The Whispering','Somewhere','Nowhere','Right Here','Everywhere',6666,6666666666,'Its All In Your Head','16-Jun-20 10:18:35 PM');

/*Table structure for table `RETAILERS` */

DROP TABLE IF EXISTS `RETAILERS`;

CREATE TABLE `RETAILERS` (
  `Retailer_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) NOT NULL,
  `Address_Line1` varchar(50) NOT NULL,
  `Address_Line2` varchar(50) DEFAULT NULL,
  `City` varchar(30) NOT NULL,
  `Phone_Number` decimal(12,0) DEFAULT NULL,
  `Website_URL` varchar(150) DEFAULT NULL,
  `Email_Address` varchar(150) DEFAULT NULL,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Retailer_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `RETAILERS` */

insert  into `RETAILERS`(`Retailer_ID`,`Name`,`Address_Line1`,`Address_Line2`,`City`,`Phone_Number`,`Website_URL`,`Email_Address`,`Updated_Date`) values 
(1,'Schoolastic','21 Lady Ruby Drive','East Tamaki','Auckland',92748112,'https://www.scholastic.co.nz','bookclub@scholastic.co.nz',NULL),
(2,'Whitcoulls','54/52 Esk Street','CBD','Invercargill',39483130,'https://www.whitcoulls.co.nz/','admin@whitcoulls.co.nz','08-Jun-20 10:10:43 AM'),
(3,'Book Depository','60 Holborn Viaduct','','London',1234567890,'https://www.bookdepository.com','admin@bookdepository.co.nz','15-Jun-20 5:00:27 PM'),
(4,'Dumpster Mike','The Allyway','Behind the Library','This One',214207869,'N/A','N/A','16-Jun-20 10:18:05 PM');

/*Table structure for table `TESTTABLE` */

DROP TABLE IF EXISTS `TESTTABLE`;

CREATE TABLE `TESTTABLE` (
  `TEST_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Test_Name` char(200) DEFAULT NULL,
  PRIMARY KEY (`TEST_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `TESTTABLE` */

/*Table structure for table `USERS` */

DROP TABLE IF EXISTS `USERS`;

CREATE TABLE `USERS` (
  `User_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Email_Address` varchar(150) NOT NULL,
  `Password` varchar(150) NOT NULL,
  `RFID_Tag` varchar(20) DEFAULT NULL,
  `Customer_ID` int(11) DEFAULT NULL,
  `Acess_Level` int(11) DEFAULT NULL,
  `Banned` int(11) DEFAULT 0,
  `Updated_Date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`User_ID`),
  KEY `Customer_ID` (`Customer_ID`),
  CONSTRAINT `USERS_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `CUSTOMERS` (`Customer_ID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4;

/*Data for the table `USERS` */

insert  into `USERS`(`User_ID`,`Email_Address`,`Password`,`RFID_Tag`,`Customer_ID`,`Acess_Level`,`Banned`,`Updated_Date`) values 
(1,'ben@benking.co.nz','y3sk2Uq09XroA+ALYVoUZs9M+1HnXBD2W+qLgREFQYV9Q2U5BxqTzw==','4c0094c960',1,1,1,'8/05/2020 9:54:33 pm'),
(2,'benjaminkingnz@gmail.com','qf6Qe+e59tqJ4tRYcV5fAOnplsNDQO+PVBi31GGzcZPRRkvWM5CO7w==','lajss222',2,0,0,'9/05/2020 10:17:27 pm'),
(3,'800987@student.sit.ac.nz','guS7L8zOTI8bAwDQaQhmY4lWs0tjGlg1R1v/DQcsfPm38ohoucAcfA==','0107c396ad',3,2,1,'8/05/2020 9:54:33 pm'),
(4,'benking@xtra.co.nz','7k6MZ6abv9ckJCXw+97ssMMy374iUOh3qgsrUFTGfU+mrHZ9l+NMUw==','00s0s',4,0,0,'16-Jun-20 12:59:14 AM'),
(5,'njones123@benking.co.nz','PeUnyKD4Z84N25ny77nhQMx9TtRcvh8LrWWbmiYXD1+8pp1jT24KtA==','ds',5,0,0,'8/05/2020 9:54:33 pm'),
(6,'admin@benking.co.nz','uKXS97TM2Ga5tm+mB0HgsK1IEXvX8xRG6Tg9vPKnw4UjCGO5Z3ZI2w==','123456',NULL,2,0,'2020-06-16 00:53:51.692730'),
(7,'brent@benking.co.nz','TyqUSgSPJRCOw8BIrAhLDcktPDtCsF0kM1p1bVH7Wn/FKoBTXdEfuw==','SDDS',NULL,1,0,'8/05/2020 10:23:14 pm'),
(8,'jsmithy@benking.co.nz','eS2Bl6egybQ5JFVrpdl30OhQbkT6b3z6aDAy9yTrfPbb6bhxAf2uqA==','ds',6,0,0,'9/05/2020 10:16:42 pm'),
(9,'2014006529@student.sit.ac.nz','McyPaVm9Zgt52zO+YPJ1y8+/CnuR5Lus09CgwDF9/59HxKXTrXqonw==','SDDS',NULL,1,0,'10/05/2020 10:14:55 pm'),
(10,'junk@benking.co.nz','aokVpJ+xpzp4J4g2E5cyvsPow8T8s5L/s+QjDaH/l6jENTcphWq90Q==','HDJH',NULL,1,0,'12/05/2020 1:20:19 pm'),
(11,'lib@benking.co.nz','cdZ52r1psXcMMEAAppx1UIu+ueIolfnrmcdr/NtwY+8CTrLlD3QlCA==','',NULL,1,0,'2020-06-03 11:03:53.199520'),
(13,'customer@xtra.co.nz','P2iG8lhuI28hZc8gwsaPpRCCmD6C8LbkHTxzZm6CgF0VCrKPBNwUlA==','',9,0,0,'2020-06-03 11:19:17.000019'),
(15,'randomemail@email.com','Jo62qE3MrcUECs0J8KS8DYeJQzEet8FJa2ov7kjUbYjcJCCgSblmdQ==','',10,0,0,'2020-06-10 22:58:33.691416'),
(16,'newuser@email.com','zYNyDF4U7PySXZlDq9CqD+kB/j/ckwzTONSu1ZGf/qrt25YTdurkow==','',NULL,2,0,'2020-06-10 23:33:09.552106');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

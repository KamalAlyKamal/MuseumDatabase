CREATE DATABASE  IF NOT EXISTS `museum` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `museum`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: museum
-- ------------------------------------------------------
-- Server version	5.7.15-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `belongto`
--

DROP TABLE IF EXISTS `belongto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `belongto` (
  `WorkerSsn` int(14) NOT NULL,
  `DepID` int(11) NOT NULL,
  PRIMARY KEY (`WorkerSsn`,`DepID`),
  KEY `BelongtoDepartment_idx` (`DepID`),
  CONSTRAINT `BelongtoDepartmentID` FOREIGN KEY (`DepID`) REFERENCES `department` (`Departmentid`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `BelongtoWorkerSSN` FOREIGN KEY (`WorkerSsn`) REFERENCES `workers` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `belongto`
--

LOCK TABLES `belongto` WRITE;
/*!40000 ALTER TABLE `belongto` DISABLE KEYS */;
INSERT INTO `belongto` VALUES (111111,1),(111115,1),(111119,1),(111113,2),(111116,2),(111118,2),(111114,3),(111117,3),(111120,4),(111112,5);
/*!40000 ALTER TABLE `belongto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `Departmentid` int(11) NOT NULL,
  `DepartmentName` varchar(35) NOT NULL,
  `Section` char(1) NOT NULL,
  `Floor` int(11) NOT NULL,
  `Budget` int(11) NOT NULL,
  PRIMARY KEY (`Departmentid`),
  UNIQUE KEY `Departmentid_UNIQUE` (`Departmentid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'historicaldocuments','A',1,1000000),(2,'musicalinstruments','B',1,2000000),(3,'textiles','A',2,500000),(4,'weaponandammunition','B',2,900000),(5,'jewelery','A',3,4000000),(6,'Historicalfossils','B',3,400000),(7,'Paintings','A',4,500000),(8,'HistoricalEquipment','B',4,100000),(9,'Sculptures','C',4,100000),(10,'InternalSupplies','A',5,500000),(11,'Sales','B',5,40000),(12,'Research','A',6,50000),(50,'test767','A',9,1900),(99,'test','D',99,900);
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department_manager`
--

DROP TABLE IF EXISTS `department_manager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department_manager` (
  `SSN` int(14) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  PRIMARY KEY (`SSN`),
  KEY `DepartmentManagerDepartmentID_idx` (`DepartmentID`),
  CONSTRAINT `DepartmentManagerDepartmentID` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`Departmentid`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `DepartmentManagerManagerSSN` FOREIGN KEY (`SSN`) REFERENCES `managers` (`Ssn`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department_manager`
--

LOCK TABLES `department_manager` WRITE;
/*!40000 ALTER TABLE `department_manager` DISABLE KEYS */;
INSERT INTO `department_manager` VALUES (111126,1),(111127,2),(111128,3),(111129,4),(111130,5),(111133,10),(111132,11);
/*!40000 ALTER TABLE `department_manager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `SSN` int(14) NOT NULL,
  `Fname` varchar(30) NOT NULL,
  `Minit` char(1) NOT NULL,
  `Lname` varchar(30) NOT NULL,
  `Salary` int(11) NOT NULL,
  `Address` varchar(500) NOT NULL,
  `Sex` char(1) NOT NULL,
  `BirthDate` date NOT NULL,
  `PostalCode` int(11) NOT NULL,
  `Country` varchar(30) NOT NULL,
  `HomePhone` int(11) NOT NULL,
  `MobilePhone` varchar(11) NOT NULL,
  `Notes` varchar(500) NOT NULL,
  `Photo` varchar(500) NOT NULL,
  `HireDate` date NOT NULL,
  `YearsofExperience` int(11) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `BonusSalary` int(11) NOT NULL,
  `userType` int(1) NOT NULL,
  PRIMARY KEY (`SSN`),
  UNIQUE KEY `SSN_UNIQUE` (`SSN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (111111,'Jones','M','Smith',800,'38 Mohie El Din Abou El Ezz Street, Dokki-Giza, Egypt.','M','1996-05-05',1,'Egypt',25478564,'01004578569','EMPTYY','EMPTYY','2016-08-01',5,'00001',0,1),(111112,'David','S','Jones',900,'Cairo 87, Misr Helwan Agricultural Road Maadi, Cairo Egypt.','M','1990-05-04',2,'Egypt',24574136,'01117895425','EMPTYY','EMPTYY','2016-06-03',4,'00002',0,1),(111113,'Maia','F','Joe',500,'5th Compound, 8th Settlement, New Cairo','F','1992-05-02',3,'Egypt',25978543,'01007456874','EMPTYY','EMPTYY','2016-04-02',2,'00003',0,1),(111114,'Emy','K','Rowling',700,'Cairo 87, Misr Helwan Agricultural Road Maadi, Cairo Egypt.','F','1989-04-02',4,'Egypt',21475896,'01147856744','EMPTYY','EMPTYY','2016-01-02',6,'00004',0,1),(111115,'Khaled','M','Aly',200,'37 Mohie Street, Dokki, Giza, Egypt','M','1980-02-04',5,'Egypt',21478569,'01423478569','EMPTYY','EMPTYY','2016-05-20',1,'00005',0,1),(111116,'Faia','K','David',1000,'20 Street,  Madenet Nasr, Egypt','F','1995-02-05',6,'Egypt',21645475,'01004125698','EMPTYY','EMPTYY','2016-07-06',3,'00006',0,1),(111117,'Diana','J','Jones',1200,'15th street, Obour, Egypt','F','1990-05-11',7,'Egypt',21478569,'01145698745','EMPTYY','EMPTYY','2016-07-05',2,'00007',0,1),(111118,'Kim','E','Johm',500,'30th street, Dokki, Giza, Egypt','F','1992-09-22',8,'Egypt',21612354,'01008745698','EMPTYY','EMPTYY','2016-05-01',1,'00008',0,1),(111119,'Yen','K','Flick',300,'5th street new cairo Egypt','M','1990-05-02',9,'Egypt',21647589,'01147856984','EMPTYY','EMPTYY','2016-02-01',2,'00009',0,1),(111120,'James','M','Redeflick',1200,'3rd Street, Madenet Nasr, Egypt','M','1990-05-02',10,'Egypt',21645874,'01145698745','EMPTYY','EMPTYY','2016-03-05',3,'00010',0,1),(111121,'David','K','Rowling',1500,'3rd avenue, Dokki, Giza, Egypt','M','1990-05-03',11,'Egypt',26145785,'01004785698','EMPTYY','EMPTYY','2016-05-01',2,'00011',0,2),(111122,'Kayle','M','Jordan',2000,'20th street, Madenet Nasr, Egypt','M','1990-05-30',12,'Egypt',24785698,'01145987456','EMPTYY','EMPTYY','2016-01-29',3,'00012',0,2),(111123,'Josef','M','Micheal',2500,'30th Medan el mesaha, Dokki, Giza','M','1990-05-04',13,'Egypt',24785987,'01005789654','EMPTYY','EMPTYY','2016-07-05',2,'00013',0,2),(111124,'Mina','K','Rowling',1900,'20th Steet, Almaza, Cairo, Egypt','M','1991-04-03',14,'Egypt',24785698,'01145698745','EMPTYY','EMPTYY','2016-01-25',3,'00014',0,2),(111125,'Jasmin','M','Kareem',2100,'20th Street, el maadi, Cairo, Egypt','M','1991-04-01',15,'Saudi',24785978,'01145786987','EMPTYY','EMPTYY','2016-07-05',4,'00015',0,2),(111126,'Micheal','M','Jordan',2200,'29th street, Dokki, Giza, Egypt','M','1990-10-02',16,'USA',24578627,'01144455789','EMPTYY','EMPTYY','2016-07-07',5,'00016',0,3),(111127,'Flora','J','Jordan',2500,'2nd Street, Madenet Nasr, Egypt','F','1995-05-02',17,'Canada',24785687,'01142258878','EMPTYY','EMPTYY','2016-02-05',2,'00017',0,3),(111128,'James','M','Fred',1400,'27 Mohie Street, Dokki, Giza, Egypt','M','1999-07-02',18,'France',27589655,'01254886947','EMPTYY','EMPTYY','2016-03-01',4,'00018',0,3),(111129,'Garef','K','Flard',2000,'7th street new cairo Egypt','M','1986-04-03',19,'Egypt',27455687,'01255487897','EMPTYY','EMPTYY','2016-01-05',2,'00019',0,3),(111130,'Jerald','K','Kevin',2500,'5th Compound, 8th Settlement, New Cairo, Egypt','M','1987-04-02',20,'Canada',27587587,'01245878944','EMPTYY','EMPTYY','2016-01-05',3,'00020',0,3),(111131,'John','J','Rowling',3000,'London','M','1970-07-01',21,'Paris',27545569,'01005478965','EMPTYY','EMPTYY','2016-01-01',10,'00021',0,4),(111132,'David','F','Gail',4000,'New Cairo','M','1980-07-01',22,'London',57587857,'01005547895','EMPTYY','EMPTYY','2016-01-01',5,'00022',0,3),(111133,'Khaled','A','Mohamed',1000,'Madenet Nasr','M','1990-07-05',23,'Egypt',45878569,'01005878965','EMPTYY','EMPTYY','2016-05-02',3,'00023',0,3);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `exhibits`
--

DROP TABLE IF EXISTS `exhibits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `exhibits` (
  `ExhibitName` varchar(50) NOT NULL,
  `YearAcquired` date NOT NULL,
  `EstimatedValue` bigint(11) NOT NULL,
  `SerialNumber` int(10) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `Photo` varchar(50) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  UNIQUE KEY `SerialNumber_UNIQUE` (`SerialNumber`),
  KEY `ExhibitDepartmentID_idx` (`DepartmentID`),
  CONSTRAINT `ExhibitDepartmentID` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`Departmentid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exhibits`
--

LOCK TABLES `exhibits` WRITE;
/*!40000 ALTER TABLE `exhibits` DISABLE KEYS */;
INSERT INTO `exhibits` VALUES ('The Pledge of Allegiance','2016-01-30',6000000,1,'The Pledge of Allegiance was written in August 1892 by the socialist minister Francis Bellamy (1855-1931). It was originally published in The Youth\'s Companion on September 8, 1892. Bellamy had hoped that the pledge would be used by citizens in any country','EMPTYY',1),('The Letter of Columbus Announcing His Discovery','2016-06-06',2000000,2,'The following letter was written by Columbus, near the end of his return voyage, to Luis de Sant Angel, Treasurer of Aragon, who had given him substantial help in fitting out his expedition. This announcement of his discovery of the West Indies was evidently intended for the eyes of Ferdinand and Isabella. The text of the present translation is taken from American History Leaflets, edited by Professors Hart and Channing.','EMPTYY',1),('the declaration of independence','2016-05-01',2420000,3,'The Declaration of Independence is the statement adopted by the Second Continental Congress meeting at the Pennsylvania State House (Independence Hall) in Philadelphia which announced that the thirteen American colonies','EMPTYY',1),('Recognition of the Independence of Cuba','2016-05-05',100000,4,'The following resolution not only recognized the independence of Cuba, but authorized the levying of war upon Spain in order to force upon that country a similar recognition. The resolution was passed in response to a message sent to Congress by President McKinley, April 11, 1898, asking for permission to intervene in Cuba.','EMPTYY',1),('The Voyages to Vinland','2016-04-08',500000,5,'The following account of the discovery of North America by Leif Ericsson is contained in the “Saga of Eric the Red”; and the present translation is that made by A. M. Reeves from the version of the Saga in the Flateyar-bok, compiled by Jon Thordharson about 1387. The part of the coast where Leif landed is much in dispute, the most recent investigations tending to the southern part of the coast of Labrador, though many scholars believe Vinland to have been on the New England shore.','EMPTYY',1),('Balfour Declaration','2016-05-09',500000,6,'The Balfour Declaration was a letter from the United Kingdom\'s Foreign Secretary Arthur James Balfour to Walter Rothschild, 2nd Baron Rothschild, a leader of the British Jewish community for transmission to the Zionist Federation of Great Britain and Ireland. stating that united kingdom will help them  to establish a national home for the jewesh people  in Palestine.','EMPTYY',1),('The National Association on a German Constitution','2016-03-03',5000000,7,'The declaration of the National Association on the question of a German constitution (from September 4, 1860) clarifies the Association\'s view that a German nation-state was only possible on the basis of a liberal reform government in Prussia.','EMPTYY',1),('Surrender of Germany','2016-07-04',1000000,8,'The unconditional surrender of the German Third Reich from World War II','EMPTYY',1),('Paris Treaty','2016-08-19',1000000,9,'Agreement between Austria, France, Great Britain, Prussia, Russia, Sardinia, and Turkey about peace, borders, war prisoners, and trade between countries. Includes agreements about Black Sea and Danube use as well as territorial changes.','EMPTYY',1),('The Proclamation of Rebellion','2016-07-05',5000000,10,'it was the response of George III of Great Britain to the news of the Battle of Bunker Hill at the outset of the American Revolutionary War, it declared elements of the American colonies in a state of \"open and avowed rebellion.\" It ordered officials of the British Empire \"to use their utmost endeavours to withstand and suppress such rebellion','EMPTYY',1),('Kin','2016-01-01',1000,11,'large Japanese temple bell, made in the 19th century or earlier. Overall height (including red lacquered wooden stand) 61.0cm. Diameter of gong 42.0cm.','EMPTYY',2),('Conch Horn','2016-07-01',1500,12,'EMPTYY','EMPTYY',2),('Flageolet','2016-05-01',1000,13,'EMPTYY','EMPTYY',2),('Shoe Shaped Harp','2016-03-01',2500,14,'EMPTYY','EMPTYY',2),('Banjo','2016-05-03',250000,15,'The banjo is a four-, five- or six- or even more rarely 12-stringed instrument with a thin membrane stretched over a frame or cavity as a resonator, called the head.','EMPTYY',2),('Hour-Glass Shaped Drum','2016-09-05',45000,16,'EMPTYY','EMPTYY',2),('Balloon Guitar','2016-07-03',47000,17,'EMPTYY','EMPTYY',2),('ETHNOGRAPHIC','2016-03-20',4999,18,'EMPTYY','EMPTYY',2),('Xylophone with stick','2016-04-30',7800,19,'Bird arrows , Wooden stick with rubber top , 10 candles used','EMPTYY',2),('MONKEY FLUTE','2016-06-01',8000,20,'EMPTYY','EMPTYY',2),('POUCH WITH STRAP','2016-04-02',5000,21,'bags used to carry stuff','EMPTYY',3),('Man\'s Robe','2016-07-04',8000,22,'EMPTYY','EMPTYY',3),('SASH','2016-05-01',7000,23,'it is large and usually colorful ribbon or band of material worn around the body, draping from one shoulder to the opposing hip, or else running around the waist','EMPTYY',3),('Cloth Fragment','2016-04-29',3200,24,'EMPTYY','EMPTYY',3),('Pouch with Cloth Plateau ','2016-09-21',9800,25,'EMPTYY','EMPTYY',3),('AFRICAN ETHNOGRAPHIC COLLECTION','2016-05-12',60000,26,'EMPTYY','EMPTYY',3),('Woman Legging','2016-07-25',94000,27,'EMPTYY','EMPTYY',3),('Sash','2016-06-05',45100,28,'EMPTYY','EMPTYY',3),('Kapala','2016-04-01',60000,29,'Head Cloth in ancient Indonesia','EMPTYY',3),('DECORATED BAND FRAGMENT','2016-08-04',7000,30,'EMPTYY','EMPTYY',3),('Battle Axe','2016-03-02',5000,31,'EMPTYY','EMPTYY',4),('ASian CAnon','2016-08-03',9000,32,'EMPTYY','EMPTYY',4),('Sword','2016-01-01',5400,33,'Origin : AFRICAN    : WarsUsedAt :    Material  :  STONE - Era :1901   - Type :projectile   ExhibitName:SAMPLE, SHOT','EMPTYY',4),('tomahawk ','2016-01-27',12000,34,'type of single-handed axe from North America, traditionally resembling a hatchet with a straight shaft','EMPTYY',4),('SPRINGFIELD RIFLE WITH BRASS NAILS','2016-04-02',20000,35,'a long rifle first produced by springfield armory in springfield massachussetts and then used by lakota tribe during the american civil war','EMPTYY',4),('SAMPLE  SHOT','2016-08-03',800,36,'EMPTYY','EMPTYY',4),('Bow with string','2016-07-05',3000,37,' a projectile weapon system used to shoot aerodynamic arrows','EMPTYY',4),('BULL hammer','2016-07-05',5000,38,'a stone ball club that were used mostly by early Plains, Plateau and Southwest Native Indians . These consisted of a relatively free-moving head of rounded stone or wood attached to a wooden handle','EMPTYY',4),('Kpinga ','2016-02-07',3500,39,' a bladed throwing knife used by the Azande of Nubia. It would have been about 22 inches in length and had three different shaped blades projecting at different angles to maximize damage to the enemy','EMPTYY',4),('Chu Ko Nu','2016-07-09',50000,40,'it is a crossbow where the separate actions of stringing the bow, placing the bolt and shooting it can be accomplished with a simple one-handed movement while keeping the crossbow stationary','EMPTYY',4),('GOLD FINGER RING','2016-02-07',10000,41,'a golden ring believed to be a gift from a mexican husband to his wife from Tzotzil Maya tribe','EMPTYY',5),('zuni','2016-08-03',50000,42,'This piece of Native American jewelry  hand made  out of genuine sterling silver .The necklace is composed of double strands of 8-mm silver eccentric beads placed at regular intervals among the sides of the center link.','EMPTYY',5),('Navajo','2016-09-21',25000,43,'This piece of Native American jewelry is hand strung out of sterling silver and . The necklace is made up of fourstrands that consist of: Purple Agate branch beads that average about 10-mm','EMPTYY',5),('hopi','2016-09-15',10000,44,'This piece of Native American jewelry is hand crafted out of sterling silver.�the second layer forms a marvelous Water Wave design . In Native American beliefs, the water waves design represents continuous life.','EMPTYY',5),('fulani','2016-09-01',150000,45,'Traditional West African earrings hand crafted out of 21 karat gold .  only highborn Sambala tribe women wore this earring  through centuries as a form of wealth ','EMPTYY',5),('Sunray ','2016-09-25',25000,46,'EMPTYY','EMPTYY',5),('scalp ornament','2016-05-01',30000,47,'EMPTYY','EMPTYY',5),('the Nizam Crown','2016-06-12',20000000,48,'the crown worn by Sir Mir Osman Ali Khan during his ruling era','EMPTYY',5),('Hope Diamond','2016-08-03',15000000,49,'EMPTYY','EMPTYY',5),('imperial sceptre','2016-06-20',25000000,50,'The Orlov diamond in the sceptre  is a large diamond whose origin can be traced back to 18th century in southern India. The particulars of the Orlovs story have been lost with time, but it is widely reported that the diamond once served as an eye of the statue in a temple in southern India. ','EMPTYY',5),('Iguanodon','2016-06-12',999999999,51,'EMPTYY','EMPTYY',6),('Megalosaurus','2016-06-02',999999999,52,'EMPTYY','EMPTYY',6),('Mosasaurus','2016-06-01',999999999,53,'EMPTYY','EMPTYY',6),('Hadrosaurus','2016-06-30',999999999,54,'EMPTYY','EMPTYY',6),('Archaeopteryx','2016-02-04',999999999,55,'EMPTYY','EMPTYY',6),('Anchiornis','2016-02-01',999999999,56,'EMPTYY','EMPTYY',6),('Diplodocus','2016-02-10',999999999,57,'EMPTYY','EMPTYY',6),('Coelophysis','2016-02-25',999999999,58,'EMPTYY','EMPTYY',6),('Euoplocephalus','2016-02-24',999999999,59,'EMPTYY','EMPTYY',6),('Brachylophosaurus','2016-08-04',999999999,60,'EMPTYY','EMPTYY',6),('mona lisa','2016-08-05',10000000,61,'EMPTYY','EMPTYY',7),('Bonjour, Monsieur Courbet','2016-08-10',8000000,62,'EMPTYY','EMPTYY',7),('The Butcher\'s Shop','2016-08-05',5000000,63,'EMPTYY','EMPTYY',7),('The Scream','2016-08-06',3000000,64,'EMPTYY','EMPTYY',7),('The Death of Sardanapalus','2016-04-03',9000000,65,'EMPTYY','EMPTYY',7),('The Lady of Shalott','2016-04-05',6500000,66,'EMPTYY','EMPTYY',7),('The Luncheon on the Grass','2016-04-03',4500000,67,'EMPTYY','EMPTYY',7),('The Last Supper','2016-03-04',15000000,68,'EMPTYY','EMPTYY',7),('The Creation of Adam','2016-03-01',12000000,69,'EMPTYY','EMPTYY',7),('The Starry Night','2016-03-08',9600000,70,'EMPTYY','EMPTYY',7),('Scissor','2016-04-05',90000,71,'EMPTYY','EMPTYY',8),('Shears','2016-04-01',50000,72,'EMPTYY','EMPTYY',8),('Knive','2016-04-09',10000,73,'EMPTYY','EMPTYY',8),('Compass','2016-04-20',50000,74,'EMPTYY','EMPTYY',8),('Cloth Ruler','2016-01-05',11000,75,'EMPTYY','EMPTYY',8),('Snow Shoes','2016-01-05',5000,76,'EMPTYY','EMPTYY',8),('Sledge Hammer','2016-01-10',100000,77,'EMPTYY','EMPTYY',8),('Terra Cotta Stamp','2016-01-25',20000,78,'EMPTYY','EMPTYY',8),('Dice (Set of 4)','2016-05-20',6000,79,'EMPTYY','EMPTYY',8),('Buck Saw','2016-01-19',10000,80,'EMPTYY','EMPTYY',8),('Akhenaten Daughter','2016-05-22',1000,81,'EMPTYY','EMPTYY',9),('Nefertiti large sculpture','2016-05-29',1000000,82,'EMPTYY','EMPTYY',9),('Osiris plaque','2016-05-15',200000,83,'EMPTYY','EMPTYY',9),('Statue of Alexander the Great','2016-09-15',15000,84,'EMPTYY','EMPTYY',9),('Dying Slave','2016-09-10',14000,85,'EMPTYY','EMPTYY',9),('Marble statue of Poseidon','2016-09-12',20000,86,'EMPTYY','EMPTYY',9),('Goddess Uma sculpture','2016-09-13',1000,87,'EMPTYY','EMPTYY',9),('Japanese Cat sculpture','2016-09-11',1000,88,'EMPTYY','EMPTYY',9),('Seated Buddha sculpture','2016-10-12',12000,89,'EMPTYY','EMPTYY',9),('Native American Warrior','2016-09-28',15000,90,'EMPTYY','EMPTYY',9);
/*!40000 ALTER TABLE `exhibits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historicaldocuments`
--

DROP TABLE IF EXISTS `historicaldocuments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historicaldocuments` (
  `SerialNumber` int(10) NOT NULL,
  `Date` date NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  UNIQUE KEY `Serial_Numbers_UNIQUE` (`SerialNumber`),
  CONSTRAINT `DocumentExhibitSerialNumber` FOREIGN KEY (`SerialNumber`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historicaldocuments`
--

LOCK TABLES `historicaldocuments` WRITE;
/*!40000 ALTER TABLE `historicaldocuments` DISABLE KEYS */;
INSERT INTO `historicaldocuments` VALUES (1,'1892-08-03'),(2,'1493-03-14'),(3,'1776-07-04'),(4,'1898-04-11'),(5,'1000-01-01'),(6,'1917-11-02'),(7,'1860-08-02'),(8,'1945-05-07'),(9,'1856-03-30'),(10,'1775-08-23');
/*!40000 ALTER TABLE `historicaldocuments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historicalequipments`
--

DROP TABLE IF EXISTS `historicalequipments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historicalequipments` (
  `SerialNumber` int(10) NOT NULL,
  `Use` varchar(30) NOT NULL,
  `Culture` varchar(30) NOT NULL,
  `era` varchar(30) NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  CONSTRAINT `EquipmentExhibitSerialNumber` FOREIGN KEY (`SerialNumber`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='HistoricalEquipments table with attributes ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historicalequipments`
--

LOCK TABLES `historicalequipments` WRITE;
/*!40000 ALTER TABLE `historicalequipments` DISABLE KEYS */;
INSERT INTO `historicalequipments` VALUES (71,'Shearing','JAPANESE','1000-1100'),(72,'Tailor Shears','CHINESE','1132-1140'),(73,'Cutting','LI CAMEROoN','1600-1630'),(74,'Measuring Device','CHINESE','900-1000'),(75,'Measuring Cloth','JAPANESE','1100-1163'),(76,'Walking in snow','CANADA','1780-1860'),(77,'Hammering','ESKIMO','1820-1842'),(78,'Marking and Stamping','NAHUATL MEXICO','1710-1765'),(79,'Board Games','ARAPAHO','1800-1870'),(80,'Cut firewood','CHAMA PERU','1600-1710');
/*!40000 ALTER TABLE `historicalequipments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historicalfossils`
--

DROP TABLE IF EXISTS `historicalfossils`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historicalfossils` (
  `SerialNumber` int(10) NOT NULL,
  `CarbonLevel` int(30) NOT NULL,
  `Species` varchar(30) NOT NULL,
  `Period` varchar(30) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `Age` int(15) NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  CONSTRAINT `FossilsExhibitsSerialNumber` FOREIGN KEY (`SerialNumber`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='HistoricalFossils table with attributes ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historicalfossils`
--

LOCK TABLES `historicalfossils` WRITE;
/*!40000 ALTER TABLE `historicalfossils` DISABLE KEYS */;
INSERT INTO `historicalfossils` VALUES (51,10,'Ornithischia','mid-Jurassic','thumb',126000000),(52,6,'Ornithischia','late-jurassic','jaw',166000000),(53,15,'Squamata','Cretaceous','full skeleton',70000000),(54,17,'Ornithischia','Cretaceous','full skeleton',65000000),(55,7,'Saurischia','late-jurassic','half skeleton',150000000),(56,6,'Saurischia','late-jurassic','full skeleton',160000000),(57,7,'Saurischia','late-jurassic','head',155000000),(58,2,'Saurischia','late-Triassic  ','foot',200000000),(59,18,'Ornithischia','Cretaceous','full skeleton',60000000),(60,13,'Ornithischia','early-Jurassic','half skeleton',90000000);
/*!40000 ALTER TABLE `historicalfossils` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `internalsupplies`
--

DROP TABLE IF EXISTS `internalsupplies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `internalsupplies` (
  `QuantityTotal` int(11) NOT NULL,
  `QuantityResearch` int(11) NOT NULL,
  `QuantityExhibits` int(11) NOT NULL,
  `SuppliedItemName` varchar(30) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  PRIMARY KEY (`SuppliedItemName`,`SupplierID`),
  KEY `InternalSupplierID_idx` (`SupplierID`),
  KEY `InternalDepartmentID_idx` (`DepartmentID`),
  CONSTRAINT `InternalDepartmentID` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`Departmentid`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `InternalSupplierID` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `internalsupplies`
--

LOCK TABLES `internalsupplies` WRITE;
/*!40000 ALTER TABLE `internalsupplies` DISABLE KEYS */;
INSERT INTO `internalsupplies` VALUES (1000,300,60,'bags',117,10),(310,10,300,'calculatorrrr',115,10),(100,60,30,'calculators ',115,10),(1000,800,100,'copybooks',113,10),(100,40,20,'free cd',116,10),(20,5,15,'nookj',111,10),(800,500,100,'pencils ',110,10),(1000,700,200,'Pens ',110,10),(200,15,120,'phones ',112,10),(100,100,100,'qweqwe',112,10),(100,50,15,'taplets ',111,10),(50,8,42,'test989',114,10),(500,5,4,'testtt87',112,10),(600,100,300,'watches',114,10),(600,300,50,'white papers packets',110,10);
/*!40000 ALTER TABLE `internalsupplies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jewelery`
--

DROP TABLE IF EXISTS `jewelery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jewelery` (
  `Serial_Number` int(10) NOT NULL,
  `Type` char(30) NOT NULL,
  `Culture` char(30) NOT NULL,
  `Material` char(30) NOT NULL,
  PRIMARY KEY (`Serial_Number`),
  UNIQUE KEY `serial_number_UNIQUE` (`Serial_Number`),
  CONSTRAINT `JeweleryExhibitSerialNumber` FOREIGN KEY (`Serial_Number`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jewelery`
--

LOCK TABLES `jewelery` WRITE;
/*!40000 ALTER TABLE `jewelery` DISABLE KEYS */;
INSERT INTO `jewelery` VALUES (41,'ring','mexican','gold'),(42,'necklace','native american','silver'),(43,'necklace','native american','silver'),(44,'ring','native american','silver'),(45,'earrings','african','gold'),(46,'earrings','african','silver'),(47,'necklace','native american','bone'),(48,'crown','indian','emerald'),(49,'necklace','indian','diamond'),(50,'sceptre','russian','diamind');
/*!40000 ALTER TABLE `jewelery` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `managers`
--

DROP TABLE IF EXISTS `managers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `managers` (
  `Ssn` int(14) NOT NULL,
  `Email` varchar(30) DEFAULT NULL,
  `Title` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`Ssn`),
  CONSTRAINT `ManagerEmployeeSSN` FOREIGN KEY (`Ssn`) REFERENCES `employee` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `managers`
--

LOCK TABLES `managers` WRITE;
/*!40000 ALTER TABLE `managers` DISABLE KEYS */;
INSERT INTO `managers` VALUES (111121,'johan@hotmail.com','Eng'),(111122,'kyaan@yahoo.com','Eng'),(111123,'Joose@yahoo.com','Mr'),(111124,'minaa@hotmail.com','Prof'),(111125,'jas@yahoo.com','Mr'),(111126,'jam@yahoo.com','Eng'),(111127,'sKled@hotmail.com','Prof'),(111128,'jamKa@yahoo.com','Eng'),(111129,'KalV@hotmail.com','Eng'),(111130,'JUil@yahoo.com','Mr'),(111131,'kjjkz2yahoo.com','Mr'),(111132,'kj@hotmail.com','Eng'),(111133,'fwwf@gmail.com','Mr');
/*!40000 ALTER TABLE `managers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `musicalinstruments`
--

DROP TABLE IF EXISTS `musicalinstruments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `musicalinstruments` (
  `Serial_Number` int(10) NOT NULL,
  `Type` char(30) NOT NULL,
  `Culture` char(30) NOT NULL,
  `Material` char(30) NOT NULL,
  PRIMARY KEY (`Serial_Number`),
  UNIQUE KEY `Serial_Number_UNIQUE` (`Serial_Number`),
  CONSTRAINT `MusicalExhibitSerialNumber` FOREIGN KEY (`Serial_Number`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `musicalinstruments`
--

LOCK TABLES `musicalinstruments` WRITE;
/*!40000 ALTER TABLE `musicalinstruments` DISABLE KEYS */;
INSERT INTO `musicalinstruments` VALUES (11,'Percussion','Asian Japanese','Wood'),(12,'Horn','Nepalese','Shell'),(13,'Flute','British Guiana','Bone'),(14,'Harp','Afghanistan','Wood/Hair'),(15,'string','NYANDERE','wood'),(16,'Drum','Chinese','Wood/String/Metal'),(17,'Guitar','Chinese','Wood/Bone/String'),(18,'WHISTLES','BRITISH GUIAN','Bone'),(19,'Xylophone','Mexican Guatemala','Wood/Metal'),(20,'flute','mexican','clay');
/*!40000 ALTER TABLE `musicalinstruments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paintings`
--

DROP TABLE IF EXISTS `paintings`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paintings` (
  `SerialNumber` int(10) NOT NULL,
  `PainterName` varchar(30) NOT NULL,
  `School` varchar(30) NOT NULL,
  `size` varchar(15) NOT NULL,
  `YearCompleted` int(5) NOT NULL,
  `PossessionType` varchar(30) NOT NULL,
  `ReturnDate` date NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  CONSTRAINT `PaintingExhibitSerialNumber` FOREIGN KEY (`SerialNumber`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='paintings table with attributes ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paintings`
--

LOCK TABLES `paintings` WRITE;
/*!40000 ALTER TABLE `paintings` DISABLE KEYS */;
INSERT INTO `paintings` VALUES (61,'Leonardo da Vinci','High Renaissance','53L-77W',1504,'rented','2017-03-01'),(62,'Gustave Courbet','Realism ','129L-149W',1854,'owned','0000-00-00'),(63,'Annibale Carracci','Realism ','185L-266W',1580,'owned','0000-00-00'),(64,'Edvard Munch','modern art','91L-73W',1905,'owned','0000-00-00'),(65,'Eugne Delacroix','Romanticism','392L-496W',1827,'rented','2016-12-01'),(66,'John William Waterhouse','Romanticism','183L-230L',1888,'owned','0000-00-00'),(67,'douard Manet','Impressionism','208L-264.5W',1863,'owned','0000-00-00'),(68,'Leonardo da Vinci','High Renaissance','460L-880W',1498,'rented','2017-05-01'),(69,'Michelangelo','High Renaissance','280L-570w',1512,'rented','2017-04-02'),(70,'Vincent van Gogh','modern art','73L-92W',1889,'rented','2017-08-02');
/*!40000 ALTER TABLE `paintings` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `research`
--

DROP TABLE IF EXISTS `research`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `research` (
  `Type` char(30) NOT NULL,
  `Topic` char(55) NOT NULL,
  `Researcher_SSN` int(14) NOT NULL,
  `Start_Date` date NOT NULL,
  `End_Date` date NOT NULL,
  `Status` int(1) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  PRIMARY KEY (`Type`,`Topic`),
  KEY `ResearcherWorkerSSN_idx` (`Researcher_SSN`),
  KEY `ResearcherDepartmentID_idx` (`DepartmentID`),
  CONSTRAINT `ResearcherDepartmentID` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`Departmentid`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `ResearcherWorkerSSN` FOREIGN KEY (`Researcher_SSN`) REFERENCES `workers` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `research`
--

LOCK TABLES `research` WRITE;
/*!40000 ALTER TABLE `research` DISABLE KEYS */;
INSERT INTO `research` VALUES ('Archaeology','Hagr Edfu Egypt',111114,'2016-04-01','0000-00-00',0,'EMPTY',12),('Archaeology','Iron Age',111116,'2016-11-15','0000-00-00',0,'EMPTY',12),('Fossil','Ancient fossiles in Luxor',111116,'2016-01-02','0000-00-00',0,'EMPTY',12),('Medical','Greek and Roman medical instruments',111114,'2016-01-10','0000-00-00',0,'EMPTY',12),('Treasure','Investigating Luxor Treasures',111116,'2016-01-01','0000-00-00',0,'EMPTY',12);
/*!40000 ALTER TABLE `research` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sales` (
  `ItemName` char(30) NOT NULL,
  `BarCode` int(10) NOT NULL,
  `QuantityStock` int(11) NOT NULL,
  `QuantityOrder` int(11) NOT NULL,
  `SupplierID` int(11) NOT NULL,
  `SellingPrice` int(11) NOT NULL,
  `UnitCost` int(11) NOT NULL,
  `DiscountPercentage` int(11) NOT NULL,
  `DepartmentID` int(11) NOT NULL,
  PRIMARY KEY (`BarCode`),
  UNIQUE KEY `BarCode_UNIQUE` (`BarCode`),
  KEY `SalesSupplierID_idx` (`SupplierID`),
  KEY `SalesDepartmentID_idx` (`DepartmentID`),
  CONSTRAINT `SalesDepartmentID` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`Departmentid`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `SalesSupplierID` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES ('perfumes',123256789,300,30,122,606,363,0,11),('historical sweetshirts',123456781,131,122,120,97,26,23,11),('notebooks',123456782,300,200,110,148,109,20,11),('hand made crafts',123456783,123,80,120,727,485,30,11),('novels',123456784,100,60,124,243,146,0,11),('car accessories',123456785,200,180,123,483,362,0,11),('nickleace',123456786,120,90,121,206,97,30,11),('t-shirts',123456787,200,120,120,97,55,10,11),('metal statues',123456788,100,60,119,120,49,0,11),('poster',123456789,80,12,110,72,37,10,11);
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sculptures`
--

DROP TABLE IF EXISTS `sculptures`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sculptures` (
  `SerialNumber` int(10) NOT NULL,
  `SculptorName` varchar(30) NOT NULL,
  `Material` varchar(30) NOT NULL,
  `Culture` varchar(30) NOT NULL,
  `Weight` varchar(30) NOT NULL,
  `YearCompleted` varchar(30) NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  UNIQUE KEY `SerialNumber_UNIQUE` (`SerialNumber`),
  CONSTRAINT `SculpturesExhibitSerialNumber` FOREIGN KEY (`SerialNumber`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Scultptures table with attributes ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sculptures`
--

LOCK TABLES `sculptures` WRITE;
/*!40000 ALTER TABLE `sculptures` DISABLE KEYS */;
INSERT INTO `sculptures` VALUES (81,'EMPTYY','cast stone','egyptian','1kg','3000BC'),(82,'EMPTYY','cast stone','egyptian','5kg','3000BC'),(83,'EMPTYY','cast stone','egyptian','4kg','2700BC'),(84,'EMPTYY','marble','greek','20kg','1600BC'),(85,'Michelangelo Buonarroti','marble','french','600kg','1703'),(86,'Byblos','marble','turkish','35kg','4000BC'),(87,'EMPTYY','bronze','asian','4kg','1600'),(88,'EMPTYY','bronze','japanese','1kg','1900'),(89,'EMPTYY','bronze','asian','2kg','900'),(90,'EMPTYY','resin bronze','Indian Native American','3kg','700');
/*!40000 ALTER TABLE `sculptures` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suppliers` (
  `SupplierID` int(11) NOT NULL,
  `SupplierName` char(30) NOT NULL,
  `Fax` bigint(10) NOT NULL,
  `Address` varchar(500) NOT NULL,
  `City` char(20) NOT NULL,
  `Region` char(20) NOT NULL,
  `PostalCode` bigint(7) NOT NULL,
  `Phone` bigint(13) NOT NULL,
  `HomePage` varchar(500) NOT NULL,
  PRIMARY KEY (`SupplierID`),
  UNIQUE KEY `SupplierID_UNIQUE` (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (110,'samir and ali',37480077,'7 medan el msaha','giza','dokki',12345,1022334433,'EMPTYY'),(111,'samsung',37480078,'2 tl3t 7arb','giza','moneb',12346,1022334434,'EMPTYY'),(112,'nokia',37480079,'2 karim el aswiti street','monfea','waraa',12347,1022334435,'EMPTYY'),(113,'alwan',37480080,'31 monfi street','monfea','waraa',12348,1022334436,'EMPTYY'),(114,'sowatch',37480081,'6 barzil street','cairo','zamlek',12349,1022334437,'EMPTYY'),(115,'casio',37480082,'22 gamal salem street','giza','mohandsen',12350,1022334438,'EMPTYY'),(116,'pansonic',37480083,'6 el hosry street','cairo','october',12351,1022334439,'EMPTYY'),(117,'nike',37480084,'23 el hosry street','cairo','october',12352,1022334440,'EMPTYY'),(119,'el hadedi',37480085,'6 gamal wasef street','giza','dokki',12353,1022334441,'EMPTYY'),(120,'h&m',37480086,'2 el monofi street','monfea','abozazee',12354,1022334442,'EMPTYY'),(121,'guess',37480087,'6 hay el ashgar street','cairo','masrelgdeda',12355,1022334443,'EMPTYY'),(122,'onemillion',37480088,'33 gam3a street','giza','gamaa',12356,1022334444,'EMPTYY'),(123,'hmobile',37480089,'12 nour street','monfea','abozazee',12357,1022334445,'EMPTYY'),(124,'darelnashar',37480090,'144 ahmed esmat street','cairo','ainshams',12358,1022334446,'EMPTYY');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `textiles`
--

DROP TABLE IF EXISTS `textiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `textiles` (
  `SerialNumber` int(10) NOT NULL,
  `Materials` varchar(30) NOT NULL,
  `Dimensions` varchar(30) NOT NULL,
  `Culture` varchar(30) NOT NULL,
  PRIMARY KEY (`SerialNumber`),
  UNIQUE KEY `Serial_number_UNIQUE` (`SerialNumber`),
  CONSTRAINT `TextiltedExhibitSerialNumber` FOREIGN KEY (`SerialNumber`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `textiles`
--

LOCK TABLES `textiles` WRITE;
/*!40000 ALTER TABLE `textiles` DISABLE KEYS */;
INSERT INTO `textiles` VALUES (21,'cloth/tape/beads/yarn','94L 29W','COMANCHE'),(22,'Cotton','136L 5W','Hausa'),(23,'PLANT FIBER / wool','185L W12.5','MICRONESIA'),(24,'Cotton ','39.5L 30W','Peru '),(25,'Cloth ','94L W29','Plateau'),(26,'BArkcloth','63*25.5 *18 Cm','Peru '),(27,'Wool ','30L 18W','Nez Perce'),(28,'Plant Fiber','171L 11W','Caroline Islands'),(29,'Cloth','80L 50W','Indonesia'),(30,'FISH MOTIF','27*6 Cm','MICRONESIA');
/*!40000 ALTER TABLE `textiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `weaponandammunition`
--

DROP TABLE IF EXISTS `weaponandammunition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `weaponandammunition` (
  `Serial_Number` int(10) NOT NULL,
  `Origin` varchar(30) NOT NULL,
  `WarsUsedAt` varchar(45) NOT NULL,
  `Material` varchar(30) NOT NULL,
  `Era` varchar(30) NOT NULL,
  `Type` varchar(30) NOT NULL,
  PRIMARY KEY (`Serial_Number`),
  UNIQUE KEY `serial_number_UNIQUE` (`Serial_Number`),
  CONSTRAINT `WeaponExhibitSerialNumber` FOREIGN KEY (`Serial_Number`) REFERENCES `exhibits` (`SerialNumber`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weaponandammunition`
--

LOCK TABLES `weaponandammunition` WRITE;
/*!40000 ALTER TABLE `weaponandammunition` DISABLE KEYS */;
INSERT INTO `weaponandammunition` VALUES (31,'Togo','EMPTYY','Wood/Metal','Tchore ','Axe'),(32,'PHILIPPINES','EMPTYY','BRASS','circa 1900 A.D ','Canon'),(33,'Republic of Kiribati','Wars of Micronesia','Wood/Tooth','Late 19th Century A.D.','Sword'),(34,'america ','Indigenous amirican peaople war vs colonies','IRON','native american culture','axe'),(35,'america ','American Civil War','IRON/ BRASS/ STEEL','LAKOTA',' long gun'),(36,'AFRICAN','EMPTYY','STONE','Early 19th Century A.D.','projectile'),(37,'usa ','native americans vs colonies','Wood','comanche','projectile '),(38,'usa ','native americans vs colonies','stone/wood','BLACKFEET','clubs '),(39,'zimbabwe','zimbabwe civil war','iron','zande ','projectile '),(40,'china','Sino-Japanese wars','wood','northern chinese','projectile');
/*!40000 ALTER TABLE `weaponandammunition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `worker_manager`
--

DROP TABLE IF EXISTS `worker_manager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `worker_manager` (
  `SSN` int(14) NOT NULL,
  `Jop_title` varchar(30) NOT NULL,
  PRIMARY KEY (`SSN`),
  CONSTRAINT `WorkerManagerManagerSSN` FOREIGN KEY (`SSN`) REFERENCES `managers` (`Ssn`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_manager`
--

LOCK TABLES `worker_manager` WRITE;
/*!40000 ALTER TABLE `worker_manager` DISABLE KEYS */;
INSERT INTO `worker_manager` VALUES (111121,'Technician'),(111122,'Presenter'),(111123,'Cleaner'),(111124,'Researcher'),(111125,'Salesman');
/*!40000 ALTER TABLE `worker_manager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workers`
--

DROP TABLE IF EXISTS `workers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workers` (
  `SSN` int(14) NOT NULL,
  `ShiftTime` varchar(30) NOT NULL,
  `JobTitle` varchar(30) NOT NULL,
  `WorkerMngrSSN` int(14) NOT NULL,
  PRIMARY KEY (`SSN`),
  UNIQUE KEY `SSN_UNIQUE` (`SSN`),
  KEY `WorkerWorkerManagerSSN_idx` (`WorkerMngrSSN`),
  CONSTRAINT `WorkerEmployeeSSN` FOREIGN KEY (`SSN`) REFERENCES `employee` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `WorkerWorkerManagerSSN` FOREIGN KEY (`WorkerMngrSSN`) REFERENCES `worker_manager` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workers`
--

LOCK TABLES `workers` WRITE;
/*!40000 ALTER TABLE `workers` DISABLE KEYS */;
INSERT INTO `workers` VALUES (111111,'4pm','Technician',111121),(111112,'8am','Cleaner',111123),(111113,'12pm','Salesman',111125),(111114,'8pm','Researcher',111124),(111115,'12pm','Presenter',111122),(111116,'8am','Researcher',111124),(111117,'8pm','Cleaner',111123),(111118,'4pm','Technician',111121),(111119,'8pm','Cleaner',111123),(111120,'8am','Salesman',111125);
/*!40000 ALTER TABLE `workers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'museum'
--

--
-- Dumping routines for database 'museum'
--
/*!50003 DROP PROCEDURE IF EXISTS `AddNewDepartment` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddNewDepartment`(in DepID INT(11), in DepName VARCHAR(35), in Sec CHAR(1), in Floor INT(11), in Budget INT(11))
BEGIN
Insert into department values (DepId, DepName, Sec, Floor, Budget);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AddNewInternalSupplies` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddNewInternalSupplies`(in QuantityTotal INT(11), in QuantityResearch INT(11), in QuantityExhibits INT(11), in SuppliedItemName VARCHAR(30), in SupplierID INT(11), in DepId INT(11))
BEGIN
	Insert into internalsupplies values (QuantityTotal, QuantityResearch, QuantityExhibits, SuppliedItemName, SupplierID, DepId);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CalculateProfit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CalculateProfit`(in BCode INT(10))
BEGIN
 
		select ( SellingPrice - UnitCost - ( SellingPrice * DiscountPercentage / 100 ))  
        from sales
        where BarCode = BCode;
        
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CountExhibits` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CountExhibits`()
BEGIN
	Select count(*) as TotalNumberOfExhibits
    from exhibits;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `CountWorkers` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `CountWorkers`()
BEGIN
	select count(SSN) as NumberOfWorkers
    from workers;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EmployeesAverageSalary` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `EmployeesAverageSalary`()
BEGIN
	select avg(Salary) as EmployeeAverageSalary
    from employee;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetHistoricalDocuments` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetHistoricalDocuments`()
BEGIN
		select H.SerialNumber,e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, H.Date, d.Floor, d.Budget, d.Section
        from HistoricalDocuments as H, Exhibits as e, Department as d 
        WHERE H.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetPaintings` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPaintings`()
BEGIN
		select e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description,p.SerialNumber, p.PainterName, p.School, p.size,  p.YearCompleted, p.PossessionType, p.ReturnDate, d.Section, d.Floor, d.Budget
        from Paintings as p, Exhibits as e, Department as d 
        WHERE P.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetSculptures` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetSculptures`()
BEGIN
		select s.SerialNumber,e.ExhibitName,e.YearAcquired,e.EstimatedValue,e.Description, s.SculptorName,s.Material,
        s.Culture,s.Weight,s.YearCompleted, d.Budget
        from Sculptures as s, Exhibits as e, Department as d 
        WHERE s.SerialNumber = e.SerialNumber and e.Departmentid = D.DepartmentId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateSalesUnitCostandSellingPrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateSalesUnitCostandSellingPrice`(IN taxratio int(3))
BEGIN
	Update sales
    set UnitCost = UnitCost + (UnitCost*taxratio/100),
    SellingPrice = SellingPrice + (SellingPrice*taxratio/100);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-26  6:45:07

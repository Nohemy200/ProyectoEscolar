CREATE DATABASE  IF NOT EXISTS `sistemasds2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `sistemasds2`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: sistemasds2
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `alumnos`
--

DROP TABLE IF EXISTS `alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alumnos` (
  `idalumno` int NOT NULL AUTO_INCREMENT,
  `nie` varchar(75) NOT NULL,
  `nombres` varchar(100) NOT NULL,
  `apellidos` varchar(100) NOT NULL,
  `fechanacimiento` date NOT NULL,
  `telefono` varchar(9) NOT NULL,
  `idgenero` int NOT NULL,
  `idestado` int NOT NULL,
  `idapoderado` int NOT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idalumno`),
  KEY `fk_genero_idx` (`idgenero`),
  KEY `fk_estado1_idx` (`idestado`),
  KEY `fk_apoderado_idx` (`idapoderado`),
  CONSTRAINT `fk_estado1` FOREIGN KEY (`idestado`) REFERENCES `estado` (`idestado`),
  CONSTRAINT `fk_genero` FOREIGN KEY (`idgenero`) REFERENCES `genero` (`idgenero`),
  CONSTRAINT `fk_idapoderado` FOREIGN KEY (`idapoderado`) REFERENCES `apoderado` (`idapoderado`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alumnos`
--

LOCK TABLES `alumnos` WRITE;
/*!40000 ALTER TABLE `alumnos` DISABLE KEYS */;
INSERT INTO `alumnos` VALUES (1,'PG000000-1','LUIZ ENRIQUE','PEREZ GIRON','2018-01-01','12345670',1,1,1,'SONSONATE'),(2,'DF000000-1','GERARDO ALEXIS','DIMAS FUENTES','2017-01-02','12345671',1,1,2,'ACAJUTLA'),(3,'SM000000-1','LUIS MAURICIO','SANTOS MONGE','2016-05-05','12345673',1,1,3,'SONSONATE'),(4,'ME000000-1','WILBER ALEXIS','MENDOZA ESQUIVEL','2015-02-25','12345674',1,1,4,'ACAJUTLA'),(5,'EN000000-1','LUCIA ELIZABETH','ALEMAN NUÑEZ','2014-02-27','12345675',1,2,5,'IZALCO'),(6,'SL000000-1','MARCOS ERNESTO','SANTOS LUE','2013-02-24','12345676',1,2,6,'SONSONATE'),(7,'RC000000-1','CAROLINA MARIA','RIVERA CABRERA','2012-05-25','12345677',1,2,7,'ACAJUTLA'),(8,'MC000000-1','SANDRA MARIBEL','MARTINEZ CRUZ','2011-09-28','12345678',1,2,8,'SONSONATE'),(9,'TM000000-1','DANIEL ALONSO','TRIGUEROS MURCIA','2013-05-12','12345679',1,2,9,'SONSONATE'),(11,'RG000000-1','MADELINE ESTEFANI','RAMOS GARCIA','2023-05-20','12345672',1,2,1,'SONSONATE'),(12,'GF000000-1','MARIA DEL CARMEN','GARCIA FLORES','2023-05-28','80809090',2,2,12,'SONSONATE'),(13,'RD000000-1','ALEJANDRA DANIELA','RUIZ DIAS','2023-06-10','12311115',1,2,14,'SONSONATE'),(14,'LL000000-1','PEDRO ARMANDO','LUE LAINEZ','2023-06-12','12345678',1,2,15,'SONSONATE');
/*!40000 ALTER TABLE `alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `apoderado`
--

DROP TABLE IF EXISTS `apoderado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `apoderado` (
  `idapoderado` int NOT NULL AUTO_INCREMENT,
  `dui` varchar(10) NOT NULL,
  `tiporelacion` varchar(100) NOT NULL,
  `nombresapoderado` varchar(75) NOT NULL,
  `apellidos` varchar(75) NOT NULL,
  `telefono` varchar(50) NOT NULL,
  `fechanacimiento` date NOT NULL,
  `idgenero` int NOT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`idapoderado`),
  KEY `fk_genero_idx` (`idgenero`),
  CONSTRAINT `fj_genero` FOREIGN KEY (`idgenero`) REFERENCES `genero` (`idgenero`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `apoderado`
--

LOCK TABLES `apoderado` WRITE;
/*!40000 ALTER TABLE `apoderado` DISABLE KEYS */;
INSERT INTO `apoderado` VALUES (1,'12345678-9','PADRE','JUAN ALONSO','PEREZ MARTINEZ','79560252','1995-05-08',1,''),(2,'','PADRE','ALEXIS JOSE','DIMAZ ARGUJO','78596235','1994-06-06',1,''),(3,'','PADRE','JUAN JOSE','SANTOS DIAZ','75245869','1992-07-08',1,''),(4,'','TIO','EDGARDO ALEJANDRO','MENDOZA PEREZ','75486599','1995-08-02',1,''),(5,'','MADRE','JENESIS MARGARITA','ALEMAN CORTEZ','74586956','1990-08-15',2,''),(6,'8324728','MADRE','ROSARIO ESMERALDA','SANTOS JIMENEZ','78546985','1990-09-09',2,'ejhsaaskg'),(7,'','MADRE','CAROLINA ELIZA','RIVERA LOPEZ','75486854','1995-10-12',2,''),(8,'','PADRE','ROGELIO ABEL','MARTINEZ ALARGON','75485698','1980-10-11',1,''),(9,'','PADRE','EDWIN GEOVANY','TRIGUEROS ARISTIDES','78458695','1981-10-10',1,''),(11,'','TIO','LUIS FERNANDO','AREVALO RUIZ','12345679','2023-05-18',1,''),(12,'','PADRE','MANUEL ALFREDO','FLORES DIAZ','80709060','2023-05-28',1,''),(13,'12345678-2','PADRE','RIGOBERTO ISMAEL','SANTOS SANTOS','12312345','2023-05-31',1,''),(14,'99888','PADRE','ALEXANDER','RUIZ','1234','2023-06-10',1,'jgdckk'),(15,'12345678-9','PADRE','PEDRO ARMANDO ','LUE LAINEZ','61234569','2023-06-12',1,'sonsonate'),(17,'123456','MAMA','ANA','SANCHEZ','77571572','2023-06-12',2,'SONSONATE');
/*!40000 ALTER TABLE `apoderado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aulas`
--

DROP TABLE IF EXISTS `aulas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aulas` (
  `idaula` int NOT NULL AUTO_INCREMENT,
  `numeroaula` varchar(75) NOT NULL,
  PRIMARY KEY (`idaula`),
  UNIQUE KEY `idaula_UNIQUE` (`idaula`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aulas`
--

LOCK TABLES `aulas` WRITE;
/*!40000 ALTER TABLE `aulas` DISABLE KEYS */;
INSERT INTO `aulas` VALUES (1,'A1'),(6,'A2'),(7,'A3'),(8,'A4'),(9,'A5'),(10,'A6'),(11,'A7'),(13,'A8');
/*!40000 ALTER TABLE `aulas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciclos`
--

DROP TABLE IF EXISTS `ciclos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ciclos` (
  `idciclo` int NOT NULL AUTO_INCREMENT,
  `ciclo` varchar(5) NOT NULL,
  `idgrado` int NOT NULL,
  PRIMARY KEY (`idciclo`),
  KEY `fk_idx` (`idgrado`),
  CONSTRAINT `fk` FOREIGN KEY (`idgrado`) REFERENCES `grados` (`idgrado`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciclos`
--

LOCK TABLES `ciclos` WRITE;
/*!40000 ALTER TABLE `ciclos` DISABLE KEYS */;
INSERT INTO `ciclos` VALUES (1,'I',10),(2,'I',2),(3,'I',3),(4,'II',4),(5,'II',5),(6,'II',6),(7,'III',7),(8,'III',8),(9,'III',9),(10,'EDI',11);
/*!40000 ALTER TABLE `ciclos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clasificasiones`
--

DROP TABLE IF EXISTS `clasificasiones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clasificasiones` (
  `idclasificasion` int NOT NULL AUTO_INCREMENT,
  `clasificasion` varchar(45) NOT NULL,
  PRIMARY KEY (`idclasificasion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificasiones`
--

LOCK TABLES `clasificasiones` WRITE;
/*!40000 ALTER TABLE `clasificasiones` DISABLE KEYS */;
INSERT INTO `clasificasiones` VALUES (1,'SISTEMA'),(2,'ALUMNOS'),(3,'DOCENTES');
/*!40000 ALTER TABLE `clasificasiones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `docentes`
--

DROP TABLE IF EXISTS `docentes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `docentes` (
  `iddocente` int NOT NULL AUTO_INCREMENT,
  `nombresdocente` varchar(75) NOT NULL,
  `apellidosdocente` varchar(75) NOT NULL,
  `dui` varchar(15) NOT NULL,
  `telefono` int NOT NULL,
  `fechanacimiento` date NOT NULL,
  `idgenero` int NOT NULL,
  `idestado` int NOT NULL,
  `idespecialidad` int NOT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`iddocente`),
  UNIQUE KEY `iddocentes_UNIQUE` (`iddocente`),
  KEY `fk_genero_idx` (`idgenero`),
  KEY `fk_estado_idx` (`idestado`),
  KEY `fk_especialidad_idx` (`idespecialidad`),
  CONSTRAINT `fk_especialidad` FOREIGN KEY (`idespecialidad`) REFERENCES `especialidad` (`idespecialidad`),
  CONSTRAINT `fk_estado` FOREIGN KEY (`idestado`) REFERENCES `estado` (`idestado`),
  CONSTRAINT `fk_genero1` FOREIGN KEY (`idgenero`) REFERENCES `genero` (`idgenero`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `docentes`
--

LOCK TABLES `docentes` WRITE;
/*!40000 ALTER TABLE `docentes` DISABLE KEYS */;
INSERT INTO `docentes` VALUES (3,'MARCOS LEONEL','PEREZ MENDEZ','123456789-0',79582050,'1990-06-12',1,1,1,'san jenaro'),(14,'GERARDO ENRIQUE','EGUIZABAL SANTOS','123456789-1',79560425,'1992-02-05',1,1,1,'sonsonate'),(15,'DIANA ELIZABETH','CAMPOS LOPEZ','123456789-2',78965482,'1995-03-10',2,1,1,'sonsonate'),(16,'DANIELA ALEJANDRA','FUENTES CRUZ','123456789-3',75486958,'1990-03-08',2,1,8,'hhgvhvjh'),(17,'JOSE ALONSO','ALEMAN MENDOZA','123456789-4',79584586,'1988-03-07',1,1,1,'los rios'),(18,'MANUEL ALFREDO','JAVIER HERNANDEZ','123456789-5',76586945,'1985-08-08',1,1,1,'santa ana'),(19,'JAIME DAVID','HERNANDEZ LUE','123456789-6',60601010,'2023-05-21',1,1,1,'sonsonate'),(20,'JAVIER EFRAIN ','RAMOS HERNANDEZ','123456789-7',80809090,'2023-05-21',1,1,1,'juayua'),(21,'MANUEL EFRAIN','PEREZ PEREZ','123456789-8',20203030,'2023-05-21',1,1,3,'los naranjos'),(22,'HICELA DEL CARMEN','ARCE ESPINOZA','123456789-9',10106060,'2023-05-21',2,1,2,'sonsonate'),(24,'ANA','PEREZ','323827328-9',72636327,'2023-06-10',2,1,2,'sonsonate'),(25,'RUTH NOEMI','RAMOS HERNANDEZ','123412347-0',12347898,'2023-06-11',2,1,1,'sonsonate');
/*!40000 ALTER TABLE `docentes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidad`
--

DROP TABLE IF EXISTS `especialidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `especialidad` (
  `idespecialidad` int NOT NULL AUTO_INCREMENT,
  `especialidad` varchar(100) NOT NULL,
  PRIMARY KEY (`idespecialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidad`
--

LOCK TABLES `especialidad` WRITE;
/*!40000 ALTER TABLE `especialidad` DISABLE KEYS */;
INSERT INTO `especialidad` VALUES (1,'INGLES'),(2,'LICENCIATURA ENMATEMATICA'),(3,'LENGUAJE Y LITERATURA'),(8,'ESTUDIOS SOCIALES'),(9,'EDUCACION FISICA'),(10,'LICENCIATURA EN CIENCIA');
/*!40000 ALTER TABLE `especialidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado`
--

DROP TABLE IF EXISTS `estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado` (
  `idestado` int NOT NULL AUTO_INCREMENT,
  `estado` varchar(50) NOT NULL,
  PRIMARY KEY (`idestado`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado`
--

LOCK TABLES `estado` WRITE;
/*!40000 ALTER TABLE `estado` DISABLE KEYS */;
INSERT INTO `estado` VALUES (1,'ACTIVO'),(2,'INACTIVO');
/*!40000 ALTER TABLE `estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genero`
--

DROP TABLE IF EXISTS `genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genero` (
  `idgenero` int NOT NULL AUTO_INCREMENT,
  `genero` varchar(50) NOT NULL,
  PRIMARY KEY (`idgenero`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genero`
--

LOCK TABLES `genero` WRITE;
/*!40000 ALTER TABLE `genero` DISABLE KEYS */;
INSERT INTO `genero` VALUES (1,'MASCULINO'),(2,'FEMENINO');
/*!40000 ALTER TABLE `genero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grados`
--

DROP TABLE IF EXISTS `grados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grados` (
  `idgrado` int NOT NULL AUTO_INCREMENT,
  `grado` varchar(75) NOT NULL,
  `idaula` int NOT NULL,
  `iddocente` int NOT NULL,
  PRIMARY KEY (`idgrado`),
  KEY `fk_aula_idx` (`idaula`),
  KEY `fk_docente_idx` (`iddocente`),
  CONSTRAINT `fk_aula` FOREIGN KEY (`idaula`) REFERENCES `aulas` (`idaula`),
  CONSTRAINT `fk_docente` FOREIGN KEY (`iddocente`) REFERENCES `docentes` (`iddocente`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grados`
--

LOCK TABLES `grados` WRITE;
/*!40000 ALTER TABLE `grados` DISABLE KEYS */;
INSERT INTO `grados` VALUES (2,'2° GRADO',6,14),(3,'3° GRADO',7,15),(4,'4° GRADO',8,16),(5,'5° GRADO',9,17),(6,'6° GRADO',10,18),(7,'7° GRADO',1,3),(8,'8° GRADO',6,14),(9,'9° GRADO',7,15),(10,'1° GRADO',6,17),(11,'PALVULARIA',10,22),(14,'2°GRADO',13,3);
/*!40000 ALTER TABLE `grados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materias`
--

DROP TABLE IF EXISTS `materias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materias` (
  `idmateria` int NOT NULL AUTO_INCREMENT,
  `materia` varchar(75) NOT NULL,
  PRIMARY KEY (`idmateria`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materias`
--

LOCK TABLES `materias` WRITE;
/*!40000 ALTER TABLE `materias` DISABLE KEYS */;
INSERT INTO `materias` VALUES (3,'MATEMATICA'),(4,'INGLES'),(6,'SOCIALES'),(7,'LENGUAJE'),(8,'EDUCACION FISICA'),(9,'CIENCIAS'),(10,'ARTISTICA'),(11,'MUCI'),(12,'AREAS DE DESARROLLO PERSONAL'),(13,'ENTORNO'),(14,'MOTORA'),(15,'COMUNICACION Y EXPRESION'),(16,'ANALISIS');
/*!40000 ALTER TABLE `materias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materias_alumnos`
--

DROP TABLE IF EXISTS `materias_alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materias_alumnos` (
  `idmateriasalumnos` int NOT NULL AUTO_INCREMENT,
  `idmateria` int NOT NULL,
  `idalumno` int NOT NULL,
  PRIMARY KEY (`idmateriasalumnos`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materias_alumnos`
--

LOCK TABLES `materias_alumnos` WRITE;
/*!40000 ALTER TABLE `materias_alumnos` DISABLE KEYS */;
/*!40000 ALTER TABLE `materias_alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materias_grados`
--

DROP TABLE IF EXISTS `materias_grados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materias_grados` (
  `idmateriasgrados` int NOT NULL AUTO_INCREMENT,
  `idmateria` int NOT NULL,
  `idgrado` int NOT NULL,
  PRIMARY KEY (`idmateriasgrados`),
  KEY `FKMaterias_idx` (`idmateria`),
  KEY `FKGrados_idx` (`idgrado`),
  CONSTRAINT `FKGrados` FOREIGN KEY (`idgrado`) REFERENCES `grados` (`idgrado`),
  CONSTRAINT `FKMaterias` FOREIGN KEY (`idmateria`) REFERENCES `materias` (`idmateria`)
) ENGINE=InnoDB AUTO_INCREMENT=69 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materias_grados`
--

LOCK TABLES `materias_grados` WRITE;
/*!40000 ALTER TABLE `materias_grados` DISABLE KEYS */;
INSERT INTO `materias_grados` VALUES (5,8,7),(6,9,7),(7,3,8),(8,4,8),(9,6,8),(10,7,8),(11,8,8),(12,9,8),(13,3,9),(14,4,9),(15,6,9),(16,7,9),(17,8,9),(18,9,9),(27,3,3),(28,6,3),(30,8,3),(31,9,3),(32,10,3),(33,11,3),(34,3,10),(35,6,10),(36,7,10),(37,8,10),(38,9,10),(39,10,10),(40,11,10),(41,3,4),(42,6,4),(43,7,4),(44,8,4),(45,9,4),(46,10,4),(47,11,4),(48,3,5),(49,6,5),(50,7,5),(51,8,5),(52,9,5),(53,10,5),(54,11,5),(55,3,6),(56,6,6),(57,7,6),(58,8,6),(59,9,6),(60,10,6),(61,11,6),(62,12,11),(63,13,11),(64,14,11),(65,15,11),(67,3,14),(68,6,2);
/*!40000 ALTER TABLE `materias_grados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matriculas`
--

DROP TABLE IF EXISTS `matriculas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `matriculas` (
  `idmatricula` int NOT NULL AUTO_INCREMENT,
  `fechamatricula` datetime NOT NULL,
  `idgrado` int NOT NULL,
  `idalumno` int NOT NULL,
  `idseccion` int NOT NULL,
  `anio` varchar(5) NOT NULL,
  PRIMARY KEY (`idmatricula`),
  KEY `fk_grados_idx` (`idgrado`),
  KEY `fkalumnos_idx` (`idalumno`),
  KEY `fk_secciones_matriculas_idx` (`idseccion`),
  KEY `fk_matri_seccion_idx` (`idseccion`),
  CONSTRAINT `fk_grados` FOREIGN KEY (`idgrado`) REFERENCES `grados` (`idgrado`),
  CONSTRAINT `fk_matri_seccion` FOREIGN KEY (`idseccion`) REFERENCES `secciones` (`idseccion`),
  CONSTRAINT `fkalumnos` FOREIGN KEY (`idalumno`) REFERENCES `alumnos` (`idalumno`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matriculas`
--

LOCK TABLES `matriculas` WRITE;
/*!40000 ALTER TABLE `matriculas` DISABLE KEYS */;
INSERT INTO `matriculas` VALUES (13,'2023-09-30 00:00:00',3,1,5,'2023'),(14,'2023-09-30 00:00:00',3,2,5,'2023'),(15,'2023-09-30 00:00:00',10,3,1,'2023'),(16,'2023-09-30 00:00:00',10,4,2,'2023');
/*!40000 ALTER TABLE `matriculas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas`
--

DROP TABLE IF EXISTS `notas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notas` (
  `idnota` int NOT NULL AUTO_INCREMENT,
  `idmateria` int NOT NULL,
  `nota` double DEFAULT NULL,
  `idmatricula` int NOT NULL,
  `idperiodo` int NOT NULL,
  PRIMARY KEY (`idnota`),
  KEY `fk_materias_idx` (`idmateria`),
  KEY `fk_notas_matri_idx` (`idmatricula`),
  KEY `fk_matri_notas_idx` (`idmatricula`),
  KEY `fk_notas_idx` (`idmatricula`),
  KEY `fk_mat_not_idx` (`idmatricula`),
  KEY `fk_matric_notas_idx` (`idmatricula`),
  KEY `fk_nota_periodo_idx` (`idperiodo`),
  CONSTRAINT `fk_materias` FOREIGN KEY (`idmateria`) REFERENCES `materias` (`idmateria`),
  CONSTRAINT `fk_matric_notas` FOREIGN KEY (`idmatricula`) REFERENCES `matriculas` (`idmatricula`),
  CONSTRAINT `fk_nota_periodo` FOREIGN KEY (`idperiodo`) REFERENCES `periodos` (`idperiodo`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notas`
--

LOCK TABLES `notas` WRITE;
/*!40000 ALTER TABLE `notas` DISABLE KEYS */;
INSERT INTO `notas` VALUES (1,3,0,13,1),(2,3,0,13,2),(3,3,0,13,3),(4,6,0,13,1),(5,6,0,13,2),(6,6,0,13,3),(7,8,0,13,1),(8,8,0,13,2),(9,8,0,13,3),(10,9,0,13,1),(11,9,0,13,2),(12,9,0,13,3),(13,10,0,13,1),(14,10,0,13,2),(15,10,0,13,3),(16,11,0,13,1),(17,11,0,13,2),(18,11,0,13,3),(19,3,0,14,1),(20,3,0,14,2),(21,3,0,14,3),(22,6,0,14,1),(23,6,0,14,2),(24,6,0,14,3),(25,8,0,14,1),(26,8,0,14,2),(27,8,0,14,3),(28,9,0,14,1),(29,9,0,14,2),(30,9,0,14,3),(31,10,0,14,1),(32,10,0,14,2),(33,10,0,14,3),(34,11,0,14,1),(35,11,0,14,2),(36,11,0,14,3),(37,3,0,15,1),(38,3,0,15,2),(39,3,0,15,3),(40,6,0,15,1),(41,6,0,15,2),(42,6,0,15,3),(43,7,0,15,1),(44,7,0,15,2),(45,7,0,15,3),(46,8,0,15,1),(47,8,0,15,2),(48,8,0,15,3),(49,9,0,15,1),(50,9,0,15,2),(51,9,0,15,3),(52,10,0,15,1),(53,10,0,15,2),(54,10,0,15,3),(55,11,0,15,1),(56,11,0,15,2),(57,11,0,15,3),(58,3,0,16,1),(59,3,0,16,2),(60,3,0,16,3),(61,6,0,16,1),(62,6,0,16,2),(63,6,0,16,3),(64,7,0,16,1),(65,7,0,16,2),(66,7,0,16,3),(67,8,0,16,1),(68,8,0,16,2),(69,8,0,16,3),(70,9,0,16,1),(71,9,0,16,2),(72,9,0,16,3),(73,10,0,16,1),(74,10,0,16,2),(75,10,0,16,3),(76,11,0,16,1),(77,11,0,16,2),(78,11,0,16,3);
/*!40000 ALTER TABLE `notas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opciones`
--

DROP TABLE IF EXISTS `opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opciones` (
  `idopcion` int NOT NULL AUTO_INCREMENT,
  `opcion` varchar(45) NOT NULL,
  `idclasificasion` int NOT NULL,
  PRIMARY KEY (`idopcion`),
  KEY `fkclasificacion_idx` (`idclasificasion`),
  CONSTRAINT `fkclasificacion` FOREIGN KEY (`idclasificasion`) REFERENCES `clasificasiones` (`idclasificasion`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
INSERT INTO `opciones` VALUES (1,'INICIAR SESION',1),(2,'VER USUARIOS',1),(3,'AGREGAR USUARIOS',1),(4,'EDITAR USUARIOS',1),(5,'ELIMINAR USUARIOS',1),(6,'VER REPORTES',1),(7,'VER ALUMNOS',2),(8,'VER DOCENTES',3),(9,'VER MATRICULAS',3),(10,'VER NOTAS',3);
/*!40000 ALTER TABLE `opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `periodos`
--

DROP TABLE IF EXISTS `periodos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `periodos` (
  `idperiodo` int NOT NULL AUTO_INCREMENT,
  `periodo` varchar(45) NOT NULL,
  PRIMARY KEY (`idperiodo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `periodos`
--

LOCK TABLES `periodos` WRITE;
/*!40000 ALTER TABLE `periodos` DISABLE KEYS */;
INSERT INTO `periodos` VALUES (1,'Primer periodo'),(2,'Segundo periodo'),(3,'Tercer periodo');
/*!40000 ALTER TABLE `periodos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `idpermiso` int unsigned NOT NULL AUTO_INCREMENT,
  `idrol` int NOT NULL,
  `idopcion` int NOT NULL,
  PRIMARY KEY (`idpermiso`),
  KEY `fkRol_idx` (`idrol`),
  KEY `fkopciones_idx` (`idopcion`),
  CONSTRAINT `fkopciones` FOREIGN KEY (`idopcion`) REFERENCES `opciones` (`idopcion`),
  CONSTRAINT `fkrol` FOREIGN KEY (`idrol`) REFERENCES `roles` (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (12,1,2),(13,1,3),(14,1,4),(15,1,5),(16,1,6),(17,1,7),(18,1,8),(19,1,9),(20,1,10),(21,1,1),(23,2,10),(24,2,9),(25,2,8),(26,2,7),(27,2,6),(28,6,6),(29,6,5),(30,6,4),(31,6,3),(32,6,1),(33,6,2),(34,6,7),(35,6,8),(36,6,9),(37,6,10),(38,2,5),(39,2,4),(40,2,3),(41,2,2),(42,2,1);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idRol` int NOT NULL AUTO_INCREMENT,
  `rol` varchar(45) NOT NULL,
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Docente'),(6,'Director'),(8,'contador');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `secciones`
--

DROP TABLE IF EXISTS `secciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `secciones` (
  `idseccion` int NOT NULL AUTO_INCREMENT,
  `seccion` varchar(45) NOT NULL,
  `idgrado` int NOT NULL,
  PRIMARY KEY (`idseccion`),
  KEY `fk_seccion_grado_idx` (`idgrado`),
  CONSTRAINT `fk_seccion_grado` FOREIGN KEY (`idgrado`) REFERENCES `grados` (`idgrado`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `secciones`
--

LOCK TABLES `secciones` WRITE;
/*!40000 ALTER TABLE `secciones` DISABLE KEYS */;
INSERT INTO `secciones` VALUES (1,'A',10),(2,'B',10),(3,'A',2),(4,'B',2),(5,'A',3),(6,'A',4),(7,'B',4),(8,'A',5),(9,'A',6),(10,'A',7),(11,'A',8),(12,'A',9),(13,'A',11),(14,'B',11);
/*!40000 ALTER TABLE `secciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(45) NOT NULL,
  `password` varchar(80) NOT NULL,
  `idRol` int NOT NULL,
  `iddocente` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_usuario_tipo_idx` (`idRol`),
  KEY `fk_usuarios_idx` (`iddocente`),
  CONSTRAINT `fk_usuarios` FOREIGN KEY (`iddocente`) REFERENCES `docentes` (`iddocente`),
  CONSTRAINT `fk_usuariosRoles` FOREIGN KEY (`idRol`) REFERENCES `roles` (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (5,'fernando','adcd7048512e64b48da55b027577886ee5a36350',1,15),(11,'javier','adcd7048512e64b48da55b027577886ee5a36350',2,20),(12,'noemi','adcd7048512e64b48da55b027577886ee5a36350',2,25),(14,'jaime','63982e54a7aeb0d89910475ba6dbd3ca6dd4e5a1',2,19),(15,'ana','63982e54a7aeb0d89910475ba6dbd3ca6dd4e5a1',2,24);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-13 18:13:32

/*
SQLyog Ultimate v12.2.6 (64 bit)
MySQL - 10.4.10-MariaDB-log : Database - raskin-wae_sano
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`raskin-wae_sano` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `raskin-wae_sano`;

/*Table structure for table `hasil_spk` */

DROP TABLE IF EXISTS `hasil_spk`;

CREATE TABLE `hasil_spk` (
  `No_KTP` varchar(20) NOT NULL,
  `Jumlah` double DEFAULT NULL,
  `Ranking` int(5) DEFAULT NULL,
  PRIMARY KEY (`No_KTP`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `hasil_spk` */

/*Table structure for table `kriteria` */

DROP TABLE IF EXISTS `kriteria`;

CREATE TABLE `kriteria` (
  `No_Kriteria` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Nama` varchar(50) NOT NULL,
  `Bobot` double NOT NULL,
  PRIMARY KEY (`No_Kriteria`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `kriteria` */

insert  into `kriteria`(`No_Kriteria`,`Nama`,`Bobot`) values 
(1,'Surat Keterangan Miskin',10),
(2,'Penghasilan Setiap Bulan',7.5),
(3,'Tanggungan Anak',5),
(4,'Kondisi Rumah',2.5);

/*Table structure for table `penduduk` */

DROP TABLE IF EXISTS `penduduk`;

CREATE TABLE `penduduk` (
  `ID` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `No_KK` varchar(20) NOT NULL,
  `No_KTP` varchar(20) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Desa` varchar(50) NOT NULL,
  `Kecamatan` varchar(50) NOT NULL,
  `RT_RW` varchar(10) NOT NULL,
  `K_1` varchar(50) NOT NULL,
  `K_2` varchar(50) NOT NULL,
  `K_3` varchar(50) NOT NULL,
  `K_4` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `No_KK` (`No_KK`),
  UNIQUE KEY `No_KTP` (`No_KTP`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `penduduk` */

insert  into `penduduk`(`ID`,`No_KK`,`No_KTP`,`Nama`,`Desa`,`Kecamatan`,`RT_RW`,`K_1`,`K_2`,`K_3`,`K_4`) values 
(1,'531204206973006','531204200390006','Antonius','Wae Sano','Sanongoang','002/001','Tidak Punya','< 1jt','4 anak','Cukup Sederhana'),
(2,'537564206970005','531204206950006','Blasius Jeramun','Wae Sano','Sanongoang','002/001','Punya','> 5jt','1 anak','Sangat Mewah'),
(3,'531235025560005','532564252450006','Jeremia','Wae Sano','Sanongoang','005/003','Tidak Punya','3jt - 5jt','2 anak','Mewah'),
(4,'532665632563006','531204207670006','Benediktus','Wae Sano','Sanongoang','005/006','Punya','1jt - 3jt','3 anak','Sederhana');

/*Table structure for table `sub_kriteria` */

DROP TABLE IF EXISTS `sub_kriteria`;

CREATE TABLE `sub_kriteria` (
  `No` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Kriteria` varchar(50) NOT NULL,
  `Sub_Kriteria` varchar(20) NOT NULL,
  `Bobot` double NOT NULL,
  PRIMARY KEY (`No`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `sub_kriteria` */

insert  into `sub_kriteria`(`No`,`Kriteria`,`Sub_Kriteria`,`Bobot`) values 
(1,'Surat Keterangan Miskin','Punya',10),
(2,'Surat Keterangan Miskin','Tidak Punya',2.5),
(3,'Penghasilan Setiap Bulan','< 1jt',10),
(4,'Penghasilan Setiap Bulan','1jt - 3jt',7.5),
(5,'Penghasilan Setiap Bulan','3jt - 5jt',5),
(6,'Penghasilan Setiap Bulan','> 5jt',2.5),
(7,'Tanggungan Anak','1 anak',2),
(8,'Tanggungan Anak','2 anak',4),
(9,'Tanggungan Anak','3 anak',6),
(10,'Tanggungan Anak','4 anak',8),
(11,'Tanggungan Anak','> 4 anak',10),
(12,'Kondisi Rumah','Cukup Sederhana',10),
(13,'Kondisi Rumah','Sederhana',7.5),
(14,'Kondisi Rumah','Mewah',5),
(15,'Kondisi Rumah','Sangat Mewah',2.5);

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `ID` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Username` varchar(25) DEFAULT NULL,
  `Password` varchar(25) DEFAULT NULL,
  `Hak_Akses` enum('Admin','Kepala Desa') DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `USER_UNIQUE` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `user` */

insert  into `user`(`ID`,`Username`,`Password`,`Hak_Akses`) values 
(1,'admin','admin','Admin'),
(2,'kepdes','kepdes','Kepala Desa');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

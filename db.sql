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

insert  into `hasil_spk`(`No_KTP`,`Jumlah`,`Ranking`) values 
('5312040912080008',16.38,5),
('5312042007390006',10.88,9),
('5312042077670006',17.38,3),
('5312042706950006',19.12,2),
('5312044204720002',19.38,1),
('5312044604120001',15.75,6),
('5312044808970005',11.25,8),
('5312044812990003',7.88,11),
('5312046108130003',11.88,7),
('5312048007030002',16.75,4),
('5325642752450006',9.5,10);

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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `penduduk` */

insert  into `penduduk`(`ID`,`No_KK`,`No_KTP`,`Nama`,`Desa`,`Kecamatan`,`RT_RW`,`K_1`,`K_2`,`K_3`,`K_4`) values 
(1,'5312042706973006','5312042007390006','Antonius','Wae Sano','Sanongoang','002/001','Tidak Punya','< 1jt','4 anak','Cukup Sederhana (bambu)'),
(2,'5375642706970005','5312042706950006','Blasius Jeramun','Wae Sano','Sanongoang','002/001','Punya','> 5jt','1 anak','Sangat Mewah (tembok, kaca dan keramik)'),
(3,'5312350725560005','5325642752450006','Jeremia','Wae Sano','Sanongoang','005/003','Tidak Punya','3jt - 5jt','2 anak','Mewah (tembok)'),
(4,'5326656732563006','5312042077670006','Benediktus','Wae Sano','Sanongoang','005/006','Punya','1jt - 3jt','3 anak','Sederhana (papan)'),
(5,'5312040912080008','5312040912080008','Muhamad Ansari','Wae Sano','Sanongoang','002/001','Punya','1jt - 3jt','2 anak','Sederhana (papan)'),
(6,'5312040205060002','5312044204720002','Gregorius Dalus','Wae Sano','Sanongoang','002/001','Punya','< 1jt','> 4 anak','Cukup Sederhana (bambu)'),
(7,'5312042903600003','5312044808970005','Bonefasius Jehadan','Wae Sano','Sanongoang','002/001','Tidak Punya','1jt - 3jt','> 4 anak','Mewah (tembok)'),
(8,'5312043207050007','5312044812990003','Aventinus Benyamin','Wae Sano','Sanongoang','002/001','Tidak Punya','< 1jt','1 anak','Cukup Sederhana (bambu)'),
(9,'5312046508200004','5312048007030002','Yohanes Refandi','Wae Sano','Sanongoang','002/001','Punya','1jt - 3jt','3 anak','Mewah (tembok)'),
(10,'5312048092800005','5312044604120001','Brunoldus Candra','Wae Sano','Sanongoang','002/001','Punya','1jt - 3jt','2 anak','Mewah (tembok)'),
(11,'5312044205010008','5312046108130003','Marianus Jebaburt','Wae Sano','Sanongoang','002/001','Tidak Punya','< 1jt','> 4 anak','Cukup Sederhana (bambu)');

/*Table structure for table `sub_kriteria` */

DROP TABLE IF EXISTS `sub_kriteria`;

CREATE TABLE `sub_kriteria` (
  `No` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Kriteria` varchar(50) NOT NULL,
  `Sub_Kriteria` varchar(50) NOT NULL,
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
(12,'Kondisi Rumah','Cukup Sederhana (bambu)',10),
(13,'Kondisi Rumah','Sederhana (papan)',7.5),
(14,'Kondisi Rumah','Mewah (tembok)',5),
(15,'Kondisi Rumah','Sangat Mewah (tembok, kaca dan keramik)',2.5);

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

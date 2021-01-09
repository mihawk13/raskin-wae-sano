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
  `Atribut` enum('Keuntungan','Biaya') DEFAULT NULL,
  PRIMARY KEY (`No_Kriteria`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `kriteria` */

insert  into `kriteria`(`No_Kriteria`,`Nama`,`Bobot`,`Atribut`) values 
(1,'Surat Keterangan Miskin',10,'Keuntungan'),
(2,'Penghasilan Setiap Bulan',7.5,'Biaya'),
(3,'Tanggungan Anak',5,'Keuntungan'),
(4,'Kondisi Rumah',2.5,'Keuntungan');

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
  `gambar_KK` varchar(20) DEFAULT NULL,
  `gambar_KTP` varchar(20) DEFAULT NULL,
  `Status` enum('Aktif','NonAktif') DEFAULT 'Aktif',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `No_KK` (`No_KK`),
  UNIQUE KEY `No_KTP` (`No_KTP`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

/*Data for the table `penduduk` */

insert  into `penduduk`(`ID`,`No_KK`,`No_KTP`,`Nama`,`Desa`,`Kecamatan`,`RT_RW`,`gambar_KK`,`gambar_KTP`,`Status`) values 
(1,'5312042706973006','5312042007390006','Antonius','Wae Sano','Sanongoang','002/001','916004903652543.jpg','916004843263338.jpg','Aktif'),
(2,'5375642706970005','5312042706950006','Blasius Jeramun','Wae Sano','Sanongoang','002/001','916004774785315.jpg','916004750157114.jpg','Aktif'),
(3,'5312350725560005','5325642752450006','Jeremia','Wae Sano','Sanongoang','005/003','916004599120059.jpg','916004563286550.jpg','Aktif'),
(4,'5326656732563006','5312042077670006','Benediktus','Wae Sano','Sanongoang','005/006','916004414875227.jpg','916004390790135.jpg','Aktif'),
(5,'5312040912080008','5312040912080008','Muhamad Ansari','Wae Sano','Sanongoang','002/001','916004162548834.jpg','916004135913326.jpg','Aktif'),
(6,'5312040205060002','5312044204720002','Gregorius Dalus','Wae Sano','Sanongoang','002/001','916004009762827.jpg','916003978149213.jpg','Aktif'),
(7,'5312042903600003','5312044808970005','Bonefasius Jehadan','Wae Sano','Sanongoang','002/001','916003887600438.jpg','916003754796763.jpg','NonAktif'),
(8,'5312043207050007','5312044812990003','Aventinus Benyamin','Wae Sano','Sanongoang','002/001','916003581201469.jpg','916003557519909.jpg','Aktif'),
(9,'5312046508200004','5312048007030002','Yohanes Refandi','Wae Sano','Sanongoang','002/001','916003435844576.jpg','916003406798140.jpg','NonAktif'),
(10,'5312048092800005','5312044604120001','Brunoldus Candra','Wae Sano','Sanongoang','002/001','916003301912914.jpg','916003273839265.jpg','Aktif'),
(11,'5312044205010008','5312046108130003','Marianus Jebaburt','Wae Sano','Sanongoang','002/001','919360912199556.jpg','919360879969847.jpg','NonAktif');

/*Table structure for table `penduduk_kriteria` */

DROP TABLE IF EXISTS `penduduk_kriteria`;

CREATE TABLE `penduduk_kriteria` (
  `penduduk_id` int(5) DEFAULT NULL,
  `kriteria_id` int(5) DEFAULT NULL,
  `sub_kriteria_id` int(5) DEFAULT NULL,
  UNIQUE KEY `UNIK_Kriteia` (`penduduk_id`,`kriteria_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `penduduk_kriteria` */

insert  into `penduduk_kriteria`(`penduduk_id`,`kriteria_id`,`sub_kriteria_id`) values 
(1,1,2),
(1,2,3),
(1,3,9),
(1,4,12),
(2,1,1),
(2,2,3),
(2,3,8),
(2,4,12),
(3,1,1),
(3,2,3),
(3,3,8),
(3,4,13),
(4,1,1),
(4,2,4),
(4,3,10),
(4,4,12),
(5,1,1),
(5,2,3),
(5,3,11),
(5,4,12),
(6,1,1),
(6,2,4),
(6,3,8),
(6,4,12),
(7,1,2),
(7,2,6),
(7,3,7),
(7,4,15),
(8,1,1),
(8,2,5),
(8,3,7),
(8,4,13),
(9,1,2),
(9,2,3),
(9,3,7),
(9,4,13),
(10,1,1),
(10,2,4),
(10,3,8),
(10,4,13),
(11,1,2),
(11,2,3),
(11,3,8),
(11,4,14);

/*Table structure for table `sub_kriteria` */

DROP TABLE IF EXISTS `sub_kriteria`;

CREATE TABLE `sub_kriteria` (
  `No` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Kriteria_ID` int(5) NOT NULL,
  `Sub_Kriteria` varchar(50) NOT NULL,
  `Bobot` double NOT NULL,
  PRIMARY KEY (`No`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;

/*Data for the table `sub_kriteria` */

insert  into `sub_kriteria`(`No`,`Kriteria_ID`,`Sub_Kriteria`,`Bobot`) values 
(1,1,'Punya',10),
(2,1,'Tidak Punya',2.5),
(3,2,'< 1jt',10),
(4,2,'1jt - 3jt',7.5),
(5,2,'3jt - 5jt',5),
(6,2,'> 5jt',2.5),
(7,3,'1 anak',2),
(8,3,'2 anak',4),
(9,3,'3 anak',6),
(10,3,'4 anak',8),
(11,3,'> 4 anak',10),
(12,4,'Cukup Sederhana (bambu)',10),
(13,4,'Sederhana (papan)',7.5),
(14,4,'Mewah (tembok)',5),
(15,4,'Sangat Mewah (tembok, kaca dan keramik)',2.5);

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

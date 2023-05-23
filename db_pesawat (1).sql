-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2023 at 08:56 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pesawat`
--

-- --------------------------------------------------------

--
-- Table structure for table `pemesanantiket`
--

CREATE TABLE `pemesanantiket` (
  `kodetiket` int(3) NOT NULL,
  `kodetujuan` int(5) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `telepon` varchar(100) NOT NULL,
  `tanggal` int(100) NOT NULL,
  `bulan` varchar(100) NOT NULL,
  `tahun` varchar(100) NOT NULL,
  `jam` varchar(100) NOT NULL,
  `pesawat` varchar(100) NOT NULL,
  `tujuan` varchar(100) NOT NULL,
  `kelas` varchar(100) NOT NULL,
  `jumlah` int(100) NOT NULL,
  `harga` varchar(100) NOT NULL,
  `pembayaran` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pemesanantiket`
--

INSERT INTO `pemesanantiket` (`kodetiket`, `kodetujuan`, `nama`, `telepon`, `tanggal`, `bulan`, `tahun`, `jam`, `pesawat`, `tujuan`, `kelas`, `jumlah`, `harga`, `pembayaran`) VALUES
(9010, 2, 'Holan', '0838388383', 31, 'Juli', '2023', '10.00', 'Mojo Air', 'Makkasar - Jkt', 'Ekonomi', 2, '500000', 'Debit'),
(9011, 5, 'Nono', '3883838', 19, 'Juni', '2023', '19.00', 'Marto Asia', 'Papua - Solo', 'Bisnis', 4, '13860000', 'Debit'),
(9012, 2, 'ADIT', '032532582358', 31, 'Juli', '2023', '10.00', 'Mojo Air', 'Makkasar - Jkt', 'Ekonomi', 2, '1000000', 'Cash'),
(9013, 4, 'Mana', '085393949', 23, 'Mei', '2024', '11.00', 'Singapore Airlines', 'Samarinda - Singapore', 'Ekonomi', 5, '10000000', 'Cash'),
(9014, 2, 'Mana', '0829399495969', 31, 'Juli', '2023', '10.00', 'Mojo Air', 'Makkasar - Jkt', 'Ekonomi', 4, '1500000', 'Cash'),
(9016, 5, 'Noya', '08376467576', 19, 'Juni', '2023', '19.00', 'Marto Asia', 'Papua - Solo', 'Bisnis', 4, '9200000', 'Debit');

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

CREATE TABLE `tb_login` (
  `KodeUser` varchar(10) NOT NULL,
  `NamaUser` varchar(10) NOT NULL,
  `StatusUser` varchar(10) NOT NULL,
  `PasswordUser` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_login`
--

INSERT INTO `tb_login` (`KodeUser`, `NamaUser`, `StatusUser`, `PasswordUser`) VALUES
('1', 'Admin', 'Admin', 'Admin'),
('2', 'User', 'User', '123');

-- --------------------------------------------------------

--
-- Table structure for table `tb_tujuan`
--

CREATE TABLE `tb_tujuan` (
  `kode` int(3) NOT NULL,
  `tujuan` varchar(100) NOT NULL,
  `kelas` varchar(100) NOT NULL,
  `tanggal` int(100) NOT NULL,
  `bulan` varchar(50) NOT NULL,
  `tahun` int(20) NOT NULL,
  `jam` varchar(10) NOT NULL,
  `harga` int(100) NOT NULL,
  `pesawat` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_tujuan`
--

INSERT INTO `tb_tujuan` (`kode`, `tujuan`, `kelas`, `tanggal`, `bulan`, `tahun`, `jam`, `harga`, `pesawat`) VALUES
(1, 'Samarinda - Jkt', 'Bisnis', 15, 'Maret', 2023, '15.00', 2500000, 'Denim Air'),
(2, 'Makkasar - Jkt', 'Ekonomi', 31, 'Juli', 2023, '10.00', 500000, 'Mojo Air'),
(3, 'Balikpapan - Surabaya', 'Bisnis', 15, 'Februari', 2024, '19.00', 2500000, 'Elang Indonesia'),
(4, 'Samarinda - Singapore', 'Ekonomi', 23, 'Mei', 2023, '11.00', 2000000, 'Singapore Airlines'),
(5, 'Papua - Solo', 'Bisnis', 19, 'Juni', 2023, '19.00', 2300000, 'Marto Asia');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pemesanantiket`
--
ALTER TABLE `pemesanantiket`
  ADD PRIMARY KEY (`kodetiket`);

--
-- Indexes for table `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`KodeUser`);

--
-- Indexes for table `tb_tujuan`
--
ALTER TABLE `tb_tujuan`
  ADD PRIMARY KEY (`kode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pemesanantiket`
--
ALTER TABLE `pemesanantiket`
  MODIFY `kodetiket` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9017;

--
-- AUTO_INCREMENT for table `tb_tujuan`
--
ALTER TABLE `tb_tujuan`
  MODIFY `kode` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

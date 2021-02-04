-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 14, 2020 at 11:28 AM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cp3_db`
--
CREATE DATABASE IF NOT EXISTS `cp3_db` DEFAULT CHARACTER SET latin1 COLLATE latin1_general_ci;
USE `cp3_db`;

-- --------------------------------------------------------

--
-- Table structure for table `equipment_borrowed`
--

CREATE TABLE `equipment_borrowed` (
  `activity_id` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `equipment_id` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `date_released` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `date_returned` varchar(250) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `foo`
--

CREATE TABLE `foo` (
  `prefix` char(3) COLLATE latin1_general_ci NOT NULL,
  `num` tinyint(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `foo`
--

INSERT INTO `foo` (`prefix`, `num`) VALUES
('a', 1),
('a', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tblaccounts`
--

CREATE TABLE `tblaccounts` (
  `username` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `password` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `user_type` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `branch` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `department` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `status` varchar(250) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tblaccounts`
--

INSERT INTO `tblaccounts` (`username`, `password`, `user_type`, `branch`, `department`, `status`) VALUES
('narence', 'narence', 'user', 'Psg', 'Comsci', 'active'),
('nars', 'nars', 'admin', 'Pla', 'Ba', 'active'),
('nars2', 'nars2', 'technical', 'Pla', 'Comsci', 'active'),
('nars3', 'nars3', 'user', 'Abad', 'Psych', 'active'),
('nars4', 'nars44', 'admin', 'Leg', 'Ba', 'active'),
('nars5', 'nars55', 'admin', '', '', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `tblactivity`
--

CREATE TABLE `tblactivity` (
  `id` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `date` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `requestor` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `dept` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `activity_name` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `activity_date` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `activity_purpose` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `date_released` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `date_returned` varchar(100) COLLATE latin1_general_ci NOT NULL,
  `released_by` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `returned_by` varchar(250) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tblactivity`
--

INSERT INTO `tblactivity` (`id`, `date`, `requestor`, `dept`, `activity_name`, `activity_date`, `activity_purpose`, `date_released`, `date_returned`, `released_by`, `returned_by`) VALUES
('20200312164322', '2020-03-12', 'nars3', 'Psych', 'event1', '3/26/2020', 'event1', '3/12/2020 4:51:37 PM', '3/12/2020 4:51:35 PM', 'nars', 'nars');

-- --------------------------------------------------------

--
-- Table structure for table `tblequipments`
--

CREATE TABLE `tblequipments` (
  `asset_number` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `num` int(250) NOT NULL,
  `serial_number` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `branch` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `model` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `description` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `status` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `available` varchar(250) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tblequipments`
--

INSERT INTO `tblequipments` (`asset_number`, `num`, `serial_number`, `branch`, `model`, `description`, `status`, `available`) VALUES
('AU-LEG-2020-01-1', 1, 'xvdz-adgx-qwg', 'LEG', 'MONITOR', 'core i9', 'RETIRE', 'NO'),
('AU-MABINI-2020-01-2', 2, '3434', 'MABINI', 'LAPTOP', '3434', 'WORKING', 'YES'),
('AU-PSG-2020-01-4', 4, 'jkhhjkhj', 'PSG', 'PROJECTOR', 'edddef', 'WORKING', 'YES'),
('AU-PSG-2020-02-5', 5, 'a', 'PSG', 'LAPTOP', 'a', 'WORKING', 'YES');

-- --------------------------------------------------------

--
-- Table structure for table `tbllogs`
--

CREATE TABLE `tbllogs` (
  `date` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `action` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `info` varchar(250) COLLATE latin1_general_ci NOT NULL,
  `username` varchar(250) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tbllogs`
--

INSERT INTO `tbllogs` (`date`, `action`, `info`, `username`) VALUES
('3/12/2020 4:43:47 PM', 'Added an Activity with an id of : 20200312164322', 'Borrowing Management', 'nars3'),
('3/12/2020 4:44:25 PM', 'Added an Activity with an id of : 20200312164358', 'Borrowing Management', 'nars3'),
('3/12/2020 4:45:24 PM', 'updated an activity with an id of AU-MABINI-2020-01-2', 'Borrowing Management', 'username'),
('3/12/2020 4:45:40 PM', 'updated an activity with an id of AU-MABINI-2020-01-2', 'Borrowing Management', 'username'),
('3/12/2020 4:45:54 PM', 'deleted an activity with an id of 20200312164358', 'Borrowing Management', 'nars3'),
('3/12/2020 4:46:26 PM', 'updated an activity with an id of AU-PSG-2020-01-4', 'Borrowing Management', 'username'),
('3/12/2020 4:49:20 PM', 'Released an activity with an id of 20200312164322', 'Return Management', 'nars'),
('3/12/2020 4:50:17 PM', 'Released an activity with an id of 20200312164322', 'Return Management', 'nars'),
('3/12/2020 4:50:39 PM', 'Return an activity with an id of 20200312164322', 'Return Management', 'nars'),
('3/12/2020 4:51:39 PM', 'Released an activity with an id of 20200312164322', 'Return Management', 'nars');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `equipment_borrowed`
--
ALTER TABLE `equipment_borrowed`
  ADD PRIMARY KEY (`equipment_id`);

--
-- Indexes for table `foo`
--
ALTER TABLE `foo`
  ADD PRIMARY KEY (`prefix`,`num`);

--
-- Indexes for table `tblaccounts`
--
ALTER TABLE `tblaccounts`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `tblactivity`
--
ALTER TABLE `tblactivity`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblequipments`
--
ALTER TABLE `tblequipments`
  ADD PRIMARY KEY (`asset_number`),
  ADD UNIQUE KEY `num` (`num`);

--
-- Indexes for table `tbllogs`
--
ALTER TABLE `tbllogs`
  ADD PRIMARY KEY (`date`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `foo`
--
ALTER TABLE `foo`
  MODIFY `num` tinyint(4) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblequipments`
--
ALTER TABLE `tblequipments`
  MODIFY `num` int(250) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

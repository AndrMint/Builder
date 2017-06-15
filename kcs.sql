-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2017 at 08:20 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kcs`
--

-- --------------------------------------------------------

--
-- Table structure for table `studentadress`
--

CREATE TABLE `studentadress` (
  `ID` int(11) NOT NULL,
  `COUNTRY` varchar(50) DEFAULT NULL,
  `CITY` varchar(45) DEFAULT NULL,
  `STREET` varchar(45) DEFAULT NULL,
  `POST_CODE` varchar(50) DEFAULT NULL,
  `student_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentadress`
--

INSERT INTO `studentadress` (`ID`, `COUNTRY`, `CITY`, `STREET`, `POST_CODE`, `student_id`) VALUES
(1, 'Lietuva', 'Kaunas', 'Picos g.', '3444', 1),
(2, 'Lietuva', 'Vilnius', 'Amerikos g.', '3544', 2),
(3, 'Vokietija', 'Berlynas', 'Vytauto g.', '3455', 3),
(4, 'Lietuva', 'Klaipeda', 'Tautos g.', '3337', 4),
(5, 'Lietuva', 'Klaipeda', 'Vandens g.', '3337', 4),
(6, 'Lietuva', 'Kaunas', 'Picos g.', '3444', 5),
(7, 'Lietuva', 'Panevezys', 'Olandu g.', '3444', 5);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(50) NOT NULL,
  `SURNAME` varchar(50) NOT NULL,
  `PHONE` varchar(20) DEFAULT NULL,
  `EMAIL` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`ID`, `NAME`, `SURNAME`, `PHONE`, `EMAIL`) VALUES
(1, 'Mykolas', 'Mokonas', '523231', 'swx@gmail.com'),
(2, 'Tautvydas', 'Toad', '3442211', 'ate@gmail.com'),
(3, 'Donas', 'Rupuzokas', '523231', 'chicken@gmail.com'),
(4, 'Jonas', 'Rodauskas', '323218', 'jonaitis@gmail.com'),
(5, 'Audrius', 'Drauskas', '377388283', 'ttoto@yahoo.com');

-- --------------------------------------------------------

--
-- Table structure for table `student_marks_laukai`
--

CREATE TABLE `student_marks_laukai` (
  `ID` int(11) NOT NULL,
  `STUDENT_ID` int(11) NOT NULL,
  `TITLE` varchar(50) NOT NULL,
  `MARK` int(10) NOT NULL,
  `TIME_STAMP` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student_marks_laukai`
--

INSERT INTO `student_marks_laukai` (`ID`, `STUDENT_ID`, `TITLE`, `MARK`, `TIME_STAMP`) VALUES
(1, 1, 'Matematika', 5, '2017-06-12 17:37:26'),
(2, 1, 'Fizika', 6, '2017-06-12 17:37:26'),
(3, 2, 'Kuno Kultura', 10, '2017-06-12 17:37:26'),
(4, 2, 'Matematika', 6, '2017-06-12 17:37:26'),
(5, 3, 'Geografija', 8, '2017-06-12 17:37:26'),
(6, 3, 'Anglu k.', 9, '2017-06-12 17:37:26'),
(7, 4, 'Lietuviu k.', 6, '2017-06-12 17:37:26'),
(8, 4, 'Chemija', 4, '2017-06-12 17:37:26'),
(9, 5, 'Daile', 10, '2017-06-12 17:37:26'),
(10, 5, 'Technologijos', 10, '2017-06-12 17:37:26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `studentadress`
--
ALTER TABLE `studentadress`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student_marks_laukai`
--
ALTER TABLE `student_marks_laukai`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `studentadress`
--
ALTER TABLE `studentadress`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `student_marks_laukai`
--
ALTER TABLE `student_marks_laukai`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

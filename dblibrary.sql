-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2022 at 05:00 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dblibrary`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbooknumber`
--

CREATE TABLE `tblbooknumber` (
  `ID` int(11) NOT NULL,
  `BOOKTITLE` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Desc` varchar(90) NOT NULL,
  `Author` varchar(90) NOT NULL,
  `PublishDate` date NOT NULL,
  `Publisher` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblbooknumber`
--

INSERT INTO `tblbooknumber` (`ID`, `BOOKTITLE`, `QTY`, `Desc`, `Author`, `PublishDate`, `Publisher`) VALUES
(20, 'Tom Thumb', 1, 'Tom Thumb', 'Richard Jesse Watson', '2022-11-30', 'unknown'),
(21, 'Adventure Time', 1, 'Adventure Time', 'Crusoe', '2019-11-30', 'unknown'),
(22, 'Tumult', 1, 'desc', 'Rok Nardin', '2022-12-03', 'vnc'),
(23, 'Book One', 1, 'desc', 'A1', '2022-12-03', 'unknown'),
(24, 'Book Two', 1, 'desc', 'A2', '2022-12-03', 'unknown'),
(25, 'BK3', 1, 'desc', 'A3', '2022-12-03', 'NBH'),
(26, 'Book Three', 1, 'desc', 'A4', '2022-12-03', 'NBH'),
(27, 'Book  Five', 1, 'desc', 'A5', '2022-12-03', 'NBH'),
(28, 'Book Six', 1, 'desc', 'A6', '2022-12-03', 'NBH'),
(29, 'Book Seven', 1, 'desc', 'A7', '2022-12-03', 'NBH'),
(30, 'Book Eight', 1, 'desc', 'A8', '2022-12-03', 'NBH'),
(31, 'BK9', 1, 'desc', 'A9', '2022-12-03', 'GHJ');

-- --------------------------------------------------------

--
-- Table structure for table `tblbooks`
--

CREATE TABLE `tblbooks` (
  `BookID` int(11) NOT NULL,
  `AccessionNo` varchar(90) NOT NULL,
  `BookTitle` varchar(125) NOT NULL,
  `BookDesc` varchar(255) NOT NULL,
  `Author` varchar(125) NOT NULL,
  `PublishDate` date NOT NULL,
  `BookPublisher` varchar(125) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `BookPrice` double NOT NULL,
  `BookQuantity` int(11) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `BookType` varchar(90) NOT NULL,
  `DeweyDecimal` varchar(90) NOT NULL,
  `OverAllQty` int(11) NOT NULL,
  `Donate` tinyint(1) NOT NULL,
  `Remark` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblbooks`
--

INSERT INTO `tblbooks` (`BookID`, `AccessionNo`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`, `Status`, `BookType`, `DeweyDecimal`, `OverAllQty`, `Donate`, `Remark`) VALUES
(26, 'F02262021', 'Adventure Time', 'Adventure Time', 'Crusoe', '2019-11-30', 'unknown', 1, 0, 1, 'Available', 'Unknown', '', 1, 0, 'Donate'),
(28, 'BK1', 'Book One', 'desc', 'A1', '2022-12-03', 'unknown', 1, 0, 1, 'Available', 'Non-Fiction', '', 1, 0, 'Donate'),
(29, 'BK2', 'Book Two', 'desc', 'A2', '2022-12-03', 'unknown', 1, 0, 1, 'Available', 'Non-Fiction', '', 1, 0, 'Donate'),
(30, 'BK3', 'BK3', 'desc', 'A3', '2022-12-03', 'NBH', 1, 0, 1, 'Not Available', 'Fiction', '', 1, 0, 'Donate'),
(31, 'BK4', 'Book Three', 'desc', 'A4', '2022-12-03', 'NBH', 1, 0, 1, 'Not Available', 'Unknown', '', 1, 0, 'Donate'),
(32, 'BK5', 'Book  Five', 'desc', 'A5', '2022-12-03', 'NBH', 1, 0, 1, 'Available', 'Fiction', '', 1, 0, 'Donate'),
(33, 'BK6', 'Book Six', 'desc', 'A6', '2022-12-03', 'NBH', 1, 0, 1, 'Not Available', 'Fiction', '', 1, 0, 'Donate'),
(34, 'BK7', 'Book Seven', 'desc', 'A7', '2022-12-03', 'NBH', 1, 0, 1, 'Available', 'Unknown', '', 1, 0, 'Donate'),
(35, 'BK8', 'Book Eight', 'desc', 'A8', '2022-12-03', 'NBH', 4, 0, 1, 'Available', 'Fiction', '', 1, 0, 'Donate'),
(36, 'BK9', 'BK9', 'desc', 'A9', '2022-12-03', 'GHJ', 1, 0, 1, 'Available', 'Fiction', '', 1, 0, 'Donate');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrow`
--

CREATE TABLE `tblborrow` (
  `BorrowId` int(11) NOT NULL,
  `AccessionNo` varchar(90) NOT NULL,
  `NoCopies` int(11) NOT NULL,
  `DateBorrowed` datetime NOT NULL,
  `Purpose` varchar(90) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `DueDate` datetime NOT NULL,
  `BorrowerId` varchar(30) NOT NULL,
  `Due` tinyint(1) NOT NULL,
  `Remarks` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblborrow`
--

INSERT INTO `tblborrow` (`BorrowId`, `AccessionNo`, `NoCopies`, `DateBorrowed`, `Purpose`, `Status`, `DueDate`, `BorrowerId`, `Due`, `Remarks`) VALUES
(32, 'BK1', 1, '2022-12-03 12:08:48', 'Research', 'Returned', '2022-12-03 17:30:00', '20/0000', 0, 'On Time'),
(33, 'BK5', 1, '2022-12-03 13:12:49', 'Photocopy', 'Returned', '2022-12-03 13:42:49', '20/05706', 0, 'On Time'),
(34, 'BK3', 1, '2022-12-03 16:38:00', 'Overnight', 'Borrowed', '2022-12-04 16:38:00', '20/04985', 0, ''),
(35, 'BK4', 1, '2022-12-03 17:56:47', 'Overnight', 'Borrowed', '2022-12-04 17:56:47', '20/05706', 0, ''),
(36, 'BK6', 1, '2022-12-03 18:43:07', 'Overnight', 'Borrowed', '2022-12-04 18:43:07', '20/04985', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrower`
--

CREATE TABLE `tblborrower` (
  `IDNO` int(11) NOT NULL,
  `BorrowerId` varchar(90) NOT NULL,
  `Firstname` varchar(125) NOT NULL,
  `Lastname` varchar(125) NOT NULL,
  `MiddleName` varchar(125) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Sex` varchar(11) NOT NULL,
  `ContactNo` varchar(125) NOT NULL,
  `CourseYear` varchar(125) NOT NULL,
  `BorrowerPhoto` varchar(255) NOT NULL,
  `BorrowerType` varchar(35) NOT NULL,
  `Stats` varchar(36) NOT NULL,
  `IMGBLOB` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblborrower`
--

INSERT INTO `tblborrower` (`IDNO`, `BorrowerId`, `Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`, `BorrowerPhoto`, `BorrowerType`, `Stats`, `IMGBLOB`) VALUES
(20, '20/0000', 'Tobi', 'Uchiha', 'Obito', 'Konoha', 'Male', '0700000000', 'BSD 2020', '', 'Student', 'Active', ''),
(22, '20/1234', 'Bang', 'Garou', 'K.', 'City Z', 'Male', '0712345678', 'BSD 2020', '', 'Student', 'Active', ''),
(23, '20/04444', 'Sai', 'Genos', 'K.', 'desc', 'Male', '07394764333', '', '', 'Student', 'NotActive', ''),
(25, '20/04985', 'Sai', 'Genos', 'T.', 'desc', 'Male', '0739348975343', 'BSD 2018', '', 'Student', 'Active', ''),
(26, '20/04900', 'John', 'Tareo', 'G.', 'desc', 'Male', '013838746564', 'BSD 2020', '', 'Student', 'Active', ''),
(27, '20/04901', 'Collins', 'X', 'V', 'Nairobi', 'Male', '07336828763', 'BSD 2020', '', 'Student', 'Active', ''),
(28, '20/04902', 'Charanko', 'Dojo', 'H.', 'City Z', 'Male', '018376454', 'BSD 2020', '', 'Student', 'Active', ''),
(29, '20/04905', 'Minato', 'Shizune', 'M.', 'Konoha', 'Female', '0723498726', 'BSD 2020', '', 'Student', 'Active', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `CategoryId` int(11) NOT NULL,
  `Category` varchar(125) NOT NULL,
  `DDecimal` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`CategoryId`, `Category`, `DDecimal`) VALUES
(1, 'Computers, Information and General Reference', '000'),
(2, 'Philosophy and Psychology', '100'),
(3, 'Religion', '200'),
(4, 'Social Science', '300'),
(5, 'Language', '400'),
(6, 'Science', '500'),
(7, 'Technology', '600'),
(8, 'Arts and Recreation', '700'),
(9, 'Literature', '800'),
(10, 'History and Geography', '900'),
(12, 'ALL', 'ALL');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE `tblpayment` (
  `PaymentId` int(11) NOT NULL,
  `BorrowId` int(11) NOT NULL,
  `Payment` double NOT NULL,
  `Change` double NOT NULL,
  `DatePayed` date NOT NULL,
  `BorrowerId` int(11) NOT NULL,
  `Remarks` varchar(125) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblreturn`
--

CREATE TABLE `tblreturn` (
  `ReturnId` int(11) NOT NULL,
  `BorrowId` int(11) NOT NULL,
  `NoCopies` int(11) NOT NULL,
  `DateReturned` datetime NOT NULL,
  `Remarks` varchar(125) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblreturn`
--

INSERT INTO `tblreturn` (`ReturnId`, `BorrowId`, `NoCopies`, `DateReturned`, `Remarks`) VALUES
(27, 30, 1, '2022-12-03 12:09:13', 'Returned'),
(28, 33, 1, '2022-12-03 16:30:38', 'Returned'),
(29, 32, 1, '2022-12-03 17:56:10', 'Returned');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `UserId` int(11) NOT NULL,
  `Fullname` varchar(124) NOT NULL,
  `User_name` varchar(125) NOT NULL,
  `Pass` varchar(125) NOT NULL,
  `UserRole` varchar(125) NOT NULL,
  `Status` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`UserId`, `Fullname`, `User_name`, `Pass`, `UserRole`, `Status`) VALUES
(11, 'Guest', 'Guest', 'guest', 'Librarian', 'Active'),
(12, 'Generic Account', 'user', 'user', 'Librarian', 'Active'),
(14, 'test account', 'test', 'test', 'Assistant', 'Active'),
(15, 'test account 2', 'test2', 'test2', 'Assistant', 'Active'),
(16, 'vim clown', 'vim-clown', 'balls', 'Librarian', 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbooknumber`
--
ALTER TABLE `tblbooknumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `tblborrow`
--
ALTER TABLE `tblborrow`
  ADD PRIMARY KEY (`BorrowId`);

--
-- Indexes for table `tblborrower`
--
ALTER TABLE `tblborrower`
  ADD PRIMARY KEY (`IDNO`),
  ADD UNIQUE KEY `BorrowerId` (`BorrowerId`);

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD PRIMARY KEY (`PaymentId`);

--
-- Indexes for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD PRIMARY KEY (`ReturnId`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbooknumber`
--
ALTER TABLE `tblbooknumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `tblbooks`
--
ALTER TABLE `tblbooks`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tblborrow`
--
ALTER TABLE `tblborrow`
  MODIFY `BorrowId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `tblborrower`
--
ALTER TABLE `tblborrower`
  MODIFY `IDNO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tblcategory`
--
ALTER TABLE `tblcategory`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tblpayment`
--
ALTER TABLE `tblpayment`
  MODIFY `PaymentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `ReturnId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

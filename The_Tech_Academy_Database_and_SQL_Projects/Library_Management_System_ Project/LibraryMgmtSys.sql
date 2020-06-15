
/*
	LIBRARY MANAGEMENT SYSTEM PROJECT
	Date: 6/15/2020
*/

/***********************************************
	Creation of database
************************************************/

CREATE DATABASE db_LibraryManagmentSystem;

/*
	Populate the tables in the database as follows:

	a. Insert into the LIBRARY_BRANCH table 6 values of your choosing with the exception that one branch name is “Sharpstown.” Create values for the following columns: BranchName and BranchAddress.

	b. Insert into the BORROWER table 8 values of your choosing for the following columns: CardNo, Name, Address and Phone.

	c. Insert into the PUBLISHER table 10 values of your choosing for the following columns: PublisherName, Address and Phone.

	d. Insert into the BOOKS table 20 rows of different books. Ensure to include values in the following columns: Title and PublisherName. Assign one of the book titles with the value “The Lost Tribe.” If you need ideas for the other books, Google the top 100 books of all time and pull names from there.

	e. Insert into the BOOK_AUTHORS table 10 different author names (You may insert a name multiple times with a different BookID, for example, one author may have written multiple books that have different IDs).

	f. Insert into the BOOK_COPIES table values for the following columns: Number_of_Copies, BookID, and BranchID. Ensure that if a branch has a book, it has at least two copies of it. (To clarify, the Number_of_Copies column should show two or more for each row).

	g. Insert into the BOOK_LOANS table 10 rows including values in the following columns: BookID, BranchID, CardNo, DateOut, DateDue (Each BORROWER may have more than one book checked out).

*/

/***********************************************
	Creation of each table
************************************************/

USE db_LibraryManagmentSystem;

CREATE TABLE Library_Branch (
	BranchID INT PRIMARY KEY NOT NULL IDENTITY (1000,1),
	BranchName VARCHAR(50) NOT NULL,
	BranchAddress VARCHAR(150) NOT NULL,
);

CREATE TABLE Publisher (
	PublisherName VARCHAR(100) PRIMARY KEY NOT NULL,
	PublisherAddress VARCHAR(200) NOT NULL,
	Phone VARCHAR(30) NOT NULL,
);

CREATE TABLE Books (
	BookID INT PRIMARY KEY NOT NULL IDENTITY (2200,1),
	Title VARCHAR(200) NOT NULL,
	PublisherName VARCHAR(100) NOT NULL CONSTRAINT fk_PublisherName FOREIGN KEY REFERENCES Publisher(PublisherName) ON UPDATE CASCADE ON DELETE CASCADE,
);

CREATE TABLE Borrower (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY (500,1),
	BorrowerName VARCHAR(100) NOT NULL,
	BorrowerAddress VARCHAR(200) NOT NULL,
	BorrowerPhone VARCHAR(30) NOT NULL,
);

CREATE TABLE Book_Copies (
	BookID INT NOT NULL CONSTRAINT fk_Book_ID FOREIGN KEY REFERENCES Books(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_Branch_ID FOREIGN KEY REFERENCES Library_Branch(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	Number_Of_Copies INT NOT NULL
);

CREATE TABLE Book_Authors (
	BookID INT NOT NULL CONSTRAINT fk_Book_ID_2 FOREIGN KEY REFERENCES Books(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName VARCHAR(100) NOT NULL
);

CREATE TABLE Book_Loans (
	BookID INT NOT NULL CONSTRAINT fk_Book_ID_3 FOREIGN KEY REFERENCES Books(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_Branch_ID_2 FOREIGN KEY REFERENCES Library_Branch(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_CardNo FOREIGN KEY REFERENCES Borrower(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE NOT NULL,
	DateDue DATE NOT NULL
);


SELECT * FROM Library_Branch;
SELECT * FROM Book_Copies;
SELECT * FROM Books;
SELECT * FROM Book_Authors;
SELECT * FROM Borrower;
SELECT * FROM Book_Loans;
SELECT * FROM Publisher;


/*
DROP TABLE IF EXISTS Books;
DROP TABLE IF EXISTS Book_Copies;
DROP TABLE IF EXISTS Book_Authors;
DROP TABLE IF EXISTS Book_Loans;
DROP TABLE IF EXISTS Library_Branch;
DROP TABLE IF EXISTS Borrower;
DROP TABLE IF EXISTS Publisher;
*/

/***********************************************
	Insertion of data into created tables
************************************************/

INSERT INTO Library_Branch (BranchName, BranchAddress)
	VALUES
	('Lionsgate', '123 Main St'),
	('Richmond', '456 Avery Dr'),
	('Seymour', '789 Brock St'),
	('Arnold', '18 Stout Pl'),
	('Daemen', '24 Kennedy Ave'),
	('Sharpstown', '89 Topper St')
;

INSERT INTO Borrower (BorrowerName, BorrowerAddress, BorrowerPhone)
	VALUES
	('Bryce Willard', '225 Rice Hwy', '357-864-9999'),
	('Amy Lester', '2 Rolex Pl', '357-554-9999'),
	('Pete Smith', '5 Candlyland Dr', '555-864-9999'),
	('Suni West', '8795 Los St', '971-864-9999'),
	('Liberty Laird', '808 Wright Hwy', '357-864-2399'),
	('Trish Paterson', '9963 Queen Pl', '357-864-9256'),
	('Yella Shaw', '56942 Utica St', '357-764-9999'),
	('Phil Jackson', '6466 Station Blvd', '357-444-9999')
;

INSERT INTO Publisher (PublisherName, PublisherAddress, Phone)
	VALUES
	('Penguin', '227 Artic Ave', '555-678-9877'),
	('Scholastical', '4400 Mallory Dr', '444-678-9877'),
	('Harper', '2302 Lee Way', '549-678-9877'),
	('Maximilian', '2 Dollars Pl', '222-678-9877'),
	('Simon', '17895 Garfield Ave', '866-678-9877'),
	('McCray', '7 Chris Blvd', '555-622-9877'),
	('Harlow', '369 Bird St', '555-678-9822'),
	('Pear', '147 Sunshine St', '555-238-9877'),
	('Gageson', '25892 Micro Way', '368-678-9877'),
	('Sprinter', '321 Race Blvd', '555-678-4477')
; 

INSERT INTO Books (Title, PublisherName)
	VALUES
	('The Great Gatsby', 'Simon'),
	('The Catcher in the Rye', 'Simon'),
	('1984', 'Penguin'),
	('Brave New World', 'Harper'),
	('A Passage to India', 'Simon'),
	('Pride and Prejudice', 'Pear'),
	('A Bend in the River', 'McCray'),
	('Great Expectations', 'Simon'),
	('White Noise', 'Sprinter'),
	('Money', 'Simon'),
	('Oscar And Lucinda', 'Harlow'),
	('Haroun and the Sea of Stories', 'Gageson'),
	('American Pastoral', 'Simon'),
	('Austerlitz', 'Maximilian'),
	('A Wrinkle in Time', 'Maximilian'),
	('Are You There, God? It''s me, Margaret', 'Penguin'),
	('Of Human Bondage', 'Harper'),
	('The Amazing Adventure of Kavalier and Clay', 'Penguin'),
	('The Brief Wonderous Life of Oscar Wao', 'Scholastical'),
	('The Lost Tribe', 'Penguin')
;

INSERT INTO Book_Authors (BookID, AuthorName)
	VALUES
	(2200,'Harper Lee'),
	(2201, 'George Orwell'),
	(2202,'EM Forster'),
	(2203,'V. S. Naipaul'),
	(2204,'Charles Dickens'),
	(2205,'Don DeLillo'),
	(2206,'Martin Amis'),
	(2207,'Judy Bloom'),
	(2208,'Michael Chabon'),
	(2209,'Junot Diaz')
;

INSERT INTO Book_Copies (BookID, BranchID, Number_Of_Copies)
	VALUES
	(2200, 1000, 4),
	(2201, 1001, 6),
	(2202, 1002, 9),
	(2203, 1003, 3),
	(2204, 1004, 5),
	(2205, 1005, 8),
	(2206, 1001, 7),
	(2207, 1005, 4),
	(2208, 1005, 6),
	(2209, 1002, 7),
	(2210, 1001, 8),
	(2211, 1003, 8),
	(2212, 1005, 4),
	(2213, 1004, 10),
	(2214, 1005, 6),
	(2215, 1001, 8),
	(2216, 1000, 8),
	(2217, 1000, 8),
	(2218, 1003, 5),
	(2219, 1001, 4)
;

INSERT INTO Book_Loans (BookID, BranchID, CardNo, DateOut, DateDue)
	VALUES
	(2203, 1003, 500, '2020-02-15', '2020-03-15'),
	(2210, 1001, 500, '2020-02-15', '2020-04-15'),
	(2207, 1005, 501, '2020-05-19', '2020-06-19'),
	(2206, 1001, 502, '2020-02-15', '2020-03-15'),
	(2202, 1002, 503, '2020-02-15', '2020-03-15'),
	(2211, 1003, 504, '2020-02-15', '2020-03-15'),
	(2219, 1001, 505, '2020-02-15', '2020-03-15'),
	(2213, 1004, 506, '2020-02-15', '2020-03-15'),
	(2213, 1004, 507, '2020-02-15', '2020-03-15'),
	(2205, 1005, 507, '2020-02-15', '2020-03-15')
;

SELECT * FROM Library_Branch;
SELECT * FROM Book_Copies;
SELECT * FROM Books;
SELECT * FROM Book_Authors;
SELECT * FROM Borrower;
SELECT * FROM Book_Loans;
SELECT * FROM Publisher;


/***********************************************
	Queries Section
************************************************/

SELECT Book_Loans.BookID, BranchID, Book_Loans.CardNo, DateOut, DateDue, Title, PublisherName
	FROM Book_Loans
	FULL OUTER JOIN Borrower ON Book_Loans.CardNo = Borrower.CardNo
	FULL OUTER JOIN Books ON Book_Loans.BookID = Books.BookID
;

--a query that returns all book titles and the authors name
SELECT Title, AuthorName
	FROM Books
	INNER JOIN Book_Authors ON Books.BookID = Book_Authors.BookID
;

/*
	Create stored procedures that will query for each of the following questions:

	1. How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?

	2. How many copies of the book titled "The Lost Tribe" are owned by each library branch?

	3.a Retrieve the names of all borrowers who have books checked out.
	3.b Retrieve the names of all borrowers who do not have any books checked out.

*/
--------------------------------------------------------------------------------------------------------------------------------------------

--1. How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?

CREATE PROC dbo.uspGet_Number_Of_Copies_From_Branch 
	@BookTitle NVARCHAR(150),
	@BranchName NVARCHAR(50)
	AS
	SELECT 
		Title, Number_Of_Copies, BranchName
		FROM Book_Copies
		INNER JOIN Books ON Book_Copies.BookID = Books.BookID
		INNER JOIN Library_Branch ON Book_Copies.BranchID = Library_Branch.BranchID
		WHERE Title LIKE @BookTitle AND BranchName LIKE @BranchName 
		GO

--Stored Procedure
EXEC dbo.uspGet_Number_Of_Copies_From_Branch @BookTitle = 'The Lost Tribe', @BranchName = 'Richmond'

--------------------------------------------------------------------------------------------------------------------------------------------

--2. How many copies of the book titled "The Lost Tribe" are owned by each library branch?

CREATE PROC dbo.uspGet_Number_Of_Copies_From_Each_Branch
	@BookTitle VARCHAR(150)
	AS
	SELECT Title, Number_Of_Copies, BranchName
		FROM Book_Copies
		INNER JOIN Books ON Book_Copies.BookID = Books.BookID
		INNER JOIN Library_Branch ON Book_Copies.BranchID = Library_Branch.BranchID
		WHERE Title LIKE @BookTitle
		GO

--Stored Procedure
EXEC dbo.uspGet_Number_Of_Copies_From_Each_Branch @BookTitle = 'The Lost Tribe'

--------------------------------------------------------------------------------------------------------------------------------------------

--3.a Retrieve the names of all borrowers who do have books checked out.

CREATE PROC dbo.uspGet_Name_Of_Borrowers_With_Books_Checked_Out
	AS
	SELECT BorrowerName, Title, DateOut
		FROM Book_Loans
		INNER JOIN Borrower ON Book_Loans.CardNo = Borrower.CardNo
		INNER JOIN Books ON Book_Loans.BookID = Books.BookID
		GO

--Stored Procedure
EXEC dbo.uspGet_Name_Of_Borrowers_With_Books_Checked_Out


--3.b Retrieve the names of all borrowers who do not have any books checked out.

CREATE PROC dbo.uspGet_Name_Of_Borrowers_With_No_Books_Checked_Out
	AS
	SELECT BorrowerName, Title, DateOut
		FROM Book_Loans
		INNER JOIN Borrower ON Book_Loans.CardNo = Borrower.CardNo
		INNER JOIN Books ON Book_Loans.BookID = Books.BookID
		WHERE DateOut IS NULL
		GO

--Stored procedure
--There is not result since all Borrowers in the dB at this time have at least one book checked out.
EXEC dbo.uspGet_Name_Of_Borrowers_With_No_Books_Checked_Out

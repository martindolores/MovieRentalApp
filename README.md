# MovieRentalApp

Welcome to my Movie Rental Management System Application! It uses a local database with SQL connection to save movie details, customer details as well as a simple login
authentication. 

---------------------------------------------------------
SQL CONNECTION
----------------------------------------------------------
In order to get the connection to work, you must update the constants in the file. Replace the data source to your own datasource. You must also create four tables.
Once the SQL CONNECTION and Tables are created the program should run!

NOTE: the names must be the same and the columns names as well.

SQL Script

Table 1:
create table loginTable(
id int NOT NULL IDENTITY (1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null
)

Table 2:
create table newMovie(
mid int NOT NULL IDENTITY (1,1) primary key,
mName varchar(250) not null,
mRating varchar(250) not null,
mGenres varchar(250) not null,
mDirectors varchar(250) not null,
mPrice bigint not null,
mPurDate varchar(250) not null,
mQuan varchar(250) not null
)

Table 3:
create table CustomerDetails(
custid int NOT NULL IDENTITY(1,1) primary key,
custfname varchar(250) not null,
custlname varchar(250) not null,
custemail varchar(250) not null,
custdate varchar(250) not null,
custaddr varchar(250) not null,
custsub varchar(250) not null,
custstate varchar(250) not null,
custpost varchar(250) not null,
custmemberno varchar(250) not null
)

Table 4:
create table issueMovie(
id int NOT NULL IDENTITY (1,1) primary key,
cust_memberNo varchar(250) not null,
cust_Fname varchar(250) not null,
cust_Lname varchar(250) not null,
cust_Email varchar(250) not null,
issue_mName varchar(250) not null,
issue_Date varchar(250) not null,
issue_returnDate varchar(250) not null
)

----------------------------------------------------------
FUNCTIONS
----------------------------------------------------------

Movies:
1.  Add New Movie
- Creates a new movie and adds it to newMovie table. Prompts user to add Movie name, rating, genres, directors, price purchase date and quantity.
2.  View Movies
- Allows user to view all movies and update infomation if required and will update newMovie table

Customer:
1.  Add Customer
- Allows user to enter Customer Details and adds it to CustomerDetails table. Prompts user to add first name, last name, email, and address. This will also issue
a member no. for customer.
2.  View Customer Info
- Allows user to update, delete customer details as well as view member no. .

Issue Movies:
- User can issue movie to customer by searching for customer by member no. . This will automatically populate the customer details and user will have to find movie
the customer wishes to borrow. This will update the issueMovie table and issue_returnDate will be 'NULL' (this is because customer has not returned the movie).

Return Movies:
- User can return movie for customer by searching for customer by member no. . This will his will automatically populate the customer details and user will have to find movie
the customer wishes to return. Select return date for movie and it will update issueMovie, column issue_returnDate with the return date.

Issued and Returned Movies:
- Allows user to view all movies that are issued or returned. 

This application is designed as a Test for job recruitment process at Mtech.

Candidate: Luis Momox Beristain

<h2>Description</h2>
It is a web API in which four Http methods where developed: Get, Post, Put and Delete.
The application retrieves data from a table named 'Employees' that has th following attributes:
-Id (PK)
-Name
-LastName
-RFC
-BornDate
-Status

-Id is the primary key, all other attributes are not null.
-Rfc is unique and a regex was used to validate length and format
-Status is a enum (as per request) with values: Not Set, Active, Inactive 

<h2>Use</h2>
Run the application in the following route: localhost:5132/swagger/index.html
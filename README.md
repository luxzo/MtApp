This application is designed as a Test for job recruitment process at Mtech.

Candidate: Luis Momox Beristain

<h2>Description</h2>
It is a web API in which four Http methods where developed: Get, Post, Put and Delete.
The application retrieves data from a table named 'Employees' that has th following attributes:
<ul>
  <li>Id</li>
  <li>Name</li>
  <li>LastName</li>
  <li>RFC</li>
  <li>BornDate</li>
  <li>Status</li>
</ul>

The application has 2 Get Methods:
<p><b>GetByBDate</b> which sorts and retrieves values by date of birth</p>
<p><b>GetByname</b> which sorts and retrieves values by name</p>


<p>Id is the primary key, all other attributes are not null.</p>
<p>Rfc is unique and a regex was used to validate length and format</p>
<p>Status is a enum (as per request) with values: Not Set, Active, Inactive </p>

<h2>Use</h2>
Run the application in the following route: localhost:5132/swagger/index.html
A swagger page will be prompted.

# Code Explanation – ConsoleApp1

The program is a C# console application that connects to a SQL Server database.

It defines the server name (Data Source) and database name (Initial Catalog) to create a connection string.

The connection uses Windows Authentication (Trusted_Connection=True), not a username/password.

The connection is opened using conn.Open() inside a try block.

The InsertStaff method inserts a hardcoded student record (ID = 2, Name = "shubham", Contact = "8320633601") into the student table using parameterized SQL.

SQL parameters (@std_id, @name, @contact) are used to avoid SQL injection.

ExecuteNonQuery() runs the insert command and returns the number of rows affected.

The displayStaff method uses a SELECT * FROM student query to fetch all records.

A SqlDataReader reads each row and prints student ID, name, and contact number.

The connection is safely closed in the finally block, even if an error occurs.




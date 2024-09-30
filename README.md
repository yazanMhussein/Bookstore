# Bookstore
# Bookstore Management Platform

This is an ASP.NET Core MVC application for managing a bookstore. It provides CRUD (Create, Read, Update, Delete) operations for books using Entity Framework Core and a SQL Server database.

## Prerequisites

To run this project, ensure you have the following installed:
From NuGet Manager add the following packages:

Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
Install-Package Microsoft.EntityFrameworkCore.Design

## Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/YOUR_USERNAME/BookstoreManagementPlatform.git
   cd BookstoreManagementPlatform
Set up the database:

Open appsettings.json in the root directory and update the connection string to match your SQL Server configuration:
json
Copy code
"ConnectionStrings": {
  "BooksDbContext": "Server=YOUR_SERVER_NAME;Database=BooksDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Apply migrations: Open the terminal in Visual Studio and run:

bash
Copy code
dotnet ef database update
Run the application:

In Visual Studio, press F5 or use the Run option to start the application.
The application will be accessible at https://localhost:5001 or http://localhost:5000.
Usage
Once the application is running, you can perform the following CRUD operations:

1. View All Books (Index)
Go to /BookStore/Index to see a list of all books.
2. Add a New Book (Create)
Navigate to /BookStore/Create to add a new book.
Fill in the form with the book details (Title, Author, Price, Genre) and submit.
3. Edit an Existing Book (Edit)
Go to /BookStore/Edit/{id}, where {id} is the ID of the book you wish to edit.
Update the fields and save your changes.
4. View Book Details (Details)
Go to /BookStore/Details/{id} to view details of a specific book.
5. Delete a Book (Delete)
Go to /BookStore/Delete/{id} to delete a book.
Confirm the deletion to remove the book from the database.
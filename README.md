
# Web-Based Student Management System in .NET

## Overview

The **Web-Based Student Management System** is a .NET-based application developed to efficiently manage student information. This project utilizes SQL Server for data storage and Entity Framework for seamless database access. The system features a user-friendly interface designed to perform CRUD (Create, Read, Update, Delete) operations on student records.

## Approach

### Problem Understanding
The task required creating a student management system with specific requirements, including the use of SQL Server, Entity Framework, and ensuring unique Student IDs. The focus was on developing a solution that is both functional and user-friendly while adhering to best practices in software development.

### Design and Implementation
1. **Database Design**:
   - **Tables**: Designed a `Students` table in SQL Server with fields such as `StudentID`, `Name`, `DateOfBirth`, `Class`, and `Section`.
   - **Relationships**: Ensured that the StudentID is unique by applying a unique constraint, which prevents duplicate entries.

2. **Entity Framework**:
   - Utilized Entity Framework for Object-Relational Mapping (ORM), making it easier to interact with the SQL Server database. This choice was made to streamline database operations and maintain a clean, maintainable codebase.

3. **User Interface**:
   - Designed the UI with simplicity in mind, ensuring that users can easily perform CRUD operations.
   - Employed HTML, CSS, and JavaScript to create a responsive and intuitive interface.

4. **Input Validation**:
   - Implemented input validation to ensure the integrity of the data. For example, the system checks for unique Student IDs and ensures that all required fields are populated.

### Thought Process
The development process was guided by the following considerations:
- **Scalability**: Designed the database and application to easily scale with additional fields or entities in the future.
- **Maintainability**: Kept the codebase modular and well-documented to facilitate future updates or changes.
- **User Experience**: Prioritized a simple and efficient user interface to ensure that end-users can interact with the system without difficulty.

## Project Structure

- **/Models**: Contains the Entity Framework models representing the database tables.
- **/Controllers**: Manages the application logic and user input, handling CRUD operations.
- **/Views**: Includes the HTML, CSS, and JavaScript files for the user interface.
- **/DatabaseScripts**: SQL scripts for setting up the database tables.
- **appsettings.json**: Configuration file for database connection strings and other settings.

## Installation

### Prerequisites
- **.NET Framework**
- **SQL Server**

### Steps
1. **Clone the Repository**:
  https://github.com/raisul19960/Student-Management-System.git

2. **Set Up SQL Server**:
    - Create a database named `StudentDbContext`.
    - Execute the DbMOdels folder to create the necessary tables.

3. **Configure the Connection String**:
    - Update the connection string in `Web.config` with  SQL Server details.

4. **Build and Run the Application**:
    - Open the solution in Visual Studio.
    - Build the project.
    - Run the application using `Ctrl + F5`.

## How to Run the Project

1. Launch the application using the steps provided in the Installation section.
2. Use the navigation menu to access the different CRUD operations:
   - **Add Student**: Enter details in the form to add a new student.
   - https://github.com/raisul19960/Student-Management-System/commit/ab161f42661673f1c29f3c27df2e8c55d7148de1#commitcomment-145535360
   - **View Students**: Browse the list of existing students.
   - **Edit Student**: Select a student to update their details.
   - **Delete Student**: Remove a student from the system.

## Decision-Making Steps

1. **Choosing Entity Framework**: Opted for Entity Framework to reduce the complexity of SQL queries and to provide a robust ORM solution.
2. **UI/UX Design**: Prioritized a straightforward design to ensure the system is accessible to users with varying levels of technical expertise.
3. **Validation**: Decided to implement server-side validation to enhance data integrity and prevent potential errors during data entry.

## Submission Requirements

This project was specifically developed for this task and has not been used for any previous projects. The project includes:
- All source files and documentation.
- A clear README file outlining the approach, installation instructions, and other relevant details.
- Documentation of the thought process and decision-making steps.

## Contact

For any questions or further information, please contact: raisulislam946608329@gmail.com.




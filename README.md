# Assignment: SQL, Database Contexts and Transactions

# Part 1: Building Functions, Views, and Stored Procedures

## Introduction

In this part, we will build a view, a stored procedure, and a function by using the `FourthWallAcademy` database. We will need to create these objects based on the requirements below.

## Starter Files

After opening the project in the dev container, run `./setup-database.sh` to create the database within docker. You will use the `solution.sql` file for Part 1.

## Requirements

We will write SQL expressions that meet the following requirements:

### Creating a View

Create a view that combines student information with their powers and ratings. The view needs to be called `StudentPowerView`.

### Creating a Function

Create a function to calculate the average rating of a student's powers as a decimal value with a precision of 5 and a scale of 2. The function needs to be called `GetAveragePowerRating`.

### Creating a Stored Procedure

Create a stored procedure to add a new student along with their powers and ratings. The name of the stored procedure needs to be `AddStudentWithPowers`.

## Part 1 Deliverables

The deliverable of this exercise is a `solution.sql` file containing SQL queries and commands that can be executed in the dev container provided. The SQL provided must adhere to the requirements specified above.

## Part 1 Conclusion

Knowing how to use SQL programmability features is an important skill for any software developer who works with databases. This exercise helped us to build the foundation of this skill. We gain experience in building views, functions, and stored procedures, all of which are frequently used in the software development industry.

# Part 2: Building Entity Framework DB Context

## Introduction

In this part, we will build an Entity Framework abstraction of the `FourthWallAcademy` database. We will do so according to the requirements below.

### Starter Files

The `StudentManagementApp` solution is the starting point. - Before building, you need to run `dotnet add package Microsoft.EntityFrameworkCore --version 8.0.6` in your project directory

## Requirements

We will be using the tables from the `FourthWallAcademy` database as the templates for our domain models.

### Add Domain Models

All domain model classes need to be placed in the `Models` folder inside the solution. Each database table needs to have a domain model to represent it. Every table in the database needs to be represented by a domain model class and each class needs to adhere to the following criteria:

- Each class needs to have the `Table` attribute with the database table name.

- Each primary key needs to be annotated with the `Key` attribute.

- If a table has a primary key consisting of more than one column, the corresponding domain model class needs to be annotated with the `PrimaryKey` attribute from the `Microsoft.EntityFrameworkCore` namespace. This attribute needs to list the names of the columns that the key consists of.

### Build Relationships Between Models

Each domain model will need to have related entities as its properties. The property that represents the foreign key column needs to be annotated with the `ForeignKey` attribute.

### Add DB Context

We need to add a database context class that lists all the entity models. The `OnConfiguring()` method override inside this class must have an appropriate connection string that can successfully connect to the database.

### Add a Query to List Students

Once we added the database context, we will need to apply it in the `Program.cs` file to query the database. We will need to execute the query to list all students and output these details in the database. For each user, we will need to show the following information:

- Student id
- First name
- Last name
- Alias

## Part 2 Deliverables

The deliverable of this exercise is a .NET console application with Entity Framework dependencies. The application needs to adhere to the above requirements.

## Part 2 Conclusion

Entity Framework is a popular ORM used by many real-world applications. To be able to work with the codebases of these applications, we need to gain experience in building domain models and database context by using Entity Framework. This exercise gave us an opportunity to practice these skills.

# Part 3: Implementing Complex Data Updates

## Introduction

In this part, we will build a complex transaction against the `FourthWallAcademy` database. This will help us to get familiar with the process of building and executing such transactions. The logic we need to implement is defined by the requirements below.

## Requirements

We already have a DB context and all entity models defined. What we need to do is build a transaction that adheres to the following requirements:

### Add a New Student

The first action performed in the transaction will need to be the creation of a new record in the `Student` database.

### Assign Power to The Student

We will then need to assign a power to the newly added student. Any power can be used.

### Enroll The Student in a Section

We need to enroll the newly added student in a section.

### Commit Changes

We need to make sure that all the above changes are done inside the transaction and committed at the end.

### Error Handling

If an error occurs, the changes performed within the scope of the transaction need to be automatically rolled back.

## Part 3 Deliverables

The deliverable of this exercise is a .NET console application that adheres to the above requirements.

## Part 3 Conclusion

Database transactions are a very important concept, as real-life applications often make interdependent modifications to multiple database entities. Knowing how to implement them in both raw SQL and an ORM is an important skill to master for a back-end web developer. This is what we practiced in this exercise.

# Overall Deliverables

- executable `solution.sql` file
- executable .NET console application with
  - Entity Framework Models
  - StudentManagementContext.cs
  - Program.cs

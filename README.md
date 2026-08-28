# aspnet-backend-foundations
C# Console Projects - OOP, LINQ, File I/O, Async &amp; Database Foundations
# C# Backend Foundations (.NET)

A collection of C# console applications built during Phase 1 of the .NET Backend Development Track. This repository covers Object-Oriented Programming (OOP), LINQ queries, File I/O persistence, Asynchronous programming, SQL concepts, and Entity Relationship Diagram (ERD) modeling.

---

## 📂 Included Projects

### 1. Expense Tracker
* **Concepts:** Basic C# control flow, loops, methods, and input validation.
* **Features:** Allows users to track daily expenses and view totals.

### 2. Employee Management System
* **Concepts:** Classes, objects, lists, auto-properties.
* **Features:** Manages employee records (Id, Name, Department, Salary) with console operations.

### 3. Bank Account System
* **Concepts:** Encapsulation, access modifiers, constructors, state management.
* **Features:** Deposit, withdraw, and check balance with business rule validation.

### 4. Product Search Engine
* **Concepts:** LINQ filtering (`.Where()`, `.OrderBy()`, `.Select()`), lambda expressions.
* **Features:** Search and filter products by category, price range, and name.

### 5. Student Grades Analyzer
* **Concepts:** Complex LINQ (`.GroupBy()`), Extension Methods, File I/O (`System.IO`), Data parsing (`string.Join`, `string.Split`).
* **Features:** 
  * Calculate individual and class averages.
  * Assign letter grades (A, B, C, D, F).
  * Find top and lowest performers.
  * Group students by letter grade.
  * **File Persistence:** Save to and load student records from disk using `students.txt`.

---

## ⚡ Additional Async & SQL Exercises

* **Async Simulation:** Demonstrates performance gains of `Task.WhenAll(...)` concurrent execution (~2s) versus sequential `await` (~6s).
* **SQL Practice:** Core SQL queries covering `GROUP BY`, `HAVING`, aggregations (`AVG`, `COUNT`), and DML statements (`UPDATE`, `DELETE`).

---

## 📐 Library System ERD (Database Schema)

```text
  +-------------------+              +--------------------+
  |      AUTHOR       |              |      CATEGORY      |
  +-------------------+              +--------------------+
  | PK  Id            |              | PK  Id             |
  |     Name          |              |     Name           |
  |     Country       |              |                    |
  +---------+---------+              +---------+----------+
            | 1                                | 1
            | (writes)                         | (classifies)
            | N                                | N
  +---------+----------------------------------+----------+
  |                        BOOK                           |
  +-------------------------------------------------------+
  | PK  Id                                                |
  |     Title                                             |
  |     ISBN                                              |
  |     PublishedYear                                     |
  | FK  AuthorId   --------------------> Author.Id        |
  | FK  CategoryId --------------------> Category.Id      |
  +-------------------------+-----------------------------+
                            | 1
                            | (is borrowed in)
                            | N
  +-------------------------+-----------------------------+
  |                        LOAN                           |
  +-------------------------------------------------------+
  | PK  Id                                                |
  | FK  BookId     --------------------> Book.Id          |
  | FK  MemberId   --------------------> Member.Id        |
  |     LoanDate                                          |
  |     ReturnDate                                        |
  +-------------------------+-----------------------------+
                            | N
                            | (issued to)
                            | 1
                  +---------+---------+
                  |      MEMBER       |
                  +-------------------+
                  | PK  Id            |
                  |     Name          |
                  |     Email         |
                  |     JoinDate      |
                  +-------------------+

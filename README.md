
# Industrial Databases Project

## Project Title: **Comparison of Data Read Speed Between MS SQL Server and Text Files in a WinForms Application**

### Course: **Industrial Databases**

### University: Silesian University of Technology

### Author: Jakub Pająk && Kacper Stiborski

### Date: 10.2024

---

## Project Overview

This project is a part of the course "Industrial Databases" and focuses on comparing the read speed of records stored in two different data formats: 

- **MS SQL Server Database** 
- **Text File (.txt)**

The project involves creating a simple Windows Forms (WinForms) application using **C#** in **.NET Framework 4.7.2**. The application will measure and display the differences in the time it takes to read records from an **MS SQL Server** database versus a plain **text file**.

---

## Objectives

1. Develop a WinForms application to interact with an **MS SQL Server** database and text files.
2. Measure the time it takes to read records from both data sources.
3. Display the results in the application’s UI, showing the differences in performance.

---

## Technology Stack

- **Language**: C#
- **Framework**: .NET 4.7.2
- **Database**: MS SQL Server
- **UI Framework**: WinForms
- **File Format**: Text File (.txt)

---

## Application Functionality

1. **User Interface (WinForms)**:
   - A simple and intuitive UI that allows the user to choose between reading data from an MS SQL Server database or a text file.
   - Displays the results (time taken to read the data) in a clear format.

2. **Data Sources**:
   - **MS SQL Server**: The application connects to an instance of MS SQL Server, retrieves records from a predefined table, and calculates the time taken for the operation.
   - **Text File**: The application reads records from a plain text file, counts the number of records, and measures the time required.

3. **Comparison**:
   - The application displays the results for both data sources and compares the time it took to read the records from each.

---

## Installation and Setup

1. **Prerequisites**:
   - Visual Studio with .NET 4.7.2 support.
   - An instance of **MS SQL Server** running locally or remotely.
   - A text file (.txt) containing data records for comparison.
   
2. **Steps**:
   - Clone or download the project from the repository.
   - Open the project in Visual Studio.
   - Configure the connection string in the `app.config` file to point to your MS SQL Server instance.
   - Add a text file with records for testing (you can place it in the project’s `bin` folder or provide a path in the application).
   - Build and run the application.

---

## How to Use the Application

1. **Start the Application**:
   - Run the application from Visual Studio.
   
2. **Select Data Source**:
   - Choose between MS SQL Server or a Text File as the data source.

3. **Perform Read Operation**:
   - Click the button to start reading the records.
   - The time taken to read the records will be displayed on the screen.

4. **Compare Results**:
   - The application will provide a clear comparison of the read times from both data sources.

---

## Performance Testing

The performance testing compares the read speed for:

- Reading a specific number of records from the MS SQL Server database.
- Reading the same number of records from a plain text file.


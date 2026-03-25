# Police Info Management System

A **Police Info Management System** built in **C#** to help manage day-to-day police station information such as complaints, cases, suspects, officers, and basic reporting.  
This project focuses on organizing data in one place, improving traceability, and reducing manual paperwork.



---

## What this project does

The system provides a centralized way to:

- Record and maintain police-related information (e.g., complaints, incidents, cases)
- Track case progress and related entities (people/officers/records)
- Search/filter stored records quickly
- Produce basic summaries or reports for operational use


---

## Tech Stack

- **Language:** C# (100%)
- **Framework:** .NET 
- **UI (if applicable):** WinForms
- **Database (if applicable):** SQL Server 
- **IDE:** Visual Studio 2022

---

## Features

- **Secure login / role-based access**
- **Officer management** (add/edit/remove officer records)
- **Case management** (create cases, update status, assign officers)
- **Complaint/incident recording**
- **Search & filtering** (by ID, name, date, status, etc.)
- **Data validation** to reduce incorrect entries
- **Basic reporting / summaries** 



---

## How to Run

### Prerequisites
- **Windows** 
- **Visual Studio 2022** 
- **.NET SDK / .NET Framework**
- Database installed/configured 

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/IndikaMadhushan/Police-info-management-System.git
   cd Police-info-management-System
   ```

2. **Open the solution in Visual Studio**
   - Open the `.sln` file 

3. **Configure database **
   - Update your connection string in:
     - `App.config` or `Web.config` or `appsettings.json` 
   - Run any SQL scripts located in:
     - `database/` or `scripts/` 

4. **Restore dependencies**
   - Visual Studio usually restores automatically
   - Or via CLI:
     ```bash
     dotnet restore
     ```

5. **Build and run**
   - In Visual Studio: **Build** → **Build Solution**
   - Then press **F5** (Start Debugging) or **Ctrl+F5** (Start Without Debugging)

---

## Project Structure

- `src/` – application source code 
- `docs/` – documentation/screenshots
- `scripts/` – database or setup scripts


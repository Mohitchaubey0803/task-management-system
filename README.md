# Task Management System  
ASP.NET Core MVC Application

---

## Project Overview

This project is a **Task Management System** built using **ASP.NET Core MVC**.  
It allows users to create, view, update, delete, and search tasks through a clean and professional web interface.

The main goal of this application is to demonstrate **enterprise-level ASP.NET Core MVC development practices**, including proper architecture, database design, clean code, and documentation.

This project was developed as part of a technical assignment to showcase full-stack development skills using MVC architecture.

---

## Features

- Create a new task  
- View all tasks in a list  
- Search tasks by title  
- Edit existing tasks  
- Delete tasks with confirmation  
- View detailed task information  
- Task status management (Pending / In Progress / Completed)  
- Audit fields (Created On, Updated On, Created By, Updated By)

---

## Technology Stack

### Backend
- ASP.NET Core MVC
- C#

### Database
- Microsoft SQL Server
- Entity Framework Core (Code First)

### Frontend
- Razor Views
- Bootstrap 5

### Architecture & Patterns
- MVC Pattern
- Repository Pattern
- ViewModel Pattern
- Separation of Concerns

---

## Application Architecture

The application follows a **layered architecture** to ensure maintainability and scalability.

### Layers

- **Models**  
  Database entities such as `TaskItem` and `ErrorViewModel`.

- **ViewModels**  
  UI-specific models used to transfer data between Views and Controllers (e.g., `TaskCreateEditVM`).

- **Repositories**  
  Data access logic implemented using the Repository pattern.

- **Controllers**  
  Handle HTTP requests and coordinate between Views and Repositories.

- **Views**  
  Razor pages styled using Bootstrap for a clean and responsive user interface.

This structure ensures:
- Clean and readable code  
- Easy future enhancements  
- Alignment with real-world enterprise development standards  

---

## Database Design

### Task Table Fields

- Id (GUID – Primary Key)  
- Title  
- Description  
- DueDate  
- Status  
- Remarks  
- CreatedOn  
- LastUpdatedOn  
- CreatedBy  
- LastUpdatedBy  

### Design Decisions

- **Code First approach** used for flexibility and maintainability  
- **Index on Title** added for faster search operations  
- **Enum for Task Status** used to maintain data consistency  

---

## CRUD Operations Mapping

| Operation | Description |
|---------|------------|
| Create | Create Task form |
| Read | Task list and task details view |
| Update | Edit Task form |
| Delete | Delete confirmation page |
| Search | Search by task title |

---

## UI / UX Design

- Bootstrap 5 used for responsive and professional UI  
- Clean and minimal layout  
- Focus on usability and readability  
- Server-side validation enabled using ASP.NET Core  

The UI is intentionally kept **simple and professional**, similar to real enterprise internal applications.

---

## Build and Run Instructions

### Prerequisites

- .NET SDK (8.0 or compatible)
- Microsoft SQL Server
- Visual Studio or VS Code

### Steps

1. Clone the repository
```bash
git clone https://github.com/Mohitchaubey0803/task-management-system.git
dotnet ef database update
dotnet run
https://localhost:<port>/Task

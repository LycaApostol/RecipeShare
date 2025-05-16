# RecipeShare - Cooking Website (Group 2)

RecipeShare is a web application built with **ASP.NET Core MVC** that allows users to explore, share, and manage cooking recipes. Users can browse recipes, search by ingredients or cuisine, and contribute their own recipes.

---

## 📌 Technologies Used
- ASP.NET Core MVC (C#)
- SQL Server / LocalDB
- Visual Studio 2022
- Bootstrap (for styling)

---

## 📥 How to Download and Run the Project

### 📌 Prerequisites
- Visual Studio 2022
- .NET 8
- SQL Server (LocalDB or full version)

---

### 📌 Steps

1. **Clone or Download the Project**

   - Clone via Git:
     ```bash
     git clone https://github.com/LycaApostol/RecipeShare.git
     ```
   - Or download as ZIP from your repository link and extract it.

2. **Open the Project**
   - Launch Visual Studio 2022.
   - Open the `RecipeShare.sln` file.

3. **Restore NuGet Packages**
   - Visual Studio should restore dependencies automatically.
   - If not, go to:
     ```
     Tools > NuGet Package Manager > Manage NuGet Packages for Solution
     ```
     and restore them manually.

4. **Configure the Database**
   - Open `appsettings.json`.
   - Update the connection string to match your SQL Server / LocalDB configuration if needed.
   - Run the following command in the **Package Manager Console**:
     ```bash
     Update-Database
     ```

5. **Run the App**
   - Press `Ctrl + F5` or click **Start Without Debugging**.
   - The app will launch in your default browser.

---

## 📌 Features
- Browse a variety of cooking recipes
- Search recipes by ingredients, cuisine, or category
- View detailed recipe instructions with images
- User management for adding, editing, and deleting recipes



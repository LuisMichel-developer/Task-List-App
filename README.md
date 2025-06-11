"# 📘 Task List console app

🗓️ A console-based app that allows you to add tasks for all days of the week and select the day you want to check your tasks.

---

## 📦 Technologies Used

- **Language**: C# (.NET 6 / 7 / 8)
- **IDE**: Visual Studio 2022+
- **Type of App**: Console
- **Platform**: Windows / Cross-platform

---

## 🎯 Main Features

- ✅ Add tasks for each day of the week
- ✅ Check tasks for a specific day
- ✅ Exit the program safely
  
---

## 🧠 Project Logic

This project uses `switch`, `if-else`, and loops to create an interactive weekly task list. The app first asks the user to input a task for each day of the week (Monday to Sunday). 

After that, a **menu** appears where the user can select a day to view its corresponding task or choose to exit the application.

A `while` loop is used to keep displaying the menu until the user selects **Exit**.

Here’s an example of how the task-checking feature works:


```csharp
case "2":
    while (choice1 < 1 || choice1 > 8)
{
    Console.Write("Enter your choice (1-8): ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice >= 1 || choice <= 8) 
    {
        if (choice == 8)
        {
            Console.WriteLine("Exiting the program. Have a great week!");
            return;
        }
        else
        {
            Console.WriteLine($"Tasks for {days[choice - 1]}: {tasks[choice - 1]}");
        }

This code show how I can do the Deposit option.
```

---

# 🖥️ Sample Output

plaintext
```
Welcome to your weekly task list!
Please enter your tasks for each day of the week (Monday to Sunday):
Enter tasks for Monday: 1
Enter tasks for Tuesday: 2
Enter tasks for Wednesday: 3
Enter tasks for Thursday: 4
Enter tasks for Friday: 5
Enter tasks for Saturday: 6
Enter tasks for Sunday: 7

Task for the week
Select the day you wanna view the task
1. Monday
2. Tuesday
3. Wednesday
4. Thursday
5. Friday
6. Saturday
7. Sunday
8. Exit
Enter your choice (1-8): 4
Tasks for Thursday: 4
Enter your choice (1-8): 8
Exiting the program. Have a great week!
```

---

## 🏁 Cómo ejecutar el proyecto


1. Clone this repository:

   ```bash

   git clone https://github.com/LuisMichel-developer/Task-List-App

   ```

2. Open the file `.sln` in Visual Studio

3. Run the project with `Ctrl + F5`



---



## 🚀 Possible Improvements



- [ ] Add file saving to persist data between sessions

- [ ] Improve the console interface with colors or formatting

- [ ]  Add input validation for better error handling



---



## 🧑‍💻 Author

- 👤 **Luis Michel**
- 🎓 Software Engineering student
- 📍 Colima, Mexico
- 🌐 [LinkedIn Profile](https://www.linkedin.com/in/luis-michel-dev/)


---

## 📃 License

This project is licensed under the [MIT License](LICENSE).


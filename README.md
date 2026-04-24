# Exercise_2

## Overview

This project is a Blazor application that demonstrates a simple user input flow and component interaction.

The primary focus of this exercise is on:

* Form handling
* Validation
* State management between components

---

## Prerequisites

Make sure the following are installed:

* Microsoft Visual Studio (2022 or later)
* .NET SDK (match the version used in the project, e.g., .NET 8)

Verify installation:

```
dotnet --version
```

---

## Setup Instructions

1. Clone the repository:

```
git clone https://github.com/Arcade-Gannon-420/Exercise_2.git
```

2. Navigate to the project folder:

```
cd Exercise_2
```

3. Restore dependencies:

```
dotnet restore
```

4. Run the application:

```
dotnet run
```

5. Open browser:

```
https://localhost:<port>
```

---

## Scope of Review

Due to redundant or boilerplate files, focus your review only on:

* `Components/UserForm.razor`
* `Components/Pages/Home.razor`

---

## What to Evaluate

When reviewing the files above, pay attention to:

### 1. Form Handling

* Proper use of `EditForm`
* Validation via DataAnnotations
* Handling of valid/invalid submissions

### 2. State Management

* How data flows between components
* Ownership of state (parent vs child)
* Avoidance of unintended resets or data loss

### 3. Code Structure

* Separation of concerns
* Readability and maintainability
* Avoidance of hardcoded logic

---

## Expected Behavior

* User can input data through the form
* Validation errors should display correctly
* On successful submission:

  * Data should persist (in-memory)
  * UI should reflect updated state

---

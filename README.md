# HTTP5101 Assignment 2

This README provides an overview of the HTTP5101 Assignment 2 tasks and requirements.

## Assignment Overview

The assignment requires the creation of WebAPI methods to solve J1 and J2 problems from the Canadian Computing Competition (CCC). Additionally, an initiative task to attempt a J3 or higher problem is included.

### Task Descriptions

#### Adapted J1 - The New CCC (Canadian Calorie Counting)
Write a program that computes the total calories of a meal based on the user's selections of a burger, drink, side order, and dessert.

#### Adapted J2 - Roll the Dice
Write a program to determine the number of ways to roll a total sum of 10 with two dice of given sides.

#### Initiative Task
Attempt a J3 or higher problem.

## HTTP Endpoints

### J1 Problem Solution

**GET http://localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}**

Input Specification:
- {burger}: Integer representing the index of the burger choice
- {drink}: Integer representing the index of the drink choice
- {side}: Integer representing the index of the side order choice
- {dessert}: Integer representing the index of the dessert choice

Output Specification:
- Returns the total calorie count of the meal.

### J2 Problem Solution

**GET http://localhost/api/J2/DiceGame/{m}/{n}**

Input Specification:
- {m}: Positive integer representing the number of sides on the first die
- {n}: Positive integer representing the number of sides on the second die

Output Specification:
- Returns the number of ways to roll a total sum of 10 with the given dice.

### Initiative Task

Implement a WebAPI method to solve a J3 or higher problem.

## Author 
Saloni Pawar


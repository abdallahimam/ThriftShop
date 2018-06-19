# ThriftShop
is a small program to manage the products of a shop.
# Description:
* Firstly, here’s a brief description for the database structure
* Product Table
  * Id (Integer, Primary Key)
  *	Name (varchar)
  *	Price (Double)
  *	Category (varchar)
  *	Brand_id (Integer, foreign key refers to Id column in brand table)
* Brand table
  * Id (Integer, Primary Key)
  * BrandName (varchar)
# Secondly here are the required functions:
- Fill the data base with some data. Keep attention to the relations between table
- There should be a list of actions appeared to user when the program runs. So that the user can select a specific action to do. The result of this action should be presented to user then the main menu will be shown again.
- Create a function so that the user can be able show all products with its brand. From the main menu the user will select show products. Then the program will show to users all products in the system (line by line) each line contains the product info with the brand info
- Create a function so that the user can be able to add new products to the system. The user will select Add product from the menu the program will ask the user to enter the product name, price, category and brand name. Make sure that the brand is existing in the Brand table.
- Create a function so that the user can be able to select products with price less than specific price. From the main menu the user will select filter products by price. The program will ask the user to enter a price number. After the user enters this number the program will show to user all products with price less than or equal the entered price
- Create a function so that the user can be able to list all brands in the system sorted with number of products associated with each brand. The user will select from the main menu “Show brands” then the program will show to user all brands in system (line by line) each line contains a brand name followed by number of products assigned with this brand
-	Create a function so that the user can be able to sort products. The user will select from the main menu “Sort products”. Then the program will ask the user about the sorting way. The products can be sorted by name or sorted by price. So, the user will select the sorting way. After that the program will ask the user about the sorting direction (Ascending or descending) the user will select the sorting direction. Finally, the program will show to the user the products sorted according to the criteria entered by the user. 
# Implementation:
* prodrammed by C#
* LINQ to handle database operation

# VirtualVendingMachine
This repository is solution to the below question which was asked to me in one of the coding rounds - 
The vending machine API must maintain available products as well as the price for each of the products in inventory.

Stock never runs out so there is no need to maintain quantity.

ID
Product
Price
1
Coke
$0.95
2
Diet Coke
$0.90
3
Candy Bar
$0.60
4
Gum
$0.30
5
Chips
$1.10
6
Energy Drink
$1.00

The application will accept nickels (5c), dimes (10c), quarters (25c), and dollar bills ($1) from the user. It will also dispense the correct amount of change after 
a purchase; provided that the coins needed to create the proper change are available in the machine. If the correct amount of change is not available an error 
message should be displayed, and the product not sold. Dollar bills cannot be dispensed as change. The change starting in the machine is 2 quarters, 5 dimes, 3 nickels.

Make sure the change provided is the smallest number of coins possible.

After each coin has been put in the machine, the total amount entered for the current transaction should be printed.

Assumption - The vending machine is available for public use and anyone can access it so no need to implement authentication/authorization

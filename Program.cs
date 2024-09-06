const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

int numberOfSandwiches, numberOfToppings; 
double tip, baseCost, totalSandwichCost, totalToppingCost, orderCost; 

System.Console.WriteLine("How many sandwiches would you like? ");
numberOfSandwiches = int.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings would you like? ");
numberOfToppings = int.Parse(Console.ReadLine());

System.Console.WriteLine("How of much of a tip will you leave? ");
tip = int.Parse(Console.ReadLine());

totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING * numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost; 

orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT); 

System.Console.WriteLine("The total cost of your order will be " + orderCost);
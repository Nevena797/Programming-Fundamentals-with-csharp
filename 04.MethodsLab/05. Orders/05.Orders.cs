﻿string command = Console.ReadLine();
int amount = int.Parse(Console.ReadLine());

double price = 0;

switch (command)
{
	case "coffee":
		price = 1.50;
		break;
	case "water":
		price = 1.00;
		break;
	case "coke":
		price = 1.40;
		break;
	case "snacks":
		price = 2.00;
		break;
	default:
		Console.WriteLine("Invalid command");
		return;
}

totalPrice(amount, price);

void totalPrice(int amount,double price)
{
	Console.WriteLine($"{amount * price:f2}");
}

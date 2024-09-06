using CommandPattern;
using CommandPattern.Command;

Chef chef = new Chef();  

IOrderCommand steakOrder = new SteakOrderCommand(chef);
IOrderCommand saladOrder = new SaladOrderCommand(chef);

Waiter waiter = new Waiter();

//waiter taking steak order from customer
waiter.SetOrder(steakOrder);
waiter.ServeOrder();

//waiter taking salad order from customer
waiter.SetOrder(saladOrder);
waiter.ServeOrder();  
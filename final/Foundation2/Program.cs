using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("1 gallon milk", "d150", 2.85);
        Product p2 = new Product("1 cup yogurt", "d083", 0.75);
        Product p3 = new Product("1 lb cheddar cheese", "d215", 3.35);
        Product p4 = new Product("iceberg lettuce", "p019", 1.15);
        Product p5 = new Product("green leaf lettuce", "p020" , 1.79);
        Product p6 = new Product("butterhead lettuce", "p021" ,1.83);
        Order order = new Order();
        string selection;
        int _quantity;
        
        do
        {
            Console.WriteLine("d150, 1 gallon milk");
            Console.WriteLine("d083, 1 cup yogurt");
            Console.WriteLine("d215, 1 lb cheddar cheese");
            Console.WriteLine("p019, iceberg lettuce");
            Console.WriteLine("p020, green leaf lettuce");
            Console.WriteLine("p021, butterhead lettuce");
            Console.Write("What item do you want to purchace? Type 'stop' to stop. ");
            selection = Console.ReadLine();
            if (selection == "d150")
            {
                Console.Write("How many do you want?");
                _quantity = int.Parse(Console.ReadLine());
                order._products.Add(p1);
                order.GetQuantity(_quantity);
                p1.GetQuantity(_quantity);
            }
            if (selection == "d083")
            {
                Console.Write("How many do you want?");
                _quantity = int.Parse(Console.ReadLine());
                order._products.Add(p2);
                order.GetQuantity(_quantity);
                p2.GetQuantity(_quantity);
            }
            if (selection == "d215")
            {
                Console.Write("How many do you want?");
                _quantity = int.Parse(Console.ReadLine());
                order._products.Add(p3);
                order.GetQuantity(_quantity);
                p3.GetQuantity(_quantity);
            }
            if (selection == "p019")
            {
                Console.Write("How many do you want?");
                _quantity = int.Parse(Console.ReadLine());
                order._products.Add(p4);
                order.GetQuantity(_quantity);
                p4.GetQuantity(_quantity);
            }
            if (selection == "p020")
            {
                Console.Write("How many do you want?");
                _quantity = int.Parse(Console.ReadLine());
                order._products.Add(p5);
                order.GetQuantity(_quantity);
                p5.GetQuantity(_quantity);
            }
            if (selection == "p021")
            {
                Console.Write("How many do you want?");
                _quantity = int.Parse(Console.ReadLine());
                order._products.Add(p6);
                order.GetQuantity(_quantity);
                p6.GetQuantity(_quantity);
            }
        } while (selection != "stop");
        double price = order.TotalPrice();
        Console.WriteLine($"Your total cost is {price}");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine(order.ShippingLabel());
    }
}
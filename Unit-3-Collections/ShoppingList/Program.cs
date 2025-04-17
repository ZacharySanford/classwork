namespace ShoppingList
{
    internal class Program
    {
        static Dictionary<string, decimal> menu = new Dictionary<string, decimal>();

        static void Main(string[] args)
        {

            decimal sum = 0;

            Console.WriteLine("Start Program");

            

            menu["asparagus"] = 2.99m;
            menu["popcorn"] = 4.99m;
            menu["cherries"] = 2.99m;
            menu["strawberries"] = 1.99m;
            menu["oranges"] = 3.99m;
            menu["grapes"] = 3.49m;
            menu["blackberries"] = 2.49m;
            menu["blueberries"] = 4.99m;

            Console.WriteLine($"The store currently has: ");
            foreach (KeyValuePair<string, decimal> anItem in menu)
            {
                Console.WriteLine($"{anItem.Key} = ${anItem.Value}.");
            }
            
            

            List<string> cart = AddToCart();
            foreach(string item in cart)
            {
                Console.WriteLine(item);
            }

            foreach (string item in cart)
            {
                if (menu.ContainsKey(item)) 
                {
                    Console.WriteLine($"{item} cost ${menu[item]}");    
                    sum = sum + menu[item];

                   
                }
            }
            Console.WriteLine($"Your total today is ${sum}");
        }
    

        static List<string> AddToCart()
        {
            bool keepShopping = false;
            bool getInput = true;
            string userInput = "";
            string addToCart;
            List<string> cart = new List<string>();

            
            do
            {
                Console.WriteLine("What would you like to add to your cart?");

                addToCart = Console.ReadLine();

                if(menu.ContainsKey(addToCart))
                {
                    cart.Add(addToCart);
                }
                else
                {
                    Console.WriteLine("It doesn't look like we carry that item. Please try again.");
                }
                do
                {
                    Console.WriteLine("Would you like to add another item to your cart?");
                    userInput = Console.ReadLine().ToUpper();
                    string firstChar = userInput.Substring(0, 1);

                    if (firstChar == "Y")
                    {
                        getInput = false;
                        keepShopping = true;
                        
                    }
                    else
                    {
                        if (firstChar == "N")
                        {
                            getInput = false;
                            keepShopping = false;    
                        }
                    }
                } while (getInput);

            } while (keepShopping);
            return cart;
        }


    }

}

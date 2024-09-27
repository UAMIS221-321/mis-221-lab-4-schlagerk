//main menu

DisplayMenu();
string pizzaChoice = GetMenuChoice(); //prime loop
System.Console.WriteLine(pizzaChoice); //condition controlled loop
while (pizzaChoice != "4")
{ //update read
    RouteEm(pizzaChoice);
    DisplayMenu();
    pizzaChoice = GetMenuChoice();
}
//end main

static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("1. Display a pizza slice without toppings\n2. Display a cheese pizza slice\n3. Display a pepperoni pizza slice\n4. Exit");
}

static string GetMenuChoice()
{
    System.Console.WriteLine("Enter which pizza you would like!");
    return (Console.ReadLine());
}

static void RouteEm(string pizzaChoice)
{
    switch(pizzaChoice)
    {
        case "1":
            PlainPizza();
            Pause();
            break;
        case "2":
            CheesePizza();
            Pause();
            break;
        case "3":
            PepPizza();
            Pause();
            break;
        default:
            System.Console.WriteLine("Invalid selection");
            Pause();
            break;
    }
}

static void PlainPizza()
{
    int maxNum = GetRandomNumber();
    for(int i = maxNum; i > 0; i--){
    System.Console.Write("*");
        for(int j = i-1; j > 0; j--){
            System.Console.Write("\t"+"*");
        }
    System.Console.WriteLine( );
   }
}

static void CheesePizza()
{
    int maxNum = GetRandomNumber();
    for(int i = maxNum; i > 0; i--){
    System.Console.Write("*");
        for(int j = i-1; j > 0; j--){
            if(i == maxNum)
            {
                Console.Write("\t"+"*");
            }
            else if(j == 1)
            {
                System.Console.Write("\t"+"*");
            }
            else
            {
                Console.Write("\t"+"#");
            }
        }
    System.Console.WriteLine( );
   }  
}

static void PepPizza()
{
    int maxNum = GetRandomNumber();
    for(int i = maxNum; i > 0; i--){
    System.Console.Write("*");
        for(int j = i-1; j > 0; j--){
            if(i == maxNum)
            {
                Console.Write("\t"+"*");
            }
            else if(j == 1)
            {
                System.Console.Write("\t"+"*");
            }
            else
            {
                for(int k = i-1; k > 0; k--)
                    RandomPep();
                    {
                    int topping = RandomPep();
                    if (topping == 1)
                        {
                        Console.Write("\t"+"#");
                        }
                    else if(topping == 0)
                        {
                        Console.Write("\t"+"[]");
                        }
                    
                    }
            }
        }
    System.Console.WriteLine( );
   }  
}

static void Pause()
{
    System.Console.WriteLine("Press any key to continue ;)");
    Console.ReadKey();
}

static int GetRandomNumber()
{
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    return number;
}

static int RandomPep()
{
    Random rnd = new Random();
    int topping = rnd.Next(2);
    return topping;
}
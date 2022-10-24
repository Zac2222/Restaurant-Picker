// Reviewed: Patrick De Leon
// Comment: I like how clean and easy this looks. I love that "pizza but dining" restaurant lol 

bool isNumber;
int userNum;
bool runAgain = true;
    while(runAgain == true)
    {

        string[] fastFood = {"McDonald\'s", "Jack in the box", "wendy\'s", "Burger King", "A&W", "Carls Jr", "KFC", "Taco Bell", "Pizza", "Popeyes"};
        string[] dining = {"Chillies", "AppleBees", "Olive Garden", "Buffalo Wild Wings", "Outback Steak House", "Red Robins", "Ihop", "Dennys", "Joes Crab Shack", "Pizza But Dining"};
        string[] dessert = {"Cold Stone", "Baskin Robins", "Dunkin Donuts", "Sweet Labs", "Fosters Freeze", "Crumbl", "Menchies", "Oh My Yogurt", "Swird", "Star Donuts"};

        Random ranNum = new Random();

        Console.WriteLine("Please Select a category and a random restaurant choice will be decided for you.");
        Console.WriteLine("Press 1 for fast food: \nPress 2 for dining: \npress 3 for dessert:");

        do
        {
            isNumber = int.TryParse(Console.ReadLine(), out userNum);
            if(isNumber == false)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }while(isNumber == false);


        Random rand = new Random();
        if(userNum == 1)
        {
            int randNum = rand.Next(fastFood.Length);

            Console.WriteLine($"Your fast food choice is: {fastFood[randNum]}");
        }

        if(userNum == 2)
        {
            int randNum = rand.Next(dining.Length);

            Console.WriteLine($"Your fast food choice is: {dining[randNum]}");
        }

        if(userNum == 3)
        {
            int randNum = rand.Next(dessert.Length);

            Console.WriteLine($"Your fast food choice is: {dessert[randNum]}");
        }

        string choice = "";
	    Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }
using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int room = 1;
        string response = "";
        bool gameFinished = false;
        bool hasKey = false;
        int randomNumb = random.Next(1, 10);

        Console.WriteLine("your running from the police because you stole a Fortnite V-Buck Gift Card your only options for escape are a helicopter or a car with cool and shiny rims. so whats your choice a helicopter or a car?");
       
        while(gameFinished == false)
        {
            Console.WriteLine("Part: " + room);
            
            response = Console.ReadLine();  


            switch (room)
            {
                case 1:
                    switch (response)
                    {
                        case "car":
                            if (response == "car")
                            {
                                room = 2;
                                Console.WriteLine("The car with shiny rims breaks down after a car chase once you get out of the car you either have to hide in a pawnshop or a box. so what do you choose a pawnshop or box");
                            }
                            break;
                         case "helicopter":
                            if (response == "helicopter")
                            {
                                room = 2;
                                Console.WriteLine(" The helicopter gets shot down once your back on land you have to hide in a pawnshop or a box.  so what do you choose a pawnshop or box.");
                            }
                            break;

                    }
                    break;
               
                case 2:
                    switch (response)
                    {
                        case "pawnshop":
                            if (response == "pawnshop")
                            {
                                room = 3;
                                Console.WriteLine(" You enter the Gold and Silver Pawnshop and Rick Harrison is there with a gun for you to use to fight off the ops for $" + randomNumb + " you realize that you barely have enough money to buy it. Type yes if you want the gun Type no if you dont want the gun." );
                            }
                            break;

                        case "box":
                            if (response == "box")
                            {
                                room = 3;
                                Console.WriteLine("You enter the box amd theres landmine. so if you want to step on it type step if you dont want to step on type nah. ");
                            }
                            break;
                    }
                    break;
                
                case 3:
                    switch (response)
                    {
                        case "no":
                            if (response == "no")
                            {
                                room = 4;
                                Console.WriteLine("you said no to rick and rick doesnt take no for an answer so he shot you right there on the spot. GAME OVER! ");
                                gameFinished = true;
                            }
                            break;

                        case "yes":
                            if (response == "yes")
                            {
                                room = 4;
                                Console.WriteLine ("You said yes rick,  gives you the gun and you use it to fight of the police.  you beat the police in a shootout but you suffer many injuries you options are to go to the hospital or go home. what do you choose hospital or home.");
                            }
                            break;
                        case "step":
                            if (response == "step")
                            {
                                room = 4;
                                Console.WriteLine("You stupidly stepped on the landmine and it blew up  GAME OVER! ");
                                gameFinished = true;
                            }
                            break;
                        case "nah":
                            if (response == "nah")
                            {
                                room = 4;
                                Console.WriteLine("You decided not to step on the landmine but you look around more in the box but then all of a sudden the land mine blows up randomly GAME OVER! ");
                                gameFinished = true;
                            }
                            break;
                    }
                    break;
               
                case 4:
                    switch (response)
                    {
                        case "hospital":
                            if (response == "hospital")
                            {
                                room = 5;
                                Console.WriteLine ("You go to the hospital and you tell the doctors a crazy man shot you and they believe it and you once you recover you leave the hospital without getting in trouble ----CONGRATS YOU WIN----");
                                gameFinished = true;
                            }
                            break;
                        case "home":
                            if (response == "home")
                            {
                                room = 5;
                                Console.WriteLine("  you go home and you patch up your wounds because you took cpr class in high school and after a few months you recover while in recovery you use the v-bucks you stole to buy a really cool skin ----CONGRATS YOU WIN----");
                                gameFinished = true;
                            }
                            break;

                    }
                    break;


            }
        }
    }
}
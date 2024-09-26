// the actual code
Console.ForegroundColor
= ConsoleColor.Blue;
Console.WriteLine("you are set in a dimly lit room aorund you is a skeleton with a small bag and 2 doors that lead left and right");
Console.WriteLine("type A to go left B to go right and C to investagate");
Console.WriteLine("what do you do? please use capitals :)");

string playerInput = Console.ReadLine();
{
    if (playerInput == "A")
    {

        Console.WriteLine("down the hallw3ay the brick interiro becomes natural and the sound of water can be heard");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("the door behind you shuts and a large THUNK can be heard theres no way back");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("you are now in a Cenote a undeground body of water with a figure beneath it you could continue down the path or investiagte the water ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("type A to continue down the path or B to look at the figure in the water use capitals please");
        string playerInputRoute1 = Console.ReadLine();
        if (playerInputRoute1 == "A")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("you continue down the path and come to a exit to the dungeon");
            Console.WriteLine("YOU ESCAPED");
        }
        else if (playerInputRoute1 == "B")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("the figure lunges out of the water and the maw of a shark is the last thing you see");
            Console.WriteLine("YOU HAVE PERISHED");
        }

    }

    else if (playerInput == "B")
    {
        Console.WriteLine("down the hallway the area becomes frigid and the floor is coverd in a thin veil of ice");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("the door behind you shuts and a large THUNK can be heard, theres no way back");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("you are now in a man made tunnel of ice surrunded by water as deep as the eye can see what do you do?");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("type A to continue down the path or B to crack the ice tunnel");
        string playerInputRoute2 = Console.ReadLine();
        if (playerInputRoute2 == "A")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("as you wonder who made this tunnel a evil ice wizzard appears at the end of the tunnel and encloses you into a icey tomb");
            Console.WriteLine("YOU HAVE PERISHED");
        }
        else if (playerInputRoute2 == "B")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("you crack the ice and the area is filled with suprisngly warm water you pass out and wake up in a cruise ship");
            Console.WriteLine("YOU ESCAPED");
        }

    }

    else if (playerInput == "C")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("the satchel you find appears to be a set of live and armed BOMBS what do you do?!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("type A to throw and B to EAT");

        string playerInputRoute3 = Console.ReadLine();
        if (playerInputRoute3 == "A")
        {
            Console.WriteLine("you throw it at the wall behind you and use the skeleton as cover");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BOOM");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("a hole revaeals a path outside");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("you have a door to your left and right as well as a entrance out side");
            Console.WriteLine("type A to go left B to go right and C to go out;");
            string playerInput2 = Console.ReadLine();
            {
                if (playerInput2 == "A")
                {

                    Console.WriteLine("down the hallw3ay the brick interiro becomes natural and the sound of water can be heard");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the door behind you shuts and a large THUNK can be heard theres no way back");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("you are now in a Cenote a undeground body of water with a figure beneath it you could continue down the path or investiagte the water ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("type A to continue down the path or B to look at the figure in the water use capitals please");
                    string playerInputRoute1 = Console.ReadLine();
                    if (playerInputRoute1 == "A")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you continue down the path and come to a exit to the dungeon");
                        Console.WriteLine("YOU ESCAPED");
                    }
                    else if (playerInputRoute1 == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("the figure lunges out of the water and the maw of a shark is the last thing you see");
                        Console.WriteLine("YOU HAVE PERISHED");
                    }

                }

                else if (playerInput2 == "B")
                {
                    Console.WriteLine("down the hallway the area becomes frigid and the floor is coverd in a thin veil of ice");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the door behind you shuts and a large THUNK can be heard, theres no way back");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("you are now in a man made tunnel of ice surrunded by water as deep as the eye can see what do you do?");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("type A to continue down the path or B to crack the ice tunnel");
                    string playerInputRoute2 = Console.ReadLine();
                    if (playerInputRoute2 == "A")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("as you wonder who made this tunnel a evil ice wizzard appears at the end of the tunnel and encloses you into a icey tomb");
                        Console.WriteLine("YOU HAVE PERISHED");
                    }
                    else if (playerInputRoute2 == "B")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("you crack the ice and the area is filled with suprisngly warm water you pass out and wake up in a cruise ship");
                        Console.WriteLine("YOU ESCAPED");
                    }

                }

                else if (playerInput2 == "C")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("outside the peacefull forrest was actualy all a bomb and pressed on a pressure plate and like super explode");
                }

                else if (playerInputRoute3 == "B")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("in all of the ideas you have you shove the live ordanace in your mouth uhhhhhh welll ");
                    Console.WriteLine("YOU HAVE PERISHED");
                }
            }
        }
    }
}
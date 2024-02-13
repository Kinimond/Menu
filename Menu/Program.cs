namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output;
            int input;
            int runGame;

            Console.WriteLine("Skriv 1 for at starte spillet. Skriv 0 for at afslutte spillet");
            runGame = int.Parse(Console.ReadLine());
            switch (runGame)
            {
                case 0:
                    break;
                case 1:

                    Console.WriteLine("Du har startet dit spil, du skal nu vælge hvilken knap du vil trykke på. \n1, 2, 3 eller 4?");
                    input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            output = "Du starter spillet";
                            break;
                        case 2:
                            output = "Du går til indstillinger.";
                            break;
                        case 3:
                            output = "Du har lukket spillet. ";
                            break;
                        case 4:
                            output = "Du døde. ";
                            break;
                        default:
                            output = "Du trykkede ikke på nogen knap.";
                            break;
                    }
                    Console.WriteLine(output);
                    Console.Clear();
                    goto case 1;
                }
            } 
        }
    }

    


            /*
            int input;
            string output;
            
            Console.WriteLine("Du har startet dit spil, du skal nu vælge hvilken knap du vil trykke på. \n1, 2, 3 eller 4?");
            
            input = int.Parse(Console.ReadLine());
            output = "Du trykkede ikke på nogen knap.";
            {
                if (input == 1) { output = "Du starter spillet"; }
                else if (input == 2) { output = "Du går til indstillinger."; }
                else if (input == 3) { output = "Du har lukket spillet. "; }
                else if (input == 4) { output = "Du døde. "; }
                
            Console.WriteLine(output);
                */
            
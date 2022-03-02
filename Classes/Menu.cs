using mis321_pa2_ncward1.interfaces;
namespace mis321_pa2_ncward1
{
    public class Menu
    {
        public int userChoice;
        public int attacker;
        public Character currAttacker;
        public Character currDefender;
        public Character char1;
        public Character char2;
        public string player1;
        public string player2;

        public void CharacterSelection()
        {
            System.Console.WriteLine("Player 1 please enter your name");
            player1 = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Player 2 please enter your name");
            player2 = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine($"Hello {player1} & {player2}");

            Character char1 = new Character();
            string check = "";
            while(check!= "Jack Sparrow" && check!= "Will Turner" && check!= "Davy Jones")
            {
                System.Console.WriteLine($"Please choose a name: Jack Sparrow , Will Turner , Davy Jones");
                check = Console.ReadLine();
            }
            char1.Name=check;

            Character char2 = new Character();
            string check2 = "";
            while(check2!= "Jack Sparrow" && check2!= "Will Turner" && check2!= "Davy Jones")
            {
                System.Console.WriteLine($"Please choose a name: Jack Sparrow , Will Turner , Davy Jones");
                check2 = Console.ReadLine();
            }
            char1.Name=check2;

            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Press any key to determine who will attack first");
            Console.ReadKey();


            Random rnd = new Random();
            int attacker = rnd.Next(0,2);

            

        }

  

    }
}
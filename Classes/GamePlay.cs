using mis321_pa2_ncward1.interfaces;
namespace mis321_pa2_ncward1
{
    public class GamePlay : Menu
    {
         public void Attack(Character char1, Character char2, string player1, string player2)
        {
            


            while(char1.Health > 0 && char2.Health > 0)
            {

                if(attacker == 0)
                {
                    
                    currAttacker = char1;
                    currDefender = char2;
                    attacker = 1;
                    Console.WriteLine($"{char1.Name} turn to strike");
                }
                else if(attacker == 1)
                {
                    currAttacker = char2;
                    currDefender = char1;
                    attacker = 0;
                    System.Console.WriteLine($"{char2.Name} turn to strike");
                }

                double damage = (currAttacker.AttackStrength - currDefender.DefensePower);
                if(damage<=0)
                {
                    damage=1;
                }
                if(currAttacker.Name == "Jack Sparrow" && currDefender.Name == "Will Turner")
                {
                    damage = damage * 1.2;
                }
                else if(currAttacker.Name == "Will Turner" && currDefender.Name == "Davy Jones")
                {
                    damage = damage * 1.2;
                }
                else if(currAttacker.Name == "Davy Jones" && currDefender.Name == "Jack Sparrow")
                {
                    damage = damage * 1.2;
                }
                else if(damage >= currDefender.Health)
                {
                    currDefender.Health = 0;
                    System.Console.WriteLine($"Congrats {currAttacker.Name} you won\nThanks for playing");
                }
                else
                {
                    damage = damage *1;
                }
                currDefender.Health = currDefender.Health - damage;
                System.Console.WriteLine(currAttacker.Name + " attacked " + currDefender.Name + " for "+ damage+ " damage ");
                System.Console.WriteLine(currDefender.Name + " now has " + currDefender.Health + " health left "); 
                Console.ReadKey();
                Console.Clear();
                int choice = 0;
                while(choice!=3 && char1.Health > 0 && char2.Health > 0)
                {
                    System.Console.WriteLine($"1: Check {currAttacker.Name} stats\n2: Check {currDefender.Name} stats\n3: Continue Fight");
                    choice = int.Parse(Console.ReadLine());

                    if(choice == 1)
                    {
                        System.Console.WriteLine("Name: "+currAttacker.Name+"\nHealth: "+currAttacker.Health+"\nAttack Strength: "+currAttacker.AttackStrength+"\nDefense Power: "+currAttacker.DefensePower);
                    }
                    else if(choice == 2)
                    {
                        System.Console.WriteLine("Name: "+currDefender.Name+"\nHealth: "+currDefender.Health+"\nAttack Strength: "+currDefender.AttackStrength+"\nDefense Power: "+currDefender.DefensePower);
                    }
                    else if (choice == 3)
                    {
                        System.Console.WriteLine("Let the fight commence");
                    }
                    else
                    {
                        System.Console.WriteLine($"1: Check {currAttacker.Name} stats\n2: Check {currDefender.Name} stats\n3: Continue Fight");
                        choice = int.Parse(Console.ReadLine());
                    }
                }   
            }
        }
    }
}
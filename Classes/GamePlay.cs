using mis321_pa2_ncward1.interfaces;
namespace mis321_pa2_ncward1
{
    public class GamePlay : Character
    {
         public void Attack()
        {

            while(char1.Health > 0 && char2.Health > 0)
            {
                if(attacker == 0)
                {
                    Console.WriteLine($"{player1} you will attack first");
                    currAttacker = char1;
                    currDefender = char2;
                    attacker = 1;
                }
                else if(attacker == 1)
                {
                    System.Console.WriteLine($"{player2} you will attack first");
                    currAttacker = char2;
                    currDefender = char1;
                    attacker = 0;
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
                else
                {
                    damage = damage *1;
                }

                System.Console.WriteLine(currAttacker.Name + " attacked " + currDefender + " for "+ damage+ " damage ");
                System.Console.WriteLine(currDefender.Name + " now has " + currDefender.Health + " health left ");    
            }
        }
    }
}
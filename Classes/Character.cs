using mis321_pa2_ncward1.interfaces;
namespace mis321_pa2_ncward1
{
    public class Character : Menu
    {

        public string Name {get; set;}
        public int MaxPower {get; set;}
        public int Health {get; set;}
        public int AttackStrength {get; set;}
        public int DefensePower {get; set;}

        public Character()
        {
            Name = "";
            Random rnd = new Random();
            MaxPower = rnd.Next(0,101);
            Health = 100;
            AttackStrength = rnd.Next(0,MaxPower);
            DefensePower = rnd.Next(MaxPower);
        }
        


    }
}
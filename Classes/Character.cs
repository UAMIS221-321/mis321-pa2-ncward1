using mis321_pa2_ncward1.interfaces;
namespace mis321_pa2_ncward1
{
    public class Character : Menu
    {

        public string Name {get; set;}
        public Random rnd = new Random();
        public int MaxPower {get; set;}
        public double Health = 100;
        public double AttackStrength {get; set;}
        public double DefensePower {get; set;}
    

        public Character()
        {
            Name = "";
            MaxPower = rnd.Next(1,101);
            AttackStrength = rnd.Next(1,MaxPower);
            DefensePower = rnd.Next(MaxPower);
        }
        


    }
}
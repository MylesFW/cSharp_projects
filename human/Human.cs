namespace FirstCSharp
{
    public class Human
        {
        public string Name;
        public int Str;
        public int Intel;
        public int Dex;
        private int health;
        public int Health {get; set;}

        public Human(string name)
        {
            Name = name;
            Str = 3;
            Intel = 3;
            Dex = 3;
            Health = 100;
        }
        public Human(string name, int str, int intel, int dex, int health)
        {
            Name = name;
            Str = str;
            Intel = intel;
            Dex = dex;
            Health = health;
        }
        public int Attack(Human target)
        {
            target.Health -= 5 * this.Str;
            return target.Health;
        }
    }
    
}
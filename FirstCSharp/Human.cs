namespace FirstCSharp
{
    public class Human
        {
        public string _Name;
        public int _Str;
        public int _Intel;
        public int _Dex;
        private int _health;
        public int _Health {get; set;}

        public Human(string name)
        {
            _Name = name;
            _Str = 3;
            _Intel = 3;
            _Dex = 3;
            _Health = 100;
        }
        public Human(string name, int str, int intel, int dex, int health)
        {
            _Name = name;
            _Str = str;
            _Intel = intel;
            _Dex = dex;
            _Health = health;
        }
        public int Attack(Human target)
        {
            target._Health -= 5 * this._Str;
            return target._Health;
        }
    }
    
}
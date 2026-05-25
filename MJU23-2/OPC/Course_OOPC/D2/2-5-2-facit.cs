using System.Runtime.InteropServices;

namespace OPC1_uppg_2_5_2_facit
{
    internal class Program
    {
        static Random rnd = new Random();
        class Monster
        {
            public string name;
            public int HP;
            public int damage;
            public Monster(string name, int HP, int damage)
            {
                this.name = name;
                this.HP = HP;
                this.damage = damage;
            }
            public override string ToString()
                => $"name={name}, HP={HP}, damage={damage}";
            public void Hit(Monster other)
            {
                other.HP -= rnd.Next(1, damage);
            }
            public bool IsDead() => HP <= 0;
            public String Name { get { return name; } }
        }
        static void Main(string[] args)
        {
            Monster Ugluk = new Monster("Ugluk", 16, 4);
            Monster Aragorn = new Monster("Aragorn", 14, 6);
            Console.WriteLine($"{Ugluk} {Aragorn}");
            Ugluk.Hit(Aragorn);
            Aragorn.Hit(Ugluk);
            Console.WriteLine($"{Ugluk} {Aragorn}");
        }
    }
}
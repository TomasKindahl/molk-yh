using System.Threading;

namespace lektion_2_interfacet
{
    internal class Program
    {
        class Monster
        {
            public void Hit(int amount) {  }
        }
        class Player : Monster
        {
            AttackItem sword;
            public Player() {
                sword = new Sword();
            }
            public bool Attack(Monster m)
            {
                return true;
            }
        }
        interface AttackItem
        {
            // ··· kan ha attribut, har alltid en konstruktor ···
            public bool Hit(Monster m)
            {
                m.Hit(Damage);
                return true;
            }
            public abstract void Blunt(int amount);
            public int Damage { get; set; }
        }
        class Sword : AttackItem
        {
            public int Damage { get { return 4; } set { } }
            public void Blunt(int amount)
            {
                // 
            }
        }
        static void Main(string[] args)
        {
            Player I = new Player();
            Monster enemy = new Monster();
            I.Attack(enemy);
        }
    }
}

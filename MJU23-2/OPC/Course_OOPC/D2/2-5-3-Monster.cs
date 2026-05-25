using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC1_uppg_2_5_3_facit
{
    class Monster
    {
        static Random rnd = new Random();
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
}

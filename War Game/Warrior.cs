using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game
{
    internal class Warrior
    {
        

        private string warriorName;
        private int health;
        private int maxAttack;
        private int maxBlock;

        public Warrior()
        {
            warriorName = "No name";
        }
        public Warrior(string warriorName , int health , int maxAttack, int maxBlock)
        {
            this.warriorName = warriorName;
            this.health = health;
            this.maxAttack = maxAttack;
            this.maxBlock = maxBlock;
        }

        public bool IsAlive()
        {
            return health > 0;
        }

        public int Attack()
        {
            Random random = new Random();

            int attack = random.Next(1, maxAttack);
            PrintAttack(attack);
            return attack;
        }

        public int Block()
        {
            Random random = new Random();

            int block =  random.Next(1, maxBlock);
            PrintBlock(block);
            return block;
        }

        public void MakeDamage(int damage)
        {
            if (damage < 0) 
                return;

            health -= damage;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name : {warriorName}");
            Console.WriteLine($"Health : {health}");
            Console.WriteLine($"Max Attack : {maxAttack}");
            Console.WriteLine($"Max Block : {maxBlock}");
        }

        public void PrintHealth()
        {
            Console.WriteLine($"Warrior {warriorName} has health {health}");
        }
        public void AnnounceWinner()
        {
            Console.WriteLine($"Warrior {warriorName} is the Winner!!");
        }
        private void PrintAttack(int attack)
        {
            Console.WriteLine($"Warrior {warriorName} attacked " +
                $"with value {attack}");

        }

        private void PrintBlock(int block)
        {
            Console.WriteLine($"Warrior {warriorName} blocked " +
                $"with value {block}");
        }

        
    }
}

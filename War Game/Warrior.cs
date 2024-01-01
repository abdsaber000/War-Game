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
            health = 0;
            maxAttack = 0;
            maxBlock = 0; 
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
            int attack = GetRandomMove(maxAttack);
            PrintAction("attack", attack);
            return attack;
        }

        public int Block()
        {
            int block = GetRandomMove(maxBlock);
            PrintAction("block", block);
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

        private int GetRandomMove(int maxMove)
        {
            Random random = new Random();
            int randomMove = random.Next( 1, maxMove);
            return randomMove;
        }
        private void PrintAction(string action , int value)
        {
            Console.WriteLine($"Warrior {warriorName} {action}ed " +
                $"with value {value}");
        }
    }
}

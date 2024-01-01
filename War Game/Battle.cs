using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game
{
    internal class Battle
    {
        private Warrior firstWarrior;
        private Warrior secondWarrior;
        private int roundNumber;
        private const int FIRST_TURN = 1;
        private const int SECOND_TURN = 0;
        public Battle(Warrior firstWarrior ,  Warrior secondWarrior)
        {
            this.firstWarrior = firstWarrior;
            this.secondWarrior = secondWarrior;
            roundNumber = 0;
        }

        public void StartGame()
        {
            PrintStartStatus();
            StartBattle();
            AnnounceWinner();
        }
        private void StartBattle()
        {
            while (IsWarriorsAlive())
            {
                roundNumber++;
                Fight();
            }
        }

        private void AnnounceWinner()
        {
            Console.WriteLine("Game is Over !!!");

            if (firstWarrior.IsAlive())
            {
                firstWarrior.AnnounceWinner();
            }
            else
            {
                secondWarrior.AnnounceWinner();
            }
            
        }
        private bool IsWarriorsAlive()
        {
            return firstWarrior.IsAlive() && secondWarrior.IsAlive();
        }
        private void Fight()
        {
            PrintFightStatus();
            HandleFight();
        }

        private void HandleFight()
        {
            if (GetTurn() == FIRST_TURN)
            {
                HandleDamage(ref firstWarrior, ref secondWarrior);
            }
            else
            {
                HandleDamage(ref secondWarrior, ref firstWarrior);
            }
        }
        private int GetTurn()
        {
            return roundNumber % 2;
        }
        private static void HandleDamage(ref Warrior attackWarrior 
            , ref Warrior blockWarrior)
        {
            int damage = GetDamage(attackWarrior, blockWarrior);
            blockWarrior.MakeDamage(damage);
        }
        private static int  GetDamage(Warrior attackWarrior , Warrior blockWarrior)
        {
            int attack = attackWarrior.Attack();
            int block = blockWarrior.Block();
            int damage = attack - block;
            return damage;
        }
        private void PrintFightStatus()
        {
            Console.WriteLine($"Round {roundNumber}");
            firstWarrior.PrintHealth();
            secondWarrior.PrintHealth();
        }
        private void PrintStartStatus()
        {
            Console.WriteLine("Game Started !!!");
            Console.WriteLine("Warrior 1 info:");
            firstWarrior.PrintInfo();
            Console.WriteLine("Warrior 2 info:");
            secondWarrior.PrintInfo();
        }

    }
}

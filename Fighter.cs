using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public interface IAttackStrategy
    {
        void Attack();
    }
    public class SwordAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with sword!");
        }
    }

    public class BowAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with bow!");
        }
    }

    public class FireballAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Attacking with fireball!");
        }
    }
    public class Character
    {
        private IAttackStrategy attackStrategy;

        public Character(IAttackStrategy attackStrategy)
        {
            this.attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            attackStrategy.Attack();
        }
    }

    class Fighter
    {
        void Main()
        {
            var knight = new Character(new SwordAttackStrategy());
            knight.Attack(); // Output: Attacking with sword!

            var archer = new Character(new BowAttackStrategy());
            archer.Attack(); // Output: Attacking with bow!

            var mage = new Character(new FireballAttackStrategy());
            mage.Attack(); // Output: Attacking with fireball!

        }
    }
    public interface IAbility
    {
        void Use();
    }

    public class Fireball : IAbility
    {
        public void Use()
        {
            Console.WriteLine("Casting fireball!");
        }
    }












    /// <summary>
    /// another
    /// </summary>
    public class SwordAttack : IAbility
    {
        public void Use()
        {
            Console.WriteLine("Swinging sword!");
        }
    }

    public class Characterr
    {
        private IAbility ability;

        public void SetAbility(IAbility ability)
        {
            this.ability = ability;
        }

        public void UseAbility()
        {
            ability.Use();
        }
    }

    class Programm
    {
        static void Main(string[] args)
        {
            // create characters
            Characterr knight = new Characterr();
            Characterr wizard = new Characterr();

            // assign abilities
            knight.SetAbility(new SwordAttack());
            wizard.SetAbility(new Fireball());

            // use abilities
            knight.UseAbility(); // output: Swinging sword!
            wizard.UseAbility(); // output: Casting fireball!
        }
    }

}

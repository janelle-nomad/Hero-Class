using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Janelle Heron
 * 300839820
 * Hero Class 
 * 
 * Program Description: This is the Hero Class, contains several different methods there in to generate the hero's abilities,
 * generate the hero's hit chance against a target, hitDamage against the target, as well as allows the player or user to name their hero. 
 * 
 * version 0.1 - Built the Hero class, & fixed spelling errors 
 */


namespace Hero_Class
{
    // Hero Class
    class Hero
    {
        /**
         * <summary> Creating Private Properties </summary>
         * 
         * 
         * 
         */

                private int _strength;
                private int _speed;
                private int _health;
                private string _name;

        /**
         * <summary> Creating Public Properties </summary>
         * 
         * @assigns _strength as a value
         */

        public int Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }

        public int Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }

        public int Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /**
         * Description: This is the hero constructor for the hero class takes a string param in the 
         * @Constructor Hero
         */
         
        public Hero(string name) 
        {
            this.Name = name; /* Declared that the private _name, is associated with "name",
             //                     which is a public property */
            int strength;
            int speed;
            int health;

            this.Strength = Strength;
            this.Speed = Speed;
            this.Health = Health;
           
            _generateAbilities();
            Console.WriteLine();
            show(); 
        }
        private void _generateAbilities() //declaring the private method, generate abilities
        {
            Random stats = new Random();//Random generator in order to generate random numbers for the hero's abilities
            
            this.Strength = stats.Next(1, 101); //strength can be an integer ranging between 1 - 100
            this.Speed = stats.Next(1, 101);    // speed can be an integer ranging between 1 - 100
            this.Health = stats.Next(1, 101);  //health can be an integer ranging between 1 - 100
        }
        /**
         *  hit Attempt Method: This will determine the success of the attack
         *  
         */

        private void _hitAttempt()
        {
            Random rnd = new Random();
            int hitChance = rnd.Next(1, 101); // generates random int between 1 and 100
            Console.WriteLine("Your hit chance is {0}", hitChance);
            if (hitChance > 80) //Player hits with 20% accuracy
            {
                
                Console.WriteLine("You landed a hit!, Great Job!"); // Here the _hitAttempt = true, so the _damage method is called
                _hitDamage(); // on a hit, calls the hitDamage method
            }
            else
            {
                Console.WriteLine("You missed...better luck next time! =("); // on a miss, prints result and terminates
            }
        }

        // _hitDethod to determine the damage, that the hero can dish out
        private int _hitDamage()
        {
            int potentialDmg, damageBoost, dmgDealt;
            Random rnd = new Random();
            potentialDmg = rnd.Next(6) + 1; //The hero's potential damage is a number between 1 and 6 this number will then be multiplied by the heo's strength 
            damageBoost = this.Strength; //
            dmgDealt = potentialDmg * damageBoost; // multiplies damage with hero strength
            Console.WriteLine("You damage is {0}\nYou dealt {1} damage!", potentialDmg, dmgDealt);
            return dmgDealt; //sends final damage result with modifiers
           
        }

        /***|PUBLIC METHODS|***/

        // method to start a fight
        public void fight()
        {
            _hitAttempt(); //calls hitAttempt method
        }

        public void show() // method to show character's current stats
        {
            Console.WriteLine("{0}'s Stats\nStrength  Speed  Health \n========  =====  ======\n{1, 6}{2, 8}{3, 8}", this.Name, this.Strength, this.Speed, this.Health); // displays stats with some visual fluff
        }
    }
}

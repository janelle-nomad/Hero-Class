using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Janelle Heron
 * 300839820
 * Hero Class 
 */

namespace Hero_Class
{
    /**
     * @This class is the "driver" class for the program
     * 
     * @class Program
     *version 0.2 - Built the Hero class, & fixed spelling errors 
     */

    public class Program
    {
        /**
         * The main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {
            string heroName; //creating variable heroName

            Console.Write("Enter your hero's name: ");
            heroName = Console.ReadLine(); //assigns user input to name string, which will be used in the hero class

            Hero userHero = new Hero(heroName); //creates a new hero instance with the user's input as the hero's name
            userHero.fight(); //Calls the fight method, which will process the inner methods, _hitAttempt, _hitDamage, _hitDamage.
         
        }
    }
}
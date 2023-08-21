using System;

namespace Enemies
{
    /// <summary>
    /// Represent Zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represent the health of the zombie
        /// </summary>
        public int health;

        /// <summary>
        /// Constructor of a Zombie
        /// </summary>
        public Zombie() {
            health = 0;
        }

        /// <summary>
        /// Zombie Constructor with parameter
        /// </summary>
        /// <param name="value"> Health </param>
        /// <exception cref="ArgumentException"> If health inferior 0 </exception>
        public Zombie(int value) {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}

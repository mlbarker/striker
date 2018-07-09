//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Samurai.cs
//-----–----------–------------------
namespace striker_poc.Jobs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using Mounds;

    public class Samurai : IJob
    {
        #region Public Properties

        /// <summary>
        /// The job name.
        /// </summary>
        public string Name { get; protected set; } = "Samurai";

        #endregion

        #region Interface Methods

        /// <summary>
        /// Moves mole into the mound
        /// </summary>
        public void MoveInMound()
        {
            Console.WriteLine(Name + " goes into the mound.");
        }

        /// <summary>
        /// Moves mole out of the mound
        /// </summary>
        public void MoveOutMound()
        {
            Console.WriteLine(Name + " comes out of the mound.");
        }

        /// <summary>
        /// Moves mole to a different mound
        /// </summary>
        public void MoveToDifferentMound()
        {
            Console.WriteLine(Name + " moves to a different mound.");
        }

        /// <summary>
        /// Triggers mole to throw a designated weapon
        /// </summary>
        public void Throw()
        {
            Console.WriteLine(Name + " performs Flying Slash!");
        }

        /// <summary>
        /// Triggers the mole to counter attack.
        /// </summary>
        public void Counter()
        {
            Console.WriteLine(Name + " performs Counter Slash.");
        }

        /// <summary>
        /// Triggers the mole to charge, then attack
        /// </summary>
        public void Charge()
        {

        }

        /// <summary>
        /// Triggers the mole to evade attacks
        /// </summary>
        public void Evade()
        {

        }

        #endregion
    }
}

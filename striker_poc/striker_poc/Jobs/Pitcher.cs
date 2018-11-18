//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Pitcher.cs
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

    public class Pitcher : IJob
    {
        #region Fields
        #endregion

        #region Interface Properties

        /// <summary>
        /// The job name.
        /// </summary>
        public string Name { get; protected set; } = "Pitcher";

        #endregion

        #region Interface Methods

        /// <summary>
        /// Moves mole into the mound
        /// </summary>
        public void MoveInMound()
        {
            Console.WriteLine(Name + " goes into mound.");
        }

        /// <summary>
        /// Moves mole out of the mound
        /// </summary>
        public void MoveOutMound()
        {
            Console.WriteLine(Name + " comes out of mound.");
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
            Console.WriteLine(Name + " throws a baseball!");
        }

        /// <summary>
        /// Triggers the mole to counter attack.
        /// </summary>
        public void Counter()
        {
            Console.WriteLine(Name + " has no counter ability.");
        }

        /// <summary>
        /// Triggers the mole to charge, then attack
        /// </summary>
        public void Charge()
        {
            Console.WriteLine(Name + " has no charge ability.");
        }

        /// <summary>
        /// Triggers the mole to evade attacks
        /// </summary>
        public void Evade()
        {
            Console.WriteLine(Name + " has no evade ability.");
        }

        #endregion
    }
}

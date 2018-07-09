//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Mole.cs
//-----–----------–------------------
namespace striker_poc.Moles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using Jobs;

    public class Mole : BaseMole
    {
        #region Constructors

        /// <summary>
        /// The base constructor for the mole
        /// </summary>
        public Mole()
        {
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// The type of mole
        /// </summary>
        public override string Type { get; protected set; } = "Mole";

        /// <summary>
        /// The job that defines the type of mole
        /// and that mole's attributes and abilities
        /// </summary>
        public override IJob Job { get; protected set; } = new NoJob();

        /// <summary>
        /// Mole throws a projectile at the player.
        /// </summary>
        public override void ThrowProjectile()
        {
            Job.Throw();
        }

        #endregion
    }
}

//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Mole.cs
//-----–----------–------------------
namespace mole_library.Moles
{
    using Interfaces;
    using Jobs;

    /// <summary>
    /// The regular mole with no jobs
    /// </summary>
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

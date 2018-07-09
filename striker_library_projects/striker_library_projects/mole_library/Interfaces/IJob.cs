//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// IJob.cs
//-----–----------–------------------
namespace mole_library.Interfaces
{
    /// <summary>
    /// The interface for all jobs for the moles
    /// </summary>
    public interface IJob
    {
        #region Interface Properties

        /// <summary>
        /// Name of the job
        /// </summary>
        string Name { get; }

        #endregion

        #region Interface Methods

        /// <summary>
        /// Moves mole into the mound
        /// </summary>
        void MoveInMound();

        /// <summary>
        /// Moves mole out of the mound
        /// </summary>
        void MoveOutMound();
    
        /// <summary>
        /// Moves mole to a different mound
        /// </summary>
        void MoveToDifferentMound();

        /// <summary>
        /// Triggers mole to throw a designated weapon
        /// </summary>
        void Throw();
    
        /// <summary>
        /// Triggers the mole to counter attack.
        /// </summary>
        void Counter();
    
        /// <summary>
        /// Triggers the mole to charge, then attack
        /// </summary>
        void Charge();
    
        /// <summary>
        /// Triggers the mole to evade attacks
        /// </summary>
        void Evade();

        #endregion
    }
}

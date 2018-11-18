//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// MoveInMoundState.cs
//-----–----------–------------------
namespace mole_library.States
{
    using Moles;

    /// <summary>
    /// The state for moles to move into their mound.
    /// </summary>
    public class MoveInMoundState : BaseState
    {
        #region Fields
        #endregion

        #region Constructors

        public MoveInMoundState()
        {

        }

        #endregion

        #region Abstract Properties

        /// <summary>
        /// The name of this state.
        /// </summary>
        public override string Name { get; protected set; } = "MoveInMoundState";

        #endregion

        #region Abstract Methods

        /// <summary>
        /// The action to perform in this state.
        /// </summary>
        /// <param name="mole">the mole who is performing the action.</param>
        public override void Action(BaseMole mole)
        {
            mole.MoveInMound();
        }

        #endregion

        #region Public Methods
        #endregion
    }
}

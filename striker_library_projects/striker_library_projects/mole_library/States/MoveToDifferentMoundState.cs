//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// MoveToDifferentMoundState.cs
//-----–----------–------------------
namespace mole_library.States
{
    using Moles;

    /// <summary>
    /// The state that all moles will use to move to
    /// a different mound.
    /// </summary>
    public class MoveToDifferentMoundState : BaseState
    {
        #region Fields
        #endregion

        #region Constructors

        public MoveToDifferentMoundState()
        {

        }

        #endregion

        #region Abstract Properties

        /// <summary>
        /// The name of this state.
        /// </summary>
        public override string Name { get; protected set; } = "MoveToDifferentMoundState";

        #endregion

        #region Abstract Methods

        /// <summary>
        /// The action to perform in this state.
        /// </summary>
        /// <param name="mole">the mole who is performing the action.</param>
        public override void Action(BaseMole mole)
        {
            mole.MoveToDifferentMound();
        }

        #endregion

        #region Public Methods
        #endregion
    }
}

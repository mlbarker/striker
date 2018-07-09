//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// MoveOutMoundState.cs
//-----–----------–------------------
namespace mole_library.States
{
    using Moles;

    /// <summary>
    /// The state that all moles use to move out of the mound.
    /// </summary>
    public class MoveOutMoundState : BaseState
    {
        #region Fields
        #endregion

        #region Constructors

        public MoveOutMoundState()
        {

        }

        #endregion

        #region Abstract Properties

        /// <summary>
        /// The name of this state.
        /// </summary>
        public override string Name { get; protected set; } = "MoveOutMoundState";

        #endregion

        #region Abstract Methods

        /// <summary>
        /// The action to perform in this state.
        /// </summary>
        /// <param name="mole">the mole who is performing the action.</param>
        public override void Action(BaseMole mole)
        {
            mole.MoveOutMound();
        }

        #endregion

        #region Public Methods
        #endregion
    }
}

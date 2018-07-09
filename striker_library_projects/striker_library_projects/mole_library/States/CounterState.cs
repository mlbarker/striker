//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// CounterState.cs
//-----–----------–------------------
namespace mole_library.States
{
    using Moles;

    /// <summary>
    /// CounterState for certain moles to utilize.
    /// </summary>
    public class CounterState : BaseState
    {
        #region Fields
        #endregion

        #region Constructors

        public CounterState()
        {

        }

        #endregion

        #region Abstract Properties

        /// <summary>
        /// The name of this state.
        /// </summary>
        public override string Name { get; protected set; } = "CounterState";

        #endregion

        #region Abstract Methods

        /// <summary>
        /// The action to perform in this state.
        /// </summary>
        /// <param name="mole">the mole who is performing the action.</param>
        public override void Action(BaseMole mole)
        {
            mole.Counter();
        }

        #endregion

        #region Public Methods
        #endregion
    }
}

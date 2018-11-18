//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// BaseState.cs
//-----–----------–------------------
namespace striker_poc.States
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moles;

    public abstract class BaseState
    {
        #region Fields
        #endregion

        #region Public Properties
        #endregion

        #region Constructors

        /// <summary>
        /// Base constructor
        /// </summary>
        public BaseState()
        {

        }

        #endregion

        #region Abstract Properties

        /// <summary>
        /// The name of this state.
        /// </summary>
        public abstract string Name { get; protected set; }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// The action to perform in this state.
        /// </summary>
        /// <param name="mole">the mole who is performing the action.</param>
        public abstract void Action(BaseMole mole);

        #endregion

        #region Public Methods

        /// <summary>
        /// The procedure to run when entering the state.
        /// </summary>
        /// <param name="mole">The mole who is entering the state.</param>
        public void Enter(BaseMole mole)
        {
            mole.ResetAllTimers();
        }

        /// <summary>
        /// The procedure to run when exiting the state.
        /// </summary>
        /// <param name="mole">The mole who is exiting the state.</param>
        public void Exit(BaseMole mole)
        {
            mole.ResetAllTimers();
        }

        #endregion
    }
}

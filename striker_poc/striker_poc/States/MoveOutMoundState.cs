﻿//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// MoveOutMoundState.cs
//-----–----------–------------------
namespace striker_poc.States
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Moles;

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

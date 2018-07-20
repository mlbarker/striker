//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Mound.cs
//-----–----------–------------------
namespace mole_library.Mounds
{
    using System.Collections.Generic;
    using Moles;

    /// <summary>
    /// The implementation where the moles will occupy.
    /// </summary>
    public class Mound
    {
        #region Fields

        /// <summary>
        /// The moles that occupy this mound.
        /// </summary>
        protected List<BaseMole> m_moles;

        /// <summary>
        /// The ID for this mound.
        /// </summary>
        protected int m_id;

        /// <summary>
        /// Toggled to true once an ID is set for the mound.
        /// </summary>
        private bool m_idIsSet; 

        #endregion

        #region Public Properties

        /// <summary>
        /// The max amount of moles allowed in this mound.
        /// </summary>
        public int MaxOccupancy { get; protected set; } = 2;

        /// <summary>
        /// The identifier for the mound.
        /// The ID should be set with its index.
        /// </summary>
        public int ID
        {
            get
            {
                return m_id;
            }

            set
            {
                if (!m_idIsSet)
                {
                    m_id = value;
                    m_idIsSet = true;
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// A basic mound for moles.
        /// </summary>
        public Mound()
        {

        }

        /// <summary>
        /// Mound that has a set mole occupancy limit.
        /// </summary>
        /// <param name="maxOccupancy">Maximum amount of moles for this hole.</param>
        Mound(int maxOccupancy)
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a mole to this mound.
        /// </summary>
        /// <param name="mole">The occupying mole.</param>
        /// <returns>true - the mole has occupied the hole.</returns>
        public bool Occupy(BaseMole mole)
        {
            return false;
        }

        /// <summary>
        /// Removes a specific mole from the hole.
        /// </summary>
        /// <returns>true - the mole was removed successfully.</returns>
        public bool Remove(BaseMole mole)
        {
            return false;
        }

        /// <summary>
        /// Will remove the last mole that was added.
        /// </summary>
        /// <returns>true - the last mole was removed successfully.</returns>
        public bool Remove()
        {
            return false;
        }

        /// <summary>
        /// Removes all moles from this mound.
        /// </summary>
        public void Clear()
        {
        }

        /// <summary>
        /// Clear this mounds ID.
        /// </summary>
        public void ClearID()
        {
            m_id = -1;
            m_idIsSet = false;
        }

        /// <summary>
        /// Checks for if this mound is empty.
        /// </summary>
        /// <returns>True - the mound is empty.</returns>
        public bool Empty()
        {
            return false;
        }

        #endregion
    }
}


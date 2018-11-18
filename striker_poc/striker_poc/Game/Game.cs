//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// Game.cs
//-----–----------–------------------
namespace striker_poc.Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using Jobs;
    using States;
    using Moles;
    
    /// <summary>
    /// The game class for Striker
    /// </summary>
    public class Game : IGame
    {
        #region Fields
        
        /// <summary>
        /// Holds the list of all states for the moles
        /// </summary>
        private List<BaseState> m_states = new List<BaseState>();
        
        /// <summary>
        /// Holds the list of all jobs for the moles
        /// </summary>
        private List<IJob> m_jobs = new List<IJob>();
        
        #endregion
        
        #region Public Methods
        
        /// <summary>
        /// Starts up game objects prior to running the game.
        /// </summary>
        public void Initialize()
        {
            InitializeStates();
            InitializeJobs();
        }
        
        /// <summary>
        /// Runs the game.
        /// </summary>
        public void Run()
        {
        }
        
        /// <summary>
        /// Shuts down all the game objects.
        /// </summary>
        public void Shutdown()
        {
        }
        
        #endregion
        
        #region Private Methods
        
        /// <summary>
        /// Creates all of the necessary states for moles.
        /// </summary>
        private void InitializeStates()
        {
            m_states.Add(new MoveInMoundState());
            m_states.Add(new MoveOutMoundState());
            m_states.Add(new CounterState());
            m_states.Add(new MoveToDifferentMoundState());
        }
        
        private void InitializeJobs()
        {
            m_jobs.Add(new NoJob());
            m_jobs.Add(new Pitcher());
            m_jobs.Add(new Samurai());
        }
        
        /// <summary>
        /// Updates all game objects while the game is running.
        /// </summary>
        private void Update()
        {
        }
        
        #endregion
    } 
}
//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// IGame.cs
//-----–----------–------------------
namespace striker_poc.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    /// <summary>
    /// The interface for all game classes
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Starts up game objects prior to running the game.
        /// </summary>
        void Initialize();
        
        /// <summary>
        /// Updates all game objects.
        /// </summary>
        void Update();
        
        /// <summary>
        /// Shut downs all game objects.
        /// </summary>
        void Shutdown();
    }
}
//+src=Game/Game.cs
//+src=States/MoveToDifferentMoundState.cs
//+src=States/MoveOutMoundState.cs
//+src=States/MoveInMoundState.cs
//+src=States/CounterState.cs
//+src=States/BaseState.cs
//+src=Mounds/Mound.cs
//+src=Moles/Mole.cs
//+src=Moles/BaseMole.cs
//+src=Jobs/Samurai.cs
//+src=Jobs/Pitcher.cs
//+src=Jobs/NoJob.cs
//+src=Interfaces/IJob.cs
//+src=Interfaces/IGame.cs

namespace striker_poc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Game;

    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            
            game.Initialize();
            game.Run();
            game.Shutdown();            
        }
    }
}
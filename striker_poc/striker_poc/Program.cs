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
    using Interfaces;
    using Jobs;
    using States;
    using Moles;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<BaseState> states = new List<BaseState>();
            states.Add(new MoveInMoundState());
            states.Add(new MoveOutMoundState());
            states.Add(new CounterState());
            states.Add(new MoveToDifferentMoundState());

            List<IJob> jobs = new List<IJob>();
            jobs.Add(new NoJob());
            jobs.Add(new Pitcher());
            jobs.Add(new Samurai());

            Mole mole = new Mole();
            for (int index = 0; index < jobs.Count; ++index)
            {
                mole.ChangeJobs(jobs[index]);

                for (int idx = 0; idx < states.Count; ++idx)
                {
                    mole.SetState(states[idx]);
                    mole.Action();
                }
            }
        }
    }
}
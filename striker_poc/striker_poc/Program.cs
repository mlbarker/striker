

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

    class Program
    {
        static void Main(string[] args)
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

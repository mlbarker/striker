//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// BaseMole.cs
//-----–----------–------------------
namespace mole_library.Moles
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Mounds;
    using States;

    /// <summary>
    /// Base implementation that all moles will inherit.
    /// </summary>
    public abstract class BaseMole
    {
        #region Fields

        /// <summary>
        /// The mounds the mole knows about in the level.
        /// </summary>
        protected List<Mound> m_mounds;

        #endregion

        #region Public Properties

        /// <summary>
        /// The mole's health
        /// </summary>
        public int Health { get; protected set; } = 20;

        /// <summary>
        /// The mole's stamina
        /// </summary>
        public int Stamina { get; protected set; } = 20;

        /// <summary>
        /// The mole's current state
        /// </summary>
        public BaseState CurrentState { get; protected set; } = new MoveOutMoundState();

        /// <summary>
        /// The mound that the mole currently occupies
        /// </summary>
        public Mound CurrentMound
        {
            get;
            protected set;
        }

        public List<Mound> Mounds
        {
            get
            {
                return m_mounds;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Base constructor
        /// </summary>
        public BaseMole()
        {

        }

        /// <summary>
        /// Constructor to set the health, stamina and the mound
        /// for the mole
        /// </summary>
        /// <param name="health">The amount of health</param>
        /// <param name="stamina">The amount of stamina</param>
        /// <param name="mound">The mound for this mole to occupy</param>
        public BaseMole(int health, int stamina, Mound mound)
        {
            Health = health;
            Stamina = stamina;
            CurrentMound = mound;
        }

        #endregion

        #region Abstract Methods/Properties

        /// <summary>
        /// The type of mole
        /// </summary>
        public abstract string Type { get; protected set; }

        /// <summary>
        /// The job that defines the type of mole
        /// and that mole's attributes and abilities
        /// </summary>
        public abstract IJob Job { get; protected set; }

        /// <summary>
        /// Mole throws a projectile at the player.
        /// </summary>
        public abstract void ThrowProjectile();

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize the mole with any attributes necessary.
        /// </summary>
        /// <param name="mounds">The mounds in the level for the mole to know about.</param>
        public void Initialize(List<Mound> mounds)
        {
            if (mounds.Count > 0)
            {
                m_mounds = mounds;
            }
        }

        /// <summary>
        /// Resets all of the mole's timers
        /// </summary>
        public void ResetAllTimers()
        {

        }

        /// <summary>
        /// The action to perform based on the current state.
        /// </summary>
        public void Action()
        {
            CurrentState.Action(this);
        }

        /// <summary>
        /// Changes the mole's job.
        /// </summary>
        /// <param name="job">The new job.</param>
        public void ChangeJobs(IJob job)
        {
            Console.WriteLine("Old job: " + Job.Name);
            Console.WriteLine("New job: " + job.Name);
            Job = job;
        }

        /// <summary>
        /// Changes the mole's state
        /// </summary>
        /// <param name="state">The new state.</param>
        public void SetState(BaseState state)
        {
            Console.WriteLine("Exiting old state: " + CurrentState.Name);
            CurrentState.Exit(this);

            Console.WriteLine("Entering new state: " + state.Name);
            CurrentState = state;
            CurrentState.Enter(this);
        }

        /// <summary>
        /// Moves the mole inside of the current mound.
        /// </summary>
        public void MoveInMound()
        {
            Job.MoveInMound();
        }

        /// <summary>
        /// Moves the mole out of the current mound.
        /// </summary>
        public void MoveOutMound()
        {
            Job.MoveOutMound();
        }

        /// <summary>
        /// Moves mole to an unoccupied mound.
        /// </summary>
        public void MoveToDifferentMound()
        {
            Job.MoveToDifferentMound();
        }

        /// <summary>
        /// Mole performs a counter attack
        /// </summary>
        public void Counter()
        {
            Job.Counter();
        }

        /// <summary>
        /// Mole charges up attack, then attacks.
        /// </summary>
        public void Charge()
        {
            Job.Charge();
        }

        /// <summary>
        /// Mole evades oncoming attack.
        /// </summary>
        public void Evade()
        {
            Job.Evade();
        }

        /// <summary>
        /// Adjusts mole's stamina.
        /// </summary>
        /// <param name="changeAmt"></param>
        public void AdjustStamina(int changeAmt)
        {
            Stamina += changeAmt;
        }

        /// <summary>
        /// Adjust mole's health.
        /// </summary>
        /// <param name="changeAmt"></param>
        public void AdjustHealth(int changeAmt)
        {
            Health += changeAmt;
        }

        #endregion
    }
}

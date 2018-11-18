//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// BaseMoleTests.cs
//-----–----------–------------------
namespace mole_library_test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using mole_library.Interfaces;
    using mole_library.Moles;
    using mole_library.Mounds;
    using mole_library.States;
    using mole_library.Jobs;

    [TestClass]
    public class MoleTests
    {
        [TestMethod]
        public void MoleInitializeMoundListIsNullTest()
        {
            // Create a mound list with no mounds.
            List<Mound> mounds = new List<Mound>();

            // initialize mole with created mounds.
            BaseMole mole = new Mole();
            mole.Initialize(mounds);

            Assert.IsNull(mole.Mounds);
        }

        [TestMethod]
        public void MoleInitializeMoundListTest()
        {
            // Create a mound list with no mounds.
            List<Mound> mounds = new List<Mound>();
            mounds.Add(new Mound());

            // initialize mole with created mounds.
            BaseMole mole = new Mole();
            mole.Initialize(mounds);

            Assert.AreEqual(mounds, mole.Mounds);
        }

        [TestMethod]
        public void MoleCurrentStateTest()
        {
            // Create a new mole and a new state to
            // set for the mole.
            BaseMole mole = new Mole();
            MoveInMoundState moveInState = new MoveInMoundState();
            mole.SetState(moveInState);

            // Objects should be the same.
            Assert.AreSame(moveInState, mole.CurrentState);
        }

        [TestMethod]
        public void MoleCurrentStateIsDifferentTest()
        {
            // Create a new mole and a new state 
            // without setting it to the mole.
            BaseMole mole = new Mole();
            MoveInMoundState moveInState = new MoveInMoundState();

            // Objects should different.
            Assert.AreNotSame(moveInState, mole.CurrentState);
        }

        [TestMethod]
        public void MoleCurrentJobTest()
        {
            // Create a new mole and 
            // new job for the mole.
            BaseMole mole = new Mole();
            IJob pitcher = new Pitcher();
            mole.ChangeJobs(pitcher);

            // Objects should be the same.
            Assert.AreSame(pitcher, mole.Job);
        }

        [TestMethod]
        public void MoleCurrentJobIsDifferentTest()
        {
            // Create a new mole and new job
            // and set the job for the mole.
            BaseMole mole = new Mole();
            IJob job = new Pitcher();
            mole.ChangeJobs(job);

            // Create a new job w/o setting it to the mole.
            job = new Samurai();

            // Objects should be different.
            Assert.AreNotSame(job, mole.Job);
        }

        [TestMethod]
        public void MoleMoveInMoundTest()
        {

        }

        [TestMethod]
        public void MoleMoveOutMoundTest()
        {

        }

        [TestMethod]
        public void MoleMoveToDifferentMoundTest()
        {

        }

        [TestMethod]
        public void MoleCounterTest()
        {

        }

        [TestMethod]
        public void MoleThrowProjectileTest()
        {

        }

        [TestMethod]
        public void MoleAdjustStaminaTest()
        {
            
        }

        [TestMethod]
        public void MoleAdjustHealthTest()
        {
            
        }
    }
}

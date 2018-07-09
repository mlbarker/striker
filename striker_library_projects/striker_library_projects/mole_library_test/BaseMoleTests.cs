//-----–----------–------------------
// ImperfectlyCoded © 2018
//
// BaseMoleTests.cs
//-----–----------–------------------
namespace mole_library_test
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using mole_library.Moles;
    using mole_library.Mounds;

    [TestClass]
    public class BaseMoleTests
    {
        [TestMethod]
        public void MoleInitializeMoundListIsNullTest()
        {
            // Create a mound list with no mounds.
            List<Mound> mounds = new List<Mound>();

            // initialize mole with created mounds.
            Mole mole = new Mole();
            mole.Initialize(mounds);

            Assert.IsNull(mole.Mounds);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PainLineCore.AcceptanceTests
{
    [TestFixture]
    public class AcceptanceTests
    {
        private World _world;

        [SetUp]
        public void SetUp()
        {
            _world = new World();
        }

        [Test]
        public void A()
        {
            _world.Tick(0, new Command(CommandType.SetSpeed, "5"));
        }
    }
}

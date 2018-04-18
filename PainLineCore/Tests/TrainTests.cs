using System.Linq;
using NUnit.Framework;

namespace PainLineCore
{
    [TestFixture]
    public class TrainTests
    {
        private Track _tracks;
        private Train _train;

        [SetUp]
        public void SetUp()
        {
            _tracks = new Track();
            _train = _tracks.Train;
        }

        [TestCase(0, 0, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 1)]
        [TestCase(0, 0, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 4, 2)]
        public void Tick_TrainMovesAtSpeed(int speed, int expectation, int afterTurns)
        {
            _train.Speed = speed;

            Enumerable.Range(0, afterTurns).ToList().ForEach(i => _train.Tick());

            Assert.That(_train.DistanceTravelled, Is.EqualTo(expectation));
        }
        
        [TestCase(1, 2, 2)]
        [TestCase(2, 3, 2)]
        [TestCase(2, 5, 3)]
        [TestCase(2, 7, 4)]
        public void Tick_SetAccelleration_Accellerates(int targetSpeed, int expectedDistanceTravelled, int afterTurns)
        {
            _train.SetSpeed(targetSpeed);

            Enumerable.Range(0, afterTurns).ToList().ForEach(i => _train.Tick());

            Assert.That(_train.DistanceTravelled, Is.EqualTo(expectedDistanceTravelled));
        }

        [TestCase(0, 7, 2)]
        [TestCase(0, 9, 3)]
        [TestCase(0, 10, 4)]
        [TestCase(0, 10, 5)]
        [TestCase(0, 10, 6)]
        public void Tick_SetAccellerationToNegative_Decellerates(int targetSpeed, int expectedDistanceTravelled, int afterTurns)
        {
            _train.Speed = 5;
            _train.SetSpeed(targetSpeed);

            Enumerable.Range(0, afterTurns).ToList().ForEach(i => _train.Tick());

            Assert.That(_train.DistanceTravelled, Is.EqualTo(expectedDistanceTravelled));
        }

    }
}
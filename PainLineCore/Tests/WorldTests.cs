using NUnit.Framework;

namespace PainLineCore
{
    [TestFixture]
    public class WorldTests
    {
        [Test]
        public void World_GeneratesNumberOfTrainsAndTracksPassedToIt()
        {
            var world = new World(2);

            Assert.That(world.Tracks.Count, Is.EqualTo(2));
            Assert.That(world.Tracks[0].Train, Is.Not.Null);
            Assert.That(world.Tracks[1].Train, Is.Not.Null);
        }

        [Test]
        public void World_TracksExist()
        {
            Assert.That(new World().Tracks, Is.Not.Null);
        }

        [Test]
        public void Tick_TrainMovesAtSpeed()
        {
            var world = new World();
            world.Tracks[0].Train.Speed = 0;

            world.Tick();

            Assert.That(world.Tracks[0].Train.DistanceTravelled, Is.EqualTo(0));
        }

        [Test]
        public void Tick_IncrementsTickCounter()
        {
            var world = new World();
            world.Tick();

            Assert.That(world.Ticks, Is.EqualTo(1));
        }
    }
}

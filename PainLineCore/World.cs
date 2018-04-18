using System.Collections.Generic;

namespace PainLineCore
{
    public class World
    {
        public List<Track> Tracks { get; set; } = new List<Track>();
        public int Ticks { get; private set; }

        public World(int trains = 1)
        {
            for (var i = 0; i < trains; i++)
            {
                Tracks.Add(new Track());
            }
        }

        public void Tick(int playerNumber = 0, Command command = null)
        {
            Ticks++;
            Tracks[playerNumber].Train.Tick();
        }
    }

    public class Command
    {
        public CommandType Type { get; set; }
        public string Value { get; set; }

        public Command(CommandType type, string value)
        {
            Type = type;
            Value = value;
        }
    }

    public enum CommandType
    {
        SetSpeed,
    }
}
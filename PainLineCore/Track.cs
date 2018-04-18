using System.Collections.Generic;

namespace PainLineCore
{
    public class Track : List<Station>
    {
        public Train Train { get; set; } = new Train();

        public Track(int endStationOffset = 0)
        {
            Add(new Station());
            Add(new Station {DistanceFromStart = endStationOffset});
        }
    }
}
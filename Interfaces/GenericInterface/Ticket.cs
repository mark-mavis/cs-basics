using System;

namespace GenericInterface
{
    class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public bool Equals(Ticket? other)
        {
            
            return this.DurationInHours == other?.DurationInHours;
        }
    }
}

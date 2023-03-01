namespace LibrarySystem
{
    // DVDs have a classification, of the following type: 
    public enum Classification
    {
        Universal,
        Youth,
        Adult
    }


    // A DVD is a kind of item.
    public class DVD : Item, IReservable
    {
        // Instance variables.
        private int playingTime;
        private Classification classification;
        private Member[] reservers = new Member[5];
        private int numReservations = 0;

        // Constructor.
        public DVD(string title, int playingTime, Classification classification)
            : base(title)
        {
            this.playingTime = playingTime;
            this.classification = classification;
        }

        // Implementation of IReservable interface.
        public bool Reserved
        {
            get { return numReservations != 0; }
        }

        public bool CanBeReservedFor(Member member)
        {
            return CanBeBorrowedBy(member);
        }

        public bool ReserveItemFor(Member member)
        {
            // Is the item currently borrowed (and not already completely reserved), and is the specified member allowed to reserve it?
            if (Borrowed &&
                numReservations != reservers.Length &&
                CanBeReservedFor(member))
            {
                reservers[numReservations++] = member;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // Overrides.
        public override bool CanBeBorrowedBy(Member member)
        {
            if (classification == Classification.Universal)
            {
                // Universal DVDs can be borrowed by anyone.
                return true;
            }
            else if (classification == Classification.Youth)
            {
                // Youth DVDs can be borrowed by anyone aged 12 or above.
                return member.Age >= 12;
            }
            else
            {
                // Adult DVDs can be borrowed by anyone aged 18 or above.
                return member.Age >= 18;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n  Additional DVD details: {playingTime} {classification}.";
        }
    }
}

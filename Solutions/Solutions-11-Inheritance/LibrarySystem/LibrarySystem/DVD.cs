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
    public class DVD : Item
    {
        // Instance variables.
        private int playingTime;
        private Classification classification;

        // Constructor.
        public DVD(string title, int playingTime, Classification classification)
            : base(title)
        {
            this.playingTime = playingTime;
            this.classification = classification;
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

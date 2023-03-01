namespace LibrarySystem
{
    class ReservableBook : Book, IReservable
    {
        // Instance variables.
        private Member? reserver;

        // Constructor.
        public ReservableBook(string title, string author, string isbn, Genre genre)
            : base(title, author, isbn, genre)
        { }

        // Implementation of Reservable interface.
        public bool Reserved
        {
            get { return reserver != null; }
        }

        public bool CanBeReservedFor(Member member)
        {
            return CanBeBorrowedBy(member);
        }

        public bool ReserveItemFor(Member member)
        {
            // Is the item currently borrowed (and not already reserved), and is the specified member allowed to reserve it?
            if (Borrowed && !Reserved && CanBeReservedFor(member))
            {
                reserver = member;
                return true;
            }
            else
            {
                return false;
            }
        }


        // Additional overrides.
        public override void ReturnItem()
        {
            // Perform the "normal" business rules for a returned item.
            base.ReturnItem();

            // If this item is currently reserved by a member, immediately instigate a "borrow" operation for that member.
            if (reserver != null)
            {
                this.BorrowItemBy(reserver);
                reserver = null;
            }
        }
    }
}
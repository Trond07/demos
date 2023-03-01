namespace LibrarySystem
{
    public abstract class Item
    {
        // Instance variables.
        private string title;
        private Member? borrower = null;

        // Constructor.
        public Item(string t)
        {
            title = t;
        }

        // Business methods / properties.
        public bool Borrowed
        {
            get { return borrower != null; }
        }

        public virtual bool CanBeBorrowedBy(Member member)
        {
            return true;
        }

        public bool BorrowItemBy(Member member)
        {
            // Has the item not been borrowed yet, and is the specified member allowed to borrow it?
            if (!Borrowed && CanBeBorrowedBy(member))
            {
                // Record the fact that this item is now borrowed by the member.
                borrower = member;
                borrower.BorrowedItem();
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void ReturnItem()
        {
            // Record the fact that this item is no longer borrowed by the member.
            if (borrower != null)
                borrower.ReturnedItem();
            
            borrower = null;
        }

        public override string ToString()
        {
            if (borrower != null)
            {
                return $"{title} is on loan to {borrower.Name}";
            }
            else
            {
                return $"{title} is not on loan.";
            }
        }
    }
}
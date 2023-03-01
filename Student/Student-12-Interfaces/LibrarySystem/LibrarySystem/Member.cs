namespace LibrarySystem
{
    public class Member
    {
        // Instance variables.
        private string name;
        private int age;
        private int numberItemsBorrowed = 0;

        // Constructor.
        public Member(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties, as needed.
        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        // string representation.
        public override string ToString()
        {
            return $"{name}, aged {age}, has {numberItemsBorrowed} items(s) on loan.";
        }

        // Business methods.
        public void BorrowedItem()
        {
            numberItemsBorrowed++;
        }

        public void ReturnedItem()
        {
            numberItemsBorrowed--;
        }
    }
}
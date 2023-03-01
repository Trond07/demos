using LibrarySystem;


// Create some members.
Member[] members = new Member[3];
members[0] = new Member("Ben", 10);
members[1] = new Member("Zak", 15);
members[2] = new Member("Joe", 30);

// Create an array to hold all items.
Item[] items = new Item[6];

// Create some books.
items[0] = new Book("Great Expectations", "Charles Dickens", "978-0141439563", Genre.Fiction);
items[1] = new Book("The First Moon Landing", "Gillian Clements", "978-0749649333", Genre.NonFiction);
items[2] = new Book("The Griffalo", "Julia Donaldson", "B001TIBX3K", Genre.Children);

// Create some DVDs.
items[3] = new DVD("Shrek 3", 90, Classification.Universal);
items[4] = new DVD("The Bourne Ultimatum", 100, Classification.Youth);
items[5] = new DVD("The Sopranos", 420, Classification.Adult);

// See if a member can borrow many items.
items[0].BorrowItemBy(members[0]);
items[3].BorrowItemBy(members[0]);
Console.WriteLine("member[0]: " + members[0]);
Console.WriteLine("\nitem[0]: " + items[0]);
Console.WriteLine("\nitem[3]: " + items[3]);

// Make sure an item can't be borrowed if it's already on loan.
bool result = items[0].BorrowItemBy(members[1]);
Console.WriteLine("\nCould member borrow item that was already on loan? " + result);

// Return items.
items[0].ReturnItem();
items[3].ReturnItem();

// Try to borrow each item by each member (and return it immediately).
foreach (Item item in items)
{
    foreach (Member member in members)
    {
        if (item.BorrowItemBy(member))
        {
            Console.WriteLine("\nSuccessful borrow!\n  {0}\n  {1}\n", item, member);
            item.ReturnItem();
        }
        else
        {
            Console.WriteLine("\nUnsuccessful attempt to borrow!\n  {0}\n  {1}\n", item, member);
        }
    }
}
        

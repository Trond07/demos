using LibrarySystem;


// Create some members.
Member member1 = new Member("Ben", 10);
Member member2 = new Member("Zak", 15);
Member member3 = new Member("Joe", 30);
Member member4 = new Member("Don", 50);
Member member5 = new Member("Jan", 65);
Member member6 = new Member("Zoe", 75);
Member member7 = new Member("Tim", 120);

// Create an array to hold items, and add various items to it.
Item[] items = new Item[6];
items[0] = new ReservableBook("Great Expectations", "Charles Dickens", "978-0141439563", Genre.Fiction);
items[1] = new ReservableBook("The First Moon Landing", "Gillian Clements", "978-0749649333", Genre.NonFiction);
items[2] = new Book("The Griffalo", "Julia Donaldson", "B001TIBX3K", Genre.Children);
items[3] = new DVD("Shrek 3", 90, Classification.Universal);
items[4] = new DVD("The Bourne Ultimatum", 100, Classification.Youth);
items[5] = new DVD("The Sopranos", 420, Classification.Adult);

// Create an array to hold any items that are reservable.
IReservable[] reservableItems = new IReservable[items.Length];

// Populate IReservable array with all the items that are reservable.
int pos = 0;
foreach (Item item in items)
{
    if (item is IReservable)
    {
        reservableItems[pos++] = (IReservable)item;
    }
}


// Test 1: Try to reserve a ReservableBook that isn't yet borrowed. Should fail.
bool result1 = reservableItems[0].ReserveItemFor(member1);
Console.WriteLine("Can we reserve a ReservableBook that isn't yet borrowed? " + result1);


// Test 2: Try to reserve a ReservableBook that has been borrowed. Should succeed.
items[0].BorrowItemBy(member1);
Console.WriteLine("\nJust borrowed item: " + items[0]);

bool result2 = reservableItems[0].ReserveItemFor(member2);
Console.WriteLine("Can we reserve a ReservableBook that has been borrowed? " + result2);

items[0].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[0]);

items[0].ReturnItem();
Console.WriteLine("\nJust returned item again: " + items[0]);


// Test 3: Borrow a DVD and then reserve it lots of time.
items[3].BorrowItemBy(member1);
reservableItems[2].ReserveItemFor(member2);
reservableItems[2].ReserveItemFor(member3);
reservableItems[2].ReserveItemFor(member4);
reservableItems[2].ReserveItemFor(member5);
reservableItems[2].ReserveItemFor(member6);
reservableItems[2].ReserveItemFor(member7);     // Should not be allowed to reserve.

items[3].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[3]);

items[3].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[3]);

items[3].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[3]);

items[3].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[3]);

items[3].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[3]);

items[3].ReturnItem();
Console.WriteLine("\nJust returned item: " + items[3]);

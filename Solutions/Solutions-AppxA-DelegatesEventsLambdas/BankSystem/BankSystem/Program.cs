using BankSystem;

BankAccount acc1 = new BankAccount("Peter");

// Handle events using verbose (or shorthand) syntax.
acc1.ProtectionLimitExceeded += new EventHandler<BankAccountEventArgs>(My_ProtectionLimitExceeded_Handler);
acc1.Overdrawn += My_Overdrawn_Handler;

// Handle events using lambda expressions.
acc1.ProtectionLimitExceeded += (sender, e) => Console.WriteLine($"ProtectionLimitExceeded lambda, eventargs {e}.");
acc1.Overdrawn += (sender, e) => Console.WriteLine($"Overdrawn lambda, eventargs {e}.");

// Do some stuff.
acc1.Deposit(10000);
acc1.Deposit(30000);
acc1.Deposit(40000);
acc1.Withdraw(1000000);
            

void My_ProtectionLimitExceeded_Handler(object? sender, BankAccountEventArgs e)
{
    Console.WriteLine($"ProtectionLimitExceeded handler method, eventargs {e}.");
}

static void My_Overdrawn_Handler(object? sender, BankAccountEventArgs e)
{
    Console.WriteLine($"Overdrawn handler method, eventargs {e}.");
}

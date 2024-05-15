// Define a method to format the account completion message
string FormatCompletionMessage(int accountNumber, string username)
{
    // Return the formatted message
    return $"Account {accountNumber} ({username}) finished.";
}

// Example usage of the method
int num = 123; // Sample account number
string user = "Alice"; // Sample user name

// Print the formatted account completion message to the console
Console.WriteLine(FormatCompletionMessage(num, user));

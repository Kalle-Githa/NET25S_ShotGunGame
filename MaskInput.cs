class MaskInput
{
    public static string MaskPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(intercept: true); // inget syns på skärmen

            if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password[..^1]; // ta bort sista tecknet
                Console.Write("\b \b"); // ta bort stjärnan visuellt
            }
            else if (!char.IsControl(key.KeyChar))
            {
                password += key.KeyChar;
                Console.Write("*"); // visa stjärna istället
            }
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return password;
    }
}

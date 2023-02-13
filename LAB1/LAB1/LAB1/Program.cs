namespace LAB1;

public static class Program
{
    public static int Main()
    {
        var state = true;
        Console.WriteLine("Hello.");
        while (state)
        {
            Console.WriteLine("Choose cipher");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Caesar Cipher");
            Console.WriteLine("2 - Vigenere Cipher");
            Console.WriteLine();
            Console.Write("Your choice: ");
            var userInput = Console.ReadLine();
            Console.WriteLine();

            switch (userInput)
            {
                case "0":
                    state = false;
                    break;

                case "1":
                    var state1 = true;
                    while (state1)
                    {
                        Console.WriteLine("Choose action");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Encrypt");
                        Console.WriteLine("2 - Decrypt");
                        Console.WriteLine();
                        Console.Write("Your choice: ");
                        var userInput1 = Console.ReadLine();
                        Console.WriteLine();

                        switch (userInput1)
                        {
                            case "0":
                                state1 = false;
                                break;
                            case "1":
                                string? inputString;
                                int inputKey;

                                inputString = File.ReadAllText("inputForCaesar.txt");
                                inputKey = Convert.ToInt32(File.ReadAllText("keyForCaesar.txt"));

                                Console.WriteLine($"Encrypted string: {CaeserClass.Encrypt(inputString, inputKey)}");
                                Console.WriteLine();
                                break;
                            case "2":
                                string? inputString1;
                                int inputKey1;

                                inputString1 = File.ReadAllText("outputForCaesar.txt");
                                inputKey1 = Convert.ToInt32(File.ReadAllText("keyForCaesar.txt"));

                                Console.WriteLine($"Decrypted string: {CaeserClass.Decrypt(inputString1, inputKey1)}");
                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine("RedNeck!");
                                break;
                        }
                    }

                    break;
                case "2":
                    var state2 = true;
                    while (state2)
                    {
                        Console.WriteLine("Choose action");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Encrypt");
                        Console.WriteLine("2 - Decrypt");
                        Console.WriteLine();
                        Console.Write("Your choice: ");
                        var userInput1 = Console.ReadLine();
                        Console.WriteLine();

                        switch (userInput1)
                        {
                            case "0":
                                state2 = false;
                                break;
                            case "1":
                                
                                string? inputString;
                                string? inputKey;

                                inputString = File.ReadAllText("inputForVigenere.txt");
                                inputKey = File.ReadAllText("keyForVigenere.txt");
                                
                                Console.WriteLine($"Encrypted string: {VigenereClass.Encrypt(inputString, inputKey)}");
                                break;
                            case "2":
                                
                                string? inputString1;
                                string? inputKey1;

                                inputString1 = File.ReadAllText("outputForVigenere.txt");
                                inputKey1 = File.ReadAllText("keyForVigenere.txt");
                                
                                Console.WriteLine($"Decrypted string: {VigenereClass.Decrypt(inputString1, inputKey1)}");
                                break;
                            default:
                                Console.WriteLine("RedNeck");
                                break;
                        }
                    }

                    break;
                default:
                    Console.WriteLine("RedNeck!");
                    break;
            }
        }

        return 0;
    }
}
using System.Text;

namespace LAB1;

public static class Program
{
    public delegate void NILLKIGERS(string HHH, int kkkk);

    public static int Main()
    {
        var hgfdsdfgh = new jhgfdfghjkjhg();
        var kirill = hgfdsdfgh.ASDFGHJKLngfdfgfhg();
        Console.WriteLine("Hello.");
        while (kirill)
        {
            Console.WriteLine("Choose cipher");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Caesar Cipher");
            Console.WriteLine("2 - Vigenere Cipher");
            Console.WriteLine();
            Console.Write("Your choice: ");
            var XXXxxXXXx = ASDFGHJKL.LKJHGFD();
            Console.WriteLine();

            switch (XXXxxXXXx)
            {
                case "0":
                    kirill = !new jhgfdfghjkjhg().ASDFGHJKLngfdfgfhg();
                    break;

                case "1":
                    var artyom = hgfdsdfgh.ASDFGHJKLngfdfgfhg();
                    while (artyom)
                    {
                        Console.WriteLine("Choose action");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Encrypt");
                        Console.WriteLine("2 - Decrypt");
                        Console.WriteLine();
                        Console.Write("Your choice: ");
                        var XXXxxXXX = ASDFGHJKL.LKJHGFD();
                        Console.WriteLine();

                        switch (XXXxxXXX)
                        {
                            case "0":
                                artyom = false;
                                break;
                            case "1":
                                string? JGHJGHJGHJHGH;
                                int HGFGFGFGGFGF;

                                JGHJGHJGHJHGH = hhhhhhhhhhh.jjjjjj("inputForCaesar.txt");
                                HGFGFGFGGFGF = Convert.ToInt32(asdfgh.jjjjjj("keyForCaesar.txt"));

                                NILLKIGERS deleg = delegate(string JGHJGHJGHJHGH, int HGFGFGFGGFGF)
                                {
                                    HGFGFGFGGFGF = HGFGFGFGGFGF % 26;
                                    var stringAsArray = JGHJGHJGHJHGH.ToCharArray();
                                    for (var index = 0; index < JGHJGHJGHJHGH.Length; index++)
                                        if (stringAsArray[index] != ' ' && stringAsArray[index] != ',' &&
                                            stringAsArray[index] != '.'
                                            && !char.IsDigit(stringAsArray[index]))
                                        {
                                            var tmp = stringAsArray[index] + HGFGFGFGGFGF;
                                            if (char.IsUpper(stringAsArray[index]))
                                            {
                                                if (tmp >= 91)
                                                    tmp = tmp % 91 + 'A';
                                                else
                                                    tmp = tmp % 91;

                                                stringAsArray[index] = Convert.ToChar(tmp);
                                            }
                                            else if (char.IsLower(stringAsArray[index]))
                                            {
                                                if (tmp >= 123)
                                                    tmp = tmp % 123 + 'a';
                                                else
                                                    tmp = tmp % 123;

                                                stringAsArray[index] = Convert.ToChar(tmp);
                                            }
                                        }

                                    var fs = File.OpenWrite("outputForCaesar.txt");
                                    fs.Write(Encoding.Default.GetBytes(new string(stringAsArray)));
                                    fs.Close();
                                    Console.WriteLine(stringAsArray);
                                };
                                deleg(JGHJGHJGHJHGH, HGFGFGFGGFGF);
                                Console.WriteLine();
                                break;
                            case "2":
                                string? ghghgh;
                                int hhh;

                                ghghgh = hhhhhhhhhhh.jjjjjj("outputForCaesar.txt");
                                hhh = Convert.ToInt32(hhhhhhhhhhh.jjjjjj("keyForCaesar.txt"));

                                Console.WriteLine($"Decrypted string: {CaeserClass.Decrypt(ghghgh, hhh)}");
                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine("RedNeck!");
                                break;
                        }
                    }

                    break;
                case "2":
                    var TRU3 = new zxcvbbn().ASDFGHJKLngfdfgfhg();
                    while (TRU3)
                    {
                        Console.WriteLine("Choose action");
                        Console.WriteLine("0 - Exit");
                        Console.WriteLine("1 - Encrypt");
                        Console.WriteLine("2 - Decrypt");
                        Console.WriteLine();
                        Console.Write("Your choice: ");
                        var JOPA = ASDFGHJKL.LKJHGFD();
                        Console.WriteLine();

                        switch (JOPA)
                        {
                            case "0":
                                TRU3 = !TRU3;
                                break;
                            case "1":

                                string? output;
                                string? outk;

                                output = jdfkdgjkldfgjkdfjlkldjkfljkfd.KJHGFDFGHJKL("inputForVigenere.txt");
                                outk = hhhhhhhhhhh.jjjjjj("keyForVigenere.txt");

                                Console.WriteLine($"Encrypted string: {VigenereClass.Encrypt(output, outk)}");
                                break;
                            case "2":

                                string? hhh;
                                string? jhgfdsdfghjk;

                                hhh = hhhhhhhhhhh.jjjjjj("outputForVigenere.txt");
                                jhgfdsdfghjk = qwerty.KJHGFDFGHJKLert("keyForVigenere.txt");

                                var INPUT = hhh.ToCharArray();
                                var JHGFDFGHJK = jhgfdsdfghjk.ToCharArray();

                                for (var index = 0; index < INPUT.Length; index++)
                                    if (INPUT[index] != ' ' && INPUT[index] != ',' && INPUT[index] != '.'
                                        && !char.IsDigit(INPUT[index]))
                                    {
                                        if (char.IsUpper(INPUT[index]))
                                        {
                                            var tmp = INPUT[index] - JHGFDFGHJK[index];
                                            if (tmp < 0) tmp += 26;

                                            INPUT[index] = Convert.ToChar(tmp % 26 + 65);
                                        }
                                        else if (char.IsLower(INPUT[index]))
                                        {
                                            var tmp = INPUT[index] - JHGFDFGHJK[index];
                                            if (tmp < 0) tmp += 26;

                                            INPUT[index] = Convert.ToChar(tmp % 26 + 97);
                                        }
                                    }

                                qwerty.dfgdfgdfgdfgdfgdfgdfgdfgfd("inputForVigenere.txt", new string(INPUT));

                                Console.WriteLine(
                                    $"Decrypted string: {new string(INPUT)}");
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
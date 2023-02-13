using System.Text;

namespace LAB1;

public class CaeserClass
{
    public static string Encrypt(string? stringToEncrypt, int key)
    {
        key = key % 26;
        var stringAsArray = stringToEncrypt.ToCharArray();
        for (var index = 0; index < stringToEncrypt.Length; index++)
            if (stringAsArray[index] != ' ' && stringAsArray[index] != ',' && stringAsArray[index] != '.'
                && !char.IsDigit(stringAsArray[index]))
            {
                var tmp = stringAsArray[index] + key;
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

        FileStream fs = File.OpenWrite("outputForCaesar.txt");
        fs.Write(Encoding.Default.GetBytes(new string(stringAsArray)));
        fs.Close();
        return new string(stringAsArray);
    }

    public static string Decrypt(string? stringToDecrypt, int key)
    {
        key = key % 26;
        var tmpKey = 0;
        var stringAsArray = stringToDecrypt.ToCharArray();
        for (var index = 0; index < stringToDecrypt.Length; index++)
            if (stringAsArray[index] != Convert.ToChar(" "))
            {
                var tmp = 0;
                if (char.IsUpper(stringAsArray[index]))
                {
                    if (stringAsArray[index] - key < 65)
                    {
                        tmp = stringAsArray[index] - 65;
                        if (tmp == 0)
                        {
                            tmpKey = key;
                            tmpKey -= 1;
                        }
                        else
                        {
                            key -= tmp;
                        }

                        if (tmpKey != 0)
                            stringAsArray[index] = Convert.ToChar(90 - tmpKey);
                        else
                            stringAsArray[index] = Convert.ToChar(90 - key);

                        tmpKey = 0;
                    }
                    else
                    {
                        stringAsArray[index] = Convert.ToChar(stringAsArray[index] - key);
                    }
                }
                else if (char.IsLower(stringAsArray[index]))
                {
                    if (stringAsArray[index] - key < 97)
                    {
                        tmp = stringAsArray[index] - 97;
                        if (tmp == 0)
                        {
                            tmpKey = key;
                            tmpKey -= 1;
                        }
                        else
                        {
                            tmpKey = key - tmp;
                            tmpKey -= 1;
                        }

                        if (tmpKey != 0)
                            stringAsArray[index] = Convert.ToChar(122 - tmpKey);
                        else
                            stringAsArray[index] = Convert.ToChar(122 - key);

                        tmpKey = 0;
                    }
                    else
                    {
                        stringAsArray[index] = Convert.ToChar(stringAsArray[index] - key);
                    }
                }
            }
        
        FileStream fs = File.OpenWrite("inputForCaesar.txt");
        fs.Write(Encoding.Default.GetBytes(new string(stringAsArray)));
        fs.Close();

        return new string(stringAsArray);
    }
}
using System.Text;

namespace LAB1;

public class VigenereClass
{
    public static string Encrypt(string stringToEncrypt, string key)
    {
        var stringAsArray = stringToEncrypt.ToCharArray();
        var keyAsArray = key.ToCharArray();

        for (var index = 0; index < stringAsArray.Length; index++)
            if (stringAsArray[index] != ' ' && stringAsArray[index] != ',' && stringAsArray[index] != '.'
                && !char.IsDigit(stringAsArray[index]))
            {
                if (char.IsUpper(stringAsArray[index]))
                    stringAsArray[index] = Convert.ToChar((stringAsArray[index] + keyAsArray[index]) % 26 + 65);
                else if (char.IsLower(stringAsArray[index]))
                    stringAsArray[index] = Convert.ToChar((stringAsArray[index] + keyAsArray[index]) % 26 + 97);
            }

        var fs = File.OpenWrite("outputForVigenere.txt");
        fs.Write(Encoding.Default.GetBytes(new string(stringAsArray)));
        fs.Close();

        return new string(stringAsArray);
    }
}
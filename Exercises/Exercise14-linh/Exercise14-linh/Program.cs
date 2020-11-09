using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise14_linh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Encryption Program");
            Console.WriteLine("Enter 1 to exit.");
            Console.Write("Enter the message to encrypt: ");
            string plaintext = "";
            try
            {
                plaintext = Util.RemoveBadChars(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            if (plaintext == "1")
            {
                Environment.Exit(1);
            }
               

            Console.Write("Enter key as alpha character: ");
            char key = ' ';

            try
            {
                key = char.Parse(Util.RemoveBadChars(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            string multiCharKey = "";
            Console.Write("Enter a string key: ");
            try
            {
                multiCharKey = Util.RemoveBadChars(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            string cleanPlainText = "";
            cleanPlainText = Util.RemoveBadChars(plaintext);
            Console.WriteLine($"\nCleaned plain text is: {cleanPlainText}\n");

            string cypherString = Util.cryptAlpha(cleanPlainText, "encrypt", key);
            string decryptedString = Util.cryptAlpha(cypherString, "decrypt", key);
            string encryptStringWordKey = Util.cryptStringKey(cleanPlainText, multiCharKey, "encrypt");
            string decryptStringWordKey = Util.cryptStringKey(encryptStringWordKey, multiCharKey, "decrypt");

            Console.WriteLine($"Encrypted cypher message is: {cypherString}\n");
            Console.WriteLine($"Decrypted cypher message is: {decryptedString}\n");
            Console.WriteLine($"Encrypted cypher message with word key is: {encryptStringWordKey}\n");
            Console.WriteLine($"Decrypted cypher message with word key is: {decryptStringWordKey}\n");
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
        }
    }
}
class Util
{
    static public string cryptAlpha(string plainText, string crypt, char key = ' ')
    {
        char[] textArr = plainText.ToCharArray();
        string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerChars = "abcdefghijklmnopqrustuvwxyz";
        int shiftUpper = 0;
        for (int i = 0; i < upperChars.Length; i++)
        {
            if (upperChars[i] == key)
                shiftUpper = i + 1;
        }
        int shiftLower = 0;
        for (int i = 0; i < lowerChars.Length; i++)
        {
            if (lowerChars[i] == key)
                shiftLower = i + 1;
        }
        if (crypt == "encrypt")
        {
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i] >= 65 && textArr[i] <= 90)
                {
                    if (textArr[i] >= shiftUpper + 65)
                        textArr[i] -= (char)shiftUpper;
                    else
                        textArr[i] += (char)(shiftLower - 26);
                }
                else if (textArr[i] >= 97 && textArr[i] <= 122 || textArr[i] == 122)
                {
                    if (textArr[i] + shiftLower <= 122)
                        textArr[i] += (char)shiftLower;
                    else
                        textArr[i] += (char)(shiftLower - 26);
                }
            }
        }
        else if (crypt == "decrypt")
        {
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i] >= 65 && textArr[i] <= 90)
                {
                    if (textArr[i] >= shiftUpper + 65)
                        textArr[i] += (char)shiftUpper;
                    else
                        textArr[i] -= (char)(shiftLower - 26);
                }
                else if (textArr[i] >= 97 && textArr[i] <= 122)
                {
                    if (textArr[i] + shiftLower <= 122 || textArr[i] == 122)
                        textArr[i] -= (char)shiftLower;
                    else
                        textArr[i] += (char)(shiftLower - 26);
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        foreach (var letter in textArr)
            sb.Append(letter);

        return sb.ToString();
    }
    static public int[] createStrKey(char[] plainText, string strKey)
    {
        char[] upperChars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'W', 'Z' };
        //string lowerChars = "abcdefghijklmnopqrustuvwxyz";

        int[] shiftPlaces = new int[strKey.Length];
        for (int i = 0; i < plainText.Length; i++)
        {
            for (int j = 0; j < upperChars.Length; j++)
            {
                if (strKey[i] == upperChars[j])
                {
                    shiftPlaces[i] = j;
                    j = upperChars.Length;
                }
            }
        }
        return shiftPlaces;
    }
    static public string cryptStringKey(string plainText, string strKey, string crypt)
    {
        char[] textArr = plainText.ToCharArray();
        int[] shiftPlaces = createStrKey(plainText.ToUpper().ToCharArray(), strKey);

        if (crypt == "encrypt")
        {
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i] >= 65 && textArr[i] <= 90)
                {
                    if (textArr[i] >= shiftPlaces[i] + 65)
                        textArr[i] -= (char)shiftPlaces[i];
                    else
                        textArr[i] += (char)(shiftPlaces[i] - 26);
                }
                else if (textArr[i] >= 97 && textArr[i] <= 122 || textArr[i] == 122)
                {
                    if (textArr[i] + shiftPlaces[i] <= 122)
                        textArr[i] -= (char)shiftPlaces[i];
                    else
                        textArr[i] += (char)(shiftPlaces[i] - 26);
                }
            }
        }
        else if (crypt == "decrypt")
        {
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i] >= 65 && textArr[i] <= 90)
                {
                    if (textArr[i] >= shiftPlaces[i] + 65)
                        textArr[i] += (char)shiftPlaces[i];
                    else
                        textArr[i] -= (char)(shiftPlaces[i] - 26);
                }
                else if (textArr[i] >= 97 && textArr[i] <= 122)
                {
                    if (textArr[i] + shiftPlaces[i] <= 122 || textArr[i] == 122)
                        textArr[i] -= (char)shiftPlaces[i];
                    else
                        textArr[i] += (char)(shiftPlaces[i] - 26);
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        foreach (var letter in textArr)
            sb.Append(letter);
        return sb.ToString();
    }
    public static string RemoveBadChars(string word)
    {
        Regex reg = new Regex("[^a-zA-Z']");
        return reg.Replace(word, string.Empty);
    }
}


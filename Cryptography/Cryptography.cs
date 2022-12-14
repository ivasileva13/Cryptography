using System;

class Criprography

{
    public static void Main(String[] args)
    {
        Console.WriteLine("Input text:");
        string pleintext = Console.ReadLine().ToUpper();

        Console.WriteLine("key text:");
        string keyword = Console.ReadLine().ToUpper();

        String key = Key(pleintext, keyword);
        String encrypt = encryptText(pleintext, key);

        Console.WriteLine("Encrypted text : " + encrypt + "\n");
        Console.WriteLine("Decrypted text : " + descryptText(encrypt, key));
    }

    static String Key(String pleintext, String key)
    {

        for (int i = 0; ; i++)
        {
            if (key.Length > pleintext.Length)
                break;
            if (key.Length == 0)
                Console.WriteLine("Please insert a valid key!");
            key += key[i];
        }
        return key;
    }

    static String encryptText(String pleintext, String key)
    {
        String encrypt = "";

        for (int i = 0; i < pleintext.Length; i++)
        {
            if (pleintext.Length == 0)
                Console.WriteLine("Please insert a valid plain text!");
            int c = (pleintext[i] + key[i]) % 26;
            c += 'A';

            encrypt += (char)c;
        }
        return encrypt;
    }

    static String descryptText(String encrypt, String key)
    {
        String descrypt = "";

        for (int i = 0; i < encrypt.Length && i < key.Length; i++)
        {
            int c = (encrypt[i] - key[i] + 26) % 26;
            c += 'A';
            descrypt += (char)c;
        }
        return descrypt;
    }

}

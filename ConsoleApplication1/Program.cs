using System;

class Program
{
    static string Shifr(string text, int shift)
    {
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            if (buffer[i] >= 32 && buffer[i] <= 126)
            {
                buffer[i] = (char)((buffer[i] + shift - 32) % 95 + 32);
            }
        }
        return new string(buffer);
    }

    static string DeShifr(string cipherText, int shift)
    {
        char[] buffer = cipherText.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            if (buffer[i] >= 32 && buffer[i] <= 126)
            {
                buffer[i] = (char)((buffer[i] - shift - 32 + 95) % 95 + 32);
            }
        }
        return new string(buffer);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("1 - Shifrlash");
        Console.WriteLine("2 - Deshifrlash");
        Console.Write("Tanlovingizni kiriting (1 yoki 2): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Shifrlamoqchi bo'lgan matnni kiriting: ");
            string text = Console.ReadLine();

            Console.Write("Kalitni kiriting (raqam): ");
            int shift = int.Parse(Console.ReadLine());

            string shifrMatn = Shifr(text, shift);
            Console.WriteLine("ASCII bo'yicha shifrlangan matn: " + shifrMatn);
        }
        else if (choice == 2)
        {
            Console.Write("Deshifrlamoqchi bo'lgan matnni kiriting: ");
            string cipherText = Console.ReadLine();

            Console.Write("Kalitni kiriting (raqam): ");
            int shift = int.Parse(Console.ReadLine());

            string deshifrMatn = DeShifr(cipherText, shift);
            Console.WriteLine("ASCII bo'yicha deshifrlangan matn: " + deshifrMatn);
        }
        else
        {
            Console.WriteLine("Noto'g'ri tanlov kiritildi. 1 yoki 2 ni tanlang.");
        }
    }
}


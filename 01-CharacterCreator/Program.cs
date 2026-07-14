using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("--KARAKTER OLUŞTURMA EKRANI");

        Console.Write("Kullanıcı adınızı yazın - ");
        string isim = Console.ReadLine();

        Console.WriteLine("Kullanıcı Adı " + isim);

        Console.Write("Karakterin Gücünü Belirleyin (1/100) - ");
        int SaldırıGucu = int.Parse(Console.ReadLine());

        Console.WriteLine("Karakterin Saldırı Gücü " + SaldırıGucu);

        Console.Write("Karakterin Savunma Gücünü Belirleyin (1/100) - ");
        int SavunmaGucu = int.Parse(Console.ReadLine());

        Console.WriteLine("Karakterin Savunma Gücü " + SavunmaGucu);

        Console.WriteLine("-------------");

        Console.WriteLine("Kullanıcı Adı - " + isim);
        Console.WriteLine("Karakterin Saldırı Gücü - " + SaldırıGucu);
        Console.WriteLine("Karakterin Savunma Gücü - " + SavunmaGucu);

        int ToplamGuc = SaldırıGucu + SavunmaGucu;

        bool Baslayabilirmi = ToplamGuc > 100;

        if (Baslayabilirmi)
        {
            Console.WriteLine("Tebrikler! Oyuna giriş yapabilirsiniz.");
        }
        else
        {
            Console.WriteLine("Giriş Engellendi! Puanınız çok düşük.");
        }

       

    }
}




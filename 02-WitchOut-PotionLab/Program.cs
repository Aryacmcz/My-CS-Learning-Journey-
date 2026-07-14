using System;



class Program
{
    static void Main()
    {

        Console.WriteLine("--- Witch Out! İksir Laboratuvarına Hoş Geldiniz ---");

        Console.Write("Kullanıcı adınızı yazınız - ");
        string oyuncuAdi = Console.ReadLine();

        Console.Write("Kaç tane mistik kurbağa bacağı istiyorsunuz? ");
        int kurbagaSayisi = int.Parse(Console.ReadLine());

        Console.Write("Kaç tane Ejderha Kanı istiyorsunuz? ");
        int EjderKanisayisi = int.Parse(Console.ReadLine());


        bool iksirBasarili = false;

        
        if (kurbagaSayisi >= 5 && kurbagaSayisi <= 10 && EjderKanisayisi == 3)
        {
            iksirBasarili = true; 
        }
        else
        {
            iksirBasarili = false; 
        }


        if (iksirBasarili == true)
        {
            Console.Write("Tebrikler " + oyuncuAdi + " Görünmezlik iksirini başarıyla kaynattın!");
        }
        else
        {
            Console.Write("Eyvah! Malzemeleri tutturamadın, kazan patladı!");
        }



    }
   }

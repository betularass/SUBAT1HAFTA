// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//SORU1

/* Dizi(Array), aynı türdeki birden fazla veriyi tek bir değişkende saklamamızı sağlayan veri yapısıdır.
Örneğin, bir sınıftaki öğrencilerin yaşlarını tutmak için tek tek değişken oluşturmak yerine bir int dizisi kullanabiliriz.

Bir kitap rafı düşünelim. Her rafın bir numarası var ve belirli kitapları saklıyor. Kitapları düzenli bir şekilde saklamak ve erişmek için diziler kullanılabilir. */


//SORU2
/*
{
    
    {
        int[] sayilar = new int[5];

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nGirilen Sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
    }
}

*/


// SORU3

/*

{ 
        int[] sayilar = { 15, 22, 38, 9, 47 }; 
        int enBuyuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
        }

        Console.WriteLine("Dizideki en büyük sayı: " + enBuyuk);
    }

*/

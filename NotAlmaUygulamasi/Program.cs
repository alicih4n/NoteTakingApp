using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleNoteTakingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> notlar = new List<string>(); // Kullanıcıdan alacağımız notları saklamak için bir liste oluşturduk.


            while (true) //Sürekli olarak işlem yapılabilmesi için sonsuz bir döngüye soktuk.
            {
                Console.WriteLine("1. Notları Gör\n2. Not Ekle\n3. Çıkış\nSeçiminizi girin: ");
                int choice = Convert.ToInt32(Console.ReadLine()); //Kullanıcı seçimini aldık

                
                switch (choice) // Kullanıcı neyi seçtiyse ona göre o seçime gidiyoruz.
                {
                    case 1:
                        Console.WriteLine("Kaydedilen Notlar:");
                        StringBuilder notesString = new StringBuilder(); //StringBuilder kullanmamızın sebebi notların ekrana yazdırılması için string hale getirilmesi ve tek tek Console.Write yerine bu şekilde yazılmasıdır.
                        for (int i = 0; i < notlar.Count; i++)
                        {
                            notesString.AppendLine((i + 1) + ". " + notlar[i]); //Önceden yazdığımız kodları sırası ile burada gösteriyoruz.
                        }
                        Console.WriteLine(notesString.ToString());
                        break;

                    case 2:
                        Console.Write("İstediğiniz Notu Giriniz: ");
                        string note = Console.ReadLine();
                        notlar.Add(note);   //Notumuzu ekledik.
                        Console.WriteLine("Notunuz eklendi.");
                        break;

                    case 3:
                        return;
                    default:
                        Console.WriteLine("Yaptığınız seçim geçersizdir. Lütfen tekrar deneyiniz."); //İlk 3 seçenek harici bir değer girilirse kullanıcı buraya yönlendirilir.
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonSistemi
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
            Console.WriteLine($"\"{kitap.Baslik}\" kütüphaneye eklendi.");
        }

        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
            Console.WriteLine($"Üye eklendi: {uye.Ad} {uye.Soyad}");
        }

        public void KitapDurumlarınıGoster()
        {
            Console.WriteLine("Kütüphaneye ait tüm kitaplar ve durumları:");

            foreach (var item in Kitaplar)
            {
                Console.WriteLine($"Kitap:  {item.Baslik} | Durum: {item.Durum}");
            }
        }

        public void UyeleriGoster()
        {
            Console.WriteLine("Kütüphaneye kayıtlı üyeler:");

            foreach(var item in Uyeler)
            {
                Console.WriteLine($"Üye: {item.Ad} {item.Soyad} - Üye Numarası: {item.UyeNumarasi}");
            }
        }

        public void KitapStoklariniGoster()
        {
            Console.WriteLine("Stokta bulunan tüm kitaplar: ");

            foreach (var item in Kitaplar)
            {
                Console.WriteLine($"Kitap: {item.Baslik} | Stok: {item.Stok} | Durum: {item.Durum}");
            }
        }
    }
}

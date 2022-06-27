using System;
using System.IO;
namespace Yarisma
{
	public class Yarisma
	{
        Random rng = new Random();

        
        private int yarismaPistiUzunlugu;
        private string[] yarismacilar = new string[100];
        private Pist yarismaPisti;
        private string yarismaciDosyasi;
        public void Baslat()
        {
            //Textten dosya okunur ve tuple içerisine satırlar eklenir. Sonrasında ise splitlenerek yarışmacılar eklenir.
            List<Tuple<int, string, string>> yarismaciListesi = new List<Tuple<int, string, string>>();
            string[] yarismaci;
            string[] yarismacilarlistesi = File.ReadAllLines(yarismaciDosyasi);
            var list = new List<Tuple<int, string, string>>();
            for (int i = 0; i < yarismacilarlistesi.Length; i++)
            {
                yarismaci = yarismacilarlistesi[i].Split(' ');
                list.Add(new Tuple<int, string, string>(Convert.ToInt32(yarismaci[0]), yarismaci[1], yarismaci[2]));
            }
            //Yeni pist oluşturulur
            yarismaPisti = new Pist(yarismaPistiUzunlugu);
            //Split sonucunda elde edilen verilerle yarışmacılar piste eklenir
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Item3 == "CAKAL")
                {
                    yarismaPisti.YarismaciEkle(new Cakal(list[i].Item2, rng, list[i].Item1, yarismaPisti));

                }
                if (list[i].Item3 == "DEVEKUSU")
                {
                    yarismaPisti.YarismaciEkle(new DeveKusu(list[i].Item2, rng, list[i].Item1, yarismaPisti));
                }
                if (list[i].Item3 == "SALYANBOT")
                {
                    yarismaPisti.YarismaciEkle(new SalyanBot(list[i].Item2, rng, list[i].Item1, yarismaPisti));
                }
                if (list[i].Item3 == "MEKANIKFIL")
                {
                    yarismaPisti.YarismaciEkle(new MekanikFil(list[i].Item2, rng, list[i].Item1, yarismaPisti));
                }

            }
            yarismaPisti.KonumGuncelle();
        }

        public void KonumlariYazdir()
        {
            yarismaPisti.DurumuYazdir();
        }

        public Yarisma(string Yarismacilar, int YarismaPistiUzunlugu)
        {
            yarismaciDosyasi = Yarismacilar;
            yarismaPistiUzunlugu = YarismaPistiUzunlugu;
        }
    }
}

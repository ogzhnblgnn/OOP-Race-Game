using System;
namespace Yarisma
{
	public class Pist
	{
        
        private static List<IYarismaci> pist = new List<IYarismaci>();
        private int PistUzunlugu;
        public void DurumuYazdir()
        {
            // Yarışmacıların konumları
            for (int i = 0; i < pist.Count; i++)
            {
                Console.WriteLine($"{pist[i].Konum} : {pist[i].YarismaciNo}:{pist[i].Isim}");
            }
        }
        public List<IYarismaci> KonumdakiYarismacilar(int konumdakiler)
        {
            //Yarışmacıların anlık konumları
            List<IYarismaci> konumdakiyarismacilar = new List<IYarismaci>();

            for (int i = 0; i < pist.Count; i++)
            {
                if (pist[i].Konum == konumdakiler)
                {
                    konumdakiyarismacilar.Add(pist[i]);
                }
            }
            return konumdakiyarismacilar;

        }
        public void KonumGuncelle()
        {
            for (int j = 0; j < PistUzunlugu; j++)
            {
                for (int i = 0; i < pist.Count; i++)
                {
                    if (pist[i].Konum >= PistUzunlugu)
                    {
                        break;
                    }
                    pist[i].HareketEt();
                }
            }
        }
        public void YarismaciEkle(IYarismaci yarismacilar)
        {
            pist.Add(yarismacilar);
        }

        public Pist(int pistUzunlugu)
        {
            PistUzunlugu = pistUzunlugu;
        }
    }
}


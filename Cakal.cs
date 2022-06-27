using System;
namespace Yarisma
{
	public class Cakal : Hayvan
	{
        public Cakal(string isim, Random rng, int YarismaciNo, Pist YarismaPisti) : base(isim, rng, YarismaciNo, YarismaPisti)
        {

        }
        Random random = new Random();
        public override void HareketEt()
        {
            int rand = random.Next(1, 101);

            if (rand <= 30)
            {
                Konum += 3;
                foreach (IYarismaci yarismaci in yarismaPisti.KonumdakiYarismacilar(Konum))
                {
                    if (yarismaci.GetType() == typeof(DeveKusu))
                    {
                        DeveKusu deveKusu = (DeveKusu)yarismaci;
                        int y = random.Next(0, 100);
                        if (y >= 50 && deveKusu.Paralize == false)
                        {
                            deveKusu.Paralize = true;
                            break;
                        }
                    }
                }
            }
            else if (rand > 30 && rand < 80)
            {
                Konum += 2;

                foreach (IYarismaci yarismaci in yarismaPisti.KonumdakiYarismacilar(Konum))
                {
                    if (yarismaci.GetType() == typeof(DeveKusu))
                    {
                        DeveKusu deveKusu = (DeveKusu)yarismaci;
                        int y = random.Next(0, 100);
                        if (y >= 50 && deveKusu.Paralize == false)
                        {
                            deveKusu.Paralize = true;
                            break;
                        }
                    }
                }
            }
            else if (rand >= 80)
            {
                if (Konum > 3)
                {
                    Konum -= 4;
                }
                else
                {
                    Konum = 0;
                }
            }
        }
    }
}


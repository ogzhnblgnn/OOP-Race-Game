using System;
namespace Yarisma
{
    public class MekanikFil : Robot
    {

        Random random = new Random();

        public override void HareketEt()
        {
            int rand = rng.Next(1, 101);
            if (rand <= 40)
            {
                Konum += 2;
                foreach (IYarismaci yarismaci in yarismaPisti.KonumdakiYarismacilar(Konum))
                {
                    if (yarismaci.GetType() == typeof(DeveKusu))
                    {
                        DeveKusu deveKusu = (DeveKusu)yarismaci;
                        int y = random.Next(0, 100);
                        if (y >= 25 && deveKusu.Paralize == false)
                        {
                            deveKusu.Paralize = true;
                            break;
                        }

                    }
                }
            }
            else if (rand > 40 && rand <= 50)
            {
                Konum += 3;

                foreach (IYarismaci yarismaci in yarismaPisti.KonumdakiYarismacilar(Konum))
                {
                    if (yarismaci.GetType() == typeof(DeveKusu))
                    {
                        DeveKusu deveKusu = (DeveKusu)yarismaci;
                        int y = random.Next(0, 100);
                        if (y >= 25 && deveKusu.Paralize == false)
                        {
                            deveKusu.Paralize = true;
                            break;
                        }

                    }
                }
            }
            else if (rand > 50)
            {
            }
        }

        public MekanikFil(string Isim, Random rng, int YarismaciNo, Pist YarismaPisti) : base(Isim, rng, YarismaciNo, YarismaPisti)
        {
        }
    }
}


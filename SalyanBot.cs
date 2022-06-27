using System;
namespace Yarisma
{
	public class SalyanBot : Robot
	{
        
        public override void HareketEt()
        {
            Konum += 1;
            foreach (IYarismaci yarismaci in yarismaPisti.KonumdakiYarismacilar(Konum))
            {
                Random random = new Random();
                int rand = random.Next(0, 100);
                if (rand <= 25 && yarismaci.GetType().BaseType == typeof(Hayvan))
                {
                    if (Konum > 0)
                    {
                        yarismaci.Konum -= 1;
                    }
                }
            }
        }
        public SalyanBot(string isim, Random rng, int YarismaciNo, Pist YarismaPisti) : base(isim, rng, YarismaciNo, YarismaPisti)
        {
        }
    }
}


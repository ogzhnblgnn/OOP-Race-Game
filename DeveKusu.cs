using System;
namespace Yarisma
{
	public class DeveKusu : Hayvan
	{
        private bool paralize = false;
        public bool Paralize { get => paralize; set => paralize = value; }
        public DeveKusu(string isim, Random rng, int YarismaciNo, Pist YarismaPisti) : base(isim, rng, YarismaciNo, YarismaPisti) { }
        public override void HareketEt()
        {
            int rand = rng.Next(1, 101);
            if (!Paralize)
            {
                if (rand < 51)
                {
                    Konum += 3;
                }
                else if (rand >= 51 && rand <= 71)
                {
                    Konum += 6;

                }
                else if (rand > 71)
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
}


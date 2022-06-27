using System;
namespace Yarisma
{

    public abstract class Robot : IYarismaci
    {
        private string isim;
        protected Random rng;
        private int yarismaciNo;
        protected Pist yarismaPisti;

        public string Isim { get => isim; set => isim = Isim; }
        public int Konum { get; set; }
        public int YarismaciNo { get => this.yarismaciNo; set => yarismaciNo = YarismaciNo; }
        protected bool Bozuldu { get; set; }

        public abstract void HareketEt();


        public Robot(string Isim, Random rng, int YarismaciNo, Pist YarismaPisti)
        {
            isim = Isim;
            this.rng = rng;
            yarismaciNo = YarismaciNo;
            yarismaPisti = YarismaPisti;
        }
    }
}

using System;
namespace Yarisma
{
	public interface IYarismaci
	{
		string Isim { get; set; }
		int Konum { get; set; }
		int YarismaciNo { get; set; }

		void HareketEt();
	}
}


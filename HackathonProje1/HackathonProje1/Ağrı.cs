using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProje1
{
    class Ağrı : Onerilenler
    {

        public Ağrı()
        {
            Öneri1 = "Arpa";
            Öneri2 = "Buğday";
            Öneri3 = "Şeker Pancarı";

            Öneri1Su = 50;
            Öneri1Ekim = "Kasım";
            Öneri1Hasat = 1;
            TürkiyeFiyatı1 = 2;
            AvrupaOrtalamaFiyatı1 = 0.35M;

            Öneri2Su = 60;
            Öneri2Ekim = "Ekim";
            Öneri2Hasat = 1;
            TürkiyeFiyatı2 = 3;
            AvrupaOrtalamaFiyatı2 = 0.20M;

            Öneri3Su = 120;
            Öneri3Ekim = "Nisan";
            Öneri3Hasat = 6;
            TürkiyeFiyatı3 = 1;
            AvrupaOrtalamaFiyatı3 = 1.3M;

        }
    }
}

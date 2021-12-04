using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProje1
{
    class Adıyaman : Onerilenler
    {
        public Adıyaman()
        {
            Öneri1 = "Buğday";
            Öneri2 = "Arpa";
            Öneri3 = "Pamuk";

            Öneri1Su = 60;
            Öneri1Ekim = "Ekim";
            Öneri1Hasat = 1;
            TürkiyeFiyatı1 = 3;
            AvrupaOrtalamaFiyatı1 = 0.20M;

            Öneri2Su = 50;
            Öneri2Ekim = "Kasım";
            Öneri2Hasat = 1;
            TürkiyeFiyatı2 = 2;
            AvrupaOrtalamaFiyatı2 = 0.35M;

            Öneri3Su = 100;
            Öneri3Ekim = "Nisan";
            Öneri3Hasat = 5;
            TürkiyeFiyatı3 = 14;
            AvrupaOrtalamaFiyatı3 = 0.01M;
        }
            
    }
}

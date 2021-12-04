using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProje1
{
    class Amasya : Onerilenler
    {
        public Amasya()
        {
            Öneri1 = "Elma";
            Öneri2 = "Kiraz";
            Öneri3 = "Soğan";

            Öneri1Su = 120;
            Öneri1Ekim = "Nisan";
            Öneri1Hasat = 12;
            TürkiyeFiyatı1 = 4;
            AvrupaOrtalamaFiyatı1 = 2.11M;

            Öneri2Su = 75;
            Öneri2Ekim = "Ocak";
            Öneri2Hasat = 12;
            TürkiyeFiyatı2 = 8;
            AvrupaOrtalamaFiyatı2 = 3.2M;

            Öneri3Su = 60;
            Öneri3Ekim = "Eylül";
            Öneri3Hasat = 24;
            TürkiyeFiyatı3 = 1;
            AvrupaOrtalamaFiyatı3 = 1;
        }
    }
}

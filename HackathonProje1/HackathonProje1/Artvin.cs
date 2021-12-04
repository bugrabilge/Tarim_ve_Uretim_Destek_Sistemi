using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProje1
{
    class Artvin : Onerilenler
    {
        public Artvin()
        {
            Öneri1 = "Arpa";
            Öneri2 = "Patates";
            Öneri3 = "Buğday";

            Öneri1Su = 50;
            Öneri1Ekim = "Kasım";
            Öneri1Hasat = 1;
            TürkiyeFiyatı1 = 2;
            AvrupaOrtalamaFiyatı1 = 0.35M;

            Öneri2Su = 150;
            Öneri2Ekim = "Mart";
            Öneri2Hasat = 3;
            TürkiyeFiyatı2 = 3;
            AvrupaOrtalamaFiyatı2 = 1;

            Öneri3Su = 60;
            Öneri3Ekim = "Ekim";
            Öneri3Hasat = 1;
            TürkiyeFiyatı3 = 3;
            AvrupaOrtalamaFiyatı3 = 0.20M;
        }

    }
}

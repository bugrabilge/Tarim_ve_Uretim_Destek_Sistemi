using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProje1
{
    class Balıkesir : Onerilenler
    {
        public Balıkesir()
        {
            Öneri1 = "Zeytin";
            Öneri2 = "İncir";
            Öneri3 = "Elma";

            Öneri1Su = 110;
            Öneri1Ekim = "Haziran";
            Öneri1Hasat = 12;
            TürkiyeFiyatı1 = 7;
            AvrupaOrtalamaFiyatı1 = 8;

            Öneri2Su = 50;
            Öneri2Ekim = "Mart";
            Öneri2Hasat = 4;
            TürkiyeFiyatı2 = 10;
            AvrupaOrtalamaFiyatı2 = 9;

            Öneri3Su = 120;
            Öneri3Ekim = "Nisan";
            Öneri3Hasat = 12;
            TürkiyeFiyatı3 = 4;
            AvrupaOrtalamaFiyatı3 = 2.10M;
        }
    }
}

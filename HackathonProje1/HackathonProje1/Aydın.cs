using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonProje1
{
    class Aydın : Onerilenler
    {
        public Aydın()
        {
            Öneri1 = "İncir";
            Öneri2 = "Zeytin";
            Öneri3 = "Pamuk";

            Öneri1Su = 50;
            Öneri1Ekim = "Mart";
            Öneri1Hasat = 4;
            TürkiyeFiyatı1 = 10;
            AvrupaOrtalamaFiyatı1 = 9;

            Öneri2Su = 110;
            Öneri2Ekim = "Haziran";
            Öneri2Hasat = 12;
            TürkiyeFiyatı2 = 7;
            AvrupaOrtalamaFiyatı2 = 8;

            Öneri3Su = 110;
            Öneri3Ekim = "Nisan";
            Öneri3Hasat = 5;
            TürkiyeFiyatı3 = 14;
            AvrupaOrtalamaFiyatı3 = 0.01M;
        }
    }
}

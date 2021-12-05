using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Enums;
using TestCase.Interfaces;

namespace TestCase.Models
{
    public class RoverTalimatlar
    {
        public static Yonler SagaDon(Yonler yon)
        {
            Yonler simdikiDurum = yon;
            switch (yon)
            {
                case Yonler.Guney:
                    simdikiDurum = Yonler.Bati;
                    break;
                case Yonler.Kuzey:
                    simdikiDurum = Yonler.Dogu;
                    break;
                case Yonler.Dogu:
                    simdikiDurum = Yonler.Guney;
                    break;
                case Yonler.Bati:
                    simdikiDurum = Yonler.Kuzey;
                    break;
                default:
                    break;
            }
            return yon;
        }

        public static Yonler SolaDon(Yonler yon)
        {
            Yonler simdikiDurum = yon;
            switch (yon)
            {
                case Yonler.Guney:
                    simdikiDurum = Yonler.Dogu;
                    break;
                case Yonler.Kuzey:
                    simdikiDurum = Yonler.Bati;
                    break;
                case Yonler.Dogu:
                    simdikiDurum = Yonler.Kuzey;
                    break;
                case Yonler.Bati:
                    simdikiDurum = Yonler.Guney;
                    break;
                default:
                    break;
            }
            return yon;
        }

        public static IRoverPozisyon HareketEt(IRoverPozisyon pozisyon)
        {
            IRoverPozisyon simdikiDurum = pozisyon;
            switch (pozisyon.yon)
            {
                
                case Yonler.Guney:
                    simdikiDurum = new RoverPozisyon(simdikiDurum.yon, pozisyon.X, pozisyon.Y - 1);
                    break;
                case Yonler.Bati:
                    simdikiDurum = new RoverPozisyon(simdikiDurum.yon, pozisyon.X - 1, pozisyon.Y);
                    break;
                case Yonler.Dogu:
                    simdikiDurum = new RoverPozisyon(simdikiDurum.yon, pozisyon.X + 1, pozisyon.Y);
                    break;
                case Yonler.Kuzey:
                    simdikiDurum = new RoverPozisyon(simdikiDurum.yon, pozisyon.X, pozisyon.Y + 1);
                    break;
                default:
                    break;
            }

            return pozisyon;
        }
    }
}

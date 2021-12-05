using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Interfaces;

namespace TestCase.Models
{
    public class Rover : IRover
    {
        private const char inputL = 'L';
        private const char inputM = 'M';
        private const char inputR = 'R';
        public IList<IKomut> Komutlar { get; set; }
        public IRoverPozisyon _simdikiPozisyon { get; private set; }
        public Rover()
        {
            this.Komutlar = new List<IKomut>();
        }
        public Rover(IRoverPozisyon roverPozisyon)
        {
            _simdikiPozisyon = roverPozisyon;
        }
        public void HareketEt()
        {
            _simdikiPozisyon = RoverTalimatlar.HareketEt(_simdikiPozisyon);
        }

        public void KomutuSec(string roverTalimat)
        {
            // çoklu karakter girişi
            foreach (var item in roverTalimat.ToCharArray())
            {
                switch (char.ToUpper(item))
                {
                    case inputL:
                        this.Komutlar.Add(new SolaDonKomutu(this));
                        break;
                    case inputM:
                        this.Komutlar.Add(new HareketKomutu(this));
                        break;
                    case inputR:
                        this.Komutlar.Add(new SagaDonKomutu(this));
                        break;
                    default:
                        break;
                }
            }
        }

        public void SagaDon()
        {
            _simdikiPozisyon.yon = RoverTalimatlar.SagaDon(_simdikiPozisyon.yon);
        }

        public void SolaDon()
        {
            _simdikiPozisyon.yon = RoverTalimatlar.SolaDon(_simdikiPozisyon.yon);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Interfaces;

namespace TestCase.Models
{
    public class HareketKomutu : IKomut
    {
        IRover _rover;
        public HareketKomutu(IRover rover)
        {
            _rover = rover;
        }
        public void Islem()
        {
            _rover.HareketEt();
        }
    }
}

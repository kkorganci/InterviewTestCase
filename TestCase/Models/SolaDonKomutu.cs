using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Interfaces;

namespace TestCase.Models
{
    public class SolaDonKomutu : IKomut
    {
        IRover _rover;
        public SolaDonKomutu(IRover rover)
        {
            _rover = rover;
        }
        public void Islem()
        {
            _rover.SolaDon();
        }
    }
}

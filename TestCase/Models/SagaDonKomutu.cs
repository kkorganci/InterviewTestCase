using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Interfaces;

namespace TestCase.Models
{
    public class SagaDonKomutu : IKomut
    {
        IRover _rover;
        public SagaDonKomutu(IRover rover)
        {
            _rover = rover;
        }
        public void Islem()
        {
            _rover.SagaDon();
        }
    }
}

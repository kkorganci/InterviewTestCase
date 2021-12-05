using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Enums;
using TestCase.Interfaces;

namespace TestCase.Models
{
    public class RoverPozisyon : IRoverPozisyon
    { 
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Yonler yon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RoverPozisyon(Yonler yon = Yonler.Kuzey, int x=0,int y=0)
        {
            X = x;
            Y = y;
            this.yon = yon;
        }
    }
}

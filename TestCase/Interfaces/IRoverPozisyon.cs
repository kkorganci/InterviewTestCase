using System;
using System.Collections.Generic;
using System.Text;
using TestCase.Enums;

namespace TestCase.Interfaces
{
    public interface IRoverPozisyon
    {
        int X { get; set; }
        int Y { get; set; }
        Yonler yon { get; set; }
    }
}

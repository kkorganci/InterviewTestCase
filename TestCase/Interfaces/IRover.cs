using System;
using System.Collections.Generic;
using System.Text;

namespace TestCase.Interfaces
{
    /// <summary>
    /// işlemler
    /// </summary>
    public interface IRover
    { 
        void HareketEt();
        void SolaDon();
        void SagaDon();
        void KomutuSec(string roverTalimat);
    }
}

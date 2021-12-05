using System;
using TestCase.Interfaces;
using TestCase.Models;

namespace TestCase
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Roverın pozisyonu giriniz: ");
            var roverPosition = Console.ReadLine();
            Console.WriteLine("Rovera komut veriniz: ");
            var roverCmd = Console.ReadLine();
            //  
            var roverPo = new RoverPozisyon();
            var rover = new Rover(roverPo);
            rover.KomutuSec(roverCmd);
            // todo
            // classları bağladım ama burda değerleri sürekli almak için
            // döngü gerekiyor sanırım. Biraz hata yaptım gibi. 
           
        }
    }
}

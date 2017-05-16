using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2015137308.Entities.Entities;
using _2015137308.Persistence.EntityTypeConfigurations;

namespace _2015137308.ConsoleApp
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            var Transporte = new Transporte();
            Transporte.Service();
            var Encomienda = new Encomienda();
            Encomienda.Service();
            Console.ReadLine();
        }
       
       

    }
}

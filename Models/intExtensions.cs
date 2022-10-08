using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public static class intExtensions
    {
        public static bool Epar(this int numburo){
            return numburo % 2 == 0;
        }
    }
}
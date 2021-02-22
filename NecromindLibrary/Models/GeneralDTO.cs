using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NecromindLibrary.Models
{
    public class GeneralDTO<T>
    {
        public ErrorModel Error { get; set; }
        public List<T> Elements { get; set; }
    }
}

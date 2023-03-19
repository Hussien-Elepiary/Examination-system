using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Library.BaseQuestion
{
    internal interface IMainQuestion
    {
        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public int Mark { get; set; }
    }
}

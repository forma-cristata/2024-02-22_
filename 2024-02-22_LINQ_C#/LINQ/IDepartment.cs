using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public enum Department
    {
        English,
        Math,
        Science,
        History,
        Art,
        Music,
        HealthAndPhysEd,
        ComputerScience,
        Business
    }
    
    public interface IDepartment
    {
        public Department Department { get; protected set; }
    }
}

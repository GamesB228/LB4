using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public interface IExpirable
    {
        bool CheckExpiry(DateTime date);
    }
}

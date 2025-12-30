using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public interface IFileReader<T>
    {
        Task<T> ReadAsync(string path);
    }
}

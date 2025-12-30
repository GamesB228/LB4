using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LB6
{
    public class JsonFileWriter<T> : IFileWriter<T>
    {
        public async Task WriteAsync(string path, T data)
        {
            using FileStream fs = new FileStream(path, FileMode.Create);
            await JsonSerializer.SerializeAsync(fs, data);
        }
    }
}

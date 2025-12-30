using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LB6
{
    public class JsonFileReader<T> : IFileReader<T>
    {
        public async Task<T> ReadAsync(string path)
        {
            using FileStream fs = new FileStream(path, FileMode.Open);
            return await JsonSerializer.DeserializeAsync<T>(fs);
        }
    }
}

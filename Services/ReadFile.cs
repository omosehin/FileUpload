using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace ReadExcelFile.Services
{
    public class ReadingFile
    {
        public double item1 { get; set; }
        public double item2 { get; set; }
    }
    public interface IReadFile
    {
        Task<string> Readxlfile(IFormFile file);
    }
    public class ReadFile : IReadFile
    {
        public async Task<string> Readxlfile(IFormFile file)
        {
            string line;
            var res = new List<ReadingFile>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                while (reader.Peek()>0)
                {
                    line = reader.ReadLine();

                    res.Add(new ReadingFile
                    {
                        item1 = Convert.ToDouble( line.Split(',')[0]),
                        item2 = Convert.ToDouble(line.Split(',')[1])
                    });
                }
                
            }

            return "hello";
        }
    }
}

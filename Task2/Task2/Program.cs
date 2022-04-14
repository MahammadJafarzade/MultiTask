using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AcerStore n1 = new AcerStore(001, "Nitro5", 2000);
            AcerStore n2 = new AcerStore(002, "Aspire3", 1500);
            List<AcerStore> list = new List<AcerStore>();
            list.Add(n1);
            list.Add(n2);
            var json = JsonConvert.SerializeObject(list);
            Console.WriteLine(json);
            string result;
            using (StreamReader js = new StreamReader(@"C:\Users\Orkhan\OneDrive\Desktop\Relax\Summer.txt"))
            {
               result= js.ReadToEnd();
            };
            
            var acer = JsonConvert.DeserializeObject<List<AcerStore>>(json);
            
                Console.WriteLine(acer[0].model);                 
        
        }
    }
}

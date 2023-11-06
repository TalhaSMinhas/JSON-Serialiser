using System;
using System.IO;
using System.Text.Json;

namespace JSONSerializer
{
    internal class Program
    {
        public class Note
        {
            public string NoteName { get; set; }
            public string Abbreviation { get; set; }
            public string Content { get; set; }
        }
        
        public static void Main(string[] args)
        {
            var note1 = new Note
            {
                Abbreviation = "CMN",
                NoteName = "Client Meeting Notes",
                Content = "Discussed project requirements and deadlines with the client. Agreed to finalize the proposal by Friday."
            };

            var fileName = "note1.json";
            string jsonString = JsonSerializer.Serialize(note1);
            File.WriteAllText(fileName, jsonString);
            
            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
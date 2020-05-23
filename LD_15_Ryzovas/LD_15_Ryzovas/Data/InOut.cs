using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LD_15_Ryzovas.Data
{
    public class InOut : IInOut
    {
        public List<Publication> ReadAllFiles(string filePath)
        {
                var files = Directory.GetFiles(filePath);
                var dataFile = new List<Publication>();
                foreach (var file in files)
                {
                    using StreamReader reader = new StreamReader(file, System.Text.Encoding.UTF8);
                    var year = int.Parse(reader.ReadLine());
                    while (reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine();
                        var publication = new Publication(line);
                        publication.Year = year;
                        dataFile.Add(publication);
                    }
                    reader.Close();
                }
                
                return dataFile;
        }

        public List<Agent> ReadAgents(string fileName)
        {
            var agents = new List<Agent>();
            using (var reader = new StreamReader(fileName, System.Text.Encoding.UTF8))
            {
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLine();
                    string[] values = line?.Split(';');
                    string agentNr = values[0];
                    string agentSurname = values[1];
                    string agentName = values[2];
                    Agent publication = new Agent(agentNr, agentSurname, agentName);
                    agents.Add(publication);
                }
                reader.Close();
            }

            return agents;
        }
        
    }
}
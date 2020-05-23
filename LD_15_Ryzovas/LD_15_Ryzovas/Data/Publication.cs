namespace LD_15_Ryzovas.Data
{
    /// <summary>
    /// Publication object class.
    /// </summary>
    public class Publication
    {
        public int Year { get; set; }
        public string SubSurname { get; set; }
        public string Adress { get; set; }
        public int DataStart { get; set; }
        public int DataLength { get; set; }
        public int PubCount { get; set; }
        public string AgentNr { get; set; }

        /// <summary>
        /// Initializes a new instance of the object class.
        /// </summary>
        /// <param name="line">
        /// The line from file.
        /// </param>
        public Publication(string line)
        {
            var values = line?.Split(';');
            SubSurname = values[0];
            Adress = values[1];
            DataStart = int.Parse(values[2]);
            DataLength = int.Parse(values[3]);
            PubCount = int.Parse(values[4]);
            AgentNr = values[5];
        }
    }
}

namespace LD_15_Ryzovas.Data
{
    public class Agent
    {
        public string AgentNr { get; set; }
        public string AgentSurname { get; set; }
        public string AgentName { get; set; }

        public Agent(string agentNr, string agentSurname, string agentName)
        {
            AgentNr = agentNr;
            AgentSurname = agentSurname;
            AgentName = agentName;
        }
    }
}
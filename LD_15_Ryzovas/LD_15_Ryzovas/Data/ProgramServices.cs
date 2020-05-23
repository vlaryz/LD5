namespace LD_15_Ryzovas.Data
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The program services.
    /// </summary>
    public static class ProgramServices
    {
        /// <summary>
        /// The get agents charge.
        /// </summary>
        /// <param name="agents">
        /// The list with agents.
        /// </param>
        /// <param name="publications">
        /// The list with publications.
        /// </param>
        /// <param name="month">
        /// The month to search by.
        /// </param>
        /// The <returns name="dict">
        /// The dictionary with agents and their publications.
        /// </returns> 
        public static Dictionary<Agent, int> GetAgentsCharge(List<Agent> agents, List<Publication> publications, int month)
        {
            var dict = agents.ToDictionary(agent => agent, agent => publications.
                Where(x => x.AgentNr == agent.AgentNr && x.DataStart <= month && (x.DataStart + x.DataLength >= month))
                .Sum(publication => publication.PubCount));
            return dict;
        }

        /// <summary>
        /// The get years.
        /// </summary>
        /// <param name="publications">
        /// The list with publications.
        /// </param>
        /// <returns>
        /// The list with years<see cref="List"/>.
        /// </returns>
        public static List<int> GetYears(List<Publication> publications)
        {
            return publications.Select(x => x.Year).Distinct().ToList();
        }
    }
}
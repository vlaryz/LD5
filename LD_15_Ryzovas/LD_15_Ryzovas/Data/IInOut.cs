using System.Collections.Generic;

namespace LD_15_Ryzovas.Data
{
    /// <summary>
    /// The InOut interface.
    /// </summary>
    public interface IInOut
    {
        /// <summary>
        /// Reads all files.
        /// </summary>
        /// <param name="filePath">
        /// The path to files.
        /// </param>
        /// <returns>
        /// List with publications.
        /// </returns>
        public List<Publication> ReadAllFiles(string filePath);

        /// <summary>
        /// Reads all agents.
        /// </summary>
        /// <param name="fileName">
        /// Name of the file.
        /// </param>
        /// <returns>
        /// List with agents.
        /// </returns>
        public List<Agent> ReadAgents(string fileName);

    }
}
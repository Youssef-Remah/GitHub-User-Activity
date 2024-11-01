using System.Text;
using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class Payload
    {
        [JsonPropertyName("commits")]
        public List<Commit>? Commits { get; set; }

        public override string ToString()
        {
            StringBuilder totalCommits = new();

            if (Commits != null) 
            {
                foreach (Commit commit in Commits)
                {
                    totalCommits.Append($"{commit}");
                }
            }

            return totalCommits.ToString();
        }
    }
}

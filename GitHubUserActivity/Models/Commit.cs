using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class Commit
    {
        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        public override string ToString()
        {
            return $"Commit message: {Message}\n\n";
        }
    }
}

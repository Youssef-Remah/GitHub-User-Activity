using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class Repo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        public override string ToString()
        {
            return $"Repo Name: {Name}\n\nRepo URL: {Url}";
        }
    }
}

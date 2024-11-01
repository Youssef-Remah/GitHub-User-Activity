using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class UserEvent  
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("public")]
        public bool Public { get; set; }

        [JsonPropertyName("actor")]
        public Actor? Actor { get; set; }

        [JsonPropertyName("repo")]
        public Repo? Repo { get; set; }

        [JsonPropertyName("payload")]
        public Payload? Payload { get; set; }

        public override string ToString()
        {
            return $"Event Type: {Type}\n\nEvent Visibility: {Public}\n\n{Actor}\n\n{Repo}\n\n{Payload}";
        }
    }
}
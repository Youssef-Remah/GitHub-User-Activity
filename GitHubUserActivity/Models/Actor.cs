using System.Text.Json.Serialization;

namespace GitHubUserActivity.Models
{
    public class Actor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("display_login")]
        public string? DisplayLogin { get; set; }

        public override string ToString()
        {
            return $"Event Actor: {DisplayLogin}";
        }
    }
}

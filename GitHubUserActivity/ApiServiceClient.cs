using GitHubUserActivity.Models;
using System.Net;
using System.Net.Http.Json;

namespace GitHubUserActivity
{
	public class ApiServiceClient
	{
		static public async Task<List<UserEvent>?> GetUserEvents(string uri)
		{
			HttpClient client = new();

			client.DefaultRequestHeaders.Add("User-Agent", "GitHubUserActivityApp");

			try
			{
				List<UserEvent>? userEvents = await client.GetFromJsonAsync<List<UserEvent>>(uri);

				return userEvents;
			}

			catch (HttpRequestException e)
			{
                if (e.StatusCode is HttpStatusCode.NotFound)
				{
					Console.WriteLine("GitHub username doesn't exist!");
				}

				return null;
			}
		}
	}
}

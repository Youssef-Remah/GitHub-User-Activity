using GitHubUserActivity.Models;

namespace GitHubUserActivity
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("\n********** Welcome to the GitHub User Activity CLI app **********\n");

            Console.Write("Please type a valid GitHub username: ");


            string? username = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("\nUsername cannot be empty!");
            }


            string eventsEndpoint = $"https://api.github.com/users/{username}/events";

            List<UserEvent>? events = await ApiServiceClient.GetUserEvents(eventsEndpoint);


            if (events != null)
            {
                int eventsCount = events.Count;

                if (eventsCount == 0)
                {
                    Console.WriteLine($"\nNo events created for the user {username} in the past 90 days!");

                    return;
                }

                Console.WriteLine($"\nTotal Number of Events: {eventsCount}\n");

                for (int i = 0; i < eventsCount; i++)
                {
                    Console.WriteLine($"\nEvent {i+1}:\n");

                    Console.WriteLine(events[i]);

                    Console.WriteLine("--------------------------------------------------------");
                }
            }
        }
	}
}

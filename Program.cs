using System;

class Program
{
    static string ParseNotificationChannels(string input)
    {
        // Define the tags for different channels
        string[] channels = { "BE", "Backend", "FE", "Frontend", "QA", "Quality Assurance", "Urgent" };
        string result = "Receive channels: ";
        bool hasChannels = false;

        // Check for each channel in the input string
        foreach (string channel in channels)
        {
            if (input.Contains($"[{channel}]"))
            {
                if (hasChannels)
                {
                    result += ", ";
                }

                // Convert full names to shorthand
                switch (channel)
                {
                    case "Backend":
                        result += "BE";
                        break;
                    case "Frontend":
                        result += "FE";
                        break;
                    case "Quality Assurance":
                        result += "QA";
                        break;
                    default:
                        result += channel;
                        break;
                }

                hasChannels = true;
            }
        }

        // Return the result
        if (hasChannels)
        {
            return result;
        }
        else
        {
            return "No channels found.";
        }
    }

    static void Main(string[] args)
    {
        // Receive notification title from User Input
        Console.WriteLine("Enter the notification title:");
        string input = Console.ReadLine()!;

        string output = ParseNotificationChannels(input);
        Console.WriteLine(output);
    }
}

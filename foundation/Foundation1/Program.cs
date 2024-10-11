using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Python Tutorial for Beginners", "John Doe", 600);
        video1.AddComment("Alice", "Great video! Helped me a lot.");
        video1.AddComment("Bob", "This tutorial was awesome!");
        video1.AddComment("Charlie", "I love how simple the explanation is.");

        var video2 = new Video("Advanced Python Programming", "Jane Smith", 1200);
        video2.AddComment("David", "This is so informative, thanks for the details.");
        video2.AddComment("Eve", "Could you explain more about decorators?");
        video2.AddComment("Frank", "The examples are clear, but a little more theory would be nice.");

        var video3 = new Video("Machine Learning Basics", "Alice Green", 900);
        video3.AddComment("George", "This was a good introduction.");
        video3.AddComment("Helen", "When is the next video on this topic?");
        video3.AddComment("Ivy", "Looking forward to more tutorials.");

        
        var videos = new List<Video> { video1, video2, video3 };

        
        DisplayVideoInfo(videos);
            static void DisplayVideoInfo(List<Video> videos)
    {
        foreach (var video in videos)
        {
            // Display video details
            Console.WriteLine(video);
            Console.WriteLine("Comments:");

            // Display comments for the video
            foreach (var comment in video._comments)
            {
                Console.WriteLine(comment);
            }

            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }
    }
    }
}
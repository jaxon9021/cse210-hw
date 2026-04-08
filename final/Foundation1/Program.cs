using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        
        Video v1 = new Video("Intro to C#", "Alice", 300);
        v1.AddComment(new Comment("Bob", "Great introduction!"));
        v1.AddComment(new Comment("Jane", "Very helpful."));
        v1.AddComment(new Comment("Mike", "Thanks for explaining clearly."));
        videos.Add(v1);

        
        Video v2 = new Video("Object-Oriented Programming", "John", 600);
        v2.AddComment(new Comment("Sara", "Now I understand OOP!"));
        v2.AddComment(new Comment("Tom", "Nice examples."));
        v2.AddComment(new Comment("Emma", "Well explained."));
        videos.Add(v2);

        
        Video v3 = new Video("Advanced C# Tips", "Chris", 900);
        v3.AddComment(new Comment("Ryan", "Challenging but useful."));
        v3.AddComment(new Comment("Nina", "Learned a lot!"));
        v3.AddComment(new Comment("Luke", "Great content."));
        videos.Add(v3);

        
        Video v4 = new Video("Debugging Techniques", "Taylor", 450);
        v4.AddComment(new Comment("Olivia", "This helped me fix my code."));
        v4.AddComment(new Comment("Noah", "Debugging is easier now."));
        v4.AddComment(new Comment("Ava", "Awesome tips!"));
        videos.Add(v4);

        
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}
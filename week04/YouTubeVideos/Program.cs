using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("My first video", "Franco", 120);
        Video video2 = new Video("Tutorial Python", "Ana", 300);
        Video video3 = new Video("Trip with friends!", "Luis", 180);
        Video video4 = new Video("Gym transformation", "Tomas", 360);
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Loved it!"));
        video1.AddComment(new Comment("Emilio", "Never give up!"));
        video1.AddComment(new Comment("Jonathan", "Good luck!"));
        video2.AddComment(new Comment("Charlie", "Very helpful!"));
        video2.AddComment(new Comment("Diana", "Thanks for sharing!"));
        video2.AddComment(new Comment("Geraldine", "I didn't understand"));
        video3.AddComment(new Comment("Franco", "Nice video Franco haha"));
        video3.AddComment(new Comment("Rocio", "Nice trip!"));
        video3.AddComment(new Comment("Marcelo", "What a nice place!"));
        video4.AddComment(new Comment("Matias", "Nice motivation"));
        video4.AddComment(new Comment("Lolo", "Woow!"));
        video4.AddComment(new Comment("Jorge", "Respect"));
        foreach (Video v in videos)
        {
            v.ShowInfo();
        }
    }
}
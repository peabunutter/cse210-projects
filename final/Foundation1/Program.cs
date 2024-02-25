using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video("Fundamentals of C# - Part 7", "Vaughn Poulson", 1047);
        Video v2 = new Video("THE ILLUMINATI IS GOING TO TAKE OVER THE WORLD!!!!!!!!1!11!", "Conspiracy Carl", 2496);
        Video v3 = new Video("Let's Talk About It! s4 e14", "LTAI", 10050);
        Comment v1c1 = new Comment("HankTheTank2044","Great tutorial, thanks man!");
        Comment v1c2 = new Comment("B3nj@m1nFr@nkl!n", "You described that Really well");
        Comment v1c3 = new Comment("PorterClark", "Thanks for this series and for replying to all of my questions, it really helped! :D");
        Comment v2c1 = new Comment("CCFAn#1", "Keep your tin foil hat on at all times folks");
        Comment v2c2 = new Comment("FBI", "Noted");
        Comment v2c3 = new Comment("Illuminati", "Hi, it's the illuminai. Could you take this video down please?");
        Comment v3c1 = new Comment("katelynnoelle2343", "You had some really nice points, Nice video!");
        Comment v3c2 = new Comment("user-eg3dj4up6ms", "Actually, if you consider Karl's point a bit more, you'll see that in terms of speaking, he is technically in the right because of the second point he made at about 42:06.");
        Comment v3c3 = new Comment("TidoKan", "cool");
        v1._comments.AddRange(new List<Comment> {v1c1, v1c2, v1c3});
        v2._comments.AddRange(new List<Comment> {v2c1, v2c2, v2c3});
        v3._comments.AddRange(new List<Comment> {v3c1, v3c2, v3c3});
        videos.AddRange(new List<Video> {v1, v2, v3});
        foreach (Video video in videos)
        {
            Console.WriteLine($"\n{video._title}");
            Console.WriteLine(video._author);
            Console.WriteLine(video._length);
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"\n{comment._name}");
                Console.WriteLine(comment._text);
            }
        }
    }
}
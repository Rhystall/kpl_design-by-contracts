using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        this.id = new Random().Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }
        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {username}");
        int i = 0;
        foreach (var video in uploadedVideos)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }
}

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Ofa");

        string[] filmList = {
            "Review Film Interstellar oleh Ofa",
            "Review Film Inception oleh Ofa",
            "Review Film The Dark Knight oleh Ofa",
            "Review Film Parasite oleh Ofa",
            "Review Film Avengers: Endgame oleh Ofa",
            "Review Film The Matrix oleh Ofa",
            "Review Film The Godfather oleh Ofa",
            "Review Film Joker oleh Ofa",
            "Review Film Whiplash oleh Ofa",
            "Review Film Forrest Gump oleh Ofa"
        };

        foreach (var title in filmList)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            user.AddVideo(video);
            video.IncreasePlayCount(new Random().Next(1, 10000)); 
            video.PrintVideoDetails();
        }

        Console.WriteLine();
        user.PrintAllVideoPlayCount();
        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
    }
}


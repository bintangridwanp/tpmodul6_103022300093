namespace tpmodul6_103022300093;

using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Debug.Assert(!string.IsNullOrEmpty(username) && username.Length <= 100, "Username tidak boleh kosong atau lebih dari 100 karakter!");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video tidak boleh null!");
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoDetails()
    {
        Console.WriteLine($"User: {username} (ID: {id})");
        Console.WriteLine("Daftar Video:");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            uploadedVideos[i].PrintVideoDetails();
        }
    }
}

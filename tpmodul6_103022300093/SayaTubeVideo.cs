namespace tpmodul6_103022300093;

using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 100, "Judul tidak boleh kosong atau lebih dari 100 karakter!");
        
        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // ID random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0 && count <= 10000000, "Penambahan play count harus antara 1 hingga 10 juta!");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Jumlah play count melebihi batas maksimum integer.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}

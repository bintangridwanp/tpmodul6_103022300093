using System;
using tpmodul6_103022300093;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Agusi");

        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Agusi");
        SayaTubeVideo video2 = new SayaTubeVideo("Belajar C# untuk Pemula");

        video1.IncreasePlayCount(5000);
        video2.IncreasePlayCount(10000);

        user.AddVideo(video1);
        user.AddVideo(video2);

        user.PrintAllVideoDetails();
    }
}
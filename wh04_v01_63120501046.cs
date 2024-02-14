using System;
using System.Collections.Generic;

public abstract class Post 
{
  public string Content { get; set; }
  public string UserName { get; set; }

  public abstract void Display(); //ความสามารถของโพสต์
}  

public class TextPost : Post 
{
  public override void Display() 
  {
    Console.WriteLine("Text Post by " + UserName + ": " + Content);
  }
}

public class ImagePost : Post
{
  public string ImageUrl { get; set; }

  public override void Display() 
  {  
    Console.WriteLine("Image Post by " + UserName + ": " + Content);
    Console.WriteLine("Image URL: " + ImageUrl);
  }
}

public class VideoPost : Post
{
  public string VideoUrl { get; set; }

  public override void Display() 
  {  
    Console.WriteLine("Video Post by " + UserName + ": " + Content);
    Console.WriteLine("Video URL: " + VideoUrl);
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    List<Post> postList = new List<Post>();

    TextPost textPost1 = new TextPost {
      UserName = "Alice",
      Content = "Hello, World!"
      };
    TextPost textPost2 = new TextPost {
      UserName = "Bob",
      Content = "C# is fun!"
      };
  
    ImagePost imagePost1 = new ImagePost {
      UserName = "Charlie",
      Content = "Beautiful sunset",
      ImageUrl = "sunset.jpg"
    };
    ImagePost imagePost2 = new ImagePost {
      UserName = "Diana",
      Content = "Cute cat",
      ImageUrl = "cat.jpg"
    };
    
    VideoPost videoPost1 = new VideoPost {
      UserName = "Charlie",
      Content = "Funny cat video",
      VideoUrl = "cat_video.mp4"
    };
    
    postList.Add(textPost1);
    postList.Add(textPost2);
    postList.Add(imagePost1);
    postList.Add(imagePost2);
    postList.Add(videoPost1);
    
    foreach (Post post in postList) {
    post.Display();
    Console.WriteLine("------");
    }
  }
}
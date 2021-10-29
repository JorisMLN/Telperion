using EldarStory.Models;
using System.Collections.Generic;
using System.Linq;

namespace EldarStory.Services
{
  public static class StoryService
  {
    static List<Story> Stories { get; }
    static int nextId = 3;
    static StoryService()
    {
      Stories = new List<Story>
      {
        new Story
        { 
          Id = 0,
        
          Content = new StoryDetails
          { 
            Title = "Fondation de la Guilde", 
            Details = new List<string>{"toto", "tata"}
          },

          Info = new StoryDetails
          { 
            Title = "Decembre", 
            Details = new List<string>{"toto", "tata"}
          },

          Icon = "Youpi" 
        },

        new Story
        { 
          Id = 1,

          Content = new StoryDetails
          { 
            Title = "Bienvenue", 
            Details = new List<string>{"toto", "tata"}
          },

          Info = new StoryDetails
          { 
            Title = "Bienvenue", 
            Details = new List<string>{"toto", "tata"}
          },

          Icon = "Hourra" 
        },
      };
    }

    public static List<Story> GetAll() => Stories;

    public static Story Get(int id) => Stories.FirstOrDefault(p => p.Id == id);

    public static void Add(Story story)
    {
      story.Id = nextId++;
      Stories.Add(story);
    }

    public static void Delete(int id)
    {
      var Story = Get(id);
      if (Story is null)
        return;

      Stories.Remove(Story);
    }

    public static void Update(Story Story)
    {
      var index = Stories.FindIndex(p => p.Id == Story.Id);
      if (index == -1)
        return;

      Stories[index] = Story;
    }
  }
}
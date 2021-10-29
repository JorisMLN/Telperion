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
            Details = new List<string>{"Arsenal de Vizunah", "13 Décembre 2012"}
          },
          Info = new StoryDetails
          { 
            Title = "Guild Wars 2", 
            Details = new List<string>{"PvP", "McM"}
          },
          Icon = "laptopMacIcon" 
        },

        new Story
        { 
          Id = 1,
          Content = new StoryDetails
          { 
            Title = "Chagement de Nom", 
            Details = new List<string>{"Vizunah NightWatch", "Février 2013"}
          },
          Info = new StoryDetails
          { 
            Title = "Guild Wars 2", 
            Details = new List<string>{"PvP", "McM"}
          },
          Icon = "repeatIcon" 
        },

        new Story
        { 
          Id = 2,
          Content = new StoryDetails
          { 
            Title = "Chagement de Nom", 
            Details = new List<string>{"Eldarium", "Avril 2013"}
          },
          Info = new StoryDetails
          { 
            Title = "Guild Wars 2", 
            Details = new List<string>{"PvP", "McM"}
          },
          Icon = "repeatIcon" 
        },

        new Story
        { 
          Id = 3,
          Content = new StoryDetails
          { 
            Title = "Gallion & TardePack", 
            Details = new List<string>{"Juin 2013", ""}
          },
          Info = new StoryDetails
          { 
            Title = "ArcheAge", 
            Details = new List<string>{"PvP", "PvE", "Housing"}
          },
          Icon = "repeatIcon" 
        },

        new Story
        { 
          Id = 4,
          Content = new StoryDetails
          { 
            Title = "Alliance Le Pacte d'Orion", 
            Details = new List<string>{"Aout 2013", ""}
          },
          Info = new StoryDetails
          { 
            Title = "ArcheAge", 
            Details = new List<string>{"PvP", "PvE", "Housing"}
          },
          Icon = "repeatIcon" 
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
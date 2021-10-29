using System.Collections.Generic;
namespace EldarStory.Models
{
    public class Story
  {
    public int Id { get; set; }
    public StoryDetails Content { get; set; }
    public StoryDetails Info { get; set; }
    public string Icon { get; set; }
  }
  public class StoryDetails
  {
    public string Title { get; set; }
    public List<string> Details { get; set; }
  }
}
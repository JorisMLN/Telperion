using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EldarStory.Models;
using EldarStory.Services;

namespace EldarStory.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class StoryController : ControllerBase
  {
    public StoryController()
    {
    }

    [HttpGet]
    public ActionResult<List<Story>> GetAll() =>
    StoryService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Story> Get(int id)
    {
      var story = StoryService.Get(id);

      if (story == null)
        return NotFound();

      return story;
    }

    [HttpPost]
    public IActionResult Create(Story story)
    {
      StoryService.Add(story);
      return CreatedAtAction(nameof(Create), new { id = story.Id }, story);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Story story)
    {
      if (id != story.Id)
        return BadRequest();

      var existingStory = StoryService.Get(id);
      if (existingStory is null)
        return NotFound();

      StoryService.Update(story);

      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var story = StoryService.Get(id);

      if (story is null)
        return NotFound();

      StoryService.Delete(id);

      return NoContent();
    }
  }
}
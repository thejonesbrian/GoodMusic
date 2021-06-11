using GoodMusic.Data.Models;
using GoodMusic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace GoodMusic.Web.Controllers
{
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly ILogger<MusicController> _logger;
        private readonly IMusicService _musicService;

        public MusicController(ILogger<MusicController> logger, IMusicService musicService)
        {
            _logger = logger;
            _musicService = musicService;
        }

        [HttpGet("/api/music")]
        public ActionResult GetMusic()
        {
            var music = _musicService.GetAllMusic();
            return Ok(music);
        }

        [HttpGet("/api/music/{id}")]
        public ActionResult GetMusicById(int id)
        {
            var music = _musicService.GetMusic(id);
            return Ok(music);
        }
        
        [HttpPost("/api/music")]
        public ActionResult CreateNewMusicEntry([FromBody] NewMusicRequest musicRequest)
        {
            var rightNow = DateTime.UtcNow;
            var music = new Music
            {
                CreatedOn = rightNow,
                UpdatedOn = rightNow,
                Title = musicRequest.Title,
                BandName = musicRequest.BandName
            };
            _musicService.AddMusic(music);
            return Ok($"You Created: { music.Title } from { music.BandName }");
        }
        [HttpDelete("/api/music/{id}")]
        public ActionResult DeleteMusic(int id)
        {
            _musicService.DeleteMusic(id);
            return Ok($"You deleted: { id }");
        }
    }
}

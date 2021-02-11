using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMusic.Models;
using MvcMusic.Data;

namespace MvcMusic.Controllers.Api
{
    [Route("api/music")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly MvcMusicContext _context;

        public MusicController(MvcMusicContext context)
        {
            _context = context;
        }

        // GET: api/music
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicDTO>>> GetMusics()
        {
            return await _context.Music
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MusicDTO>> GetMusic(int id)
        {
            var music = await _context.Music.FindAsync(id);

            if (music == null)
            {
                return NotFound();
            }

            return ItemToDTO(music);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMusic(int id, MusicDTO musicDTO)
        {
            if (id != musicDTO.Id)
            {
                return BadRequest();
            }

            var music = await _context.Music.FindAsync(id);
            if (music == null)
            {
                return NotFound();
            }

            music.Title = musicDTO.Title;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!MusicExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Music>> CreateMusic(Music music)
        {

            _context.Music.Add(music);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetMusic),
                new { id = music.Id },
                ItemToDTO(music));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int id)
        {
            var music = await _context.Music.FindAsync(id);

            if (music == null)
            {
                return NotFound();
            }

            _context.Music.Remove(music);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicExists(long id) =>
             _context.Music.Any(e => e.Id == id);

        private static MusicDTO ItemToDTO(Music music) =>
            new MusicDTO
            {
                Id = music.Id,
                Title = music.Title,
                ReleaseDate = music.ReleaseDate,
                Price = music.Price,
                Genre = music.Genre,
                Rating = music.Rating,
            };
    }
}

using GoodMusic.Data;
using GoodMusic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodMusic.Services
{
    public class MusicService : IMusicService
    {
        private readonly GoodMusicDbContext _db;
        public MusicService(GoodMusicDbContext db)
        {
            _db = db;
        }
        public void AddMusic(Music music)
        {
            _db.Add(music);
            _db.SaveChanges();
        }

        public void DeleteMusic(int musicId)
        {
            var musicToDelete = _db.Music.Find(musicId);
            if(musicToDelete != null)
            {
                _db.Remove(musicToDelete);
                _db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("No such book available to delete");
            }
            
        }

        public List<Music> GetAllMusic()
        {
            return _db.Music.ToList();
        }

        public Music GetMusic(int MusicId)
        {
            return _db.Music.Find(MusicId);
        }
    }
}

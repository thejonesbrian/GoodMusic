using GoodMusic.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodMusic.Services
{
    public interface IMusicService
    {
        public List<Music> GetAllMusic();
        public Music GetMusic(int MusicId);
        public void AddMusic(Music music);
        public void DeleteMusic(int musicId);
    }
}

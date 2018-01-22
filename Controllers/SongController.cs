using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicHistory.Models;
using MusicHistory.Data;
using MusicHistory.Models.ViewModels;

namespace MusicHistory.Controllers
{
    public class SongsController : Controller
    {
        private MusicHistoryContext context;

        public SongsController(MusicHistoryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            SongListViewModel model = new SongListViewModel();
            model.Songs = from s in context.Song
                join a in context.Artist
                on s.ArtistId equals a.ArtistId
                select new SongInfo {
                    Id = s.SongId,
                    Title = s.Title,
                    Released = s.ReleaseDate,
                    Length = s.SongLength,
                    Artist = a.ArtistName
                };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            SongInfo info = (from s in context.Song
                join a in context.Artist
                on s.ArtistId equals a.ArtistId
                where s.SongId == id
                select new SongInfo {
                    Id = s.SongId,
                    Title = s.Title,
                    Released = s.ReleaseDate,
                    Length = s.SongLength,
                    Artist = a.ArtistName
                }).Single() ;

            return View(info);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

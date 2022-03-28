using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02_BTTLam.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        public ActionResult ShowSong()
        {
            return View();
        }
        //GET: Action chi tiết bài hát
        public ActionResult DetailsSong(string SongName, string AuthorName)
        {
            ViewBag.Song = SongName;
            ViewBag.Author = AuthorName;
            return View();
        }
        public ActionResult DownloadSong()
        {
            return View();
        }
    }
}
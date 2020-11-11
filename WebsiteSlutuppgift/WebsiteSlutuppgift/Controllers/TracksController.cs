using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebsiteSlutuppgift.Models;

namespace WebsiteSlutuppgift.Controllers
{
    public class TracksController : Controller
    {
        public TracksController()
        {

        }

        // GET: Tracks
        public IActionResult Index()
        {
            var tracks = DbContext.Tracks;

            return View(tracks);
        }

        // GET: Tracks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tracks/Create
        [HttpPost]
        // från vyn till metoden i controllen
        public IActionResult Create(Track track)
        {
            if (ModelState.IsValid)
            {
                track.Id = Guid.NewGuid();
                DbContext.Tracks.Add(track);
                return RedirectToAction("Index");
            }

            return View(track);
        }

        // GET: Tracks/Edit/5
        public IActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = DbContext.Tracks.FirstOrDefault(r => r.Id == id);

            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        // POST: Tracks/Edit/5
        [HttpPost]
        public IActionResult Edit(Track track)
        {
            if (ModelState.IsValid)
            {
                var trackIndex = DbContext.Tracks.FindIndex(m => m.Id == track.Id);

                if (trackIndex == -1)
                {
                    return NotFound();
                }

                DbContext.Tracks[trackIndex] = track;

                return RedirectToAction(nameof(Index));
            }

            return View(track);
        }

        // GET: Tracks/Delete/5
        public IActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = DbContext.Tracks.FirstOrDefault(r => r.Id == id);

            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        // POST: Rooms/Delete/5
        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var track = DbContext.Tracks.FirstOrDefault(r => r.Id == id);

            if (track == null)
            {
                return NotFound();
            }

            DbContext.Tracks.Remove(track);

            return RedirectToAction("Index");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Site_Guia.API.Models;

namespace Site_Guia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteController : ControllerBase
    {
        public IEnumerable<Site> _site = new Site[]
        {
            new Site() {
                SiteID = 1,
                Categoria = "Musica e Sons",
                Nome = "Music Maker",
                Descricao = "Quality free music for everyone. High-quality digital resources which make your sound great./21 tracks in mp3 format (3 per category )/1 set of stems* included",
                URL = "https://musicmaker.site/?ref=evernote.design",
                ImagemURL = "Music Maker.png",
            },
             new Site() {
                SiteID = 2,
                Categoria = "Musica e Sons",
                Nome = "bentensound",
                Descricao = "A decentralized platform for completely free stock music for your videos.",
                URL = "https://bentensound.com/?ref=evernote.design",
                ImagemURL = "bentensound.png",
            },
              new Site() {
                SiteID = 3,
                Categoria = "Musica e Sons",
                Nome = "WOWA",
                Descricao = "ADownload royalty free music for YouTube videos, Podcasts and Apps. No copyright CC0. Music inspired by Unsplash. All music published on wowa.me is licensed under Creative Commons Zero which means you can copy, modify, distribute and use the music for free, including commercial purposes, without asking permission from or providing attribution to the creator" ,
                URL = "https://www.unminus.com/?ref=evernote.design",
                ImagemURL = "WOWA.png",
            }

        };

        public SiteController()
        {

        }

        [HttpGet]
        public IEnumerable<Site> Get()
        {
            return _site;
        }

        [HttpGet("{id}")]
        public IEnumerable<Site> GetById(int id)
        {
            return _site.Where(site => site.SiteID == id);
        }
    }
}

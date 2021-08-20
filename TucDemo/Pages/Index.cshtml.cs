using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TucDemo.Data;

namespace TucDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _dbcontext;

        public List<HockeyPlayer> Player { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Jerseynumber { get; set; }
        public string city { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
            _dbcontext.Database.Migrate();
        }

        public void OnGet()
        {
            Player = _dbcontext.player.Select(c => new HockeyPlayer
            {
                Id = c.Id,
                Name = c.Name,
                JerseyNumber = c.JerseyNumber,

            }).ToList();

        }
    }
}

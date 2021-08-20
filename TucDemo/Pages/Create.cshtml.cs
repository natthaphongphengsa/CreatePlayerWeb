using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TucDemo.Data;

namespace TucDemo.Pages.Shared
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        [Required]
        public string Name { get; set; }
        [Range(1,100)]
        public int JerseyNumber { get; set; }
        [Required]
        public string City { get;set; }

        private readonly ApplicationDbContext _dbContext;

        public CreateModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public List<HockeyPlayer> Players = new List<HockeyPlayer>();

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var player = new HockeyPlayer();
                player.Name = Name;
                player.JerseyNumber = JerseyNumber;
                player.City = City;
                _dbContext.player.Add(player);
                _dbContext.SaveChanges();
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TucDemo.Data
{
    [BindProperties]
    public class HockeyPlayer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int JerseyNumber { get; set; }

        public string City { get; set; }
    }
}

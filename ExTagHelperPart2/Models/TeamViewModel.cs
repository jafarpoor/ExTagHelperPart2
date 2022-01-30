
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExTagHelperPart2.Models
{
    public class TeamViewModel
    {
        public string Name { get; set; }
        public List<SelectListItem> Teams { get; set; }
        public EnumSuport GetSuport { get; set; }
        public IEnumerable<string> TeamMltipe { get; set; }

        public List<SelectListItem> SelectListTeamMltipe { get; set; }
    }
    public enum EnumSuport
    {
        [Display(Name ="فوتبال")]
        fotball =1,

        [Display(Name = "والیبال")]
        valibal =2,

        [Display(Name = "بسکتبال")]
        basketbal =3
    }
}

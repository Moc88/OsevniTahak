using System;
using System.ComponentModel.DataAnnotations;

namespace OsevniTahak.Models
{
    public class Crop
    {
        public int Id { get; set; }
        [Display(Name = "Název plodiny")]
        public string Nazev { get; set; }
        [Display(Name = "Název odrůdy")]
        public string Odruda { get; set; }
        [Display(Name = "Název čeledi")]
        public string Celed { get; set; }
        [Display(Name = "Název výrobce")]
        public string Vyrobce { get; set; }
        [Display(Name = "Trať")]
        public int Trat { get; set; }



    }
}
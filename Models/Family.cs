using System;
using System.ComponentModel.DataAnnotations;

namespace OsevniTahak.Models
{
    public class Family
    {
        public int Id { get; set; }
        [Display(Name = "Název čeledi")]
        public string Nazev { get; set; }
        [Display(Name = "Podrobnosti")]
        public string Podrobnosti { get; set; }




    }
}
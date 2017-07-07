using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Game
    {
        public int ID { get; set; }

        [StringLength(60,MinimumLength =3)]
        [Required]
        public string tytul { get; set; }

        [Display(Name = "data_wydania")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime data_wydania { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30,MinimumLength = 5)]
        public string gatunek { get; set; }

        public double cena { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(3)]
        public string ocena { get; set; }
    }
}

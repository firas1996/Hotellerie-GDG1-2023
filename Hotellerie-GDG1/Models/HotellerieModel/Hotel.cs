using System.ComponentModel.DataAnnotations;

namespace Hotellerie_GDG1.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required !!!")]
        [StringLength(20,MinimumLength = 3,ErrorMessage ="Length should be between 3 and 20")]
        public string Name { get; set; }
        [Range(1,5,ErrorMessage ="Le nombre d'étoiles doit étre compris entre 1 et 5.")]
        public int Etoiles { get; set; }
        [Required(ErrorMessage = "The Ville is required !!!")]
        public string Ville {  get; set; }
        [Required(ErrorMessage = "The SiteWeb is required !!!")]
        [RegularExpression(@"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$",
            ErrorMessage = "The website must be in this format !!")]
        [Display(Name = " Site Web")]
        
        public string SiteWeb { get; set; }
        public string Tel {  get; set; }

    }
}

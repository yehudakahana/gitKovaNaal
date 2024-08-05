using System.ComponentModel.DataAnnotations;

namespace gitKovaNaal.Models
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="מידה")]
        public int Size { get; set; }

        [Display(Name = "צבע")]
        public string Color { get; set; }

        [Display(Name = "מותג")]
        public string Brand { get; set; }

        [Display(Name = "תמונה")]

        public string Image { get; set; }

        public  Hat Hat { get; set; }

        public Shoe(int Size, string Color, string Brand, string Image) 
        {
            Size = Size;
            Color = Color;
            Brand = Brand;
            Image = Image; 
        }

        public Shoe()
        {
        }
    }
}

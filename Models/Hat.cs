using System.ComponentModel.DataAnnotations;

namespace gitKovaNaal.Models
{
    public class Hat
    {
        [Key]
        public string Id { get; set; }
        [Display (Name= "חברה")]
        public string Company { get; set; }
        [Display(Name = "צבע")]

        public string Color { get; set; }
        [Display(Name = "מידה")]

        public string Size { get; set; }
        public string Photo {  get; set; }
        public Hat(string company, string color, string size, string photo) 
        {
            Company = company;
            Color = color;
            Size = size;
            Photo = photo; 
        
        }
        public Hat() 
        {
        }






    }
}

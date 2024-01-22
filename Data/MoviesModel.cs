using System.ComponentModel.DataAnnotations;

namespace Movies.Data
{
    public class Movies

    {
        [Key]
        public int Id { get; set; }

        [Required]

        public string? Name { get; set; }

        [Required]

        public string? MovieType { get; set; }
        [Required]
        public string? MovieLanguage { get; set; }

        [Required]

        public long Duration { get; set; }



    }
}
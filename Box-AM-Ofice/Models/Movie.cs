using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace boxAmOffice.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        [Required(ErrorMessage = "ImageURL is required")]
        [Display(Name = "Image")]

        public string ImageURL { get; set; }

        [Display(Name = "Strat Date")]

        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]

        public DateTime EndDate { get; set; }

        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        [Display(Name = "Cinema")]
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        [Display(Name = "Producer")]
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}

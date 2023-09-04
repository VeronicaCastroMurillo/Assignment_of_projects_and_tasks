using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_of_projects_and_tasks.Models {
    public class Project{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set;}
        public string? name {get; set;}
        public string? description {get; set;}
        public string? date {get; set;}

        [ForeignKey("status_id")]
        public int status_id {get; set;} 
        public Status status {get; set;} = null!;

        public List<Tasks> Tasks {get; set;} = null!;


    }
}
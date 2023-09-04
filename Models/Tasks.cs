using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_of_projects_and_tasks.Models{
    public class Tasks{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set;}
        public string? name {get; set;}
        public string? description {get; set;}

        [ForeignKey("project_id")]
        public int project_id {get; set;} 
        public Project project {get; set;} = null!;

        [ForeignKey("status_id")]
        public int status_id {get; set;} 
        public Status status {get; set;} = null!;

        public List<Tasks_user> tasks_Users {get; set;} = null!;

    }
}
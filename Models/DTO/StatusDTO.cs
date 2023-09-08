using System.ComponentModel.DataAnnotations;

namespace Assignment_of_projects_and_tasks.Models.DTO{
    public class StatusDTO{
        public int StatusCode {get; set;}

        public string? Message {get; set;}
    }
}
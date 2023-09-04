namespace Assignment_of_projects_and_tasks.Models{
    public class User: Application_user{
        public List<Tasks_user> tasks_Users {get; set;} = null!;
    }
}
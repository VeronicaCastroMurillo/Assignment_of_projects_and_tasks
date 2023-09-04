namespace Assignment_of_projects_and_tasks.Models{
    public class Tasks_user{
        public string? user_id { get; set;}
        public User user { get; set;} = null!;
        public int task_id {get; set;}
        public Tasks tasks { get; set;} = null!;

    }
}
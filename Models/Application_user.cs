using Microsoft.AspNetCore.Identity;

namespace Assignment_of_projects_and_tasks.Models{
public class Application_user: IdentityUser{
        public string? id_number { get; set;}
        public string? name {get; set;}
}

public class Application_role: IdentityRole{

}


}
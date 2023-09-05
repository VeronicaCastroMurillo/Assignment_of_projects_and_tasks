using System.ComponentModel.DataAnnotations;
using Assignment_of_projects_and_tasks.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_of_projects_and_tasks.Data{
    public class ProjectContext: DbContext{
        public ProjectContext(DbContextOptions<ProjectContext> options): base(options){}
        public DbSet<Project> projects {get; set;}
        public DbSet<Tasks> tasks {get; set;}
        public DbSet<Tasks_user> tasks_users {get; set;}
        public DbSet<Status> status {get; set;}
        public DbSet<User> user {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tasks_user>().HasKey(tu => new {tu.user_id, tu.task_id});
            builder.Entity<Tasks_user>().HasOne(u=>u.user).WithMany(u=>u.tasks_Users).HasForeignKey(tu=>tu.user_id);
            builder.Entity<Tasks_user>().HasOne(t=>t.tasks).WithMany(t=>t.tasks_Users).HasForeignKey(tu=>tu.task_id);
            builder.Entity<Status>().HasData(new Status {id=1, name="Completed"});
            builder.Entity<Status>().HasData(new Status {id=2, name="In progress"});
            builder.Entity<Status>().HasData(new Status {id=3, name="Incompleted"});
            builder.Entity<Status>().HasData(new Status {id=4, name="Canceled"});
            builder.Entity<Status>().HasData(new Status {id=5, name="Delayed"});
            builder.Entity<User>().ToTable("AspNetUsers");
            base.OnModelCreating(builder);
        }

    }
}
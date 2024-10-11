namespace StudentPortalWeb.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string? Title { get; set; }

        public string? ShortDescription { get; set; }

        public string? ApplicationUserId { get; set; }
        //relation
        public ApplicationUser? ApplicationUser { get; set; }

        public DateTime? Created { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? Description { get; set; }

        public string? slug { get; set; }


    }
}

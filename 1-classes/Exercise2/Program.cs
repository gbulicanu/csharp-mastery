using System;

namespace Exercise2
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; private set; }
        public int Vote { get; private set; }

        public Post(string title, string description)
        {
            this.DateCreated = DateTime.Now;
            this.Title = title;
            this.Description = description;
        }

        public void DownVote()
        {
            --this.Vote;
        }

        public void UpVote()
        {
            ++this.Vote;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post(
                "What is most popular programing language.",
                "What is most popular popular programming language on the planet.");

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            // post.DownVote();
            // post.DownVote();
            // post.DownVote();

            // post.DateCreated = DateTime.Now;
            // post.Vote = 0;

            Console.WriteLine(
                "Current post of '{0}' created @ {1} has {2} votes.",
                post.Title,
                post.DateCreated,
                post.Vote);
        }
    }
}

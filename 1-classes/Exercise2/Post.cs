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
}

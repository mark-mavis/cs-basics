namespace SocialMediaApp
{
    internal class MoviePost : Post
    {
        public string MovieURL { get; set; } = "unknown";
        public int MovieLength { set; get; } = 0;

        public MoviePost() { }
        public MoviePost(string title, string sendByUsername, bool isPublic, string movie_url, int movie_length) : base(title, sendByUsername, isPublic)
        {
            this.MovieURL = movie_url;
            this.MovieLength = movie_length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - URL: {2} LENGTH: {3} secs", this.ID, this.Title, this.MovieURL, this.MovieLength);
        }
    }
}

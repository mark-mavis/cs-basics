namespace SocialMediaApp
{
    internal class MoviePost : Post
    {
        private string _movieUrl = "unknown";
        private int _movieLength = 0;
        private bool _isPlaying = false;
        public string MovieURL { 
            get { return _movieUrl; } 
            set {
                if ("String" == value.GetType().ToString()) _movieUrl = value;
            } 
        }
        public int MovieLength {
            get { return _movieLength;}
            set {
                if (value >= 0) _movieLength = value;
                else throw new ArgumentException("The value can not be negative");
            }
        }

        public bool IsPlaying
        {
            get { return _isPlaying; }
            set { _isPlaying = value; }
        }

        public MoviePost() { }
        public MoviePost(string title, string sendByUsername, bool isPublic, string movie_url, int movie_length) : base(title, sendByUsername, isPublic)
        {
            this.MovieURL = movie_url;
            this.MovieLength = movie_length;
        }

        public void Play()
        {
            if (!IsPlaying)
            {
                Console.WriteLine("Playing");
            }
            else
            {
                Console.WriteLine("Pausing");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - URL: {2} LENGTH: {3} secs", this.ID, this.Title, this.MovieURL, this.MovieLength);
        }
    }
}



using SocialMediaApp;

namespace SocialMediaApp
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; } = "unknown";
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, bool isPublic, string url) : base(title, sendByUsername, isPublic)
        {
            ImageURL = url ?? "unknown";
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - URL: {2}, Sent By: {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
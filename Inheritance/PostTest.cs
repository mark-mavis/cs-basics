namespace SocialMediaApp
{
    class PostTest
    {
        public static void Run()
        {
            Post post = new Post("Happy Birthday Casey!", "markwmavis", true);
            
            Console.WriteLine(post.GetType().ToString() + ": " + post.ToString());

            post.Update("Happy Birthday Casey! I hope it is a good one.", true);
            Console.WriteLine(post.ToString());

            MoviePost moviepost = new MoviePost("People going crazy!", "markwmavis", true, "http:://www.youtube.com", 39);
            Console.WriteLine(moviepost.ToString());

            ImagePost imagePost1 = new ImagePost("hello from the cayman islands!", "cconroy", false, "http:://www.facebook.com");
            Console.WriteLine(imagePost1.ToString());

            ImagePost imagepost2 = new ImagePost();
            Console.WriteLine(imagepost2.ToString());
        }
    }
}

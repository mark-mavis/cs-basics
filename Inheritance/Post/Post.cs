namespace SocialMediaApp;
internal class Post
{
    //Accessable by the GetPostID method  that is
    // inherited to all other classes
    private static int _currentPostID;
    
    //
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string SendByUsername { get; set; }
    protected bool IsPublic { get; set; }

    public Post()
    {
        this.ID = GetNextPostID();
        this.Title = "unknown";
        this.SendByUsername = "unknown";
        this.IsPublic = true;
    }
    public Post(string title, string sendByUserName, bool isPublic)
    {
        this.ID = GetNextPostID();
        this.Title = title;
        this.SendByUsername = sendByUserName;
        this.IsPublic = isPublic;
    }
    protected int GetNextPostID()
    {
        return ++_currentPostID;
    }
    public void Update(string title, bool isPublic)
    {
        this.Title = title;
        this.IsPublic = isPublic;
    }

    public override string ToString()
    {
        
        return String.Format("{0} - {1} - Sent By: {2}", this.ID, this.Title, this.SendByUsername);
    }
}


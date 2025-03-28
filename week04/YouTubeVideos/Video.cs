class Video 
{
  public string _title;
  public string _author;
  public int _lengthInSeconds;
  public List<Comment> _comments = new List<Comment>();

  public Video(string title, string author, int lengthInSeconds)
  {
    _title = title;
    _author = author;
    _lengthInSeconds = lengthInSeconds;
    _comments = new List<Comment>();
  }
  public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        
  public void DisplayVideoInfo()
{
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_lengthInSeconds} seconds");
    Console.WriteLine( $"Number of comments: {GetNumberOfComments()}");
    Console.WriteLine("Comments:");
    foreach (Comment comment in _comments)
    {
        comment.DisplayComment();
    }
    Console.WriteLine();
}
}
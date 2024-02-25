public class Video
{
    public string _title;
    public string _author;
    public int _length;
    private int _count;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int AmountOfComments()
    {
        foreach (Comment comment in _comments)
        {
            _count++;
        }
        return _count;
    }
}
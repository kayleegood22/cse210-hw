using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _commentList = new List<Comment>();

    public int CommentCount()
    {
        int count = _commentList.Count;
        return count;
    }

    public void Display()
    {
        {
            Console.WriteLine($"Video: {_title} - {_author} ({_length} seconds)");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Comments");
            Console.WriteLine("--------------------------------");

            foreach (Comment comment in _commentList)
            {
                comment.Display();
            }
            Console.WriteLine("");
        }
    }
}
public class Comment
{
    public string _commentor;
    public string _message;

     public void Display()
    {
        Console.WriteLine($"{_commentor}: {_message}");
    }
}
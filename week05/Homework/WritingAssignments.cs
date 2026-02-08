using System.Reflection;

class WritingAssignment : Assignment
{
    private string _Title;
    public WritingAssignment(string Title, string StudentName, string Topic) : base(StudentName, Topic)
    {
        _Title = Title;
    }
    public string GetWritingInformation()
    {
        return $"{Summary()}\n {_Title}";
    }
}
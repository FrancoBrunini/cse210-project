using System.Dynamic;

class Assignment
{
    private string _StudentName;
    private string _Topic;

    public Assignment(string StudentName, string Topic)
    {
        _StudentName = StudentName;
        _Topic = Topic;
    }
    public string  GetStudentName()
    {
        return _StudentName;
    }
    public string GetTopic()
    {
        return _Topic;
    }
    public string Summary()
    {
        return $"{_StudentName} - {_Topic} ";
    }
}
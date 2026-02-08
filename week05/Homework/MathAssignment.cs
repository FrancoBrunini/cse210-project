using System.Dynamic;

class MathAssignment : Assignment
{
    private string _TextBookSection;
    private string _Problems;
    public MathAssignment(string StudentName, string Topic, string TextBookSection, string Problems) : base(StudentName, Topic)
    {
        _TextBookSection = TextBookSection;
        _Problems = Problems;
    }
    public string GetTextBookSection()
    {
        return _TextBookSection;
    }
    public string GetProblems()
    {
        return _Problems;
    }
    public string GetHomeWorkList()
    {
        return $"{Summary()}\n Section: {_TextBookSection} Problems {_Problems}";
    }

}
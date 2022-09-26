namespace Isu.Models;

public class CourseNumber
{
    private byte _number;

    public CourseNumber(byte number)
    {
        _number = number;
    }

    public byte GetNumber()
    {
        return _number;
    }

    public void SetNumber(byte number)
    {
        _number = number;
    }
}
namespace Isu.Models;
public class GroupName
{
    private string _name;
    private string _faculty;
    private string _qualification;
    private CourseNumber _course;
    public GroupName(string name)
    {
        _faculty = DefineFaculty(name[0]);
        _qualification = DefineQualification(name[1]);
        _course = new CourseNumber(byte.Parse(name[2].ToString()));
        _name = name;
    }

    public string DefineQualification(char s)
    {
        string qualification = string.Empty;
        if (s == '3')
        {
            qualification = "�����������";
        }
        else if (s == '4')
        {
            qualification = "������������";
        }
        else
        {
            Console.WriteLine("�� ����� ������������ ������������!");
        }

        return qualification;
    }

    public string DefineFaculty(char s)
    {
        string faculty = string.Empty;
        switch (s)
        {
            case 'A':
                faculty = "������-������������� �������";
                break;
            case 'B':
                faculty = "���������� ������";
                break;
            case 'C':
                faculty = "�������� ������� � �����������, �������� ���������� ���������������";
                break;
            case 'D':
                faculty = "�������� �������������� �������� � �����������";
                break;
            case 'F':
                faculty = "�������� �������������� ��������";
                break;
            case 'K':
                faculty = "�������������������� ����������";
                break;
            case 'L':
                faculty = "�������� ��������";
                break;
            case 'M':
                faculty = "�������������� ���������� � ����������������";
                break;
            case 'N':
                faculty = "������������ �������������� ����������";
                break;
            case 'P':
                faculty = "����������� ��������� � ������������ �������";
                break;
            case 'R':
                faculty = "������� ���������� � �������������";
                break;
            case 'T':
                faculty = "������� ������������� � ���������";
                break;
            case 'U':
                faculty = "���������� ����������� � ���������";
                break;
            case 'V':
                faculty = "�������� � ���������������";
                break;
            case 'W':
                faculty = "������������������ ����������";
                break;
            case 'Z':
                faculty = "������-����������� ���������";
                break;
            default:
                Console.WriteLine("�� ��������� ����� ��������� ����������� ����������!");
                break;
        }

        return faculty;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetQualification(string qualification)
    {
        _qualification = qualification;
    }

    public string GetQualification()
    {
        return _qualification;
    }

    public void SetFaculty(string faculty)
    {
        _faculty = faculty;
    }

    public string GetFaculty()
    {
        return _faculty;
    }

    public void SetCourse(CourseNumber course)
    {
        _course = course;
    }

    public CourseNumber GetCourse()
    {
        return _course;
    }

    public override string ToString()
    {
        return _name;
    }
}
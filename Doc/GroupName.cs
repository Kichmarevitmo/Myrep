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
            qualification = "аЮЙЮКЮБПХЮР";
        }
        else if (s == '4')
        {
            qualification = "лЮЦХЯРПЮРСПЮ";
        }
        else
        {
            Console.WriteLine("бШ ББЕКХ МЕОПЮБХКЭМСЧ ЙБЮКХТХЙЮЖХЧ!");
        }

        return qualification;
    }

    public string DefineFaculty(char s)
    {
        string faculty = string.Empty;
        switch (s)
        {
            case 'A':
                faculty = "ухлхйн-ахнкнцхвеяйхи йкюяреп";
                break;
            case 'B':
                faculty = "опхйкюдмюъ норхйю";
                break;
            case 'C':
                faculty = "хмярхрср дхгюимю х спаюмхярхйх, хмярхрср тхмюмянбшу йхаепреумнкнцхи";
                break;
            case 'D':
                faculty = "хмярхрср лефдсмюпндмнцн пюгбхрхъ х оюпрмепярбю";
                break;
            case 'F':
                faculty = "хмярхрср рпюмякъжхнммни ледхжхмш";
                break;
            case 'K':
                faculty = "хмтнйнллсмхйюжхнммше реумнкнцхх";
                break;
            case 'L':
                faculty = "кюгепмюъ тнрнмхйю";
                break;
            case 'M':
                faculty = "хмтнплюжхнммше реумнкнцхх х опнцпюллхпнбюмхе";
                break;
            case 'N':
                faculty = "аегноюямнярэ хмтнплюжхнммшу реумнкнцхи";
                break;
            case 'P':
                faculty = "опнцпюллмюъ хмфемепхъ х йнлоэчрепмюъ реумхйю";
                break;
            case 'R':
                faculty = "яхярелш сопюбкемхъ х пнанрнреумхйх";
                break;
            case 'T':
                faculty = "охыебше ахнреумнкнцхх х хмфемепхъ";
                break;
            case 'U':
                faculty = "реумнкнцхх лемедфлемрю х хммнбюжхи";
                break;
            case 'V':
                faculty = "тнрнмхйю х норнхмтнплюрхйю";
                break;
            case 'W':
                faculty = "мхгйнрелоепюрспмюъ щмепцерхйю";
                break;
            case 'Z':
                faculty = "тхгхйн-реумхвеяйхи тюйскэрер";
                break;
            default:
                Console.WriteLine("мЕ ОПЮБХКЭМН ББЕКХ АСЙБЕММНЕ НАНГМЮВЕМХЕ ТЮЙСКЭРЕРЮ!");
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
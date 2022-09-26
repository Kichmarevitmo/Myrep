using Isu.Models;
namespace Isu.Entities;

public class Student
{
    private string _id;
    private string _name;
    private string _surname;
    private string _fathername;
    private GroupName _groupNumber;
    private DateTime _birthday;
    public Student(string id, string name, string surname, string fathername, DateTime date, GroupName groupnumber)
    {
        _id = id;
        _name = name;
        _surname = surname;
        _fathername = fathername;
        _birthday = date;
        _groupNumber = groupnumber;
    }

    public GroupName GetGroupNumber()
    {
        return _groupNumber;
    }

    public void SetGroupNumber(GroupName number)
    {
        _groupNumber = number;
    }

    public string GetId()
    {
        return _id;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetSurname()
    {
        return _surname;
    }

    public void SetSurname(string surname)
    {
        _surname = surname;
    }

    public string GetFathername()
    {
        return _fathername;
    }

    public void SetFathername(string fathername)
    {
        _fathername = fathername;
    }

    public DateTime GetBirthday()
    {
        return _birthday;
    }

    public void SetBirthday(DateTime birthday)
    {
        _birthday = birthday;
    }
}
using Isu.Models;

namespace Isu.Entities;

public class Group
{
    private string _faculty;
    private string _qualification;
    private CourseNumber _course;
    private GroupName _groupName;
    public Group(string faculty, string qualification, CourseNumber course, GroupName name)
    {
        _faculty = faculty;
        _qualification = qualification;
        _course = course;
        _groupName = name;
    }

    public string GetFaculty()
    {
        return _faculty;
    }

    public void SetFaculty(string faculty)
    {
        _faculty = faculty;
    }

    public string GetQualification()
    {
        return _qualification;
    }

    public void SetQualification(string qualification)
    {
        _qualification = qualification;
    }

    public CourseNumber GetCourse()
    {
        return _course;
    }

    public void SetCource(CourseNumber courseNumber)
    {
        _course = courseNumber;
    }

    public GroupName GetGroupName()
    {
        return _groupName;
    }

    public void SetGroupName(GroupName groupname)
    {
        _groupName = groupname;
    }
}
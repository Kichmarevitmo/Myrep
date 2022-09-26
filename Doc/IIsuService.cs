using Isu.Entities;
using Isu.Models;

namespace Isu.Services;

public interface IIsuService
{
    void AddGroup(GroupName name);
    void AddStudent(string name, string surname, string fathername, string id, DateTime birthday, GroupName groupname);
    Student FindStudent(string id);
    List<Student> FindStudents(GroupName groupName);
    List<Student> FindStudents(CourseNumber courseNumber);
    Group FindGroup(GroupName groupName);
    List<Group> FindGroups(CourseNumber courseNumber);
    void ChangeStudentGroup(string student, string newGroup);
}
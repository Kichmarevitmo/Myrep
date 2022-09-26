using Isu.Entities;
using Isu.Models;
using Isu.Services;
using Xunit;

namespace Isu.Test;

public class IsuService
{
    private DepartmentHandling departmentHandling = new DepartmentHandling();
    [Fact]
    public void AddStudentToGroup_StudentHasGroupAndGroupContainsStudent()
    {
        var student = new Student("334800", "Александр", "Иванов", "Иванович", new DateTime(2003, 01, 01), new GroupName("M3108"));
        departmentHandling.AddStudent(student.GetName(), student.GetSurname(), student.GetFathername(), student.GetId(), student.GetBirthday(), student.GetGroupNumber());
        Assert.Equal("M3108", departmentHandling.FindStudent("334800").GetGroupNumber().ToString());
        Assert.Equal("334800", departmentHandling.FindStudents(new GroupName("M3108"))[0].GetId());
    }

    [Fact]
    public void ReachMaxStudentPerGroup_ThrowException()
    {
        Action act = () => departmentHandling.AddStudent("335800", "Александр", "Иванов", "Иванович", new DateTime(2003, 01, 01), new GroupName("M3108"));
        act = () => departmentHandling.AddStudent("335800", "Александр", "Иванов", "Иванович", new DateTime(2003, 01, 01), new GroupName("M3108"));
        IndexOutOfRangeException exp = Assert.Throws<IndexOutOfRangeException>(act);
        Assert.Equal("Error", exp.Message);
    }

    [Fact]
    public void CreateGroupWithInvalidName_ThrowException()
    {
        Action act = () => departmentHandling.AddGroup(new GroupName("MM3108"));
        ArgumentException exp = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Error", exp.Message);
    }

    [Fact]
    public void TransferStudentToAnotherGroup_GroupChanged()
    {
        var student1 = new Student("334900", "Александр", "Иванов", "Иванович", new DateTime(2003, 01, 01), new GroupName("M3108"));
        departmentHandling.AddStudent(student1.GetName(), student1.GetSurname(), student1.GetFathername(), student1.GetId(), student1.GetBirthday(), student1.GetGroupNumber());
        departmentHandling.ChangeStudentGroup("334900", "M3109");
        Assert.Equal("M3109", departmentHandling.FindStudent("334900").GetGroupNumber().ToString());
    }
}
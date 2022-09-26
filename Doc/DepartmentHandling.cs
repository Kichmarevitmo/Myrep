using Isu.Entities;
using Isu.Models;

namespace Isu.Services
{
    public class DepartmentHandling : IIsuService
    {
        private static List<Student> students = new List<Student>();
        private static List<Group> groups = new List<Group>();
        public void AddGroup(GroupName name)
        {
            if (name.GetName().Length == 5 && char.IsUpper(name.GetFaculty()[0]) && char.IsLetter(name.GetFaculty()[0]) && name.GetCourse().GetNumber() > 0 && name.GetCourse().GetNumber() <= 4 &&
                char.IsNumber(name.GetName()[1]) && char.IsNumber(name.GetName()[2]) && char.IsNumber(name.GetName()[3]) && char.IsNumber(name.GetName()[4]))
            {
                var group = new Group(name.GetFaculty(), name.GetQualification(), name.GetCourse(), name);
                groups.Add(group);
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }

        public void AddStudent(string name, string surname, string fathername, string id, DateTime birthday, GroupName groupname)
        {
            if (students.Count > 1)
            {
                throw new IndexOutOfRangeException("Error");
            }
            else
            {
                if (name.All(char.IsLetter) && name != null && surname.All(char.IsLetter) && surname != null
               && fathername.All(char.IsLetter) && fathername != null)
                {
                    var student = new Student(id, name, surname, fathername, birthday, groupname);
                    students.Add(student);
                }
                else
                {
                    throw new ArgumentException("Error");
                }
            }
        }

        public void ChangeStudentGroup(string student, string newGroup)
        {
            if (student != null && newGroup != null && student.Length == 6 && student.All(char.IsDigit) && newGroup.Length == 5 && char.IsUpper(newGroup[0]) &&
                char.IsLetter(newGroup[0]) && char.IsDigit(newGroup[1]) &&
               char.IsDigit(newGroup[2]) && char.IsDigit(newGroup[3]) && char.IsDigit(newGroup[4]))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].GetId() == student)
                        students[i].SetGroupNumber(new GroupName(newGroup));
                }
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }

        public Group FindGroup(GroupName groupName)
        {
            Group group = null;
            if (groupName != null && groupName.GetName().Length == 5 && char.IsUpper(groupName.GetFaculty()[0]) && char.IsLetter(groupName.GetFaculty()[0]) && groupName.GetCourse().GetNumber() > 0 && groupName.GetCourse().GetNumber() <= 4 &&
            char.IsNumber(groupName.GetName()[1]) && char.IsNumber(groupName.GetName()[2]) && char.IsNumber(groupName.GetName()[3]) && char.IsNumber(groupName.GetName()[4]))
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    if (groups[i].GetGroupName().GetName() == groupName.GetName())
                    {
                        group = groups[i];
                    }
                }
            }
            else
            {
                throw new ArgumentException("Error");
            }

            if (group != null)
            {
                return group;
            }
            else
            {
                Console.WriteLine("Такой группы не существует!");
                return group;
            }
        }

        public List<Group> FindGroups(CourseNumber courseNumber)
        {
            var suitableGroups = new List<Group>();
            if (courseNumber != null && courseNumber.GetNumber() > 0 && courseNumber.GetNumber() < 5)
            {
                for (int i = 0; i < groups.Count; i++)
                {
                    if (groups[i].GetCourse().GetNumber() == courseNumber.GetNumber())
                    {
                        suitableGroups.Add(groups[i]);
                    }
                }
            }
            else
            {
                    throw new ArgumentException("Error");
            }

            return suitableGroups;
        }

        public Student FindStudent(string id)
        {
            Student student = null;
            if (id != null && id.Length == 6 && id.All(char.IsDigit))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].GetId().Equals(id))
                    {
                        student = students[i];
                    }
                }
            }
            else
            {
                throw new ArgumentException("Error");
            }

            if (student == null)
            {
                throw new ArgumentException("Error");
            }

            return student;
        }

        public List<Student> FindStudents(GroupName groupName)
        {
            var suitableStudents = new List<Student>();
            if (groupName != null && groupName.GetName().Length == 5 && char.IsUpper(groupName.GetFaculty()[0]) && char.IsLetter(groupName.GetFaculty()[0]) && groupName.GetCourse().GetNumber() > 0 && groupName.GetCourse().GetNumber() <= 4 &&
           char.IsNumber(groupName.GetName()[1]) && char.IsNumber(groupName.GetName()[2]) && char.IsNumber(groupName.GetName()[3]) && char.IsNumber(groupName.GetName()[4]))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].GetGroupNumber().GetName() == groupName.GetName())
                    {
                        suitableStudents.Add(students[i]);
                    }
                }
            }
            else
            {
                throw new ArgumentException("Error");
            }

            return suitableStudents;
        }

        public List<Student> FindStudents(CourseNumber courseNumber)
        {
            var suitableStudents = new List<Student>();
            if (courseNumber != null && courseNumber.GetNumber() > 0 && courseNumber.GetNumber() < 5)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].GetGroupNumber().
                        GetCourse().GetNumber() == courseNumber.GetNumber())
                    {
                        suitableStudents.Add(students[i]);
                    }
                }
            }
            else
            {
                throw new ArgumentException("Error");
            }

            return suitableStudents;
        }
    }
}

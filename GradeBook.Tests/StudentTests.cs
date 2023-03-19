
using GradeBook;

namespace GradeBook.Tests;

public class StudentTests
{
    [Fact]
    public void Test1()
    {
        //arrange
        Student student = new Student("Ashley", 29);
        //student.Age = 13;
        bool expected = false;

        //act
         bool actual = student.CheckIsAChild();

        //assert
        Assert.Equal(expected, actual);

    }
}

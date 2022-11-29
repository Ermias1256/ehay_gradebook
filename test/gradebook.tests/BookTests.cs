
namespace gradebook.tests;

public class BookTests
{
    [Fact]
    public void Test1()
    {

        // arrange
       var  book1 = new Book("Math Grade Book");
       book1.AddGrade(80.1);
       book1.AddGrade(80.2);
       book1.AddGrade(80.5);

        // actual
       var result =  book1.GetStatistics();


        // assert
        Assert.Equal(45.5 , result.Lowest);
        Assert.Equal(56.5 , result.Highest);

     
    }
}
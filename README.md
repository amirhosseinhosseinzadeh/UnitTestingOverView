Test course

Authentication part

pyramid of testing 

{
  
    _______________________________
    |                             |
    |      Manual                 |
    |_____________________________|
  
    _______________________________
    |                             |
    |      User Interface         |
    |_____________________________|
    _______________________________
    |                             |
    |      Acceptence             |
    |_____________________________|
    _______________________________
    |                             |
    |      Integration            |
    |_____________________________|
    _______________________________
    |                             |
    |      Unit Tests             |
    |_____________________________|
}

 Unit testing =>
 {
     unit testing is testing a single unit of app (the smallest part of testing)
     it usually have a one or some input and usually a single output
     in oop the smallest unit is a method
 }

 Integration =>
 {
     Is a software testing which an indivisual unit will combine and test as a group
 }

Acceptence =>
{
    is anothe level of testing and the purpose of this test is to evaluate the systems compliance with the businuess requirments
    and make sure application is ready for deliver
}

User interface (UI test)=>
{
    will use to check the user interface of program such as result of clicks ,scrolls .etc 
    Ui test is great for checking if app is wotking as expected to
}

Manual =>
{

}

Benefits =>
    ☼ Easy to refactor
    ☼ Easy to add new modules or removing the an existence module
    ☼ Resusable code
    ☼ Faster development
    ☼ Easier debugging
    ☼ Reduced costs

wrong taughts abot unit tests =>
    ☼ Do not test everything
    ☼ The date shouldnt have nuch differences with prodcution data's
    ☼ Unit tests must be undependent from each others
    ☼ must performing unit tests continuously and frequetly

The frameworks of testing in dotnet echosystem

Ms test =>
{
    microsoft official testing framework and comes with visual studio

    pros =>
        ☼ can run unit tests and see the results throgh the visual studio 
        ☼ can run unit tests and see the results throgh command line (MSTest.exe)
    
    
    MsTest elements =>
        ☼ for using this framework we need to create a class with [TestClass] attribute (Identify the class contains the test method's)
        ☼ [TestMethod] decorator for creating methods which unit testing the application methods 
        ☼ Assert method is required to check the result of method 
}

NUnit =>
{
    NUnit is a testing framework for all dotnet languages but its existence will return to 30-years befor dontet even borns
    JUnit was a framwork for testing applications for java (pl)
    (Derived form JUnit)

    ☼ Its opensource
    ☼ Can be use with a graphical user interface or commandline

    NUnit test elemnts =>
        ☼ class : [SetUp] decorator will identifying the class that contains the test codes
        ☼ methods : [Test] decorator that contains test methods and the inputs of the test method can be 
        ☼ [TestCase] execute the same code with different data inputs which can be use from a database or an external file 
        ☼ [TestCaseSource] load a record from a .csv file or from a database 
        ☼ [Teardown] the oposite of [setup] is used to clean the resources after test being completed succesfully
}

xUnit =>
{
    the latest technology for testing dontet applications 
    made by enventor of NUnit
    
    ☼ Intuitive terminology 
    ☼ Excelent extensibility

    ☼ [Fact] - is always true
    ☼ [Theory] - is true with right data

}

Overlook (decide from frameworks)

creating test class =>
{
  
    __________________________________________
    |              |             |           |    
    |  MsTest      |     NUnit   |   xUnit   |              
    |______________|_____________|___________|    
    __________________________________________
    |              |             |           |    
    |  [TestClass] |[TestFixture]|   -----   |              
    |______________|_____________|___________|    
}

creating a simple unit testing method which dont take any parameters =>
{
 
    __________________________________________
    |              |             |           |    
    |  MsTest      |     NUnit   |   xUnit   |              
    |______________|_____________|___________|    
    __________________________________________
    |              |             |           |     
    | [TestMethod] |     [Test]  |   [Fact]  |              
    |______________|_____________|___________|    
}

creating setup any resources such as a database refernce or a service reference =>
{
 
    _____________________________________________
    |                 |             |           |    
    |     MsTest      |     NUnit   |   xUnit   |              
    |_________________|_____________|___________|    
    _____________________________________________
    |                 |             |           |     
    |[TestInitialize] |     [SetUp] |Constructor|              
    |_________________|_____________|___________|    
} 

cleaning the resources =>
{

    _____________________________________________
    |                 |             |           |    
    |     MsTest      |     NUnit   |   xUnit   |              
    |_________________|_____________|___________|    
    _____________________________________________
    |                 |             |           |     
    |[TestCleanup]    |  [TearDown] |  Dispose  |              
    |_________________|_____________|___________|    
} 

ignoring a unit test method because we dont wanna to use that method anymore =>
{
   
    ________________________________________________________________
    |                 |                  |                         |    
    |     MsTest      |     NUnit        |         xUnit           |              
    |_________________|__________________|_________________________|    
    ________________________________________________________________
    |                 |                  |                         |     
    |   [Ignore]      |[Ignore("reason")]|  [Fact(Skip="reason")]  |              
    |_________________|__________________|_________________________|    
} 

passing data to a unit testing method =>
{
   
    ________________________________________________________________
    |                 |                  |                         |    
    |     MsTest      |     NUnit        |         xUnit           |              
    |_________________|__________________|_________________________|    
    ________________________________________________________________
    |                 |                  |                         |     
    |   [DataSource]  |      [Theory]    |  [Therory]/[...Data]    |              
    |_________________|__________________|_________________________|    
} 

most of developers goin to forward with xUnit because of
    ☼ the latest technology when it comes to testing dotnet languages
    ☼ opensource 
    ☼ comunity focused


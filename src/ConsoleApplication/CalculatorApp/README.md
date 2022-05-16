Using `[Fact]` decorator will remaind us that the test method does not contains any parameters
and what ever data we need to test will provide inside the method body
but what if we wanna test a lot of data?
in that case were gonna to define the variables inside the method which contains a bigm method with alot variales

In the other hand the `[Theory]` decorator stands for a test emthod with parameters
we can pass the data's we need using different attributes =>
{

    ☼ [InLineData]
    
    ☼ [MemberData]

    ☼ [ClassData]
}

It is also valid to use multiple [InLineData] attribute
but when we wanna use alot of the data to test our method this solution is not so interesting

for this cause we have `[MemberData]` attr
    and member data attr is not allowed to be repeated every method can contain only one attribute from this type
the [MemberData] attribute is depend on a static field ,property or method which provide the values we need to test
as an IEnumerable<Any>
But there is also another solution which change our needs

we can create a class that implement the `IEnmuerable` interface that gonna give us the `GetEnumerator` Method
and instead of  passing member data we can pass class data using [ClassData] attribute

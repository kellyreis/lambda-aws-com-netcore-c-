using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using Domain.DTO;

namespace lambda.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        var upperCase = function.FunctionHandler(new ProdutoDTO(), context);

        Assert.Equal("HELLO WORLD", upperCase.Message);
    }
}

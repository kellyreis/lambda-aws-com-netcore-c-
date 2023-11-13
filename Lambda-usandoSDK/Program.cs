using Amazon.Lambda;
using Amazon.Lambda.Model;

AmazonLambdaClient client = new AmazonLambdaClient();

const string input = "{\"Nome\":\"Hello World!!\"}";

var request = new InvokeRequest()
{
    FunctionName = "Lambda",
    Payload = input,
    InvocationType = InvocationType.Event
};

var response = client.InvokeAsync(request).Result;

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Result => {new StreamReader(response.Payload).ReadToEnd()}");

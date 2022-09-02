using Amazon.DynamoDBv2;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaDemo;

public class DemoFunction
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<APIGatewayProxyResponse> DemoFunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        //context.Logger.Log($"Got new message: {input}");
        //return input.ToUpper();

        string name = "No Name";

        if(request.QueryStringParameters != null && request.QueryStringParameters.ContainsKey("name")){
            name = request.QueryStringParameters["name"];
        }

        if(request.HttpMethod == "POST")
        {
            //
        }

        var userProvider = new UserProvider(new AmazonDynamoDBClient());
        var users = await userProvider.GetUsers();

        context.Logger.Log($"Got name: {name}");
        return new APIGatewayProxyResponse {
            StatusCode = 200,
            Body = JsonSerializer.Serialize(users)
        };
    }
}

using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloWorldApi
{
	public class Function
	{
		
		public async Task<APIGatewayHttpApiV2ProxyResponse> FunctionHandler(APIGatewayHttpApiV2ProxyRequest input, ILambdaContext context)
		{
			return new APIGatewayHttpApiV2ProxyResponse
			{
				Body = @"{""Message"":""Hello world!""}",
				StatusCode = 200,
				Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
			};
		}
	}
}
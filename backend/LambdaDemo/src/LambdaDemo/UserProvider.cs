using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using LambdaDemo.Models;

namespace LambdaDemo
{
    public class UserProvider
    {
        private readonly IAmazonDynamoDB dynamoDB;

        public UserProvider(IAmazonDynamoDB dynamoDB)
        {
            this.dynamoDB = dynamoDB;
        }

        public async Task<User[]> GetUsers()
        {
            var result = await dynamoDB.ScanAsync(new ScanRequest
            {
                TableName = "user-table"
            });

            if(result != null && result.Items != null)
            {
                var users = new List<User>();

                foreach(var item in result.Items)
                {
                    item.TryGetValue("City", out var city);
                    item.TryGetValue("Address", out var address);
                    item.TryGetValue("Email", out var email);
                    item.TryGetValue("Phone", out var phone);

                    users.Add(new User
                    {
                        Address = address?.S,
                        City = city?.S,
                        Email = email?.S,
                        Phone = phone?.S
                    });
                }

                return users.ToArray();
            }

            return Array.Empty<User>();
        }
    }
}

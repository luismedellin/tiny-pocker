namespace LambdaDemo.Models
{
    using Amazon.DynamoDBv2.DataModel;
    public class Room
    {
        [DynamoDBHashKey("room_id")]
        public string? RoomId { get; set; }
        [DynamoDBProperty("name")]
        public string? Name { get; set; }
        [DynamoDBProperty("owner")]
        public string? Owner { get; set; }
        [DynamoDBProperty("create_date")]
        public DateTime? CreateDate { get; set; }
        [DynamoDBProperty("is_active")]
        public bool? IsActive { get; set; }
        [DynamoDBProperty("user_histories")]
        public List<UserHistory> UserHistories { get; set; }
        [DynamoDBProperty("users")]
        public List<string> Users { get; set; }
    }
}

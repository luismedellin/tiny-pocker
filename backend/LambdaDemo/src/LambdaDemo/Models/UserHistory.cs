namespace LambdaDemo.Models
{
    public class UserHistory
    {
        public string UserHistoryId { get; set; }
        public string Title { get; set; }
        public List<Vote> Votes { get; set; }
    }

    public class Vote
    {
        public string UserId { get; set; }
        public byte Points { get; set; }
    }
}

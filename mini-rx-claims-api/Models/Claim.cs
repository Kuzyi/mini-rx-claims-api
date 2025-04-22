namespace MiniRxClaimsApi.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string MemberId { get; set; }
        public string DrugCode { get; set; }
        public DateTime DateFilled { get; set; }
    }
}

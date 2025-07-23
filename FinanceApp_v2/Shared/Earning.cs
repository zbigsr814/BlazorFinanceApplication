using FinanceApp_v2.Components;

namespace FinanceApp_v2
{
	public class Earning
	{
        public Earning()
        {
            Id = new Guid();
		}

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public EarningCategory Category { get; set; }
        public decimal Amount { get; set; }
    }
}

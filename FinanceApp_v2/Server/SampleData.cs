using FinanceApp_v2.Storage;
using System.Runtime.CompilerServices;

namespace FinanceApp_v2
{
	public static class SampleData
	{
		public static void AddEarningsRepository(this IServiceCollection services)
		{
			var today = DateTime.Now;
			var lastMonth = DateTime.Today.AddMonths(-1);
			var previousMonth = DateTime.Today.AddMonths(-2);

			var earningRepository = new MemoryRepository<Earning>();

			earningRepository.Add(new Earning { Date = new DateTime(previousMonth.Year, previousMonth.Month, 25), Amount = 220, Category = Components.EarningCategory.Coaching, Subject = "Financal coatching" });
			earningRepository.Add(new Earning { Date = new DateTime(previousMonth.Year, previousMonth.Month, 3), Amount = 110, Category = Components.EarningCategory.Flipping, Subject = "Financal Flipping" });
			earningRepository.Add(new Earning { Date = new DateTime(previousMonth.Year, previousMonth.Month, 12), Amount = 650, Category = Components.EarningCategory.CapitalGain, Subject = "Financal CapitalGain" });

			services.AddSingleton<IRepository<Earning>>(earningRepository);
		}
	}
}

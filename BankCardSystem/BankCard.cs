namespace BankCardSystem
{
	public class BankCard
	{
		public string Bankname { get; set; }
		public string Fullname { get; set; }
		public string Pan { get; set; }
		public string Pin { get; set; }
		public string Cvc { get; set; }
		public string ExpireDate { get; set; }
		public decimal Balance { get; set; }
		public static Random random = new Random();
		public BankCard(string bankname, string fullname, string pan, string pin, string expireDate)
		{
			Bankname = bankname;
			Fullname = fullname;
			Pan = pan;
			Pin = pin;
			Cvc = Convert.ToString(random.Next(100,999));
			ExpireDate = expireDate;
			Balance = random.Next(100,10000);
		}
		public override string ToString()
		{
			return $"Bank Name:{Bankname}\nFull Name:{Fullname}\nPAN:{Pan}\nPIN:{Pin}\nCVC:{Cvc}\nExpire Date:{ExpireDate}\nBalance:{Balance}";
		}
	}
}

namespace BankCardSystem
{
	public class Bank
	{
		public Client[] Clients { get; set; }
		public Bank(Client[] clients)
		{
			Clients = clients;
		}

		public void ShowCardBalance(BankCard card) {
			Console.WriteLine($"Card Pin:{card.Pin}\n" +
				$"Card Pan:{card.Pan}\n" +
				$"Card Bankname:{card.Bankname}\n" +
				$"Card Balance:{card.Balance}\n" +
				$"Card Bank Fullname:{card.Fullname}");
		}
		public void ShowAllClientsInformation()
		{
			foreach (Client client in Clients)
			{
				Console.WriteLine(client.ToString());
			}
		}
	}
}

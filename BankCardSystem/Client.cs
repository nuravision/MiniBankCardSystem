namespace BankCardSystem
{
	public class Client
	{
		private static int idCounter = 0;
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public decimal Salary { get; set; }
		public BankCard BankAccount { get; set; }

		public Client(string name, string surname, int age, decimal salary, BankCard bankAccount)
		{
			Id=++idCounter;
			Name = name;
			Surname = surname;
			Age = age;
			Salary = salary;
			BankAccount = bankAccount;
		}
		public override string ToString()
		{
			return $"ID:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\n" +
				$"Salary:{Salary}\nBank: {BankAccount.Bankname}\n"+
				$"Balance:{BankAccount.Balance}\n" +
				$"------------------------------------------------------";
		}
	}
}

using System;

namespace BYOC.Core
{
	public class AccountService
	{
		private readonly IApiClient client;

		public Account GetAccount(Guid id)
		{
			return client.GetAccount (id);
		}

		public bool CreateAccount(string email, string password, string firstName, string lastName)
		{
			return client.CreateAccount (email, password, firstName, lastName);
		}

		public bool Authenticate(string email, string password)
		{
			return client.Authenticate (email, password);
		}
	}
}
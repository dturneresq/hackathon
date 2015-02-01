using System;

namespace BYOC.Core
{
	public interface IApiClient
	{
		bool CreateAccount (string email, string password, string firstName, string lastName);

		Account GetAccount (Guid id);

		bool Authenticate (string email, string password);
	}
}


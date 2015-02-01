using System;

namespace BYOC.Core
{
	public class FakeApiClient : IApiClient
	{
		public bool CreateAccount (string email, string password, string firstName, string lastName)
		{
			throw new NotImplementedException ();
		}

		public Account GetAccount (Guid id)
		{
			throw new NotImplementedException ();
		}

		public bool Authenticate (string email, string password)
		{
			throw new NotImplementedException ();
		}
	}
}
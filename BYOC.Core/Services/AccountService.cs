﻿using System;
using JustGiving.Api.Sdk;
using JustGiving.Api.Sdk.Model.Account;

namespace BYOC.Core
{
	public class AccountService
	{
		private readonly JustGivingClient client;

		public AccountService ()
		{
			client = new JustGivingClient (GlobalConfiguration.JustGivingApiKey);
		}

		public string GetAccount()
		{
			var account = client.Account.RetrieveAccount ();

			return "";
		}

		public string CreateAccount(string email, string password, string firstName, string lastName)
		{
			var createAccountRequest = new CreateAccountRequest {
				Email = email,
				Password = password,
				FirstName = firstName,
				LastName = lastName
			};

			string response = client.Account.Create (createAccountRequest);

			return "";
		}
	}
}

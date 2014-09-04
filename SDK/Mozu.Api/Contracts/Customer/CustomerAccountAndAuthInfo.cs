
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Customer
{
		///
		///	The authentication information associated with a customer account.
		///
		public class CustomerAccountAndAuthInfo
		{
			///
			///If true, this customer account and its associated data was imported from an external source.
			///
			public bool IsImport { get; set; }

			///
			///The password required to authenticate this customer account.
			///
			public string Password { get; set; }

			///
			///The unique identifier of the customer account.
			///
			public CustomerAccount Account { get; set; }

		}

}
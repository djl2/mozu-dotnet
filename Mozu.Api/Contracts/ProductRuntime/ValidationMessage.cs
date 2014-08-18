
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of a message displayed when a product validation failure occurs for a shopper in a storefront.
		///
		public class ValidationMessage
		{
			///
			///The contents of the message displayed to the user when the product validation failure occurs.
			///
			public string Message { get; set; }

			///
			///The severity level of the product validation failure.
			///
			public string Severity { get; set; }

			///
			///The entity that triggered the product validation.
			///
			public string Source { get; set; }

			///
			///Unique identifier of the entity that triggered the validation.
			///
			public string SourceId { get; set; }

		}

}
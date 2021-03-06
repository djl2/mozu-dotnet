
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Payments
{
	/// <summary>
	/// commerce/payments/cards related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class PublicCardClient 	{
		
		/// <summary>
		/// payments-cards Post Create description DOCUMENT_HERE 
		/// </summary>
		/// <param name="request">Mozu.PaymentService.Contracts.PublicCard ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=Create( request);
		///   var syncResponseClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> CreateClient(Mozu.Api.Contracts.PaymentService.PublicCard request)
		{
			var url = Mozu.Api.Urls.Commerce.Payments.PublicCardUrl.CreateUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.PaymentService.PublicCard>(request);
			return mozuClient;

		}

		/// <summary>
		/// payments-cards Put Update description DOCUMENT_HERE 
		/// </summary>
		/// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
		/// <param name="request">Mozu.PaymentService.Contracts.PublicCard ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.PaymentService.Response.SyncResponse"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=Update( request,  cardId);
		///   var syncResponseClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse> UpdateClient(Mozu.Api.Contracts.PaymentService.PublicCard request, string cardId)
		{
			var url = Mozu.Api.Urls.Commerce.Payments.PublicCardUrl.UpdateUrl(cardId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.PaymentService.Response.SyncResponse>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.PaymentService.PublicCard>(request);
			return mozuClient;

		}

		/// <summary>
		/// payments-cards Delete Delete description DOCUMENT_HERE 
		/// </summary>
		/// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=Delete( cardId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteClient(string cardId)
		{
			var url = Mozu.Api.Urls.Commerce.Payments.PublicCardUrl.DeleteUrl(cardId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}



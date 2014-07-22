
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


namespace Mozu.Api.Clients.Commerce.Orders.FulfillmentInfo
{
	/// <summary>
	/// Use the Fulfillment Information resource to manage shipping or pickup information for orders.
	/// </summary>
	public partial class FulfillmentInfoClient 	{
		
		/// <summary>
		/// Retrieves a list of the fulfillment information for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFulfillmentInfo( orderId);
		///   var fulfillmentInfoClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo> GetFulfillmentInfoClient(string orderId)
		{
			return GetFulfillmentInfoClient( orderId,  null);
		}

		/// <summary>
		/// Retrieves a list of the fulfillment information for the specified order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order's fulfillment information, which might include uncommitted changes.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFulfillmentInfo( orderId,  draft);
		///   var fulfillmentInfoClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo> GetFulfillmentInfoClient(string orderId, bool? draft =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.FulfillmentInfo.FulfillmentInfoUrl.GetFulfillmentInfoUrl(draft, orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of fulfillment information for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="fulfillmentInfo">Array list of fulfillment information associated with an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetFulFillmentInfo( fulfillmentInfo,  orderId);
		///   var fulfillmentInfoClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo> SetFulFillmentInfoClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo fulfillmentInfo, string orderId)
		{
			return SetFulFillmentInfoClient( fulfillmentInfo,  orderId,  null,  null);
		}

		/// <summary>
		/// Updates one or more properties of fulfillment information for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to set the fulfillment information by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="fulfillmentInfo">Array list of fulfillment information associated with an order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetFulFillmentInfo( fulfillmentInfo,  orderId,  updateMode,  version);
		///   var fulfillmentInfoClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo> SetFulFillmentInfoClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo fulfillmentInfo, string orderId, string updateMode =  null, string version =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.FulfillmentInfo.FulfillmentInfoUrl.SetFulFillmentInfoUrl(orderId, updateMode, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo>(fulfillmentInfo);
			return mozuClient;

		}


	}

}



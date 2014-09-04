
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Pickups resource to organize items submitted in an order into pickups that enable the shopper to fulfill the order items using the in-store pickup method.
	/// </summary>
	public partial class PickupResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PickupResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PickupResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PickupResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of the actions available to perform for the pickup specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the pickup.</param>
		/// <param name="pickupId">Unique identifier of the pickup for which to retrieve available actions.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var string = pickup.GetAvailablePickupFulfillmentActions( orderId,  pickupId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<string> GetAvailablePickupFulfillmentActions(string orderId, string pickupId)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.GetAvailablePickupFulfillmentActionsClient( orderId,  pickupId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<List<string>> GetAvailablePickupFulfillmentActionsAsync(string orderId, string pickupId)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.GetAvailablePickupFulfillmentActionsClient( orderId,  pickupId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the in-store pickup specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the pickup.</param>
		/// <param name="pickupId">Unique identifier of the pickup to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var pickup = pickup.GetPickup( orderId,  pickupId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup GetPickup(string orderId, string pickupId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.GetPickupClient( orderId,  pickupId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> GetPickupAsync(string orderId, string pickupId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.GetPickupClient( orderId,  pickupId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Create a new pickup for the order specified in the request for in-store fufillment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields"></param>
		/// <param name="pickup">Properties of the in-store pickup to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var pickup = pickup.CreatePickup( pickup,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup CreatePickup(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.CreatePickupClient( pickup,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> CreatePickupAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.CreatePickupClient( pickup,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more details of a defined in-store pickup.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the in-store pickup.</param>
		/// <param name="pickupId">Unique identifier of the pickup to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="pickup">Properties of the in-store pickup to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var pickup = pickup.UpdatePickup( pickup,  orderId,  pickupId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup UpdatePickup(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string pickupId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.UpdatePickupClient( pickup,  orderId,  pickupId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> UpdatePickupAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string pickupId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.UpdatePickupClient( pickup,  orderId,  pickupId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes a pickup previously defined for order item in-store pickup fulfillment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the pickup.</param>
		/// <param name="pickupId">Unique identifier of the pickup to remove.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   pickup.DeletePickup( orderId,  pickupId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeletePickup(string orderId, string pickupId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.DeletePickupClient( orderId,  pickupId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeletePickupAsync(string orderId, string pickupId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.DeletePickupClient( orderId,  pickupId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


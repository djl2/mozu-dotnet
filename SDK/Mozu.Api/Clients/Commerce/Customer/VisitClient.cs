
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


namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Visits resource to manage all visits a customer makes to a tenant's sites and measure the level of transactions a customer performs during a unique visit for customer account analytics. Companies can track customer visits by site (including online and in-person interactions), the transactions a customer performs during the visit, and the device type associated with the visit, if any.
	/// </summary>
	public partial class VisitClient 	{
		
		/// <summary>
		/// Retrieves a list of customer visits according to any filter or sort criteria specified in the request.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.VisitCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetVisits();
		///   var visitCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.VisitCollection> GetVisitsClient()
		{
			return GetVisitsClient( null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of customer visits according to any filter or sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.VisitCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetVisits( startIndex,  pageSize,  sortBy,  filter);
		///   var visitCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.VisitCollection> GetVisitsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.VisitUrl.GetVisitsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.VisitCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the customer visit specified in the request.
		/// </summary>
		/// <param name="visitId">Unique identifier of the customer visit to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Visit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetVisit( visitId);
		///   var visitClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Visit> GetVisitClient(string visitId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.VisitUrl.GetVisitUrl(visitId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Visit>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new visit for the customer account specified in the request.
		/// </summary>
		/// <param name="visit">Properties of the visit to add to the customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Visit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddVisit( visit);
		///   var visitClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Visit> AddVisitClient(Mozu.Api.Contracts.Customer.Visit visit)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.VisitUrl.AddVisitUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Visit>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.Visit>(visit);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a defined customer visit.
		/// </summary>
		/// <param name="visitId">Unique identifier of the customer visit to update.</param>
		/// <param name="visit">Properties of the customer visit to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Visit"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateVisit( visit,  visitId);
		///   var visitClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Visit> UpdateVisitClient(Mozu.Api.Contracts.Customer.Visit visit, string visitId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.VisitUrl.UpdateVisitUrl(visitId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Visit>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.Visit>(visit);
			return mozuClient;

		}


	}

}



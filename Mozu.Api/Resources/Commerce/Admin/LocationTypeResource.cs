
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


namespace Mozu.Api.Resources.Commerce.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LocationTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public LocationTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Location.LocationType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.GetLocationTypes();
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Location.LocationType> GetLocationTypes()
		{
			MozuClient<List<Mozu.Api.Contracts.Location.LocationType>> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.GetLocationTypesClient();
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationTypeCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.GetLocationType( locationTypeCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationType GetLocationType(string locationTypeCode)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.GetLocationTypeClient( locationTypeCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.AddLocationType( locationType);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationType AddLocationType(Mozu.Api.Contracts.Location.LocationType locationType)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.AddLocationTypeClient( locationType);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationTypeCode"></param>
		/// <param name="locationType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   var locationType = locationtype.UpdateLocationType( locationType,  locationTypeCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationType UpdateLocationType(Mozu.Api.Contracts.Location.LocationType locationType, string locationTypeCode)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationType> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.UpdateLocationTypeClient( locationType,  locationTypeCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationTypeCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var locationtype = new LocationType();
		///   locationtype.DeleteLocationType( locationTypeCode);
		/// </code>
		/// </example>
		public virtual void DeleteLocationType(string locationTypeCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationTypeClient.DeleteLocationTypeClient( locationTypeCode);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


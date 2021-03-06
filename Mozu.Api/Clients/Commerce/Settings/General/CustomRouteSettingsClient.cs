
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

namespace Mozu.Api.Clients.Commerce.Settings.General
{
	/// <summary>
	/// commerce/settings/general/customroutes related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class CustomRouteSettingsClient 	{
		
		/// <summary>
		/// general-customroutes Get GetCustomRouteSettings description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCustomRouteSettings( responseFields);
		///   var customRouteSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> GetCustomRouteSettingsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.GetCustomRouteSettingsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// general-customroutes Post CreateCustomRouteSettings description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateCustomRouteSettings( settings,  responseFields);
		///   var customRouteSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> CreateCustomRouteSettingsClient(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.CreateCustomRouteSettingsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>(settings);
			return mozuClient;

		}

		/// <summary>
		/// general-customroutes Put UpdateCustomRouteSettings description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">Mozu.SiteSettings.General.Contracts.General.Routing.CustomRouteSettings ApiType DOCUMENT_HERE </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCustomRouteSettings( settings,  responseFields);
		///   var customRouteSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings> UpdateCustomRouteSettingsClient(Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings settings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.UpdateCustomRouteSettingsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.General.General.Routing.CustomRouteSettings>(settings);
			return mozuClient;

		}

		/// <summary>
		/// general-customroutes Delete DeleteCustomRouteSettings description DOCUMENT_HERE 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCustomRouteSettings();
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCustomRouteSettingsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.General.CustomRouteSettingsUrl.DeleteCustomRouteSettingsUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}



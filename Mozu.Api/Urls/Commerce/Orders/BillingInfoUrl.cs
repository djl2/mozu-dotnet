
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class BillingInfoUrl 
	{

		/// <summary>
        /// Get Resource Url for GetBillingInfo
        /// </summary>
        /// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetBillingInfoUrl(string orderId, bool? draft =  null, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/billinginfo?draft={draft}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "draft", draft);
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for SetBillingInfo
        /// </summary>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
        /// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SetBillingInfoUrl(string orderId, string updateMode =  null, string version =  null, string responseFields =  null)
		{
			var url = "/api/commerce/orders/{orderId}/billinginfo?updatemode={updateMode}&version={version}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "updateMode", updateMode);
			mozuUrl.FormatUrl( "version", version);
			return mozuUrl;
		}

				
	}
}


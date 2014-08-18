
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Discounts
{
	public partial class DiscountTargetUrl 
	{

		/// <summary>
        /// Get Resource Url for GetDiscountTarget
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDiscountTargetUrl(int discountId)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/target";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateDiscountTarget
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateDiscountTargetUrl(int discountId)
		{
			var url = "/api/commerce/catalog/admin/discounts/{discountId}/target";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "discountId", discountId);
			return mozuUrl;
		}

				
	}
}

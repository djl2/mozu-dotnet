
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

namespace Mozu.Api.Urls.Commerce.Payments
{
	public partial class PublicCardUrl 
	{

				/// <summary>
        /// Get Resource Url for Create
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateUrl()
		{
			var url = "/payments/commerce/payments/cards/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.PCI_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for Update
        /// </summary>
        /// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateUrl(string cardId)
		{
			var url = "/payments/commerce/payments/cards/{cardId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.PCI_POD, false) ;
			mozuUrl.FormatUrl( "cardId", cardId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for Delete
        /// </summary>
        /// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteUrl(string cardId)
		{
			var url = "/payments/commerce/payments/cards/{cardId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.PCI_POD, false) ;
			mozuUrl.FormatUrl( "cardId", cardId);
			return mozuUrl;
		}

		
	}
}


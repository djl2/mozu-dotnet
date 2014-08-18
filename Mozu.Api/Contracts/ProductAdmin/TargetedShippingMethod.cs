
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Shipping method service type, such as UPS Ground or USPS Priority Mail, targeted for a defined discount.
		///
		public class TargetedShippingMethod
		{
			///
			///The code associated with the carrier's shipping method service type. Service type codes include a prefix that indicates the carrier. For example: FEDEX_INTERNATIONAL_STANDARD
			///
			public string Code { get; set; }

			///
			///Name of the shipping method service type associated with the targeted discount.
			///
			public string Name { get; set; }

		}

}
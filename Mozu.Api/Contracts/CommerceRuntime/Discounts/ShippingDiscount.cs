
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.CommerceRuntime.Discounts
{
		///
		///	Properties of a discount that can apply to shipping an order.
		///
		public class ShippingDiscount
		{
			///
			///Name of the discount added and applied to a shopping cart and order for a shopper's purchase. 
			///
			public AppliedDiscount Discount { get; set; }

			///
			///Carrier-supplied, unique code that represents the shipping method service type associated with the shipping discount.
			///
			public string MethodCode { get; set; }

		}

}
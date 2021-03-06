
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
		///	Properties of an invalid coupon code a shopper attempts to enter for a cart or order.
		///
		public class InvalidCoupon
		{
			public string CouponCode { get; set; }

			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime CreateDate { get; set; }

			///
			///Unique identifier for the discount in the storefront.
			///
			public int DiscountId { get; set; }

			///
			///The reason description for an action, including item return, coupon not valid, and item is taxed. 
			///
			public string Reason { get; set; }

			///
			///A code indicating the reason why a facet is invalid.
			///
			public int ReasonCode { get; set; }

		}

}
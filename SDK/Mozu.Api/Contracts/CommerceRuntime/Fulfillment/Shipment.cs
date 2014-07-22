
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
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of a shipment used to ship order items to a shopper. A shipment can include any number of packages.
		///
		public class Shipment
		{
			///
			///Total cost of shipping the shipment to the shopper.
			///
			public decimal? Cost { get; set; }

			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///Unique identifier of the shipment.
			///
			public string Id { get; set; }

			///
			///Array list of identifiers that represent the packages in this shipment.
			///
			public List<string> PackageIds { get; set; }

			///
			///Code that identifies the service type method used to perform the shipment, such as UPS_GROUND.
			///
			public string ShippingMethodCode { get; set; }

			///
			///If true, a shopper signature is required to deliver this shipment.
			///
			public bool? SignatureRequired { get; set; }

			///
			///The shipping tracking number supplied by the shipping provider to track the shipment.
			///
			public string TrackingNumber { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The address to which to shipment will ship.
			///
			public Contact DestinationAddress { get; set; }

			///
			///The address from which the shipment will ship.
			///
			public Contact OriginAddress { get; set; }

		}

}
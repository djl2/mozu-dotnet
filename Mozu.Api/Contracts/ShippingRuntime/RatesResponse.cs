
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

namespace Mozu.Api.Contracts.ShippingRuntime
{
		///
		///	Properties of the calculated shipping rate based on the information supplied in the request.
		///
		public class RatesResponse
		{
			///
			///Arrayed list of calculated shipping rates for each assocuated carrier.
			///
			public List<CarrierRatesResponse> Rates { get; set; }

		}

}
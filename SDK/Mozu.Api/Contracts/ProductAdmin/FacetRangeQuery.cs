
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
		///	For range type facets, a single range of facet values. For example, a price facet might have a $0-$25 range query.
		///
		public class FacetRangeQuery
		{
			///
			///The maximum value to use for the facet range query.
			///
			public object RangeValueEnd { get; set; }

			///
			///The minimum value to use for the facet range query.
			///
			public object RangeValueStart { get; set; }

		}

}
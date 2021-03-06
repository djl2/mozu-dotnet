
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


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties for the site search settings.
		///
		public class SiteSearchSettings
		{
			///
			///Custom boost value for searches.
			///
			public List<string> CustomBoosts { get; set; }

			///
			///Custom field for searches.
			///
			public List<SiteSearchRelevancyCustomField> CustomFields { get; set; }

			///
			///Indicates if the object is default. This indicator is used for product variations and site search settings. If true, the value/object is the default option. 
			///
			public bool IsDefault { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.SiteSearchSettings minimumMatchPercent ApiTypeMember DOCUMENT_HERE 
			///
			public int? MinimumMatchPercent { get; set; }

			///
			///The name for the search settings.
			///
			public string SettingsName { get; set; }

			///
			///The site keyword relevancy settings.
			///
			public SiteSearchKeywordRelevancySettings SiteKeywordRelevancy { get; set; }

			///
			///The site phrase relevancy settings.
			///
			public SiteSearchPhraseRelevancySettings SitePhraseRelevancy { get; set; }

		}

}
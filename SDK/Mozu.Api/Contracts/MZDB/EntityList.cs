
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
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.MZDB
{
		public class EntityList
		{
			public string ContextLevel { get; set; }

			public DateTime CreateDate { get; set; }

			public bool IsLocaleSpecific { get; set; }

			public bool IsSandboxDataCloningSupported { get; set; }

			public bool IsShopperSpecific { get; set; }

			public bool IsVisibleInStorefront { get; set; }

			public string Name { get; set; }

			public string NameSpace { get; set; }

			public int TenantId { get; set; }

			public DateTime UpdateDate { get; set; }

			public List<string> Usages { get; set; }

			public bool UseSystemAssignedId { get; set; }

			public IndexedProperty IdProperty { get; set; }

			public IndexedProperty IndexA { get; set; }

			public IndexedProperty IndexB { get; set; }

			public IndexedProperty IndexC { get; set; }

			public IndexedProperty IndexD { get; set; }

			public JObject Metadata { get; set; }

			public List<ListView> Views { get; set; }

		}

}
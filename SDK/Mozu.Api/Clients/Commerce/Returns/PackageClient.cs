
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
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Commerce.Returns
{
	/// <summary>
	/// Use the return packages subresource to manage physical packages used to ship return replacement items.
	/// </summary>
	public partial class PackageClient 	{
		
		/// <summary>
		/// Retrieves the details of a package of return replacement items.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to retrieve.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackage( returnId,  packageId);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> GetPackageClient(string returnId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.GetPackageUrl(packageId, returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the package label image supplied by the carrier for a return replacement.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package for which to retrieve the label.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package label to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPackageLabel( returnId,  packageId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetPackageLabelClient(string returnId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.GetPackageLabelUrl(packageId, returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new physical package of return replacement items.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return for which to create a replacement package.</param>
		/// <param name="package">Properties of the physical package for a return replacement.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackage( pkg,  returnId);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> CreatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.CreatePackageUrl(returnId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a package associated with a return replacement.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to update.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to update.</param>
		/// <param name="package">Properties of the return replacement package to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePackage( pkg,  returnId,  packageId);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package> UpdatePackageClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package pkg, string returnId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.UpdatePackageUrl(packageId, returnId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>(pkg);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a package associated with a return replacement.
		/// </summary>
		/// <param name="packageId">Unique identifier of the return replacement package to delete.</param>
		/// <param name="returnId">Unique identifier of the return associated with the replacement package to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePackage( returnId,  packageId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePackageClient(string returnId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.PackageUrl.DeletePackageUrl(packageId, returnId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}



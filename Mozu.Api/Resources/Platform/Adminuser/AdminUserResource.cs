
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
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Resources.Platform.Adminuser
{
	/// <summary>
	/// The Accounts resource displays the user accounts and account details associated with a developer or Mozu tenant administrator. Email addresses uniquely identify admin user accounts.
	/// </summary>
	public partial class AdminUserResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AdminUserResource() 
		{
			_apiContext = null;
		}
		 public AdminUserResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AdminUserResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AdminUserResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of the Mozu tenants or development stores for which the specified user has an assigned role.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Tenant.TenantCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adminuser = new AdminUser();
		///   var tenantCollection = adminuser.GetTenantScopesForUser( userId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Tenant.TenantCollection GetTenantScopesForUser(string userId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Tenant.TenantCollection> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.AdminUserClient.GetTenantScopesForUserClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of the Mozu tenants or development stores for which the specified user has an assigned role.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Tenant.TenantCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adminuser = new AdminUser();
		///   var tenantCollection = await adminuser.GetTenantScopesForUserAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Tenant.TenantCollection> GetTenantScopesForUserAsync(string userId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Tenant.TenantCollection> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.AdminUserClient.GetTenantScopesForUserClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the specified administrator user account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.User"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adminuser = new AdminUser();
		///   var user = adminuser.GetUser( userId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Core.User GetUser(string userId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.User> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.AdminUserClient.GetUserClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the specified administrator user account.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.User"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adminuser = new AdminUser();
		///   var user = await adminuser.GetUserAsync( userId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Core.User> GetUserAsync(string userId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.User> response;
			var client = Mozu.Api.Clients.Platform.Adminuser.AdminUserClient.GetUserClient( userId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}



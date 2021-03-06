
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

namespace Mozu.Api.Resources.Platform.Applications
{
	/// <summary>
	/// Use the Authetickets for applications resource to manage authentication tickets for your apps.
	/// </summary>
	public partial class AuthTicketResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AuthTicketResource() 
		{
			_apiContext = null;
		}
		 public AuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AuthTicketResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AuthTicketResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Generate an authentication ticket for an application.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="appAuthInfo">The information required to authenticate third party applications against the Mozu API.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = authticket.AuthenticateApp( appAuthInfo,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.AppDev.AuthTicket AuthenticateApp(Mozu.Api.Contracts.AppDev.AppAuthInfo appAuthInfo, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.AuthenticateAppClient( appAuthInfo,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Generate an authentication ticket for an application.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="appAuthInfo">The information required to authenticate third party applications against the Mozu API.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = await authticket.AuthenticateAppAsync( appAuthInfo,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AppDev.AuthTicket> AuthenticateAppAsync(Mozu.Api.Contracts.AppDev.AppAuthInfo appAuthInfo, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.AuthenticateAppClient( appAuthInfo,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Refreshes the application's authentication ticket and generates a new access token by providing the refresh token string.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="authTicketRequest">Properties of the authentication ticket refresh requests, which includes the refresh token string.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = authticket.RefreshAppAuthTicket( authTicketRequest,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.AppDev.AuthTicket RefreshAppAuthTicket(Mozu.Api.Contracts.AppDev.AuthTicketRequest authTicketRequest, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.RefreshAppAuthTicketClient( authTicketRequest,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Refreshes the application's authentication ticket and generates a new access token by providing the refresh token string.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="authTicketRequest">Properties of the authentication ticket refresh requests, which includes the refresh token string.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = await authticket.RefreshAppAuthTicketAsync( authTicketRequest,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.AppDev.AuthTicket> RefreshAppAuthTicketAsync(Mozu.Api.Contracts.AppDev.AuthTicketRequest authTicketRequest, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.RefreshAppAuthTicketClient( authTicketRequest,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes an authentication for an application based on the specified refresh token.
		/// </summary>
		/// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   authticket.DeleteAppAuthTicket( refreshToken);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteAppAuthTicket(string refreshToken)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.DeleteAppAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes an authentication for an application based on the specified refresh token.
		/// </summary>
		/// <param name="refreshToken">Alphanumeric string used for access tokens. This token refreshes access for accounts by generating a new developer or application account authentication ticket after an access token expires.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   await authticket.DeleteAppAuthTicketAsync( refreshToken);
		/// </code>
		/// </example>
		public virtual async Task DeleteAppAuthTicketAsync(string refreshToken)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.DeleteAppAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}




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


namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// Use the Cards subresource to manage stored credit cards for customer accounts. Mozu stores limited card data in the Customer service for expedited ordering purposes; however, the complete card data is stored in the Payment service.
	/// </summary>
	public partial class CardResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public CardResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves all stored credit cards for the customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CardCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var cardCollection = card.GetAccountCards( accountId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CardCollection GetAccountCards(int accountId)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CardCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.GetAccountCardsClient( accountId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="cardId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Card"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var card = card.GetAccountCard( accountId,  cardId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.Card GetAccountCard(int accountId, string cardId)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Card> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.GetAccountCardClient( accountId,  cardId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new credit card record and stores it for the customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="card">Properties of the customer credit card to add to the account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Card"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var card = card.AddAccountCard( card,  accountId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.Card AddAccountCard(Mozu.Api.Contracts.Customer.Card card, int accountId)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Card> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.AddAccountCardClient( card,  accountId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Update one or more properties of a credit card defined for a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="cardId"></param>
		/// <param name="card">Properties of the customer account credit card to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Card"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var card = card.UpdateAccountCard( card,  accountId,  cardId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.Card UpdateAccountCard(Mozu.Api.Contracts.Customer.Card card, int accountId, string cardId)
		{
			MozuClient<Mozu.Api.Contracts.Customer.Card> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.UpdateAccountCardClient( card,  accountId,  cardId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Removes a stored credit card from a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="cardId">Unique identifier of the credit card to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   card.DeleteAccountCard( accountId,  cardId);
		/// </code>
		/// </example>
		public virtual void DeleteAccountCard(int accountId, string cardId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.DeleteAccountCardClient( accountId,  cardId);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}



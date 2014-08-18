
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Properties of the metadata associated with a file or subfolder in a development or release package associated with an application version.
		///
		public class FileMetadata
		{
			///
			///Checksum function used to validate the local version of the file against the version on the server.
			///
			public string CheckSum { get; set; }

			///
			///Unique identifier of the file.
			///
			public string Id { get; set; }

			///
			///The path and file name that represents the file location.
			///
			public string Path { get; set; }

			///
			///The total size of the package file, in bytes.
			///
			public long SizeInBytes { get; set; }

			///
			///The type of file in the package.
			///
			public string Type { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}
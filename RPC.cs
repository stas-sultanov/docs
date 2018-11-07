using System;

namespace TL.RPC
{
	/// <summary>Represents a Client to Server request.</summary>
	public class Request
	{
		/// <summary>A name of the method to invoke.</summary>
		/// <remarks>This member is required.</remarks>
		public String Method { get; set; }

		/// <summary>A Structured value that holds the parameter values to be used during the invocation of the method.</summary>
		/// <remarks>This member is not required.</remarks>
		public Object Params { get; set; }

		/// <summary>An identifier of invocation established by the Client.</summary>
		/// <remarks>This member is required. Must be not <c>0</c>.</remarks>
		public Int32 Id { get; set; }
	}

	/// <summary>Represents a Server to Client response.</summary>
	public class Response
	{
		/// <summary>An object that contains all the information regarding the error ocured.</summary>
		/// <remarks>This member must be <c>null</c> if there was no error during method invocation.</remarks>
		public Error Error { get; private set; }

		/// <summary>An identifier of invocation established by the Client.</summary>
		/// <remarks>
		/// If there was no error must be the same as the value of the <see cref="Request.Id"/> member in the <see cref="Request"/> object.
		/// If there was an error must be <c>0</c>.
		/// </remarks>
		public Int32 Id { get; private set; }

		/// <summary>A structured value that contains result of the method invoked on the Server.</summary>
		/// <remarks>If there was an error must be <c>null</c>.</remarks>
		public Object Result { get; private set; }

		/// <summary>Initalizes a new instance of <see cref="Response"/> object</summary>
		/// <param name="error">Error ocured.</param>
		public Response(Error error)
		{
			Error = error;

			Id = 0;

			Result = null;
		}
	}

	/// <summary>Represents an error ocured during the method invocation.</summary>
	public sealed class Error
	{
		/// <summary>An error code.</summary>
		/// <remarks>This member is required.</remarks>
		public Int32 Code { get; set; }

		/// <summary>A human-readable description of the error.</summary>
		public String Message { get; set; }

		/// <summary>An array of arguments to construct localized message.</summary>
		public String[] Params { get; set; }

		/// <summary>A unique identifier of the error that MUST be used for end-to-end traceability.</summary>
		/// <remarks>This member is required.</remarks>
		public String TraceId { get; set; }
	}
}
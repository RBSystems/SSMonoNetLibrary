//
// System.Net.CookieException.cs
//
// Author:
//   Lawrence Pit (loz@cable.a2000.nl)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Globalization;
using System.Runtime.Serialization;

#if SSHARP
namespace SSMono.Net
#else
namespace System.Net
#endif
	{
	[Serializable]
	public class CookieException : FormatException
#if !NETCF
		, ISerializable
#endif
		{

		// Constructors
		public CookieException ()
			: base ()
			{
			}

		internal CookieException (string msg)
			: base (msg)
			{
			}

		internal CookieException (string msg, Exception e)
			: base (msg, e)
			{
			}

#if !NETCF
		protected CookieException (SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base (serializationInfo, streamingContext)
			{
			}

		// Methods
		void ISerializable.GetObjectData (SerializationInfo info, StreamingContext context)
			{
			base.GetObjectData (info, context);
			}

		public override void GetObjectData (SerializationInfo serializationInfo, StreamingContext streamingContext)
			{
			base.GetObjectData (serializationInfo, streamingContext);
			}
#endif
		}
	}


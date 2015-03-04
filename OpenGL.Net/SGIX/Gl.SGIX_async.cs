
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_ASYNC_MARKER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async")]
		public const int ASYNC_MARKER_SGIX = 0x8329;

		/// <summary>
		/// Binding for glAsyncMarkerSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_async")]
		public static void AsyncMarkerSGIX(UInt32 marker)
		{
			Debug.Assert(Delegates.pglAsyncMarkerSGIX != null, "pglAsyncMarkerSGIX not implemented");
			Delegates.pglAsyncMarkerSGIX(marker);
			CallLog("glAsyncMarkerSGIX({0})", marker);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFinishAsyncSGIX.
		/// </summary>
		/// <param name="markerp">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_async")]
		public static Int32 FinishAsyncSGIX(UInt32[] markerp)
		{
			Int32 retValue;

			unsafe {
				fixed (UInt32* p_markerp = markerp)
				{
					Debug.Assert(Delegates.pglFinishAsyncSGIX != null, "pglFinishAsyncSGIX not implemented");
					retValue = Delegates.pglFinishAsyncSGIX(p_markerp);
					CallLog("glFinishAsyncSGIX({0}) = {1}", markerp, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPollAsyncSGIX.
		/// </summary>
		/// <param name="markerp">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_async")]
		public static Int32 PollAsyncSGIX(UInt32[] markerp)
		{
			Int32 retValue;

			unsafe {
				fixed (UInt32* p_markerp = markerp)
				{
					Debug.Assert(Delegates.pglPollAsyncSGIX != null, "pglPollAsyncSGIX not implemented");
					retValue = Delegates.pglPollAsyncSGIX(p_markerp);
					CallLog("glPollAsyncSGIX({0}) = {1}", markerp, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGenAsyncMarkersSGIX.
		/// </summary>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_async")]
		public static UInt32 GenAsyncMarkerSGIX(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenAsyncMarkersSGIX != null, "pglGenAsyncMarkersSGIX not implemented");
			retValue = Delegates.pglGenAsyncMarkersSGIX(range);
			CallLog("glGenAsyncMarkersSGIX({0}) = {1}", range, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glDeleteAsyncMarkersSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="range">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_async")]
		public static void DeleteAsyncMarkerSGIX(UInt32 marker, Int32 range)
		{
			Debug.Assert(Delegates.pglDeleteAsyncMarkersSGIX != null, "pglDeleteAsyncMarkersSGIX not implemented");
			Delegates.pglDeleteAsyncMarkersSGIX(marker, range);
			CallLog("glDeleteAsyncMarkersSGIX({0}, {1})", marker, range);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsAsyncMarkerSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_async")]
		public static bool IsAsyncMarkerSGIX(UInt32 marker)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsAsyncMarkerSGIX != null, "pglIsAsyncMarkerSGIX not implemented");
			retValue = Delegates.pglIsAsyncMarkerSGIX(marker);
			CallLog("glIsAsyncMarkerSGIX({0}) = {1}", marker, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}


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
		/// Binding for glClearDepthfOES.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision")]
		public static void ClearDepthOES(float depth)
		{
			Debug.Assert(Delegates.pglClearDepthfOES != null, "pglClearDepthfOES not implemented");
			Delegates.pglClearDepthfOES(depth);
			CallLog("glClearDepthfOES({0})", depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanefOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision")]
		public static void ClipPlaneOES(int plane, float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanefOES != null, "pglClipPlanefOES not implemented");
					Delegates.pglClipPlanefOES(plane, p_equation);
					CallLog("glClipPlanefOES({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangefOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision")]
		public static void DepthRangeOES(float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangefOES != null, "pglDepthRangefOES not implemented");
			Delegates.pglDepthRangefOES(n, f);
			CallLog("glDepthRangefOES({0}, {1})", n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFrustumfOES.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision")]
		public static void FrustumOES(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglFrustumfOES != null, "pglFrustumfOES not implemented");
			Delegates.pglFrustumfOES(l, r, b, t, n, f);
			CallLog("glFrustumfOES({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetClipPlanefOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision")]
		public static void GetClipPlaneOES(int plane, float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanefOES != null, "pglGetClipPlanefOES not implemented");
					Delegates.pglGetClipPlanefOES(plane, p_equation);
					CallLog("glGetClipPlanefOES({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glOrthofOES.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision")]
		public static void OrthoOES(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglOrthofOES != null, "pglOrthofOES not implemented");
			Delegates.pglOrthofOES(l, r, b, t, n, f);
			CallLog("glOrthofOES({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

	}

}

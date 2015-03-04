
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
		/// Binding for glMultiTexCoord1bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord1OES(int texture, sbyte s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1bOES != null, "pglMultiTexCoord1bOES not implemented");
			Delegates.pglMultiTexCoord1bOES(texture, s);
			CallLog("glMultiTexCoord1bOES({0}, {1})", texture, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord1OES(int texture, sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1bvOES != null, "pglMultiTexCoord1bvOES not implemented");
					Delegates.pglMultiTexCoord1bvOES(texture, p_coords);
					CallLog("glMultiTexCoord1bvOES({0}, {1})", texture, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord2OES(int texture, sbyte s, sbyte t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2bOES != null, "pglMultiTexCoord2bOES not implemented");
			Delegates.pglMultiTexCoord2bOES(texture, s, t);
			CallLog("glMultiTexCoord2bOES({0}, {1}, {2})", texture, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord2OES(int texture, sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2bvOES != null, "pglMultiTexCoord2bvOES not implemented");
					Delegates.pglMultiTexCoord2bvOES(texture, p_coords);
					CallLog("glMultiTexCoord2bvOES({0}, {1})", texture, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord3OES(int texture, sbyte s, sbyte t, sbyte r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3bOES != null, "pglMultiTexCoord3bOES not implemented");
			Delegates.pglMultiTexCoord3bOES(texture, s, t, r);
			CallLog("glMultiTexCoord3bOES({0}, {1}, {2}, {3})", texture, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord3OES(int texture, sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3bvOES != null, "pglMultiTexCoord3bvOES not implemented");
					Delegates.pglMultiTexCoord3bvOES(texture, p_coords);
					CallLog("glMultiTexCoord3bvOES({0}, {1})", texture, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord4OES(int texture, sbyte s, sbyte t, sbyte r, sbyte q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4bOES != null, "pglMultiTexCoord4bOES not implemented");
			Delegates.pglMultiTexCoord4bOES(texture, s, t, r, q);
			CallLog("glMultiTexCoord4bOES({0}, {1}, {2}, {3}, {4})", texture, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord4OES(int texture, sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4bvOES != null, "pglMultiTexCoord4bvOES not implemented");
					Delegates.pglMultiTexCoord4bvOES(texture, p_coords);
					CallLog("glMultiTexCoord4bvOES({0}, {1})", texture, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord1OES(sbyte s)
		{
			Debug.Assert(Delegates.pglTexCoord1bOES != null, "pglTexCoord1bOES not implemented");
			Delegates.pglTexCoord1bOES(s);
			CallLog("glTexCoord1bOES({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord1OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord1bvOES != null, "pglTexCoord1bvOES not implemented");
					Delegates.pglTexCoord1bvOES(p_coords);
					CallLog("glTexCoord1bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord2OES(sbyte s, sbyte t)
		{
			Debug.Assert(Delegates.pglTexCoord2bOES != null, "pglTexCoord2bOES not implemented");
			Delegates.pglTexCoord2bOES(s, t);
			CallLog("glTexCoord2bOES({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord2OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord2bvOES != null, "pglTexCoord2bvOES not implemented");
					Delegates.pglTexCoord2bvOES(p_coords);
					CallLog("glTexCoord2bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord3OES(sbyte s, sbyte t, sbyte r)
		{
			Debug.Assert(Delegates.pglTexCoord3bOES != null, "pglTexCoord3bOES not implemented");
			Delegates.pglTexCoord3bOES(s, t, r);
			CallLog("glTexCoord3bOES({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord3OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord3bvOES != null, "pglTexCoord3bvOES not implemented");
					Delegates.pglTexCoord3bvOES(p_coords);
					CallLog("glTexCoord3bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord4OES(sbyte s, sbyte t, sbyte r, sbyte q)
		{
			Debug.Assert(Delegates.pglTexCoord4bOES != null, "pglTexCoord4bOES not implemented");
			Delegates.pglTexCoord4bOES(s, t, r, q);
			CallLog("glTexCoord4bOES({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord4OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord4bvOES != null, "pglTexCoord4bvOES not implemented");
					Delegates.pglTexCoord4bvOES(p_coords);
					CallLog("glTexCoord4bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2bOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex2OES(sbyte x, sbyte y)
		{
			Debug.Assert(Delegates.pglVertex2bOES != null, "pglVertex2bOES not implemented");
			Delegates.pglVertex2bOES(x, y);
			CallLog("glVertex2bOES({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex2OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex2bvOES != null, "pglVertex2bvOES not implemented");
					Delegates.pglVertex2bvOES(p_coords);
					CallLog("glVertex2bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3bOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex3OES(sbyte x, sbyte y, sbyte z)
		{
			Debug.Assert(Delegates.pglVertex3bOES != null, "pglVertex3bOES not implemented");
			Delegates.pglVertex3bOES(x, y, z);
			CallLog("glVertex3bOES({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex3OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex3bvOES != null, "pglVertex3bvOES not implemented");
					Delegates.pglVertex3bvOES(p_coords);
					CallLog("glVertex3bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4bOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex4OES(sbyte x, sbyte y, sbyte z, sbyte w)
		{
			Debug.Assert(Delegates.pglVertex4bOES != null, "pglVertex4bOES not implemented");
			Delegates.pglVertex4bOES(x, y, z, w);
			CallLog("glVertex4bOES({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex4OES(sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex4bvOES != null, "pglVertex4bvOES not implemented");
					Delegates.pglVertex4bvOES(p_coords);
					CallLog("glVertex4bvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

	}

}

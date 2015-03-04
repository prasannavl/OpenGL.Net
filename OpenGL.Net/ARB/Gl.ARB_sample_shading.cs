
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
		/// Value of GL_SAMPLE_SHADING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_shading")]
		public const int SAMPLE_SHADING_ARB = 0x8C36;

		/// <summary>
		/// Value of GL_MIN_SAMPLE_SHADING_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_shading")]
		public const int MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;

		/// <summary>
		/// Binding for glMinSampleShadingARB.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sample_shading")]
		public static void MinSampleShadingARB(float value)
		{
			Debug.Assert(Delegates.pglMinSampleShadingARB != null, "pglMinSampleShadingARB not implemented");
			Delegates.pglMinSampleShadingARB(value);
			CallLog("glMinSampleShadingARB({0})", value);
			DebugCheckErrors();
		}

	}

}

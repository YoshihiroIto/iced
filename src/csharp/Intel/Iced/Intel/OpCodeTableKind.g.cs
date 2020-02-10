/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

// ⚠️This file was generated by GENERATOR!🦹‍♂️

#nullable enable

#if ENCODER
namespace Iced.Intel {
	/// <summary>Opcode table</summary>
	public enum OpCodeTableKind {
		/// <summary>Legacy encoding table</summary>
		Normal,
		/// <summary><c>0Fxx</c> table (legacy, VEX, EVEX)</summary>
		T0F,
		/// <summary><c>0F38xx</c> table (legacy, VEX, EVEX)</summary>
		T0F38,
		/// <summary><c>0F3Axx</c> table (legacy, VEX, EVEX)</summary>
		T0F3A,
		/// <summary><c>XOP8</c> table (XOP)</summary>
		XOP8,
		/// <summary><c>XOP9</c> table (XOP)</summary>
		XOP9,
		/// <summary><c>XOPA</c> table (XOP)</summary>
		XOPA,
	}
}
#endif

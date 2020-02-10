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

#if INSTR_INFO
namespace Iced.Intel {
	/// <summary>Operand, register and memory access</summary>
	public enum OpAccess {
		/// <summary>Nothing is read and nothing is written</summary>
		None,
		/// <summary>The value is read</summary>
		Read,
		/// <summary>The value is sometimes read and sometimes not</summary>
		CondRead,
		/// <summary>The value is completely overwritten</summary>
		Write,
		/// <summary>Conditional write, sometimes it&apos;s written and sometimes it&apos;s not modified</summary>
		CondWrite,
		/// <summary>The value is read and written</summary>
		ReadWrite,
		/// <summary>The value is read and sometimes written</summary>
		ReadCondWrite,
		/// <summary>The memory operand doesn&apos;t refer to memory (eg. <c>LEA</c> instruction) or it&apos;s an instruction that doesn&apos;t read the data to a register or doesn&apos;t write to the memory location, it just prefetches/invalidates it, eg. <c>INVLPG</c>, <c>PREFETCHNTA</c>, <c>VGATHERPF0DPS</c>, etc.</summary>
		NoMemAccess,
	}
}
#endif

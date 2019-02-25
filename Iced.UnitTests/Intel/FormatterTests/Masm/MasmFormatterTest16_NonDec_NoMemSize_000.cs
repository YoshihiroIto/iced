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

#if !NO_MASM_FORMATTER && !NO_FORMATTER && !NO_ENCODER
using System.Collections.Generic;
using Iced.Intel;
using Iced.UnitTests.Intel.DecoderTests;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Masm {
	public sealed class MasmFormatterTest16_NonDec_NoMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, Instruction info, string formattedString) => FormatBase(index, info, formattedString, MasmFormatterFactory.Create_NoMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(NonDecodedInstructions.Infos16, formattedStrings);

		static readonly string[] formattedStrings = new string[NonDecodedInstructions.Infos16_Count] {
			"popw cs",
			"fstenv [bx+si]",
			"fstenv fs:[bx+si]",
			"fstenv [bx+si]",
			"fstenv fs:[bx+si]",
			"fstcw [bx+si]",
			"fstcw fs:[bx+si]",
			"feni",
			"fdisi",
			"fclex",
			"finit",
			"fsetpm",
			"fsave [bx+si]",
			"fsave fs:[bx+si]",
			"fsave [bx+si]",
			"fsave fs:[bx+si]",
			"fstsw [bx+si]",
			"fstsw fs:[bx+si]",
			"fstsw ax",
			"db",
			"db 77h",
			"db 77h,0A9h",
			"db 77h,0A9h,0CEh",
			"db 77h,0A9h,0CEh,9Dh",
			"db 77h,0A9h,0CEh,9Dh,55h",
			"db 77h,0A9h,0CEh,9Dh,55h,5",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h,0FEh",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h,0FEh,4Fh",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h,0FEh,4Fh,34h",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h,0FEh,4Fh,34h,27h",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h,0FEh,4Fh,34h,27h,0AAh",
			"db 77h,0A9h,0CEh,9Dh,55h,5,42h,6Ch,86h,32h,0FEh,4Fh,34h,27h,0AAh,8",
			"dw",
			"dw 77A9h",
			"dw 77A9h,0CE9Dh",
			"dw 77A9h,0CE9Dh,5505h",
			"dw 77A9h,0CE9Dh,5505h,426Ch",
			"dw 77A9h,0CE9Dh,5505h,426Ch,8632h",
			"dw 77A9h,0CE9Dh,5505h,426Ch,8632h,0FE4Fh",
			"dw 77A9h,0CE9Dh,5505h,426Ch,8632h,0FE4Fh,3427h",
			"dw 77A9h,0CE9Dh,5505h,426Ch,8632h,0FE4Fh,3427h,0AA08h",
			"dd",
			"dd 77A9CE9Dh",
			"dd 77A9CE9Dh,5505426Ch",
			"dd 77A9CE9Dh,5505426Ch,8632FE4Fh",
			"dd 77A9CE9Dh,5505426Ch,8632FE4Fh,3427AA08h",
			"dq",
			"dq 77A9CE9D5505426Ch",
			"dq 77A9CE9D5505426Ch,8632FE4F3427AA08h",
		};
	}
}
#endif

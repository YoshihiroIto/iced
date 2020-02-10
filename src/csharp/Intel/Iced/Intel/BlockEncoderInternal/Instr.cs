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

#if ENCODER
using System;

namespace Iced.Intel.BlockEncoderInternal {
	abstract class Instr {
		public readonly Block Block;
		public uint Size;
		public ulong IP;
		public readonly ulong OrigIP;

		// 6 = FF 15 XXXXXXXX = call qword ptr [rip+mem_target]
		protected const uint CallOrJmpPointerDataInstructionSize64 = 6;

		protected Instr(Block block, ulong origIp) {
			OrigIP = origIp;
			Block = block;
		}

		/// <summary>
		/// Initializes the target address and tries to optimize the instruction
		/// </summary>
		public abstract void Initialize(BlockEncoder blockEncoder);

		/// <summary>
		/// Returns <see langword="true"/> if the instruction was updated to a shorter instruction, <see langword="false"/> if nothing changed
		/// </summary>
		/// <returns></returns>
		public abstract bool Optimize();

		public abstract string? TryEncode(Encoder encoder, out ConstantOffsets constantOffsets, out bool isOriginalInstruction);

		protected string CreateErrorMessage(string errorMessage, in Instruction instruction) =>
			$"{errorMessage} : 0x{instruction.IP:X} {instruction.ToString()}";

		public static Instr Create(BlockEncoder blockEncoder, Block block, in Instruction instruction) {
			switch (instruction.Code) {
			// GENERATOR-BEGIN: JccInstr
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			case Code.Jo_rel8_16:
			case Code.Jo_rel8_32:
			case Code.Jo_rel8_64:
			case Code.Jno_rel8_16:
			case Code.Jno_rel8_32:
			case Code.Jno_rel8_64:
			case Code.Jb_rel8_16:
			case Code.Jb_rel8_32:
			case Code.Jb_rel8_64:
			case Code.Jae_rel8_16:
			case Code.Jae_rel8_32:
			case Code.Jae_rel8_64:
			case Code.Je_rel8_16:
			case Code.Je_rel8_32:
			case Code.Je_rel8_64:
			case Code.Jne_rel8_16:
			case Code.Jne_rel8_32:
			case Code.Jne_rel8_64:
			case Code.Jbe_rel8_16:
			case Code.Jbe_rel8_32:
			case Code.Jbe_rel8_64:
			case Code.Ja_rel8_16:
			case Code.Ja_rel8_32:
			case Code.Ja_rel8_64:
			case Code.Js_rel8_16:
			case Code.Js_rel8_32:
			case Code.Js_rel8_64:
			case Code.Jns_rel8_16:
			case Code.Jns_rel8_32:
			case Code.Jns_rel8_64:
			case Code.Jp_rel8_16:
			case Code.Jp_rel8_32:
			case Code.Jp_rel8_64:
			case Code.Jnp_rel8_16:
			case Code.Jnp_rel8_32:
			case Code.Jnp_rel8_64:
			case Code.Jl_rel8_16:
			case Code.Jl_rel8_32:
			case Code.Jl_rel8_64:
			case Code.Jge_rel8_16:
			case Code.Jge_rel8_32:
			case Code.Jge_rel8_64:
			case Code.Jle_rel8_16:
			case Code.Jle_rel8_32:
			case Code.Jle_rel8_64:
			case Code.Jg_rel8_16:
			case Code.Jg_rel8_32:
			case Code.Jg_rel8_64:
			case Code.Jo_rel16:
			case Code.Jo_rel32_32:
			case Code.Jo_rel32_64:
			case Code.Jno_rel16:
			case Code.Jno_rel32_32:
			case Code.Jno_rel32_64:
			case Code.Jb_rel16:
			case Code.Jb_rel32_32:
			case Code.Jb_rel32_64:
			case Code.Jae_rel16:
			case Code.Jae_rel32_32:
			case Code.Jae_rel32_64:
			case Code.Je_rel16:
			case Code.Je_rel32_32:
			case Code.Je_rel32_64:
			case Code.Jne_rel16:
			case Code.Jne_rel32_32:
			case Code.Jne_rel32_64:
			case Code.Jbe_rel16:
			case Code.Jbe_rel32_32:
			case Code.Jbe_rel32_64:
			case Code.Ja_rel16:
			case Code.Ja_rel32_32:
			case Code.Ja_rel32_64:
			case Code.Js_rel16:
			case Code.Js_rel32_32:
			case Code.Js_rel32_64:
			case Code.Jns_rel16:
			case Code.Jns_rel32_32:
			case Code.Jns_rel32_64:
			case Code.Jp_rel16:
			case Code.Jp_rel32_32:
			case Code.Jp_rel32_64:
			case Code.Jnp_rel16:
			case Code.Jnp_rel32_32:
			case Code.Jnp_rel32_64:
			case Code.Jl_rel16:
			case Code.Jl_rel32_32:
			case Code.Jl_rel32_64:
			case Code.Jge_rel16:
			case Code.Jge_rel32_32:
			case Code.Jge_rel32_64:
			case Code.Jle_rel16:
			case Code.Jle_rel32_32:
			case Code.Jle_rel32_64:
			case Code.Jg_rel16:
			case Code.Jg_rel32_32:
			case Code.Jg_rel32_64:
			// GENERATOR-END: JccInstr
				return new JccInstr(blockEncoder, block, instruction);

			// GENERATOR-BEGIN: SimpleBranchInstr
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			case Code.Loopne_rel8_16_CX:
			case Code.Loopne_rel8_32_CX:
			case Code.Loopne_rel8_16_ECX:
			case Code.Loopne_rel8_32_ECX:
			case Code.Loopne_rel8_64_ECX:
			case Code.Loopne_rel8_16_RCX:
			case Code.Loopne_rel8_64_RCX:
			case Code.Loope_rel8_16_CX:
			case Code.Loope_rel8_32_CX:
			case Code.Loope_rel8_16_ECX:
			case Code.Loope_rel8_32_ECX:
			case Code.Loope_rel8_64_ECX:
			case Code.Loope_rel8_16_RCX:
			case Code.Loope_rel8_64_RCX:
			case Code.Loop_rel8_16_CX:
			case Code.Loop_rel8_32_CX:
			case Code.Loop_rel8_16_ECX:
			case Code.Loop_rel8_32_ECX:
			case Code.Loop_rel8_64_ECX:
			case Code.Loop_rel8_16_RCX:
			case Code.Loop_rel8_64_RCX:
			case Code.Jcxz_rel8_16:
			case Code.Jcxz_rel8_32:
			case Code.Jecxz_rel8_16:
			case Code.Jecxz_rel8_32:
			case Code.Jecxz_rel8_64:
			case Code.Jrcxz_rel8_16:
			case Code.Jrcxz_rel8_64:
			// GENERATOR-END: SimpleBranchInstr
				return new SimpleBranchInstr(blockEncoder, block, instruction);

			// GENERATOR-BEGIN: CallInstr
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			case Code.Call_rel16:
			case Code.Call_rel32_32:
			case Code.Call_rel32_64:
			// GENERATOR-END: CallInstr
				return new CallInstr(blockEncoder, block, instruction);

			// GENERATOR-BEGIN: JmpInstr
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			case Code.Jmp_rel16:
			case Code.Jmp_rel32_32:
			case Code.Jmp_rel32_64:
			case Code.Jmp_rel8_16:
			case Code.Jmp_rel8_32:
			case Code.Jmp_rel8_64:
			// GENERATOR-END: JmpInstr
				return new JmpInstr(blockEncoder, block, instruction);

			// GENERATOR-BEGIN: XbeginInstr
			// ⚠️This was generated by GENERATOR!🦹‍♂️
			case Code.Xbegin_rel16:
			case Code.Xbegin_rel32:
			// GENERATOR-END: XbeginInstr
				return new XbeginInstr(blockEncoder, block, instruction);
			}

			if (blockEncoder.Bitness == 64) {
				int ops = instruction.OpCount;
				for (int i = 0; i < ops; i++) {
					if (instruction.GetOpKind(i) == OpKind.Memory) {
						if (instruction.IsIPRelativeMemoryOperand)
							return new IpRelMemOpInstr(blockEncoder, block, instruction);
						break;
					}
				}
			}

			return new SimpleInstr(blockEncoder, block, instruction);
		}

		protected string? EncodeBranchToPointerData(Encoder encoder, bool isCall, ulong ip, BlockData pointerData, out uint size, uint minSize) {
			if (minSize > int.MaxValue)
				throw new ArgumentOutOfRangeException(nameof(minSize));

			var instr = new Instruction();
			instr.Op0Kind = OpKind.Memory;
			instr.MemoryDisplSize = encoder.Bitness / 8;
			RelocKind relocKind;
			switch (encoder.Bitness) {
			case 64:
				instr.InternalSetCodeNoCheck(isCall ? Code.Call_rm64 : Code.Jmp_rm64);
				instr.MemoryBase = Register.RIP;
				var nextRip = ip + CallOrJmpPointerDataInstructionSize64;
				instr.NextIP = nextRip;
				long diff = (long)(pointerData.Address - nextRip);
				instr.MemoryDisplacement = (uint)diff;
				if (!(int.MinValue <= diff && diff <= int.MaxValue)) {
					size = 0;
					return "Block is too big";
				}
				relocKind = RelocKind.Offset64;
				break;

			default:
				throw new InvalidOperationException();
			}

			if (!encoder.TryEncode(instr, ip, out size, out var errorMessage))
				return errorMessage;
			if (Block.CanAddRelocInfos && relocKind != RelocKind.Offset64) {
				var constantOffsets = encoder.GetConstantOffsets();
				if (!constantOffsets.HasDisplacement)
					return "Internal error: no displ";
				Block.AddRelocInfo(new RelocInfo(relocKind, IP + constantOffsets.DisplacementOffset));
			}
			while (size < minSize) {
				size++;
				Block.CodeWriter.WriteByte(0x90);
			}
			return null;
		}
	}
}
#endif

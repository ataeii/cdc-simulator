﻿namespace Cdc7600
{
    public class Instruction
    {
        public OpCode OpCode { get; set; }
        public InstructionLength Length { get; set; }
        public Register Operand1 { get; set; }
        public Register Operand2 { get; set; }
        public Register OutputRegister { get; set; }

        public int Issue { get; set; }
        public int Start { get; set; }
        public int Result { get; set; }
        public int UnitReady { get; set; }
        public int? Fetch { get; set; }
        public int? Store { get; set; }

        public bool IsFinished { get; set; }
        public bool IsBeingHeld { get; set; }
        public bool IsStartOfWord { get; set; }
        public bool IsEndOfWord { get; set; }

        public override string ToString()
        {
            return (int)OpCode + " (" + Length.ToString()[0] + ")";
        }
    }

    public enum InstructionLength
    {
        Short,
        Long
    }
}

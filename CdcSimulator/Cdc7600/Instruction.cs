﻿namespace CdcSimulator.Cdc7600
{
    public class Instruction
    {
        public InstructionLength Length { get; set; }

        public enum InstructionLength
        {
            Short,
            Long
        }
    }
}
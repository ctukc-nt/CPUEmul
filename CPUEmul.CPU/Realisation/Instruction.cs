using System.Collections.Generic;
using CPUEmul.CPU.Interfaces;

namespace CPUEmul.CPU.Realisation
{
    /// <summary>
    /// Инструкция процессора (команда)
    /// </summary>
    class Instruction : IInstruction
    {

        public Instruction()
        {
            OperandsList = new List<string>();
        }

        /// <summary>
        /// Наименование команды
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Список операндов
        /// </summary>
        public List<string> OperandsList
        {
            get;
            set;
        }
    }
}
using System.Collections.Generic;
using CPUEmul.CPU.Interfaces;

namespace CPUEmul.CPU.Realisation
{

    /// <summary>
    /// Компилятор программы для ЦП
    /// </summary>
    public class Compilator
    {

        private ICPU _cpu;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cpu">Класс ЦП</param>
        public Compilator(ICPU cpu)
        {
            _cpu = cpu;
        }

        /// <summary>
        /// Переводит инструкцию в команду процессора
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<InstructionProc> ConvertInsructionToInstructionProcs(List<IInstruction> list)
        {
            foreach (var instruction in list)
            {
                
            }
        }

    }

    public class InstructionProc
    {

    }
}
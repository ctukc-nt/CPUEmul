using System.Collections.Generic;

namespace CPUEmul.CPU.Interfaces
{
    /// <summary>
    /// Интерфейс инструкции процессора (команды)
    /// </summary>
    public interface IInstruction
    {
        /// <summary>
        /// Наименование команды
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Список операндов
        /// </summary>
        List<string> OperandsList { get; set; } 
    }
}
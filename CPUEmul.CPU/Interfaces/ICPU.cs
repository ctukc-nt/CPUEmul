using System;

namespace CPUEmul.CPU.Interfaces
{
    public interface ICPU
    {
        /// <summary>
        /// Список поддерживаемых команд
        /// </summary>
        String[] Commands { get; }

        /// <summary>
        /// Загрузить инструкции
        /// </summary>
        void LoadInstructions();
    }
}
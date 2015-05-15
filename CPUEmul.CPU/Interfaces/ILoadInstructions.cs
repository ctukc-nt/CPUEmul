using System.Collections.Generic;

namespace CPUEmul.CPU.Interfaces
{
    /// <summary>
    ///     Интерфейс загрузчика инструкций
    /// </summary>
    public interface ILoadInstructions
    {
        /// <summary>
        ///     Получить инструкции из строки
        /// </summary>
        /// <param name="instInStr">Строка со списком инструкций</param>
        /// <returns>Список инструкций</returns>
        List<IInstruction> GetInstructions(string instInStr);
    }
}
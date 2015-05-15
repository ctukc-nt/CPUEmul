using System;

namespace CPUEmul.CPU.Realisation
{
    /// <summary>
    ///     Класс, отвечающий за эмуляцию ЦП
    /// </summary>
    internal class CPU
    {
        /// <summary>
        ///     Список поддерживаемых команд
        /// </summary>
        public static readonly String[] Commands =
        {
            null, "NOP", "INT", "ADD", "SUB", "DIV", "MUL", "MOV", "RET", "JZ", "JNZ"
        };

        /// <summary>
        ///     Банк данных (память данных)
        /// </summary>
        public Byte[] DataMemory;

        /// <summary>
        ///     Размер банка данных (размер памяти)
        /// </summary>
        public int DataMemorySize = 2048;

        /// <summary>
        ///     Банк программы
        /// </summary>
        public Int16[] ProgramMemory;

        /// <summary>
        ///     Размер банка программы
        /// </summary>
        public int ProgramMemorySize = 2048;

        /// <summary>
        ///     Регистры
        /// </summary>
        public Int16[] Registers;

        /// <summary>
        ///     Количество регистров
        /// </summary>
        public int RegistersCount = 10;

        /// <summary>
        ///     Флаги процессора
        /// </summary>
        public readonly String[] FlagsNames = {"I", "OV", "S", "Z"};

        /// <summary>
        ///     Системные регистры процессора
        /// </summary>
        public readonly String[] SystemRegistersNames =
        {
            "Acc", "DR", "RDR", "RAR", "MDR", "MAR", "IR", "OR", "SP", "PC", "COP",
            "TA", "ADR", "F"
        };

        public void Init()
        {
            Registers = new Int16[RegistersCount + SystemRegistersNames.Length];
            ProgramMemory = new Int16[ProgramMemorySize];
            DataMemory = new Byte[DataMemorySize];
        }

        /// <summary>
        ///     Получить код операции по наименованию
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static int GetOpCodeByName(String Name)
        {
            return Array.IndexOf(Commands, Name.ToUpper());
        }

        /// <summary>
        ///     Получить наименование операции по коду
        /// </summary>
        /// <param name="opCode"></param>
        /// <returns></returns>
        public static String GetNameByOpCode(int opCode)
        {
            return Commands[opCode];
        }

        /// <summary>
        ///     Получить HEX представление
        /// </summary>
        /// <param name="OpCode">Код операции</param>
        /// <param name="Operands">Операнды</param>
        /// <param name="Types">Типы</param>
        /// <returns>HEX представление</returns>
        public static Int16[] GetOpCodeHex(int OpCode, int[] Operands, int[] Types)
        {
            var r = new Int16[Math.Max(1, Operands.Length)];
            r[0] = (Int16) (OpCode << 10);
            if (Operands.Length > 0)
            {
                r[0] |= (Int16) (((0x3 & Types[0]) << 8) | (0x3F & Operands[0]));
            }
            if (Operands.Length == 2)
            {
                r[0] |= (Int16) ((0x3 & Types[1]) << 6);
                r[1] |= (Int16) Operands[1];
            }

            return r;
        }

        /// <summary>
        ///     Установить значение регистра
        ///     <param name="id">id</param>
        ///     значением
        ///     <param name="value">value</param>
        /// </summary>
        /// <param name="id">id регистра</param>
        /// <param name="value">Значение</param>
        public void SetReg(Int16 id, Int16 value)
        {
            Registers[SystemRegistersNames.Length + id] = value;
        }

        /// <summary>
        ///     Получить значение регистра
        ///     <param name="id">id</param>
        /// </summary>
        /// <param name="id">id регистра</param>
        /// <returns></returns>
        public Int16 GetReg(int id)
        {
            return Registers[SystemRegistersNames.Length + id];
        }

        /// <summary>
        ///     Уcтановить значение системного регистра
        ///     <param name="id">id</param>
        ///     значением
        ///     <param name="value">value</param>
        /// </summary>
        /// <param name="id">id системного регистра</param>
        /// <param name="value">Значение</param>
        public void SetSystemRegister(String id, Int16 value)
        {
            Registers[Array.IndexOf(SystemRegistersNames, id)] = value;
        }

        /// <summary>
        ///     Получить значение системного регистра
        ///     <param name="id">id</param>
        /// </summary>
        /// <param name="id">id системного регистра</param>
        public Int16 GetSystemRegister(String id)
        {
            return Registers[Array.IndexOf(SystemRegistersNames, id)];
        }

        /// <summary>
        ///     Получить значение операнда
        /// </summary>
        /// <param name="op">Операнд</param>
        /// <param name="type">Тип операнда</param>
        /// <returns>Значение</returns>
        private Int16 GetOperandValue(Int16 op, Int16 type)
        {
            switch (type)
            {
                case 1:
                    return op;
                case 3:
                    return GetReg(GetReg(31) + op); //TODO: почему было 31 в значении регистра??? а 32 - было количество
                case 2:
                    return GetReg(op);
            }
            return 0xCC; // error
        }

        /// <summary>
        ///     Установить флаг
        ///     <param name="f">f</param>
        ///     значением
        ///     <param name="value">value</param>
        /// </summary>
        /// <param name="f">Тип флага</param>
        /// <param name="value">Значение</param>
        public void SetFlag(String f, bool value)
        {
            var mask = 1 << Array.IndexOf(FlagsNames, f);
            SetSystemRegister("F", (Int16) ((this.GetReg("F") & ~mask) | mask));
        }

        /// <summary>
        ///     Получить значение флага
        ///     <param name="f">f</param>
        /// </summary>
        /// <param name="f">Тип флага</param>
        /// <returns>Значение флага</returns>
        public bool GetFlag(String f)
        {
            var mask = 1 << Array.IndexOf(FlagsNames, f);
            return (GetSystemRegister("F") & mask) == mask;
        }
    }
}
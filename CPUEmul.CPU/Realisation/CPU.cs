using System;
using System.Collections.Generic;
using CPUEmul.CPU.Exception.CPU;
using CPUEmul.CPU.Interfaces;

namespace CPUEmul.CPU.Realisation
{
    /// <summary>
    ///     Класс, отвечающий за эмуляцию ЦП
    /// </summary>
    public class CPU
    {
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
        ///     Список поддерживаемых команд
        /// </summary>
        public readonly String[] Commands =
        {
            null, "NOP", "INT", "ADD", "SUB", "DIV", "MUL", "MOV", "RET", "JZ", "JNZ"
        };

        /// <summary>
        ///     Флаги процессора
        /// </summary>
        public readonly String[] FlagsNames = {"I", "OV", "S", "Z"};

        /// <summary>
        ///     Системные регистры процессора
        /// </summary>
        public readonly String[] SystemRegistersNames =
        {
            "ACC", "DR", "RDR", "RAR", "MDR", "MAR", "IR", "OR", "SP", "PC", "CA", "F"
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
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetOperationCodeByName(String name)
        {
            return Array.IndexOf(Commands, StringNameRegisterToNameCPU(name));
        }

        /// <summary>
        ///     Получить наименование операции по коду
        /// </summary>
        /// <param name="opCode"></param>
        /// <returns></returns>
        public String GetNameByOpCode(int opCode)
        {
            return Commands[opCode];
        }

        /// <summary>
        ///     Получить HEX представление
        /// </summary>
        /// <param name="opCode">Код операции</param>
        /// <param name="operands">Операнды</param>
        /// <param name="types">Типы</param>
        /// <returns>HEX представление</returns>
        public Int16[] GetOpCodeHex(int opCode, int[] operands, int[] types)
        {
            var r = new Int16[Math.Max(1, operands.Length)];
            r[0] = (Int16) (opCode << 10);
            if (operands.Length > 0)
            {
                r[0] |= (Int16) (((0x3 & types[0]) << 8) | (0x3F & operands[0]));
            }

            if (operands.Length == 2)
            {
                r[0] |= (Int16) ((0x3 & types[1]) << 6);
                r[1] |= (Int16) operands[1];
            }

            return r;
        }

        /// <summary>
        ///     Получить значение регистра
        ///     <param name="id">id</param>
        /// </summary>
        /// <param name="id">id регистра</param>
        /// <returns></returns>
        public Int16 GetRegister(int id)
        {
            return Registers[SystemRegistersNames.Length + id];
        }

        /// <summary>
        ///     Установить значение регистра
        ///     <param name="id">id</param>
        ///     значением
        ///     <param name="value">value</param>
        /// </summary>
        /// <param name="id">id регистра</param>
        /// <param name="value">Значение</param>
        public void SetRegister(Int16 id, Int16 value)
        {
            Registers[SystemRegistersNames.Length + id] = value;
        }

        /// <summary>
        ///     Получить значение системного регистра
        ///     <param name="id">id</param>
        /// </summary>
        /// <param name="id">id системного регистра</param>
        public Int16 GetSystemRegister(String id)
        {
            return Registers[Array.IndexOf(SystemRegistersNames, StringNameRegisterToNameCPU(id))];
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
            Registers[Array.IndexOf(SystemRegistersNames, StringNameRegisterToNameCPU(id))] = value;
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
                    return GetRegister(GetRegister(31) + op); //TODO: почему было 31 в значении регистра??? а 32 - было количество
                case 2:
                    return GetRegister(op);
            }
            return 0xCC; // error
        }

        /// <summary>
        ///     Получить значение флага
        ///     <param name="f">f</param>
        /// </summary>
        /// <param name="f">Тип флага</param>
        /// <returns>Значение флага</returns>
        public bool GetFlag(String f)
        {
            var indexFlag = Array.IndexOf(FlagsNames, f);
            if (indexFlag < 0)
                throw new FlagNotSupportedException();

            var mask = 1 << Array.IndexOf(FlagsNames, f);
            return (GetSystemRegister("F") & mask) == mask;
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
            var indexFlag = Array.IndexOf(FlagsNames, f);
            if (indexFlag < 0)
                throw new FlagNotSupportedException();
            var mask = 1 << Array.IndexOf(FlagsNames, f);
            SetSystemRegister("F", (Int16) ((this.GetSystemRegister("F") & ~mask) | mask));
        }

        /// <summary>
        /// Переводит регистр названия регистра ЦП в регистр регистров ЦП
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string StringNameRegisterToNameCPU(string name)
        {
            return name.ToUpperInvariant();
        }

        /// <summary>
        /// Загрузка инструкций во внутреннюю память ЦП
        /// </summary>
        /// <param name="instructions">Список инструкций</param>
        /// <returns>Истина, если прошло успешно</returns>
        public bool Parse(List<IInstruction> instructions)
        {
            if (instructions == null || instructions.Count == 0)
                throw new EmptyInstructionsListException();

            var loadSuccess = true;
            int offset = 0;

            foreach (var instruction in instructions)
            {
                var code = GetOperationCodeByName(instruction.Name);
                if (code == -1)
                {
                    AppendToLog("Невозможно выполнение команды. Такая команда отсутсвуют в списке выполнимых.", instruction);
                    loadSuccess = false;
                }
                else
                {
                    int[] operands = new int[instruction.OperandsList.Count];
                    int[] types = new int[instruction.OperandsList.Count];
                    int[] formats = new int[instruction.OperandsList.Count];
                    for (int j = 0; j < operands.Length; j++)
                    {
                        String op = instruction.OperandsList[j];
                        switch (op[0])
                        {
                            case 'R':
                            case 'r':
                                types[j] = 0x2;
                                break;
                            case '#':
                                op = op.Replace("#", "");
                                types[j] = 0x3;
                                break;
                            default:
                                types[j] = 0x1;
                                break;
                        }

                        op = op.Replace("R", "").Replace("r", "");
                        if (op[0] == 'x' || op[0] == 'X')
                        {
                            op = op.Replace("X", "").Replace("x", "");
                        }
                        try
                        {
                            operands[j] = int.Parse(op);
                        }
                        catch (System.Exception ex)
                        {
                            AppendToLog("Ошибка разбора операндов в инструкции.", instruction);
                            AppendToLog(ex);
                        }
                    }

                    Int16[] cmx = GetOpCodeHex(code, operands, types);

                    for (int q = 0; q < cmx.Length; q++)
                    {
                        this.ProgramMemory[offset] = cmx[q];
                        offset++;
                    }
                }
            }

            return loadSuccess;
        }

        public bool NextStep()
        {
            Int16 offset = this.GetSystemRegister("PC");
            Int16 com = this.ProgramMemory[offset++];
            Int16 opCode = (Int16)(com >> 10);
            Int16 f0 = (Int16)(0x3 & (com >> 8));
            Int16 f1 = (Int16)(0x3 & (com >> 6));
            Int16 r0 = (Int16) (0x3F & com);
            Int16 v0 = this.GetOperandValue(r0, f0);
            Int16 r1 = 0;
            Int16 v1 = 0;
            if (f1 != 0)
            {
                r1 = this.ProgramMemory[offset++];
                v1 = this.GetOperandValue(r1, f1);
            }

            switch (GetNameByOpCode(opCode))
            {
                case "MOV":
                    this.SetRegister(r0, v1);
                    break;
                case "ADD":
                    this.SetRegister(r0, (Int16)(v0 + v1));
                    this.SetFlag("Z", (v0 + v1) == 0);
                    break;
                case "SUB":
                    this.SetRegister(r0, (Int16)(v0 - v1));
                    this.SetFlag("Z", (v0 - v1) == 0);
                    break;
                case "MUL":
                    this.SetRegister(r0, (Int16)(v0 * v1));
                    this.SetFlag("Z", (v0 * v1) == 0);
                    break;
                case "DIV":
                    this.SetRegister(r0, (Int16)(v0 / v1));
                    this.SetFlag("Z", (v0 / v1) == 0);
                    break;
                case "JMP":
                    this.SetSystemRegister("PC", v0);
                    return false;
                case "JZ":
                    if (!this.GetFlag("Z"))
                        break;

                    this.SetSystemRegister("PC", v0);
                    return false;
                case "JNZ":
                    if (this.GetFlag("Z"))
                        break;

                    this.SetSystemRegister("PC", v0);
                    return false;

                case "RET":
                    return true;
                case "NOP":
                    break;

                default:
                    throw new IncorrectOperationCodeException();
            }

            this.SetSystemRegister("PC", offset);
            this.SetSystemRegister("CR", this.ProgramMemory[offset]);

            return false;
        }

        private void AppendToLog(string mess)
        {
            
        }

        private void AppendToLog(IInstruction instr)
        {

        }

        private void AppendToLog(string mess, IInstruction instr)
        {

        }

        private void AppendToLog(System.Exception exception)
        {

        }
    }
}
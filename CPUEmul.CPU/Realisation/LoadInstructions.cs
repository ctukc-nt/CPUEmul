using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CPUEmul.CPU.Exception.Loader;
using CPUEmul.CPU.Interfaces;

namespace CPUEmul.CPU.Realisation
{
    public class LoadInstructions : ILoadInstructions
    {
        /// <summary>
        ///     Получить инструкции из строки
        /// </summary>
        /// <param name="instInStr">Строка со списком инструкций</param>
        /// <returns>Список инструкций</returns>
        /// <exception cref="EmptyInstructionString"></exception>
        public List<IInstruction> GetInstructions(string instInStr)
        {
            if (string.IsNullOrWhiteSpace(instInStr))
                throw new EmptyInstructionString();

            var splitted = instInStr.Replace("\r\n", "\n").Split('\n');

            var listInstructions = new List<IInstruction>();

            foreach (string instr in splitted)
            {
                String cur = instr.Trim(new char[] { ' ', '\t', '\r', '\n' });
                if (cur.Length == 0 || cur[0] == '#' || (cur[0] == '/' && cur[1] == '/'))
                    continue;

                cur = Regex.Replace(cur, @"\s+", " ");
                
                String[] wordsInString = cur.Split(new[] { ' ', '\t', ',' });
                
                if (wordsInString.Length == 0)
                    continue;

                Instruction instruction = new Instruction();
                instruction.Name = wordsInString[0];

                for (int j = 1; j < wordsInString.Length - 1; j++)
                {
                    var operand = wordsInString[j].Trim();
                    instruction.OperandsList.Add(operand);
                }

                listInstructions.Add(instruction);
            }

            return listInstructions;
        }

        /// <summary>
        ///     Получает списко инструкций из файла
        /// </summary>
        /// <param name="pathFile">Путь к файлу</param>
        /// <returns>Строка со списком инструкций</returns>
        public string GetInstructionsListStringFromFile(string pathFile)
        {
            throw new NotImplementedException();
        }
    }
}
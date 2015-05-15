using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUEmul.CPU.Realisation;
using NUnit.Framework;
namespace CPUEmul.CPU.Realisation.Tests
{
    [TestFixture()]
    public class LoadInstructionsTests
    {
        [Test()]
        public void GetInstructionsTest()
        {
            string instr = @"mov ax, bx
nop
sub ax, vc";

            LoadInstructions loaderInstructions = new LoadInstructions();
            var expect = loaderInstructions.GetInstructions(instr);

            Assert.AreEqual(3, expect.Count);
            Assert.AreEqual("mov", expect[0].Name);
            Assert.AreEqual(2, expect[0].OperandsList.Count);
        }
    }
}

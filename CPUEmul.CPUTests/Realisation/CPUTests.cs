using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUEmul.CPU.Exception.CPU;
using CPUEmul.CPU.Realisation;
using NUnit.Framework;
namespace CPUEmul.CPU.Realisation.Tests
{
    [TestFixture()]
    public class CPUTests
    {
        [Test()]
        public void GetOpCodeByNameTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetNameByOpCodeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void GetOpCodeHexTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SetRegisterTest()
        {
            CPU cpu = new CPU();
            cpu.Init();
            Assert.DoesNotThrow(() => cpu.SetRegister(1, 1));

            var assume = cpu.GetRegister(1);
            Assert.AreEqual(1, assume);
        }

        [Test()]
        public void GetRegisterTest()
        {
            CPU cpu = new CPU();
            cpu.Init();
            var assume = cpu.GetRegister(0);

            Assert.AreEqual(0, assume);
        }

        [Test()]
        public void GetSystemRegisterTest()
        {
            CPU cpu = new CPU();
            cpu.Init();
            var assume = cpu.GetSystemRegister("acc");

            Assert.AreEqual(0, assume);

        }

        [Test()]
        public void SetSystemRegisterTest()
        {
            CPU cpu = new CPU();
            cpu.Init();
            Assert.DoesNotThrow(() => cpu.SetSystemRegister("acc", 1));

            var assume = cpu.GetSystemRegister("acc");
            Assert.AreEqual(1, assume);

        }

        [Test()]
        public void GetFlagTest()
        {
            CPU cpu = new CPU();
            cpu.Init();

            var assume = cpu.GetFlag("Z");
            Assert.AreEqual(false, assume);
        }

        [Test()]
        public void UnexistFlagTest()
        {
            CPU cpu = new CPU();
            cpu.Init();

            Assert.Throws<FlagNotSupportedException>(() =>cpu.GetFlag("BBB"));
            Assert.Throws<FlagNotSupportedException>(() =>cpu.SetFlag("BBB", true));
        }

        [Test()]
        public void SetFlagTest()
        {
            CPU cpu = new CPU();
            cpu.Init();
            cpu.SetFlag("Z", true);

            var assume = cpu.GetFlag("Z");

            Assert.AreEqual(true, assume);
        }

        [Test()]
        public void InitTest()
        {
            CPU cpu = new CPU();
            cpu.Init();
        }
    }
}

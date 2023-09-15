using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Doctors;

namespace Doctors.Tests
{
    [TestClass]
    public class NeurologistTests
    {
        [TestMethod]
        public void TestPerformNeurologicalExamination_OutputFormat()
        {
            // Arrange
            Neurologist neurologist = new Neurologist("John", "male", 30, "neurologist", 3, 5000);
            StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            neurologist.PerformNeurologicalExamination();
            string output = consoleOutput.ToString().Trim();

            // Assert
            Assert.IsTrue(output.Contains("Neurologist is performing a neurological examination."));
            Assert.IsTrue(output.Contains("Testing knee jerk reflex..."));
            Assert.IsTrue(output.Contains("Great! Normal reflex response observed.") || output.Contains("Abnormal reflex response observed!"));
        }
    }

    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestDisplayPersonInfo_OutputFormat()
        {
            // Arrange
            Person person = new Person("John", "male", 30);
            StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            person.DisplayPersonInfo();
            string output = consoleOutput.ToString().Trim();

            // Assert
            string expectedOutput = "Information about person: John, male, 30";
            Assert.AreEqual(expectedOutput, output, $"Expected: '{expectedOutput}', Actual: '{output}'");
        }
    }

    [TestClass]
    public class CardiologistTests
    {
        [TestMethod]
        public void TestMeasureBloodPressure_OutputFormat()
        {
            // Arrange
            Cardiologist cardiologist = new Cardiologist("John", "male", 30, "cardiologist", 12, 5900);
            StringWriter consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            cardiologist.MeasureBloodPressure();
            string output = consoleOutput.ToString().Trim();

            // Assert
            Assert.IsTrue(output.Contains("Cardiologist makes measure blood pressure."));
            Assert.IsTrue(output.Contains("Patient's heart rate is"));
            Assert.IsTrue(output.Contains("Good! Patient's heart rate is within the normal range.")
                          || output.Contains("Patient's heart rate is too low!")
                          || output.Contains("Patient's heart rate is too high!"));
        }
    }
}
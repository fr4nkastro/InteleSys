using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.Forms;
using System.Windows.Forms;

namespace unitTest.Forms
{
    [TestClass]
    public class FrmMantenimientoDetalladoTests
    {
        [TestMethod]
        public void TestTxtDescripcionAddObs()
        {
            // Arrange
            var frmMantenimientoDetallado = new FrmMantenimientoDetallado();
            var textBox = ((TextBox)frmMantenimientoDetallado.PanelADD.Controls.Find("TxtDescripcionAddObs", false)[0]);

            // Act
            string maxText = "AuG4dV8owZKGOSi4ADphxVXpJneRMAKRpB3IbECfjMKXXW52Bjgq8DoFnJODPwB6m7gGQTcvy8975kVvFmSA9An5l1Zc1Cd5ppl06Mq7swg6SJM5muM1N8coH0HspsdZ7iHs6UGFnSxK61zuuEzt9iKrMdPVP2bS6CyDyEI2zPamwYCtWc7iJ3FCjybcnZcfco1llR0vCBIbGxZt9EXDTIoMFyulFilDAR7BHSTEPMlDw6QQE3uxCgQmQDAKSWPrWUS8Of3OFCWiEeQgug5FsmFDq3RC57xSMp69k5z09GeSQu6xN4KG525peCJro7KueCBaywm9hyNiR0aN7IcS3cqLDSPXvJCW8L2mP8I44kdeNE8rYaAIpigNSSm52jrqZOa6yAkaGCE0ehK7U5X2NJHs91DZx8qURTzb6u7CdVqHkYG2M4wCevCrL8cFHD20TeGXZst3GZ4yqyQJTicK7gNEEqekwXdL3hj1ZfCR54F0q48Ouu82j";
            textBox.Text = maxText;
            string expected = null;
            string actual = frmMantenimientoDetallado.textLengthValidation(textBox);




            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

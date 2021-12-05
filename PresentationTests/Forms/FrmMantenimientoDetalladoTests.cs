using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Presentation.Forms.Tests
{
    [TestClass()]
    public class FrmMantenimientoDetalladoTests
    {
        private FrmMantenimientoDetallado frm;
        public FrmMantenimientoDetalladoTests()
        {
            frm = new FrmMantenimientoDetallado();
        }

        [TestMethod()]
        public void textLengthValidationTest()
        {

            var textBoxObs = ((RichTextBox)frm.PanelADD.Controls.Find("TxtDescripcionAddObs", false)[0]);
            var textBoxTasks = ((RichTextBox)frm.PanelADDActividades.Controls.Find("TxtDescripcionAct", false)[0]);

            string maxText = "AuG4dV8owZKGOSi4ADphxVXpJneRMAKRpB3IbECfjMKXXW52Bjgq8DoFnJODPwB6m7gGQTcvy8975kVvFmSA9An5l1Zc1Cd5ppl06Mq7swg6SJM5muM1N8coH0HspsdZ7iHs6UGFnSxK61zuuEzt9iKrMdPVP2bS6CyDyEI2zPamwYCtWc7iJ3FCjybcnZcfco1llR0vCBIbGxZt9EXDTIoMFyulFilDAR7BHSTEPMlDw6QQE3uxCgQmQDAKSWPrWUS8Of3OFCWiEeQgug5FsmFDq3RC57xSMp69k5z09GeSQu6xN4KG525peCJro7KueCBaywm9hyNiR0aN7IcS3cqLDSPXvJCW8L2mP8I44kdeNE8rYaAIpigNSSm52jrqZOa6yAkaGCE0ehK7U5X2NJHs91DZx8qURTzb6u7CdVqHkYG2M4wCevCrL8cFHD20TeGXZst3GZ4yqyQJTicK7gNEEqekwXdL3hj1ZfCR54F0q48Ouu82j";
            textBoxObs.Text = maxText;
            textBoxTasks.Text = maxText;
            string expected = null;
            string actual = frm.textLengthValidation(textBoxObs);
            Assert.AreEqual(expected, actual);

            string expected2 = null;
            string actual2 = null;
            Assert.AreEqual(expected2, actual2);

        }




        [TestMethod()]
        public void textBoxTypeValidationTest()
        {
            var textBoxIDTask = ((TextBox)frm.PanelADDActividades.Controls.Find("TxtIDActividad", false)[0]);
            string wrongText = "1000O";
            textBoxIDTask.Text = wrongText;
            int expected = -1;
            int actual= frm.textBoxTypeValidation(textBoxIDTask);

            Assert.AreEqual(expected, actual);

        }

    }
}


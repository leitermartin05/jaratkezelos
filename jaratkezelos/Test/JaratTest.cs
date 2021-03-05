using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace jaratkezelos.Test
{
    [TestFixture]
    class JaratTest
    {
        [TestCase]
        public void ujJaratSikeres()
        {

            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("1234", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            Assert.AreEqual(new DateTime(2021, 03, 03, 20, 13, 00), jaratKezelo.MikorIndul("1234"));
        }

        [TestCase]
        public void ujJaratIsmetledes()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("1234", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            Assert.Throws<ArgumentException>(() => jaratKezelo.UjJarat("1234", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00)));
        }

        [TestCase]
        public void ujJaratHibasParameter()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("1234", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            Assert.Throws<ArgumentException>(() => jaratKezelo.UjJarat("", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00)));
        }

        [TestCase]
        public void KesesSikeres()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("5365", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 00, 00));
            jaratKezelo.Keses("5365", 40);
            Assert.AreEqual(new DateTime(2021, 03, 03, 20, 40,00), jaratKezelo.MikorIndul("5365"));
        }

        [TestCase]
        public void KesesBehozas()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("5365", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            jaratKezelo.Keses("5365", 40);
            jaratKezelo.Keses("5365", 50);
            Assert.AreEqual(new DateTime(2021, 03, 03, 20, 00, 00), jaratKezelo.MikorIndul("5365"));
        }

        [TestCase]
        public void KesesHibasBemenet()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            Assert.Throws<FormatException>(() => jaratKezelo.Keses("", 0));
            
        }

        [TestCase]
        public void MikorIndulHibasBemmenet()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("5365", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            Assert.Throws<ArgumentException>(() => jaratKezelo.MikorIndul("0000"));
        }

        [TestCase]
        public void JaratokRepterrolSikeres()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("5365", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            jaratKezelo.UjJarat("1234", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 00, 00));
            List<string> eredmenyek = new List<string>();
            eredmenyek.Add("5365");
            eredmenyek.Add("1234");

            Assert.AreEqual(eredmenyek, jaratKezelo.JaratokRepuloterrol("BUD"));
        }

        [TestCase]
        public void JaratokRepterrolHibasRepterNev()
        {
            JaratKezelo jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("5365", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 13, 00));
            jaratKezelo.UjJarat("1234", "BUD", "ABA", new DateTime(2021, 03, 03, 20, 00, 00));
            List<string> eredmenyek = new List<string>();
            eredmenyek.Add("5365");
            eredmenyek.Add("1234");

            Assert.Throws<ArgumentException>(()=> jaratKezelo.JaratokRepuloterrol(""));
        }



    }
}


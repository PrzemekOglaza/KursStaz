﻿using System;
using KursStaz.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kurs.StazTest
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (przygotuj ters)

            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Robert, Kowal";

            // Act (działaj)

            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            // Arrange (przygotuj ters)

            Klient klient = new Klient();
                klient.Nazwisko = "Kowal";

            string oczekiwana = "Kowal";

            // Act (działaj)

            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);

        }

        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {
            // Arrange (przygotuj ters)

            Klient klient = new Klient();
            klient.Imie = "Robert";

            string oczekiwana = "Robert";

            // Act (działaj)

            string aktualna = klient.ImieNazwisko;

            // Assert (potwierdz test)

            Assert.AreEqual(oczekiwana, aktualna);

        }
    }
}

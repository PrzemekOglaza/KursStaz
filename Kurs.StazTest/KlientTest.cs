using System;
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

        [TestMethod]
        public void StaticTest()
        {
            // Arrange (przygotuj ters)

            var kln1 = new Klient();
            kln1.Imie = "Jacek";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln2.Imie = "Olek";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln3.Imie = "Elek";
            Klient.Licznik += 1;
            // Act (działaj)



            // Assert (potwierdz test)

            Assert.AreEqual(3, Klient.Licznik);
        }
    }
}

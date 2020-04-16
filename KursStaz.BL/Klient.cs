﻿namespace KursStaz.BL
{
    public class Klient
    {

        public static int Licznik { get; set; }



        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value; 
            }
        }
        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string ImieNazwisko = Imie;

                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(ImieNazwisko))
                    {
                        ImieNazwisko += ", ";
                    }
                    ImieNazwisko += Nazwisko;
                }

                return ImieNazwisko;
            }
        }
    }
}

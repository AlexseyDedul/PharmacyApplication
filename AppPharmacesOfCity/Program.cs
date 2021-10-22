using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPharmacesOfCity
{
    static class Program
    {
        public static MainWindow mainWindow;
        public static PharmacyEdit pharmacyEdit;
        public static MedicinesEdit medicinesEdit;
        public static UserEdit userEdit;
        public static ExistMedEdit existMedEdit;
        public static TherapyEdit therapyEdit;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authintification());
        }
    }
}

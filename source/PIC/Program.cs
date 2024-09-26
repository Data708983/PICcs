using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public static class Program
    {
        public const string AppTitle = "PIC - Pulmonary Blood Vessels Cross-section Thickness Measurement";

        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

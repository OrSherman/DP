using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public class Program
    {
        // $G$ DSN-001 (-7)  StyleCop errors.
        //$G$ RUL-999 (-20) The name of the word file need to be as the name of the solution.
        // $G$ DSN-001 (-5) when I want to change the AppID with empty string, you got exception.

        // $G$ THE-001 (-15) Your grade on diagrams document - 85. Please see comments inside the document.
        // $G$ SFN-001 (-10) The degree of investment in implementation of the application(facebook experience of your on, not like Guy's in class) was low.
        // $G$ SFN-002 (-10) The degree of investment in implementation of first feature was low.
        // $G$ SFN-003 (-10) The degree of investment in implementation of second feature was low.


        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("My Facebook desktop App!!!");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}

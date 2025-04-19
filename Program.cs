namespace Sudoku
{
    public static class ProgramMain
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Точка входа в программу
        }
    }
}
namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            this.Hide();
            SudokuForm game = new SudokuForm();
            game.FormClosed += (s, args) => this.Show();
            game.Show();
        }
    }
}


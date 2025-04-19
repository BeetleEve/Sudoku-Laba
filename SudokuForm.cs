using System.Windows.Forms.VisualStyles;

namespace Sudoku
{
    public partial class SudokuForm : Form
    {
        private int[,] puzzle;
        private TextBox[,] cells = new TextBox[9, 9];

        public SudokuForm()
        {
            SudokuGenerator generator = new SudokuGenerator();
            puzzle = generator.Board;
            InitializeComponent();
            GenerateSudokuField();
        }

        private void ReGenerate()
        {
            Controls.RemoveAll(c => c is TextBox);
            SudokuGenerator generator = new SudokuGenerator();
            puzzle = generator.Board; GenerateSudokuField();
        }

        private void GenerateSudokuField()
        {
            int cellSize = 50;
            int padding = 2;
            int blockPadding = 5;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int extraX = (col / 3) * blockPadding;
                    int extraY = (row / 3) * blockPadding;

                    TextBox cell = new TextBox
                    {
                        Width = cellSize,
                        Height = cellSize,
                        TextAlign = HorizontalAlignment.Center,
                        Font = new Font("Arial", 18, FontStyle.Bold),
                        MaxLength = 1,
                        Multiline = true,
                        Location = new Point(col * (cellSize + padding) + 20 + extraX,
                                             row * (cellSize + padding) + 20 + extraY)
                    };

                    if (puzzle[row, col] != 0)
                    {
                        cell.Text = puzzle[row, col].ToString();
                        cell.ReadOnly = true;
                        cell.BackColor = Color.LightGray;
                    }

                    cells[row, col] = cell;
                    Controls.Add(cell);
                }
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (IsSudokuSolved())
            {
                ShowResultScreen("Поздравляем! Вы решили судоку!");
            }
            else
            {
                ShowResultScreen("Неверное решение. Попробуйте снова!");
            }
        }
        private bool IsSudokuSolved()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (!int.TryParse(cells[row, col].Text, out int value))
                        return false; if (value < 1 || value > 9)
                        return false;
                    // Временно очищаем ячейку и проверяем корректность                    cells[row, col].Text = "";
                    if (!IsValidPlacement(row, col, value))
                    {
                        cells[row, col].Text = value.ToString(); return false;
                    }
                    cells[row, col].Text = value.ToString();
                }
            }
            return true;
        }
        private bool IsValidPlacement(int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != col && cells[row, i].Text == num.ToString()) return false; if (i != row && cells[i, col].Text == num.ToString()) return false;
            }
            int startRow = (row / 3) * 3; int startCol = (col / 3) * 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++) if ((startRow + i != row || startCol + j != col) &&
                        cells[startRow + i, startCol + j].Text == num.ToString()) return false;
            return true;
        }
        private void ShowResultScreen(string message)
        {
            Controls.Clear(); Label resultLabel = new Label()
            {
                Text = message,
                AutoSize = false,
                Size = new Size(400, 200),
                Font = new Font("Arial", 24, FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Location = new Point((ClientSize.Width - 400) / 2, (ClientSize.Height - 200) / 2)
            };
            Controls.Add(resultLabel);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReGenerate();
        }
    }
    static class ControlExtensions
    {
        public static void RemoveAll(this Control.ControlCollection controls, Predicate<Control> match)
        {
            foreach (Control control in controls.Cast<Control>().Where(c => match(c)).ToList())
            {
                controls.Remove(control);
            }
        }
    }
}
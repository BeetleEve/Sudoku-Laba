namespace Sudoku
{
    public partial class SudokuForm
    {
        private RoundButton ResetButton;
        private RoundButton DrawButton;
        private RoundButton CheckButton;

        private void InitializeComponent()
        {
            ResetButton = new RoundButton();
            DrawButton = new RoundButton();
            CheckButton = new RoundButton();
            SuspendLayout();
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.Gray;
            ResetButton.Location = new Point(80, 506);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(69, 60);
            ResetButton.TabIndex = 0;
            ResetButton.Text = "roundButton1";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // DrawButton
            // 
            DrawButton.BackColor = Color.Gray;
            DrawButton.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DrawButton.ForeColor = Color.Plum;
            DrawButton.Location = new Point(168, 506);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(156, 64);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "Draw";
            DrawButton.UseVisualStyleBackColor = false;
            // 
            // CheckButton
            // 
            CheckButton.BackColor = Color.Gray;
            CheckButton.Location = new Point(343, 506);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(69, 60);
            CheckButton.TabIndex = 2;
            CheckButton.Text = "roundButton3";
            CheckButton.UseVisualStyleBackColor = false;
            CheckButton.Click += CheckButton_Click;
            // 
            // SudokuForm
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(515, 593);
            Controls.Add(CheckButton);
            Controls.Add(DrawButton);
            Controls.Add(ResetButton);
            MaximizeBox = false;
            Name = "SudokuForm";
            Text = "Sudoku";
            ResumeLayout(false);
        }
    }
}

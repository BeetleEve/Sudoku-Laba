namespace Sudoku
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PlayButtonMain = new RoundButton();
            SudokuMainLabel = new RoundedLabel();
            SuspendLayout();
            // 
            // PlayButtonMain
            // 
            PlayButtonMain.Anchor = AnchorStyles.None;
            PlayButtonMain.BackColor = Color.Gray;
            PlayButtonMain.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayButtonMain.ForeColor = Color.Plum;
            PlayButtonMain.Image = (Image)resources.GetObject("PlayButtonMain.Image");
            PlayButtonMain.Location = new Point(121, 288);
            PlayButtonMain.Name = "PlayButtonMain";
            PlayButtonMain.Size = new Size(278, 80);
            PlayButtonMain.TabIndex = 0;
            PlayButtonMain.Text = "PLAY";
            PlayButtonMain.TextImageRelation = TextImageRelation.TextBeforeImage;
            PlayButtonMain.UseVisualStyleBackColor = false;
            PlayButtonMain.Click += StartGame;
            // 
            // SudokuMainLabel
            // 
            SudokuMainLabel.Anchor = AnchorStyles.None;
            SudokuMainLabel.BackColor = Color.Gray;
            SudokuMainLabel.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SudokuMainLabel.ForeColor = Color.Plum;
            SudokuMainLabel.Location = new Point(121, 84);
            SudokuMainLabel.Name = "SudokuMainLabel";
            SudokuMainLabel.Size = new Size(278, 74);
            SudokuMainLabel.TabIndex = 1;
            SudokuMainLabel.Text = "SUDOKU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(534, 421);
            Controls.Add(SudokuMainLabel);
            Controls.Add(PlayButtonMain);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "Form1";
            Padding = new Padding(50);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RoundButton PlayButtonMain;
        private RoundedLabel SudokuMainLabel;
    }
}

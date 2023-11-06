namespace HM5_PasswordGenerator
{
    partial class PasswordGeneratorForm
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
            MainPanel = new Panel();
            GenerateButton = new Button();
            OptionsGroupBox = new GroupBox();
            ExcludeCheckBox = new CheckBox();
            SymbolsCheckBox = new CheckBox();
            CapitalLettersCheckBox = new CheckBox();
            SmallLettersCheckBox = new CheckBox();
            DigitsCheckBox = new CheckBox();
            InputTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            LengthNumeric = new NumericUpDown();
            label1 = new Label();
            ListPanel = new Panel();
            PasswordsListBox = new ListBox();
            label4 = new Label();
            MainPanel.SuspendLayout();
            OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LengthNumeric).BeginInit();
            ListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.Control;
            MainPanel.Controls.Add(GenerateButton);
            MainPanel.Controls.Add(OptionsGroupBox);
            MainPanel.Controls.Add(InputTextBox);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(LengthNumeric);
            MainPanel.Controls.Add(label1);
            MainPanel.Dock = DockStyle.Left;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(300, 528);
            MainPanel.TabIndex = 0;
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.FromArgb(255, 128, 0);
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(20, 440);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(260, 60);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "Сгенерировать";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // OptionsGroupBox
            // 
            OptionsGroupBox.Controls.Add(ExcludeCheckBox);
            OptionsGroupBox.Controls.Add(SymbolsCheckBox);
            OptionsGroupBox.Controls.Add(CapitalLettersCheckBox);
            OptionsGroupBox.Controls.Add(SmallLettersCheckBox);
            OptionsGroupBox.Controls.Add(DigitsCheckBox);
            OptionsGroupBox.Location = new Point(20, 230);
            OptionsGroupBox.Name = "OptionsGroupBox";
            OptionsGroupBox.Size = new Size(260, 200);
            OptionsGroupBox.TabIndex = 5;
            OptionsGroupBox.TabStop = false;
            OptionsGroupBox.Text = "Опции:";
            // 
            // ExcludeCheckBox
            // 
            ExcludeCheckBox.AutoSize = true;
            ExcludeCheckBox.Location = new Point(20, 150);
            ExcludeCheckBox.Name = "ExcludeCheckBox";
            ExcludeCheckBox.Size = new Size(203, 27);
            ExcludeCheckBox.TabIndex = 4;
            ExcludeCheckBox.Text = "Исключать похожие";
            ExcludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SymbolsCheckBox
            // 
            SymbolsCheckBox.AutoSize = true;
            SymbolsCheckBox.Location = new Point(20, 120);
            SymbolsCheckBox.Name = "SymbolsCheckBox";
            SymbolsCheckBox.Size = new Size(227, 27);
            SymbolsCheckBox.TabIndex = 3;
            SymbolsCheckBox.Text = "Специальные символы";
            SymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CapitalLettersCheckBox
            // 
            CapitalLettersCheckBox.AutoSize = true;
            CapitalLettersCheckBox.Location = new Point(20, 90);
            CapitalLettersCheckBox.Name = "CapitalLettersCheckBox";
            CapitalLettersCheckBox.Size = new Size(178, 27);
            CapitalLettersCheckBox.TabIndex = 2;
            CapitalLettersCheckBox.Text = "Заглавные буквы";
            CapitalLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SmallLettersCheckBox
            // 
            SmallLettersCheckBox.AutoSize = true;
            SmallLettersCheckBox.Location = new Point(20, 60);
            SmallLettersCheckBox.Name = "SmallLettersCheckBox";
            SmallLettersCheckBox.Size = new Size(184, 27);
            SmallLettersCheckBox.TabIndex = 1;
            SmallLettersCheckBox.Text = "Маленькие буквы";
            SmallLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // DigitsCheckBox
            // 
            DigitsCheckBox.AutoSize = true;
            DigitsCheckBox.Location = new Point(20, 30);
            DigitsCheckBox.Name = "DigitsCheckBox";
            DigitsCheckBox.Size = new Size(95, 27);
            DigitsCheckBox.TabIndex = 0;
            DigitsCheckBox.Text = "Цифры";
            DigitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(20, 170);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(260, 30);
            InputTextBox.TabIndex = 4;
            InputTextBox.TextChanged += InputTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(242, 23);
            label3.TabIndex = 3;
            label3.Text = "Генерировать из символов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 2;
            label2.Text = "4-32 символа";
            // 
            // LengthNumeric
            // 
            LengthNumeric.Location = new Point(20, 60);
            LengthNumeric.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            LengthNumeric.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            LengthNumeric.Name = "LengthNumeric";
            LengthNumeric.Size = new Size(260, 30);
            LengthNumeric.TabIndex = 1;
            LengthNumeric.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 0;
            label1.Text = "Длина";
            // 
            // ListPanel
            // 
            ListPanel.Controls.Add(PasswordsListBox);
            ListPanel.Controls.Add(label4);
            ListPanel.Dock = DockStyle.Fill;
            ListPanel.Location = new Point(300, 0);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(300, 528);
            ListPanel.TabIndex = 1;
            // 
            // PasswordsListBox
            // 
            PasswordsListBox.BackColor = Color.FromArgb(224, 224, 224);
            PasswordsListBox.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordsListBox.FormattingEnabled = true;
            PasswordsListBox.ItemHeight = 23;
            PasswordsListBox.Location = new Point(20, 60);
            PasswordsListBox.Name = "PasswordsListBox";
            PasswordsListBox.Size = new Size(260, 441);
            PasswordsListBox.TabIndex = 1;
            PasswordsListBox.KeyDown += PasswordsListBox_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(261, 23);
            label4.TabIndex = 0;
            label4.Text = "Нажмите, чтобы скопировать";
            // 
            // PasswordGeneratorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 528);
            Controls.Add(ListPanel);
            Controls.Add(MainPanel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PasswordGeneratorForm";
            Text = "Password Generator";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            OptionsGroupBox.ResumeLayout(false);
            OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LengthNumeric).EndInit();
            ListPanel.ResumeLayout(false);
            ListPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private NumericUpDown LengthNumeric;
        private Label label1;
        private GroupBox OptionsGroupBox;
        private CheckBox DigitsCheckBox;
        private TextBox InputTextBox;
        private Label label3;
        private Label label2;
        private Button GenerateButton;
        private CheckBox ExcludeCheckBox;
        private CheckBox SymbolsCheckBox;
        private CheckBox CapitalLettersCheckBox;
        private CheckBox SmallLettersCheckBox;
        private Panel ListPanel;
        private ListBox PasswordsListBox;
        private Label label4;
    }
}
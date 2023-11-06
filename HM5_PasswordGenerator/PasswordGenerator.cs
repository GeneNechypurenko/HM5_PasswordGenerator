using HM5_PasswordGenerator.Models;

namespace HM5_PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }
        private bool[] OptionsCheck() => new bool[5]
        {
           DigitsCheckBox.Checked,
           SmallLettersCheckBox.Checked,
           CapitalLettersCheckBox.Checked,
           SymbolsCheckBox.Checked,
           ExcludeCheckBox.Checked,
        };
        private bool IsExcludeChecked()
        {
            if (ExcludeCheckBox.Checked)
            {
                bool[] options = OptionsCheck();
                int offset = 0;
                if (options[0]) { offset += 10; }
                if (options[1]) { offset += 26; }
                if (options[2]) { offset += 26; }
                if (options[3]) { offset += 15; }
                int length = (int)LengthNumeric.Value;

                return offset > length;
            }
            else { return true; }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int length = (int)LengthNumeric.Value;
            Generator generator = new Generator(length, OptionsCheck());

            PasswordsListBox.Items.Clear();

            if (string.IsNullOrEmpty(InputTextBox.Text))
            {
                if (!Array.TrueForAll(OptionsCheck(), e => e == false))
                {
                    if (IsExcludeChecked())
                    {
                        for (int i = 0; i < 19; ++i)
                        {
                            PasswordsListBox.Items.Add(generator.Generate());
                        }
                    }
                    else { MessageBox.Show("Пароль сгенерировать невозможно!"); }
                }
                else { MessageBox.Show("Выберите опцию"); }
            }
            else
            {
                if (InputTextBox.Text.Length > 3)
                {
                    for (int i = 0; i < 19; ++i)
                    {
                        PasswordsListBox.Items.Add(generator.GenerateCustom(InputTextBox.Text));
                    }
                }
                else { MessageBox.Show("Пароль не может быть меньше 4-х символов"); }
            }
        }
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in OptionsGroupBox.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
        }

        private void PasswordsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control is true && e.KeyCode == Keys.C)
            {
                string copy = PasswordsListBox.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, copy);
            }
        }
    }
}
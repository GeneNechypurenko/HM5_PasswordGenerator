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
                if (options[0]) { offset += 26; }
                if (options[0]) { offset += 26; }
                if (options[0]) { offset += 15; }
                int length = (int)LengthNumeric.Value;

                return length <= offset;
            }
            else { return true; }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int length = (int)LengthNumeric.Value;

            if (length > 0)
            {
                if (!Array.TrueForAll(OptionsCheck(), e => e == false))
                {
                    if (IsExcludeChecked())
                    {
                        PasswordsListBox.Items.Clear();
                        Generator generator = new Generator(length, OptionsCheck());

                        for (int i = 0; i < 19; ++i)
                        {
                            PasswordsListBox.Items.Add(generator.Generate());
                        }
                    }
                    else { MessageBox.Show("Пароль сгенерировать невозможно!"); }
                }
                else { MessageBox.Show("Выберите опцию"); }
            }
            else { MessageBox.Show("Длина пароля не может быть меньше 1 символа"); }
        }
    }
}
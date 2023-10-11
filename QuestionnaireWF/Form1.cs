using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionnaireWF
{
    public partial class Anket : Form
    {
        Person user = new Person();

        public Anket()
        {
            InitializeComponent();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            user.Name = textBoxName.Text;
        }

        private void TextBoxSurname_TextChanged(object sender, EventArgs e)
        {
            user.Surname = textBoxSurname.Text;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            user.Email = textBoxEmail.Text;
        }


        private void DateTimePickerBirthdate_ValueChanged(object sender, EventArgs e)
        {
            user.BirthDate = dateTimePickerBirthdate.Value;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                if (groupBox_Anket.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text))
                    || !maskedTextBoxPhone.MaskCompleted)
                {
                    MessageBox.Show("Fill in the blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    options.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                    var textJson = JsonSerializer.Serialize(user, options);
                    File.WriteAllText(textBoxName.Text + ".json", textJson);
                    MessageBox.Show("The questionnaire was completed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox_Anket.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = string.Empty);
                    maskedTextBoxPhone.Text = string.Empty;
                    dateTimePickerBirthdate.Value = DateTime.Now;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            groupBox_Anket.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = string.Empty);
            maskedTextBoxPhone.Text = string.Empty;
            dateTimePickerBirthdate.Value = DateTime.Now;
        }

        private void MaskedTextBoxPhone_TextChanged(object sender, EventArgs e) => user.Phone = maskedTextBoxPhone.Text;

    }
}
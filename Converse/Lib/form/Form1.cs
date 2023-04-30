
using HlpForm;

namespace form
{
    public partial class Convert : Form
    {
        const string sEmp = "";
        public Convert()
        {
            InitializeComponent();
        }

        private void butt_Start_Click(object sender, EventArgs e)
        {
            string result;
            if (txBx_input.Text != sEmp && txBx_N.Text != sEmp && txBx_inpCC.Text != sEmp && txBx_outCC.Text != sEmp)
            {
                errorProvider1.Clear();
                int[] errLog = errorHandler.dataCorrect((txBx_input.Text).ToUpper(), txBx_inpCC.Text, txBx_outCC.Text, txBx_N.Text);
                for (int i = 0; i < errLog.Length; i++)
                {
                    if (errLog[i] != 0)
                    {
                        switch (i)
                        {
                            case 1:
                                errorProvider1.SetError(txBx_input, "Ошибка ввода");
                                return;
                            case 2:
                                errorProvider1.SetError(txBx_inpCC, "Значение должно быть целочисленным");
                                errorProvider1.SetError(cmBx_inpCC, "Значение должно быть целочисленным");
                                return;
                            case 3:
                                errorProvider1.SetError(txBx_inpCC, "Значение должно быть >= 2 и <= 36");
                                errorProvider1.SetError(cmBx_inpCC, "Значение должно быть >= 2 и <= 36");
                                return;
                            case 4:
                                errorProvider1.SetError(txBx_inpCC, "Система счисления заданна неверно");
                                errorProvider1.SetError(cmBx_inpCC, "Система счисления заданна неверно");
                                return;
                            case 5:
                                errorProvider1.SetError(txBx_outCC, "Значение должно быть целочисленным");
                                errorProvider1.SetError(cmBx_outCC, "Значение должно быть целочисленным");
                                return;
                            case 6:
                                errorProvider1.SetError(txBx_N, "Нецелочисленный ввод");
                                return;
                            case 7:
                                errorProvider1.SetError(txBx_N, "Значение должно быть >= 1 и <=15");
                                return;
                            case 8:
                                errorProvider1.SetError(txBx_outCC, "Значение должно быть >= 2 и <= 36");
                                errorProvider1.SetError(cmBx_outCC, "Значение должно быть >= 2 и <= 36");
                                return;



                        }
                    }
                }

                entryPoint enPoint = new((txBx_input.Text).ToUpper(), txBx_out.Text, int.Parse(txBx_N.Text), int.Parse(txBx_inpCC.Text), int.Parse(txBx_outCC.Text));
                result = enPoint.getResult();
                if (result != null)
                {
                    txBx_out.Text = result;
                } else { errorProvider1.SetError(txBx_out, "Ошибка"); }
            } else { errorProvider1.SetError(butt_Start, "Не все поля заполнены"); }
            
        }

        private void cmBx_inpCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txBx_inpCC.Text = cmBx_inpCC.Text;
        }

        private void chBx_NChange_CheckedChanged(object sender, EventArgs e)
        {
            if (chBx_NChange.Checked == true)
            {
                txBx_N.ReadOnly = false;
            } else { txBx_N.ReadOnly = true; txBx_N.Text = "15"; }
        }

        private void cmBx_outCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            txBx_outCC.Text = cmBx_outCC.Text;
        }

        private void txBx_inpCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmBx_inpCC.Text = txBx_inpCC.Text;
            }
            catch (Exception) { }
        }

        private void txBx_outCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmBx_outCC.Text = txBx_outCC.Text;
            }
            catch (Exception) { }
        }

        private void chBx_InpCC_CheckedChanged(object sender, EventArgs e)
        {
            if (chBx_InpCC.Checked == true)
            {
                txBx_inpCC.Visible = true;
                cmBx_inpCC.Visible = false;
            } else { txBx_inpCC.Visible = false; cmBx_inpCC.Visible = true; }
        }

        private void chBx_mOutCC_CheckedChanged(object sender, EventArgs e)
        {
            if (chBx_mOutCC.Checked == true)
            {
                txBx_outCC.Visible = true;
                cmBx_outCC.Visible = false;
            } else { txBx_outCC.Visible = false; cmBx_outCC.Visible = true; }
        }

        private void txBx_input_TextChanged(object sender, EventArgs e)
        {
            txBx_out.Text = String.Empty;
            errorProvider1.Clear();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpForm F1 = new HelpForm();
            F1.Show();
        }

        private void cmBx_outCC_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                txBx_outCC.Text = cmBx_outCC.Text;
            }
            catch (Exception) { }
        }

        private void cmBx_inpCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txBx_inpCC.Text = cmBx_inpCC.Text;
            }
            catch (Exception) { }
        }
    }
}
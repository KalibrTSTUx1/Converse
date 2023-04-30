namespace form
{
    partial class Convert
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBx_NChange = new System.Windows.Forms.CheckBox();
            this.butt_Start = new System.Windows.Forms.Button();
            this.cmBx_inpCC = new System.Windows.Forms.ComboBox();
            this.cmBx_outCC = new System.Windows.Forms.ComboBox();
            this.txBx_inpCC = new System.Windows.Forms.TextBox();
            this.txBx_input = new System.Windows.Forms.TextBox();
            this.txBx_out = new System.Windows.Forms.TextBox();
            this.txBx_outCC = new System.Windows.Forms.TextBox();
            this.txBx_N = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chBx_InpCC = new System.Windows.Forms.CheckBox();
            this.chBx_mOutCC = new System.Windows.Forms.CheckBox();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Конвертер систем счисления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Входные данные:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(504, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выходные данные:";
            // 
            // chBx_NChange
            // 
            this.chBx_NChange.AutoSize = true;
            this.chBx_NChange.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBx_NChange.Location = new System.Drawing.Point(8, 235);
            this.chBx_NChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBx_NChange.Name = "chBx_NChange";
            this.chBx_NChange.Size = new System.Drawing.Size(589, 30);
            this.chBx_NChange.TabIndex = 3;
            this.chBx_NChange.Text = "Пользовательский ввод количества знаков после запятой";
            this.chBx_NChange.UseVisualStyleBackColor = true;
            this.chBx_NChange.CheckedChanged += new System.EventHandler(this.chBx_NChange_CheckedChanged);
            // 
            // butt_Start
            // 
            this.butt_Start.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt_Start.Location = new System.Drawing.Point(215, 92);
            this.butt_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butt_Start.Name = "butt_Start";
            this.butt_Start.Size = new System.Drawing.Size(270, 49);
            this.butt_Start.TabIndex = 4;
            this.butt_Start.Text = "Конвертировать";
            this.butt_Start.UseVisualStyleBackColor = true;
            this.butt_Start.Click += new System.EventHandler(this.butt_Start_Click);
            // 
            // cmBx_inpCC
            // 
            this.cmBx_inpCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmBx_inpCC.FormattingEnabled = true;
            this.cmBx_inpCC.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.cmBx_inpCC.Location = new System.Drawing.Point(157, 155);
            this.cmBx_inpCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBx_inpCC.Name = "cmBx_inpCC";
            this.cmBx_inpCC.Size = new System.Drawing.Size(52, 36);
            this.cmBx_inpCC.TabIndex = 5;
            this.cmBx_inpCC.SelectedIndexChanged += new System.EventHandler(this.cmBx_inpCC_SelectedIndexChanged);
            this.cmBx_inpCC.TextChanged += new System.EventHandler(this.cmBx_inpCC_TextChanged);
            // 
            // cmBx_outCC
            // 
            this.cmBx_outCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmBx_outCC.FormattingEnabled = true;
            this.cmBx_outCC.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.cmBx_outCC.Location = new System.Drawing.Point(504, 152);
            this.cmBx_outCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBx_outCC.Name = "cmBx_outCC";
            this.cmBx_outCC.Size = new System.Drawing.Size(52, 36);
            this.cmBx_outCC.TabIndex = 6;
            this.cmBx_outCC.SelectedIndexChanged += new System.EventHandler(this.cmBx_outCC_SelectedIndexChanged);
            this.cmBx_outCC.TextUpdate += new System.EventHandler(this.cmBx_outCC_TextUpdate);
            // 
            // txBx_inpCC
            // 
            this.txBx_inpCC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_inpCC.Location = new System.Drawing.Point(157, 155);
            this.txBx_inpCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_inpCC.Name = "txBx_inpCC";
            this.txBx_inpCC.Size = new System.Drawing.Size(53, 31);
            this.txBx_inpCC.TabIndex = 7;
            this.txBx_inpCC.Visible = false;
            this.txBx_inpCC.TextChanged += new System.EventHandler(this.txBx_inpCC_TextChanged);
            // 
            // txBx_input
            // 
            this.txBx_input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_input.Location = new System.Drawing.Point(12, 92);
            this.txBx_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_input.Name = "txBx_input";
            this.txBx_input.Size = new System.Drawing.Size(197, 34);
            this.txBx_input.TabIndex = 8;
            this.txBx_input.TextChanged += new System.EventHandler(this.txBx_input_TextChanged);
            // 
            // txBx_out
            // 
            this.txBx_out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_out.Location = new System.Drawing.Point(504, 92);
            this.txBx_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_out.Name = "txBx_out";
            this.txBx_out.ReadOnly = true;
            this.txBx_out.Size = new System.Drawing.Size(214, 34);
            this.txBx_out.TabIndex = 9;
            // 
            // txBx_outCC
            // 
            this.txBx_outCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_outCC.Location = new System.Drawing.Point(503, 152);
            this.txBx_outCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_outCC.Name = "txBx_outCC";
            this.txBx_outCC.Size = new System.Drawing.Size(53, 34);
            this.txBx_outCC.TabIndex = 10;
            this.txBx_outCC.Visible = false;
            this.txBx_outCC.TextChanged += new System.EventHandler(this.txBx_outCC_TextChanged);
            // 
            // txBx_N
            // 
            this.txBx_N.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txBx_N.Location = new System.Drawing.Point(344, 170);
            this.txBx_N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_N.Name = "txBx_N";
            this.txBx_N.ReadOnly = true;
            this.txBx_N.Size = new System.Drawing.Size(52, 34);
            this.txBx_N.TabIndex = 11;
            this.txBx_N.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(304, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "N:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Исходная система счисления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(434, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Желаемая система счисления";
            // 
            // chBx_InpCC
            // 
            this.chBx_InpCC.AutoSize = true;
            this.chBx_InpCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chBx_InpCC.Location = new System.Drawing.Point(12, 159);
            this.chBx_InpCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBx_InpCC.Name = "chBx_InpCC";
            this.chBx_InpCC.Size = new System.Drawing.Size(145, 27);
            this.chBx_InpCC.TabIndex = 15;
            this.chBx_InpCC.Text = "Ручной ввод";
            this.chBx_InpCC.UseVisualStyleBackColor = true;
            this.chBx_InpCC.CheckedChanged += new System.EventHandler(this.chBx_InpCC_CheckedChanged);
            // 
            // chBx_mOutCC
            // 
            this.chBx_mOutCC.AutoSize = true;
            this.chBx_mOutCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chBx_mOutCC.Location = new System.Drawing.Point(573, 159);
            this.chBx_mOutCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBx_mOutCC.Name = "chBx_mOutCC";
            this.chBx_mOutCC.Size = new System.Drawing.Size(145, 27);
            this.chBx_mOutCC.TabIndex = 16;
            this.chBx_mOutCC.Text = "Ручной ввод";
            this.chBx_mOutCC.UseVisualStyleBackColor = true;
            this.chBx_mOutCC.CheckedChanged += new System.EventHandler(this.chBx_mOutCC_CheckedChanged);
            // 
            // helpBtn
            // 
            this.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpBtn.Location = new System.Drawing.Point(631, 17);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(78, 33);
            this.helpBtn.TabIndex = 17;
            this.helpBtn.Text = "Справка";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Convert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 266);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.chBx_mOutCC);
            this.Controls.Add(this.chBx_InpCC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBx_N);
            this.Controls.Add(this.txBx_outCC);
            this.Controls.Add(this.txBx_out);
            this.Controls.Add(this.txBx_input);
            this.Controls.Add(this.txBx_inpCC);
            this.Controls.Add(this.cmBx_outCC);
            this.Controls.Add(this.cmBx_inpCC);
            this.Controls.Add(this.butt_Start);
            this.Controls.Add(this.chBx_NChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Convert";
            this.Text = "Convert";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox chBx_NChange;
        private Button butt_Start;
        private ComboBox cmBx_inpCC;
        private ComboBox cmBx_outCC;
        private TextBox txBx_inpCC;
        private TextBox txBx_input;
        private TextBox txBx_out;
        private TextBox txBx_outCC;
        private TextBox txBx_N;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Label label6;
        private Label label5;
        private CheckBox chBx_InpCC;
        private CheckBox chBx_mOutCC;
        private Button helpBtn;
    }
}
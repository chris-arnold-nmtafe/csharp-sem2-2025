namespace CalculationsProject
{
    partial class CalculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numVal1 = new System.Windows.Forms.NumericUpDown();
            this.numVal2 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCheckText = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textResultText = new System.Windows.Forms.TextBox();
            this.btnStarts = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textChar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textResultNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textResultNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDivide);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.numVal2);
            this.groupBox1.Controls.Add(this.numVal1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numbers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnConvert);
            this.groupBox2.Controls.Add(this.btnStarts);
            this.groupBox2.Controls.Add(this.textChar);
            this.groupBox2.Controls.Add(this.textResultText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelText);
            this.groupBox2.Controls.Add(this.textCheckText);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // numVal1
            // 
            this.numVal1.Location = new System.Drawing.Point(112, 28);
            this.numVal1.Name = "numVal1";
            this.numVal1.Size = new System.Drawing.Size(120, 20);
            this.numVal1.TabIndex = 0;
            // 
            // numVal2
            // 
            this.numVal2.Location = new System.Drawing.Point(112, 54);
            this.numVal2.Name = "numVal2";
            this.numVal2.Size = new System.Drawing.Size(120, 20);
            this.numVal2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(148, 80);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(85, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1st Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "2nd Value";
            // 
            // textCheckText
            // 
            this.textCheckText.Location = new System.Drawing.Point(88, 27);
            this.textCheckText.Name = "textCheckText";
            this.textCheckText.Size = new System.Drawing.Size(197, 20);
            this.textCheckText.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(6, 30);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(76, 13);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Text to check:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result:";
            // 
            // textResultText
            // 
            this.textResultText.Enabled = false;
            this.textResultText.Location = new System.Drawing.Point(9, 180);
            this.textResultText.Name = "textResultText";
            this.textResultText.Size = new System.Drawing.Size(276, 20);
            this.textResultText.TabIndex = 3;
            // 
            // btnStarts
            // 
            this.btnStarts.Location = new System.Drawing.Point(9, 53);
            this.btnStarts.Name = "btnStarts";
            this.btnStarts.Size = new System.Drawing.Size(276, 23);
            this.btnStarts.TabIndex = 4;
            this.btnStarts.Text = "Starts with upper character";
            this.btnStarts.UseVisualStyleBackColor = true;
            this.btnStarts.Click += new System.EventHandler(this.btnStarts_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(9, 108);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(276, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert to upper character";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textChar
            // 
            this.textChar.Location = new System.Drawing.Point(88, 82);
            this.textChar.MaxLength = 1;
            this.textChar.Name = "textChar";
            this.textChar.Size = new System.Drawing.Size(43, 20);
            this.textChar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Char:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(276, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search for character in text";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textResultNum
            // 
            this.textResultNum.Enabled = false;
            this.textResultNum.Location = new System.Drawing.Point(9, 123);
            this.textResultNum.Name = "textResultNum";
            this.textResultNum.Size = new System.Drawing.Size(276, 20);
            this.textResultNum.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Result:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(291, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 422);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVal2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numVal2;
        private System.Windows.Forms.NumericUpDown numVal1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textCheckText;
        private System.Windows.Forms.Button btnStarts;
        private System.Windows.Forms.TextBox textResultText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textChar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textResultNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
    }
}


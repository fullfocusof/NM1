namespace LR1
{
    partial class ErrorEstimate
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelValue = new System.Windows.Forms.Label();
            this.labelAbsError = new System.Windows.Forms.Label();
            this.labelRelatError = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxAbsError = new System.Windows.Forms.TextBox();
            this.textBoxRelatError = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(119, 9);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(80, 19);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "- значение";
            // 
            // labelAbsError
            // 
            this.labelAbsError.AutoSize = true;
            this.labelAbsError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbsError.Location = new System.Drawing.Point(119, 46);
            this.labelAbsError.Name = "labelAbsError";
            this.labelAbsError.Size = new System.Drawing.Size(190, 19);
            this.labelAbsError.TabIndex = 4;
            this.labelAbsError.Text = "- абсолютная погрешность";
            // 
            // labelRelatError
            // 
            this.labelRelatError.AutoSize = true;
            this.labelRelatError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRelatError.Location = new System.Drawing.Point(119, 83);
            this.labelRelatError.Name = "labelRelatError";
            this.labelRelatError.Size = new System.Drawing.Size(237, 19);
            this.labelRelatError.TabIndex = 5;
            this.labelRelatError.Text = "- относительная погрешность (%)";
            // 
            // textBoxValue
            // 
            this.textBoxValue.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxValue.Location = new System.Drawing.Point(13, 9);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 6;
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // textBoxAbsError
            // 
            this.textBoxAbsError.Location = new System.Drawing.Point(12, 46);
            this.textBoxAbsError.Name = "textBoxAbsError";
            this.textBoxAbsError.Size = new System.Drawing.Size(100, 20);
            this.textBoxAbsError.TabIndex = 7;
            this.textBoxAbsError.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // textBoxRelatError
            // 
            this.textBoxRelatError.Location = new System.Drawing.Point(12, 83);
            this.textBoxRelatError.Name = "textBoxRelatError";
            this.textBoxRelatError.Size = new System.Drawing.Size(100, 20);
            this.textBoxRelatError.TabIndex = 8;
            this.textBoxRelatError.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(220, 119);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(75, 23);
            this.buttonExec.TabIndex = 9;
            this.buttonExec.Text = "Оценить";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(8, 115);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(19, 15);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "---";
            this.labelError.Visible = false;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(298, 119);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 11;
            this.buttonClearAll.Text = "Очистить";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // ErrorEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(378, 150);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textBoxRelatError);
            this.Controls.Add(this.textBoxAbsError);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelRelatError);
            this.Controls.Add(this.labelAbsError);
            this.Controls.Add(this.labelValue);
            this.Name = "ErrorEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оценка погрешности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelAbsError;
        private System.Windows.Forms.Label labelRelatError;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxAbsError;
        private System.Windows.Forms.TextBox textBoxRelatError;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonClearAll;
    }
}


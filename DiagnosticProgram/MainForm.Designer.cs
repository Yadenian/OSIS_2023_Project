namespace DiagnosticProgram
{
    partial class MainForm
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
            this.RunDiagnosticButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diagStateInfoLb = new System.Windows.Forms.Label();
            this.stopDiagButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableFreeSpaceTb = new System.Windows.Forms.TextBox();
            this.totalSizeTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateCountLabel = new System.Windows.Forms.Label();
            this.updateIntervalTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.applyNewIntervalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunDiagnosticButton
            // 
            this.RunDiagnosticButton.Location = new System.Drawing.Point(64, 242);
            this.RunDiagnosticButton.Name = "RunDiagnosticButton";
            this.RunDiagnosticButton.Size = new System.Drawing.Size(125, 23);
            this.RunDiagnosticButton.TabIndex = 0;
            this.RunDiagnosticButton.Text = "Run diagnostic";
            this.RunDiagnosticButton.UseVisualStyleBackColor = true;
            this.RunDiagnosticButton.Click += new System.EventHandler(this.RunDiagnosticButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diagnostic state";
            // 
            // diagStateInfoLb
            // 
            this.diagStateInfoLb.AutoSize = true;
            this.diagStateInfoLb.Location = new System.Drawing.Point(106, 33);
            this.diagStateInfoLb.Name = "diagStateInfoLb";
            this.diagStateInfoLb.Size = new System.Drawing.Size(73, 13);
            this.diagStateInfoLb.TabIndex = 2;
            this.diagStateInfoLb.Text = "___________";
            // 
            // stopDiagButton
            // 
            this.stopDiagButton.Location = new System.Drawing.Point(64, 204);
            this.stopDiagButton.Name = "stopDiagButton";
            this.stopDiagButton.Size = new System.Drawing.Size(125, 23);
            this.stopDiagButton.TabIndex = 3;
            this.stopDiagButton.Text = "Stop diagnostic";
            this.stopDiagButton.UseVisualStyleBackColor = true;
            this.stopDiagButton.Click += new System.EventHandler(this.StopDiagButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Available free space";
            // 
            // availableFreeSpaceTb
            // 
            this.availableFreeSpaceTb.Location = new System.Drawing.Point(15, 147);
            this.availableFreeSpaceTb.Name = "availableFreeSpaceTb";
            this.availableFreeSpaceTb.Size = new System.Drawing.Size(100, 20);
            this.availableFreeSpaceTb.TabIndex = 7;
            // 
            // totalSizeTb
            // 
            this.totalSizeTb.Location = new System.Drawing.Point(15, 94);
            this.totalSizeTb.Name = "totalSizeTb";
            this.totalSizeTb.Size = new System.Drawing.Size(100, 20);
            this.totalSizeTb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Update count: ";
            // 
            // updateCountLabel
            // 
            this.updateCountLabel.AutoSize = true;
            this.updateCountLabel.Location = new System.Drawing.Point(87, 53);
            this.updateCountLabel.Name = "updateCountLabel";
            this.updateCountLabel.Size = new System.Drawing.Size(13, 13);
            this.updateCountLabel.TabIndex = 9;
            this.updateCountLabel.Text = "0";
            // 
            // updateIntervalTb
            // 
            this.updateIntervalTb.Location = new System.Drawing.Point(175, 94);
            this.updateIntervalTb.Name = "updateIntervalTb";
            this.updateIntervalTb.Size = new System.Drawing.Size(127, 20);
            this.updateIntervalTb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Update interval ms";
            // 
            // applyNewIntervalBtn
            // 
            this.applyNewIntervalBtn.Location = new System.Drawing.Point(175, 121);
            this.applyNewIntervalBtn.Name = "applyNewIntervalBtn";
            this.applyNewIntervalBtn.Size = new System.Drawing.Size(125, 23);
            this.applyNewIntervalBtn.TabIndex = 12;
            this.applyNewIntervalBtn.Text = "Apply interval";
            this.applyNewIntervalBtn.UseVisualStyleBackColor = true;
            this.applyNewIntervalBtn.Click += new System.EventHandler(this.ApplyNewIntervalBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 277);
            this.Controls.Add(this.applyNewIntervalBtn);
            this.Controls.Add(this.updateIntervalTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.availableFreeSpaceTb);
            this.Controls.Add(this.totalSizeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopDiagButton);
            this.Controls.Add(this.diagStateInfoLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunDiagnosticButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunDiagnosticButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label diagStateInfoLb;
        private System.Windows.Forms.Button stopDiagButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox availableFreeSpaceTb;
        private System.Windows.Forms.TextBox totalSizeTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label updateCountLabel;
        private System.Windows.Forms.TextBox updateIntervalTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button applyNewIntervalBtn;
    }
}


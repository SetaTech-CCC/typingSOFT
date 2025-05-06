namespace タイピングソフト
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.flowKeyboard = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblText.Location = new System.Drawing.Point(21, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(286, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "ここに入力する文字が表示されます";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtInput.Location = new System.Drawing.Point(12, 100);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(382, 45);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // flowKeyboard
            // 
            this.flowKeyboard.Location = new System.Drawing.Point(12, 160);
            this.flowKeyboard.Name = "flowKeyboard";
            this.flowKeyboard.Size = new System.Drawing.Size(469, 145);
            this.flowKeyboard.TabIndex = 2;
            // 
            // btnLoadText
            // 
            this.btnLoadText.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadText.Location = new System.Drawing.Point(413, 100);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(96, 45);
            this.btnLoadText.TabIndex = 3;
            this.btnLoadText.Text = "読み込み";
            this.btnLoadText.UseVisualStyleBackColor = true;
            this.btnLoadText.Click += new System.EventHandler(this.btnLoadText_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 314);
            this.Controls.Add(this.btnLoadText);
            this.Controls.Add(this.flowKeyboard);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.FlowLayoutPanel flowKeyboard;
        private System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


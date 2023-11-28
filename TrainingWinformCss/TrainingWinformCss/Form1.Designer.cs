namespace TrainingWinformCss
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PopupSampleBox = new DevExpress.XtraEditors.GroupControl();
            this.OptionButtonBox = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.PopupSampleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionButtonBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PopupSampleBox
            // 
            this.PopupSampleBox.Location = new System.Drawing.Point(88, 32);
            this.PopupSampleBox.Name = "PopupSampleBox";
            this.PopupSampleBox.Size = new System.Drawing.Size(130, 125);
            this.PopupSampleBox.TabIndex = 0;
            this.PopupSampleBox.Text = "PopupSample";
            // 
            // OptionButtonBox
            // 
            this.OptionButtonBox.Location = new System.Drawing.Point(77, 211);
            this.OptionButtonBox.Name = "OptionButtonBox";
            this.OptionButtonBox.Size = new System.Drawing.Size(334, 125);
            this.OptionButtonBox.TabIndex = 1;
            this.OptionButtonBox.Text = "按鈕- 單選";
            this.OptionButtonBox.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptionButtonBox);
            this.Controls.Add(this.PopupSampleBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopupSampleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionButtonBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl PopupSampleBox;
        private DevExpress.XtraEditors.GroupControl OptionButtonBox;
    }
}


namespace Pacakges_Maker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonoandroidVerstion = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFileOpenAndMake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMonoandroidVerstion);
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Controls.Add(this.btnFileOpenAndMake);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 70);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "monoandroid version :";
            // 
            // txtMonoandroidVerstion
            // 
            this.txtMonoandroidVerstion.Location = new System.Drawing.Point(159, 39);
            this.txtMonoandroidVerstion.Name = "txtMonoandroidVerstion";
            this.txtMonoandroidVerstion.Size = new System.Drawing.Size(277, 21);
            this.txtMonoandroidVerstion.TabIndex = 7;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(76, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(534, 21);
            this.txtFilePath.TabIndex = 6;
            // 
            // btnFileOpenAndMake
            // 
            this.btnFileOpenAndMake.Location = new System.Drawing.Point(616, 12);
            this.btnFileOpenAndMake.Name = "btnFileOpenAndMake";
            this.btnFileOpenAndMake.Size = new System.Drawing.Size(130, 23);
            this.btnFileOpenAndMake.TabIndex = 5;
            this.btnFileOpenAndMake.Text = "Open/Make";
            this.btnFileOpenAndMake.UseVisualStyleBackColor = true;
            this.btnFileOpenAndMake.Click += new System.EventHandler(this.btnFileOpenAndMake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "file path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 300);
            this.panel1.TabIndex = 4;
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(780, 300);
            this.txtInfo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(796, 409);
            this.Name = "Form1";
            this.Text = "convert csproj to pacakages file info";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonoandroidVerstion;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFileOpenAndMake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInfo;
    }
}


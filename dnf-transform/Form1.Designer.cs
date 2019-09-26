namespace dnf_transform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCt = new System.Windows.Forms.Button();
            this.btnBase = new System.Windows.Forms.Button();
            this.lbCt = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.btnTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCt
            // 
            this.btnCt.Location = new System.Drawing.Point(60, 12);
            this.btnCt.Name = "btnCt";
            this.btnCt.Size = new System.Drawing.Size(129, 38);
            this.btnCt.TabIndex = 0;
            this.btnCt.Text = "打开模板CT";
            this.btnCt.UseVisualStyleBackColor = true;
            this.btnCt.Click += new System.EventHandler(this.BtnCt_Click);
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(60, 95);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(129, 37);
            this.btnBase.TabIndex = 1;
            this.btnBase.Text = "打开基址文件";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.BtnBase_Click);
            // 
            // lbCt
            // 
            this.lbCt.AutoSize = true;
            this.lbCt.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCt.Location = new System.Drawing.Point(214, 17);
            this.lbCt.Name = "lbCt";
            this.lbCt.Size = new System.Drawing.Size(103, 30);
            this.lbCt.TabIndex = 2;
            this.lbCt.Text = "待读取";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBase.Location = new System.Drawing.Point(214, 102);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(103, 30);
            this.lbBase.TabIndex = 3;
            this.lbBase.Text = "待读取";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(60, 202);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(129, 38);
            this.btnTransform.TabIndex = 4;
            this.btnTransform.Text = "转换";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.lbCt);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.btnCt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCt;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Label lbCt;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Button btnTransform;
    }
}


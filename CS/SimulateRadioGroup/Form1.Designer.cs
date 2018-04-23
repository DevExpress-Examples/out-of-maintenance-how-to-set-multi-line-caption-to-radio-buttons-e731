namespace SimulateRadioGroup {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CheckEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.CheckEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.SpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.CheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.SimpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckEdit3
            // 
            this.CheckEdit3.Enabled = false;
            this.CheckEdit3.Location = new System.Drawing.Point(16, 112);
            this.CheckEdit3.Name = "CheckEdit3";
            this.CheckEdit3.Properties.Caption = "Choice C";
            this.CheckEdit3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.CheckEdit3.Properties.RadioGroupIndex = 1;
            this.CheckEdit3.Size = new System.Drawing.Size(128, 19);
            this.CheckEdit3.TabIndex = 2;
            this.CheckEdit3.TabStop = false;
            // 
            // CheckEdit2
            // 
            this.CheckEdit2.Location = new System.Drawing.Point(16, 64);
            this.CheckEdit2.Name = "CheckEdit2";
            this.CheckEdit2.Properties.Caption = "Choice B\n(recommended)";
            this.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.CheckEdit2.Properties.RadioGroupIndex = 1;
            this.CheckEdit2.Size = new System.Drawing.Size(128, 31);
            this.CheckEdit2.TabIndex = 1;
            this.CheckEdit2.TabStop = false;
            // 
            // SpinEdit1
            // 
            this.SpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEdit1.Location = new System.Drawing.Point(380, 52);
            this.SpinEdit1.Name = "SpinEdit1";
            this.SpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SpinEdit1.Properties.Mask.EditMask = "d";
            this.SpinEdit1.Size = new System.Drawing.Size(40, 20);
            this.SpinEdit1.TabIndex = 7;
            // 
            // CheckEdit1
            // 
            this.CheckEdit1.Location = new System.Drawing.Point(16, 24);
            this.CheckEdit1.Name = "CheckEdit1";
            this.CheckEdit1.Properties.Caption = "Choice A";
            this.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.CheckEdit1.Properties.RadioGroupIndex = 1;
            this.CheckEdit1.Size = new System.Drawing.Size(128, 19);
            this.CheckEdit1.TabIndex = 0;
            this.CheckEdit1.TabStop = false;
            // 
            // SimpleButton2
            // 
            this.SimpleButton2.Location = new System.Drawing.Point(252, 52);
            this.SimpleButton2.Name = "SimpleButton2";
            this.SimpleButton2.Size = new System.Drawing.Size(120, 23);
            this.SimpleButton2.TabIndex = 6;
            this.SimpleButton2.Text = "Set Selected Index";
            this.SimpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.Location = new System.Drawing.Point(252, 20);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(168, 23);
            this.SimpleButton1.TabIndex = 5;
            this.SimpleButton1.Text = "Get Selected Index";
            this.SimpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.CheckEdit3);
            this.GroupControl1.Controls.Add(this.CheckEdit2);
            this.GroupControl1.Controls.Add(this.CheckEdit1);
            this.GroupControl1.Location = new System.Drawing.Point(12, 12);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(216, 160);
            this.GroupControl1.TabIndex = 4;
            this.GroupControl1.Text = "GroupControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 184);
            this.Controls.Add(this.SpinEdit1);
            this.Controls.Add(this.SimpleButton2);
            this.Controls.Add(this.SimpleButton1);
            this.Controls.Add(this.GroupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.CheckEdit CheckEdit3;
        internal DevExpress.XtraEditors.CheckEdit CheckEdit2;
        internal DevExpress.XtraEditors.SpinEdit SpinEdit1;
        internal DevExpress.XtraEditors.CheckEdit CheckEdit1;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton2;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
        internal DevExpress.XtraEditors.GroupControl GroupControl1;

    }
}


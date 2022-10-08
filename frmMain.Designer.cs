namespace NaveensLateFeeCalculator
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.BtnLibrary = new System.Windows.Forms.Button();
            this.BtnSystems = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1207, 146);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naveen\'s Late Fee Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNew.Location = new System.Drawing.Point(250, 227);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(183, 45);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New Release";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnLibrary
            // 
            this.BtnLibrary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibrary.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnLibrary.Location = new System.Drawing.Point(528, 227);
            this.BtnLibrary.Name = "BtnLibrary";
            this.BtnLibrary.Size = new System.Drawing.Size(186, 45);
            this.BtnLibrary.TabIndex = 2;
            this.BtnLibrary.Text = "&Library Games";
            this.BtnLibrary.UseVisualStyleBackColor = false;
            this.BtnLibrary.Click += new System.EventHandler(this.BtnLibrary_Click);
            // 
            // BtnSystems
            // 
            this.BtnSystems.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystems.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnSystems.Location = new System.Drawing.Point(809, 227);
            this.BtnSystems.Name = "BtnSystems";
            this.BtnSystems.Size = new System.Drawing.Size(189, 45);
            this.BtnSystems.TabIndex = 3;
            this.BtnSystems.Text = "Game &Systems";
            this.BtnSystems.UseVisualStyleBackColor = false;
            this.BtnSystems.Click += new System.EventHandler(this.BtnSystems_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(530, 408);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(184, 45);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1212, 751);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSystems);
            this.Controls.Add(this.BtnLibrary);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Naveen\'sLateFeeCalculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button BtnLibrary;
        private System.Windows.Forms.Button BtnSystems;
        private System.Windows.Forms.Button BtnExit;

    }


 
}



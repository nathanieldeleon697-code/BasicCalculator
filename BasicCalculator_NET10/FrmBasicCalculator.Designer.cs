
namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCompute;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();

            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(
                240, 240, 240);
            this.ClientSize = new System.Drawing.Size(310, 396);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F,
                System.Drawing.FontStyle.Regular);
            this.lblTitle.ForeColor =
                System.Drawing.Color.Black;
            this.lblTitle.Location =
                new System.Drawing.Point(25, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Basic Calculator";

            // First number
            this.txtFirstNumber.BackColor =
                System.Drawing.Color.White;
            this.txtFirstNumber.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstNumber.Font =
                new System.Drawing.Font("Consolas", 23F);
            this.txtFirstNumber.ForeColor =
                System.Drawing.Color.Black;
            this.txtFirstNumber.Location =
                new System.Drawing.Point(20, 88);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size =
                new System.Drawing.Size(270, 43);
            this.txtFirstNumber.Text = "0";
            this.txtFirstNumber.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // Operation dropdown
            this.cmbOperation.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.Font =
                new System.Drawing.Font("Segoe UI", 13F);
            this.cmbOperation.BackColor =
                System.Drawing.Color.White;
            this.cmbOperation.ForeColor =
                System.Drawing.Color.Black;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(
                new object[] { "+", "-", "×", "÷" });
            this.cmbOperation.Location =
                new System.Drawing.Point(135, 140);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size =
                new System.Drawing.Size(65, 31);

            // Second number
            this.txtSecondNumber.BackColor =
                System.Drawing.Color.White;
            this.txtSecondNumber.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondNumber.Font =
                new System.Drawing.Font("Consolas", 23F);
            this.txtSecondNumber.ForeColor =
                System.Drawing.Color.Black;
            this.txtSecondNumber.Location =
                new System.Drawing.Point(20, 180);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size =
                new System.Drawing.Size(270, 43);
            this.txtSecondNumber.Text = "0";
            this.txtSecondNumber.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Right;

            // Total display
            this.pnlTotal.BackColor =
                System.Drawing.Color.Black;
            this.pnlTotal.Location =
                new System.Drawing.Point(20, 239);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size =
                new System.Drawing.Size(270, 88);
            this.pnlTotal.Controls.Add(this.lblTotalCaption);
            this.pnlTotal.Controls.Add(this.lblResult);

            // Total caption
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font(
                "Consolas", 13F,
                System.Drawing.FontStyle.Bold);
            this.lblTotalCaption.ForeColor =
                System.Drawing.Color.Lime;
            this.lblTotalCaption.Location =
                new System.Drawing.Point(8, 7);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Text = "Total:";

            // Result
            this.lblResult.AutoEllipsis = true;
            this.lblResult.Font =
                new System.Drawing.Font("Consolas", 23F);
            this.lblResult.ForeColor =
                System.Drawing.Color.Lime;
            this.lblResult.Location =
                new System.Drawing.Point(8, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size =
                new System.Drawing.Size(255, 43);
            this.lblResult.Text = "000000";

            // Compute button
            this.btnCompute.BackColor =
                System.Drawing.Color.FromArgb(225, 225, 225);
            this.btnCompute.FlatStyle =
                System.Windows.Forms.FlatStyle.Standard;
            this.btnCompute.Font = new System.Drawing.Font(
                "Segoe UI", 10F,
                System.Drawing.FontStyle.Regular);
            this.btnCompute.ForeColor =
                System.Drawing.Color.Black;
            this.btnCompute.Location =
                new System.Drawing.Point(107, 348);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size =
                new System.Drawing.Size(100, 35);
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click +=
                new System.EventHandler(this.btnCompute_Click);

            this.AcceptButton = this.btnCompute;

            // Add controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnCompute);

            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

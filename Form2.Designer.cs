namespace RAILWAY_GUI
{
    partial class Form2
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
            this.labelTrain = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelCompartment = new System.Windows.Forms.Label();
            this.labelSeats = new System.Windows.Forms.Label();
            this.labelSeatNumbers = new System.Windows.Forms.Label();
            this.labelPassengerNames = new System.Windows.Forms.Label();
            this.cmbTrain = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.txtCompartment = new System.Windows.Forms.TextBox();
            this.txtNumSeats = new System.Windows.Forms.TextBox();
            this.txtSeatNumbers = new System.Windows.Forms.TextBox();
            this.txtPassengerNames = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrain.Location = new System.Drawing.Point(509, 86);
            this.labelTrain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(117, 25);
            this.labelTrain.TabIndex = 0;
            this.labelTrain.Text = "Select Train";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(509, 153);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(122, 25);
            this.labelClass.TabIndex = 1;
            this.labelClass.Text = "Select Class";
            this.labelClass.Click += new System.EventHandler(this.labelClass_Click);
            // 
            // labelCompartment
            // 
            this.labelCompartment.AutoSize = true;
            this.labelCompartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompartment.Location = new System.Drawing.Point(427, 242);
            this.labelCompartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompartment.Name = "labelCompartment";
            this.labelCompartment.Size = new System.Drawing.Size(204, 25);
            this.labelCompartment.TabIndex = 2;
            this.labelCompartment.Text = "Compartment Number";
            // 
            // labelSeats
            // 
            this.labelSeats.AutoSize = true;
            this.labelSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeats.Location = new System.Drawing.Point(468, 334);
            this.labelSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeats.Name = "labelSeats";
            this.labelSeats.Size = new System.Drawing.Size(158, 25);
            this.labelSeats.TabIndex = 3;
            this.labelSeats.Text = "Number of Seats";
            // 
            // labelSeatNumbers
            // 
            this.labelSeatNumbers.AutoSize = true;
            this.labelSeatNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatNumbers.Location = new System.Drawing.Point(489, 412);
            this.labelSeatNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeatNumbers.Name = "labelSeatNumbers";
            this.labelSeatNumbers.Size = new System.Drawing.Size(137, 25);
            this.labelSeatNumbers.TabIndex = 4;
            this.labelSeatNumbers.Text = "Seat Numbers";
            // 
            // labelPassengerNames
            // 
            this.labelPassengerNames.AutoSize = true;
            this.labelPassengerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassengerNames.Location = new System.Drawing.Point(458, 493);
            this.labelPassengerNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassengerNames.Name = "labelPassengerNames";
            this.labelPassengerNames.Size = new System.Drawing.Size(173, 25);
            this.labelPassengerNames.TabIndex = 5;
            this.labelPassengerNames.Text = "Passenger Names";
            // 
            // cmbTrain
            // 
            this.cmbTrain.FormattingEnabled = true;
            this.cmbTrain.Location = new System.Drawing.Point(728, 86);
            this.cmbTrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTrain.Name = "cmbTrain";
            this.cmbTrain.Size = new System.Drawing.Size(160, 33);
            this.cmbTrain.TabIndex = 6;
            this.cmbTrain.SelectedIndexChanged += new System.EventHandler(this.cmbTrain_SelectedIndexChanged);
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(728, 153);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(160, 33);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCompartment
            // 
            this.txtCompartment.Location = new System.Drawing.Point(728, 242);
            this.txtCompartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompartment.Name = "txtCompartment";
            this.txtCompartment.Size = new System.Drawing.Size(132, 30);
            this.txtCompartment.TabIndex = 8;
            // 
            // txtNumSeats
            // 
            this.txtNumSeats.Location = new System.Drawing.Point(728, 334);
            this.txtNumSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumSeats.Name = "txtNumSeats";
            this.txtNumSeats.Size = new System.Drawing.Size(132, 30);
            this.txtNumSeats.TabIndex = 9;
            // 
            // txtSeatNumbers
            // 
            this.txtSeatNumbers.Location = new System.Drawing.Point(728, 412);
            this.txtSeatNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeatNumbers.Multiline = true;
            this.txtSeatNumbers.Name = "txtSeatNumbers";
            this.txtSeatNumbers.Size = new System.Drawing.Size(132, 32);
            this.txtSeatNumbers.TabIndex = 10;
            // 
            // txtPassengerNames
            // 
            this.txtPassengerNames.Location = new System.Drawing.Point(728, 486);
            this.txtPassengerNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassengerNames.Multiline = true;
            this.txtPassengerNames.Name = "txtPassengerNames";
            this.txtPassengerNames.Size = new System.Drawing.Size(132, 32);
            this.txtPassengerNames.TabIndex = 11;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(627, 571);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(115, 38);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(627, 640);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 39);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 852);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtPassengerNames);
            this.Controls.Add(this.txtSeatNumbers);
            this.Controls.Add(this.txtNumSeats);
            this.Controls.Add(this.txtCompartment);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbTrain);
            this.Controls.Add(this.labelPassengerNames);
            this.Controls.Add(this.labelSeatNumbers);
            this.Controls.Add(this.labelSeats);
            this.Controls.Add(this.labelCompartment);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelTrain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelCompartment;
        private System.Windows.Forms.Label labelSeats;
        private System.Windows.Forms.Label labelSeatNumbers;
        private System.Windows.Forms.Label labelPassengerNames;
        private System.Windows.Forms.ComboBox cmbTrain;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtCompartment;
        private System.Windows.Forms.TextBox txtNumSeats;
        private System.Windows.Forms.TextBox txtSeatNumbers;
        private System.Windows.Forms.TextBox txtPassengerNames;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
    }
}
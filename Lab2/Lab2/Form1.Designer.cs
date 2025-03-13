namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ionCashLabel = new Label();
            alexCashLabel = new Label();
            bankCashLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            ionGivesToAlex = new Button();
            alexGivesToIon = new Button();
            SuspendLayout();
            // 
            // ionCashLabel
            // 
            ionCashLabel.AutoSize = true;
            ionCashLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            ionCashLabel.Location = new Point(23, 22);
            ionCashLabel.Name = "ionCashLabel";
            ionCashLabel.Size = new Size(66, 20);
            ionCashLabel.TabIndex = 0;
            ionCashLabel.Text = "Ion are";
            // 
            // alexCashLabel
            // 
            alexCashLabel.AutoSize = true;
            alexCashLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            alexCashLabel.Location = new Point(23, 59);
            alexCashLabel.Name = "alexCashLabel";
            alexCashLabel.Size = new Size(74, 20);
            alexCashLabel.TabIndex = 1;
            alexCashLabel.Text = "Alex are";
            // 
            // bankCashLabel
            // 
            bankCashLabel.AutoSize = true;
            bankCashLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            bankCashLabel.Location = new Point(23, 96);
            bankCashLabel.Name = "bankCashLabel";
            bankCashLabel.Size = new Size(119, 20);
            bankCashLabel.TabIndex = 2;
            bankCashLabel.Text = "In banca sunt";
            // 
            // button1
            // 
            button1.Location = new Point(81, 177);
            button1.Name = "button1";
            button1.Size = new Size(104, 71);
            button1.TabIndex = 3;
            button1.Text = "Da 10$ lui Ion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(252, 177);
            button2.Name = "button2";
            button2.Size = new Size(104, 71);
            button2.TabIndex = 4;
            button2.Text = "Primeste 5$ de la Alex";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ionGivesToAlex
            // 
            ionGivesToAlex.Location = new Point(81, 276);
            ionGivesToAlex.Name = "ionGivesToAlex";
            ionGivesToAlex.Size = new Size(104, 71);
            ionGivesToAlex.TabIndex = 6;
            ionGivesToAlex.Text = "Ion îi dă lui Alex 10$";
            ionGivesToAlex.UseVisualStyleBackColor = true;
            ionGivesToAlex.Click += ionGivesToAlex_Click;
            // 
            // alexGivesToIon
            // 
            alexGivesToIon.Location = new Point(252, 276);
            alexGivesToIon.Name = "alexGivesToIon";
            alexGivesToIon.Size = new Size(104, 71);
            alexGivesToIon.TabIndex = 5;
            alexGivesToIon.Text = "Alex îi dă lui Ion 5$";
            alexGivesToIon.UseVisualStyleBackColor = true;
            alexGivesToIon.Click += alexGivesToIon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 385);
            Controls.Add(ionGivesToAlex);
            Controls.Add(alexGivesToIon);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bankCashLabel);
            Controls.Add(alexCashLabel);
            Controls.Add(ionCashLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ionCashLabel;
        private Label alexCashLabel;
        private Label bankCashLabel;
        private Button button1;
        private Button button2;
        private Button ionGivesToAlex;
        private Button alexGivesToIon;
    }
}

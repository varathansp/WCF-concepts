namespace MessageExchangeClient
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRequestReplyOperation = new System.Windows.Forms.Button();
            this.btnRequestReplyOperation_ThrowsException = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOneWayOperation = new System.Windows.Forms.Button();
            this.btnOneWayOperation_ThrowsException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(692, 303);
            this.listBox1.TabIndex = 0;
            // 
            // btnRequestReplyOperation
            // 
            this.btnRequestReplyOperation.Location = new System.Drawing.Point(176, 328);
            this.btnRequestReplyOperation.Name = "btnRequestReplyOperation";
            this.btnRequestReplyOperation.Size = new System.Drawing.Size(340, 23);
            this.btnRequestReplyOperation.TabIndex = 1;
            this.btnRequestReplyOperation.Text = "Request Reply Operation";
            this.btnRequestReplyOperation.UseVisualStyleBackColor = true;
            this.btnRequestReplyOperation.Click += new System.EventHandler(this.btnRequestReplyOperation_Click);
            // 
            // btnRequestReplyOperation_ThrowsException
            // 
            this.btnRequestReplyOperation_ThrowsException.Location = new System.Drawing.Point(176, 379);
            this.btnRequestReplyOperation_ThrowsException.Name = "btnRequestReplyOperation_ThrowsException";
            this.btnRequestReplyOperation_ThrowsException.Size = new System.Drawing.Size(340, 23);
            this.btnRequestReplyOperation_ThrowsException.TabIndex = 2;
            this.btnRequestReplyOperation_ThrowsException.Text = "RequestReplyOperation_ThrowsException";
            this.btnRequestReplyOperation_ThrowsException.UseVisualStyleBackColor = true;
            this.btnRequestReplyOperation_ThrowsException.Click += new System.EventHandler(this.btnRequestReplyOperation_ThrowsException_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 549);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(340, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOneWayOperation
            // 
            this.btnOneWayOperation.Location = new System.Drawing.Point(176, 438);
            this.btnOneWayOperation.Name = "btnOneWayOperation";
            this.btnOneWayOperation.Size = new System.Drawing.Size(340, 23);
            this.btnOneWayOperation.TabIndex = 4;
            this.btnOneWayOperation.Text = "One Way Operation";
            this.btnOneWayOperation.UseVisualStyleBackColor = true;
            this.btnOneWayOperation.Click += new System.EventHandler(this.btnOneWayOperation_Click);
            // 
            // btnOneWayOperation_ThrowsException
            // 
            this.btnOneWayOperation_ThrowsException.Location = new System.Drawing.Point(176, 493);
            this.btnOneWayOperation_ThrowsException.Name = "btnOneWayOperation_ThrowsException";
            this.btnOneWayOperation_ThrowsException.Size = new System.Drawing.Size(340, 23);
            this.btnOneWayOperation_ThrowsException.TabIndex = 5;
            this.btnOneWayOperation_ThrowsException.Text = "OneWayOperation_ThrowsException";
            this.btnOneWayOperation_ThrowsException.UseVisualStyleBackColor = true;
            this.btnOneWayOperation_ThrowsException.Click += new System.EventHandler(this.btnOneWayOperation_ThrowsException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 630);
            this.Controls.Add(this.btnOneWayOperation_ThrowsException);
            this.Controls.Add(this.btnOneWayOperation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRequestReplyOperation_ThrowsException);
            this.Controls.Add(this.btnRequestReplyOperation);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRequestReplyOperation;
        private System.Windows.Forms.Button btnRequestReplyOperation_ThrowsException;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOneWayOperation;
        private System.Windows.Forms.Button btnOneWayOperation_ThrowsException;
    }
}


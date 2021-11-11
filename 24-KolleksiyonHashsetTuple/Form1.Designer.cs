
namespace _24_KolleksiyonHashsetTuple
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveWhere = new System.Windows.Forms.Button();
            this.btnUnionWith = new System.Windows.Forms.Button();
            this.btnIntersectWith = new System.Windows.Forms.Button();
            this.btnExceptWith = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 64);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(341, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(33, 32);
            this.txtVeri.Margin = new System.Windows.Forms.Padding(4);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(338, 23);
            this.txtVeri.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(471, 32);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 404);
            this.listBox1.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(33, 118);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(341, 46);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveWhere
            // 
            this.btnRemoveWhere.Location = new System.Drawing.Point(33, 172);
            this.btnRemoveWhere.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveWhere.Name = "btnRemoveWhere";
            this.btnRemoveWhere.Size = new System.Drawing.Size(341, 46);
            this.btnRemoveWhere.TabIndex = 4;
            this.btnRemoveWhere.Text = "Remove Where";
            this.btnRemoveWhere.UseVisualStyleBackColor = true;
            this.btnRemoveWhere.Click += new System.EventHandler(this.btnRemoveWhere_Click);
            // 
            // btnUnionWith
            // 
            this.btnUnionWith.Location = new System.Drawing.Point(33, 226);
            this.btnUnionWith.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnionWith.Name = "btnUnionWith";
            this.btnUnionWith.Size = new System.Drawing.Size(341, 46);
            this.btnUnionWith.TabIndex = 5;
            this.btnUnionWith.Text = "Union With";
            this.btnUnionWith.UseVisualStyleBackColor = true;
            this.btnUnionWith.Click += new System.EventHandler(this.btnUnionWith_Click);
            // 
            // btnIntersectWith
            // 
            this.btnIntersectWith.Location = new System.Drawing.Point(33, 280);
            this.btnIntersectWith.Margin = new System.Windows.Forms.Padding(4);
            this.btnIntersectWith.Name = "btnIntersectWith";
            this.btnIntersectWith.Size = new System.Drawing.Size(341, 46);
            this.btnIntersectWith.TabIndex = 6;
            this.btnIntersectWith.Text = "Intersect With";
            this.btnIntersectWith.UseVisualStyleBackColor = true;
            this.btnIntersectWith.Click += new System.EventHandler(this.btnIntersectWith_Click);
            // 
            // btnExceptWith
            // 
            this.btnExceptWith.Location = new System.Drawing.Point(33, 334);
            this.btnExceptWith.Margin = new System.Windows.Forms.Padding(4);
            this.btnExceptWith.Name = "btnExceptWith";
            this.btnExceptWith.Size = new System.Drawing.Size(341, 46);
            this.btnExceptWith.TabIndex = 7;
            this.btnExceptWith.Text = "Except With";
            this.btnExceptWith.UseVisualStyleBackColor = true;
            this.btnExceptWith.Click += new System.EventHandler(this.btnExceptWith_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 457);
            this.Controls.Add(this.btnExceptWith);
            this.Controls.Add(this.btnIntersectWith);
            this.Controls.Add(this.btnUnionWith);
            this.Controls.Add(this.btnRemoveWhere);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveWhere;
        private System.Windows.Forms.Button btnUnionWith;
        private System.Windows.Forms.Button btnIntersectWith;
        private System.Windows.Forms.Button btnExceptWith;
    }
}


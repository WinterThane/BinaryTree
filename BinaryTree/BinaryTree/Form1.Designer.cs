namespace BinaryTree
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.menuTitlePanel = new System.Windows.Forms.Panel();
            this.treePanel = new System.Windows.Forms.Panel();
            this.menuLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.randomRootBtn = new System.Windows.Forms.Button();
            this.fixedRootBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minRootValuTB = new System.Windows.Forms.TextBox();
            this.maxRootValueTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addRandomValueBtn = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.menuLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.Controls.Add(this.ExitBtn, 1, 2);
            this.tableLayout.Controls.Add(this.titlePanel, 1, 0);
            this.tableLayout.Controls.Add(this.menuTitlePanel, 0, 0);
            this.tableLayout.Controls.Add(this.treePanel, 1, 1);
            this.tableLayout.Controls.Add(this.menuLayoutPanel, 0, 1);
            this.tableLayout.Location = new System.Drawing.Point(2, 2);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.Size = new System.Drawing.Size(992, 620);
            this.tableLayout.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(1020, 586);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(69, 31);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.Location = new System.Drawing.Point(303, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(786, 44);
            this.titlePanel.TabIndex = 1;
            // 
            // menuTitlePanel
            // 
            this.menuTitlePanel.Location = new System.Drawing.Point(3, 3);
            this.menuTitlePanel.Name = "menuTitlePanel";
            this.menuTitlePanel.Size = new System.Drawing.Size(294, 44);
            this.menuTitlePanel.TabIndex = 2;
            // 
            // treePanel
            // 
            this.treePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePanel.Location = new System.Drawing.Point(303, 53);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(786, 514);
            this.treePanel.TabIndex = 3;
            // 
            // menuLayoutPanel
            // 
            this.menuLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuLayoutPanel.ColumnCount = 1;
            this.menuLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.menuLayoutPanel.Controls.Add(this.minRootValuTB, 0, 1);
            this.menuLayoutPanel.Controls.Add(this.fixedRootBtn, 0, 4);
            this.menuLayoutPanel.Controls.Add(this.randomRootBtn, 0, 5);
            this.menuLayoutPanel.Controls.Add(this.maxRootValueTB, 0, 3);
            this.menuLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.menuLayoutPanel.Controls.Add(this.addRandomValueBtn, 0, 8);
            this.menuLayoutPanel.Location = new System.Drawing.Point(3, 53);
            this.menuLayoutPanel.Name = "menuLayoutPanel";
            this.menuLayoutPanel.RowCount = 13;
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.menuLayoutPanel.Size = new System.Drawing.Size(294, 514);
            this.menuLayoutPanel.TabIndex = 4;
            // 
            // randomRootBtn
            // 
            this.randomRootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randomRootBtn.Location = new System.Drawing.Point(3, 163);
            this.randomRootBtn.Name = "randomRootBtn";
            this.randomRootBtn.Size = new System.Drawing.Size(288, 34);
            this.randomRootBtn.TabIndex = 0;
            this.randomRootBtn.Text = "Create random root";
            this.randomRootBtn.UseVisualStyleBackColor = true;
            // 
            // fixedRootBtn
            // 
            this.fixedRootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fixedRootBtn.Location = new System.Drawing.Point(3, 123);
            this.fixedRootBtn.Name = "fixedRootBtn";
            this.fixedRootBtn.Size = new System.Drawing.Size(288, 34);
            this.fixedRootBtn.TabIndex = 1;
            this.fixedRootBtn.Text = "Create root";
            this.fixedRootBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minimum root value:";
            // 
            // minRootValuTB
            // 
            this.minRootValuTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minRootValuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minRootValuTB.Location = new System.Drawing.Point(3, 33);
            this.minRootValuTB.Name = "minRootValuTB";
            this.minRootValuTB.Size = new System.Drawing.Size(134, 23);
            this.minRootValuTB.TabIndex = 3;
            // 
            // maxRootValueTB
            // 
            this.maxRootValueTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxRootValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxRootValueTB.Location = new System.Drawing.Point(3, 93);
            this.maxRootValueTB.Name = "maxRootValueTB";
            this.maxRootValueTB.Size = new System.Drawing.Size(134, 23);
            this.maxRootValueTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum root value:";
            // 
            // addRandomValueBtn
            // 
            this.addRandomValueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addRandomValueBtn.Location = new System.Drawing.Point(3, 283);
            this.addRandomValueBtn.Name = "addRandomValueBtn";
            this.addRandomValueBtn.Size = new System.Drawing.Size(288, 34);
            this.addRandomValueBtn.TabIndex = 6;
            this.addRandomValueBtn.Text = "Add random value";
            this.addRandomValueBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 624);
            this.Controls.Add(this.tableLayout);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary tree visualization";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayout.ResumeLayout(false);
            this.menuLayoutPanel.ResumeLayout(false);
            this.menuLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel menuTitlePanel;
        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.TableLayoutPanel menuLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minRootValuTB;
        private System.Windows.Forms.Button fixedRootBtn;
        private System.Windows.Forms.Button randomRootBtn;
        private System.Windows.Forms.TextBox maxRootValueTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addRandomValueBtn;
    }
}


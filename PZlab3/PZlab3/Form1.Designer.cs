namespace PZlab3
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
            DOit = new Button();
            setA = new Label();
            setC = new Label();
            setB = new Label();
            c_in = new TextBox();
            b_in = new TextBox();
            a_in = new TextBox();
            result = new TextBox();
            label1 = new Label();
            FIO = new TextBox();
            Groupin = new TextBox();
            Varin = new TextBox();
            Group = new Label();
            Var = new Label();
            label4 = new Label();
            Rivno = new TextBox();
            RivnoOrNo = new Label();
            SuspendLayout();
            // 
            // DOit
            // 
            DOit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DOit.Location = new Point(1148, 472);
            DOit.Name = "DOit";
            DOit.Size = new Size(284, 60);
            DOit.TabIndex = 0;
            DOit.Text = "Визначити";
            DOit.UseVisualStyleBackColor = true;
            DOit.Click += DOit_Click;
            // 
            // setA
            // 
            setA.AutoSize = true;
            setA.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setA.Location = new Point(416, 157);
            setA.Name = "setA";
            setA.Size = new Size(131, 31);
            setA.TabIndex = 1;
            setA.Text = "Введіть а";
            // 
            // setC
            // 
            setC.AutoSize = true;
            setC.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setC.Location = new Point(416, 366);
            setC.Name = "setC";
            setC.Size = new Size(130, 31);
            setC.TabIndex = 2;
            setC.Text = "Введіть c";
            setC.Click += label2_Click;
            // 
            // setB
            // 
            setB.AutoSize = true;
            setB.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setB.Location = new Point(416, 268);
            setB.Name = "setB";
            setB.Size = new Size(131, 31);
            setB.TabIndex = 3;
            setB.Text = "Введіть b";
            setB.Click += setB_Click;
            // 
            // c_in
            // 
            c_in.Font = new Font("Segoe UI", 20F);
            c_in.Location = new Point(595, 366);
            c_in.Name = "c_in";
            c_in.Size = new Size(100, 43);
            c_in.TabIndex = 6;
            // 
            // b_in
            // 
            b_in.Font = new Font("Segoe UI", 20F);
            b_in.Location = new Point(595, 256);
            b_in.Name = "b_in";
            b_in.Size = new Size(100, 43);
            b_in.TabIndex = 7;
            // 
            // a_in
            // 
            a_in.Font = new Font("Segoe UI", 20F);
            a_in.Location = new Point(595, 150);
            a_in.Name = "a_in";
            a_in.Size = new Size(100, 43);
            a_in.TabIndex = 8;
            // 
            // result
            // 
            result.Font = new Font("Segoe UI", 20F);
            result.Location = new Point(1017, 212);
            result.Name = "result";
            result.Size = new Size(479, 43);
            result.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(800, 219);
            label1.Name = "label1";
            label1.Size = new Size(143, 31);
            label1.TabIndex = 9;
            label1.Text = "Результат";
            // 
            // FIO
            // 
            FIO.Font = new Font("Segoe UI", 20F);
            FIO.Location = new Point(90, 150);
            FIO.Name = "FIO";
            FIO.Size = new Size(302, 43);
            FIO.TabIndex = 16;
            // 
            // Groupin
            // 
            Groupin.Font = new Font("Segoe UI", 20F);
            Groupin.Location = new Point(197, 256);
            Groupin.Name = "Groupin";
            Groupin.Size = new Size(100, 43);
            Groupin.TabIndex = 15;
            // 
            // Varin
            // 
            Varin.Font = new Font("Segoe UI", 20F);
            Varin.Location = new Point(197, 366);
            Varin.Name = "Varin";
            Varin.Size = new Size(100, 43);
            Varin.TabIndex = 14;
            // 
            // Group
            // 
            Group.AutoSize = true;
            Group.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Group.Location = new Point(18, 268);
            Group.Name = "Group";
            Group.Size = new Size(88, 31);
            Group.TabIndex = 13;
            Group.Text = "Група";
            // 
            // Var
            // 
            Var.AutoSize = true;
            Var.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Var.Location = new Point(18, 366);
            Var.Name = "Var";
            Var.Size = new Size(110, 31);
            Var.TabIndex = 12;
            Var.Text = "Варіант";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(18, 157);
            label4.Name = "label4";
            label4.Size = new Size(66, 31);
            label4.TabIndex = 11;
            label4.Text = "ФІО";
            // 
            // Rivno
            // 
            Rivno.Font = new Font("Segoe UI", 20F);
            Rivno.Location = new Point(1123, 292);
            Rivno.Name = "Rivno";
            Rivno.Size = new Size(373, 43);
            Rivno.TabIndex = 17;
            // 
            // RivnoOrNo
            // 
            RivnoOrNo.AutoSize = true;
            RivnoOrNo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RivnoOrNo.Location = new Point(746, 299);
            RivnoOrNo.Name = "RivnoOrNo";
            RivnoOrNo.Size = new Size(351, 31);
            RivnoOrNo.TabIndex = 18;
            RivnoOrNo.Text = "Рівнобедрений трикутник?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 605);
            Controls.Add(RivnoOrNo);
            Controls.Add(Rivno);
            Controls.Add(FIO);
            Controls.Add(Groupin);
            Controls.Add(Varin);
            Controls.Add(Group);
            Controls.Add(Var);
            Controls.Add(label4);
            Controls.Add(result);
            Controls.Add(label1);
            Controls.Add(a_in);
            Controls.Add(b_in);
            Controls.Add(c_in);
            Controls.Add(setB);
            Controls.Add(setC);
            Controls.Add(setA);
            Controls.Add(DOit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label setA;
        private Label setC;
        private Label setB;
        private TextBox c_in;
        private TextBox b_in;
        private TextBox a_in;
        private TextBox result;
        private Label label1;
        private TextBox FIO;
        private TextBox Groupin;
        private TextBox Varin;
        private Label Group;
        private Label Var;
        private Label label4;
        protected Button DOit;
        private TextBox Rivno;
        private Label RivnoOrNo;
    }
}

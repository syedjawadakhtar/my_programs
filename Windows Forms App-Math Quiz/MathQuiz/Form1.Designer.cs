namespace MathQuiz
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusSign = new Label();
            plusRightLabel = new Label();
            equalsSign = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label2 = new Label();
            minusRightLabel = new Label();
            minusSign = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            label6 = new Label();
            timesRightLabel = new Label();
            multiplicationSign = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            label3 = new Label();
            dividedRightLabel = new Label();
            divisionSign = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 10);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusLeftLabel.Location = new Point(50, 75);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            plusSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusSign.Location = new Point(131, 75);
            plusSign.Name = "plusSign";
            plusSign.Size = new Size(60, 50);
            plusSign.TabIndex = 3;
            plusSign.Text = "+";
            plusSign.TextAlign = ContentAlignment.MiddleCenter;
            plusSign.Click += label2_Click;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            plusRightLabel.Location = new Point(206, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalsSign
            // 
            equalsSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            equalsSign.Location = new Point(272, 75);
            equalsSign.Name = "equalsSign";
            equalsSign.Size = new Size(60, 50);
            equalsSign.TabIndex = 5;
            equalsSign.Text = "=";
            equalsSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location = new Point(329, 82);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            sum.ValueChanged += sum_ValueChanged;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location = new Point(332, 162);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            difference.ValueChanged += difference_ValueChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(275, 155);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 11;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusRightLabel.Location = new Point(209, 155);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 10;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusSign
            // 
            minusSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusSign.Location = new Point(134, 155);
            minusSign.Name = "minusSign";
            minusSign.Size = new Size(60, 50);
            minusSign.TabIndex = 9;
            minusSign.Text = "-";
            minusSign.TextAlign = ContentAlignment.MiddleCenter;
            minusSign.Click += label4_Click;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minusLeftLabel.Location = new Point(53, 155);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 8;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location = new Point(332, 232);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            product.ValueChanged += product_ValueChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(275, 225);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 16;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesRightLabel.Location = new Point(209, 225);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 15;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // multiplicationSign
            // 
            multiplicationSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            multiplicationSign.Location = new Point(134, 225);
            multiplicationSign.Name = "multiplicationSign";
            multiplicationSign.Size = new Size(60, 50);
            multiplicationSign.TabIndex = 14;
            multiplicationSign.Text = "×";
            multiplicationSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            timesLeftLabel.Location = new Point(53, 225);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 13;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location = new Point(332, 299);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            quotient.ValueChanged += quotient_ValueChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(275, 292);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 21;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedRightLabel.Location = new Point(206, 288);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 20;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divisionSign
            // 
            divisionSign.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            divisionSign.Location = new Point(134, 292);
            divisionSign.Name = "divisionSign";
            divisionSign.Size = new Size(60, 50);
            divisionSign.TabIndex = 19;
            divisionSign.Text = "÷";
            divisionSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dividedLeftLabel.Location = new Point(53, 292);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 18;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(172, 379);
            startButton.Name = "startButton";
            startButton.Size = new Size(136, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start the Quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 457);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label3);
            Controls.Add(dividedRightLabel);
            Controls.Add(divisionSign);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label6);
            Controls.Add(timesRightLabel);
            Controls.Add(multiplicationSign);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label2);
            Controls.Add(minusRightLabel);
            Controls.Add(minusSign);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(equalsSign);
            Controls.Add(plusRightLabel);
            Controls.Add(plusSign);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusSign;
        private Label plusRightLabel;
        private Label equalsSign;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label2;
        private Label minusRightLabel;
        private Label minusSign;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label label6;
        private Label timesRightLabel;
        private Label multiplicationSign;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label label3;
        private Label dividedRightLabel;
        private Label divisionSign;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}
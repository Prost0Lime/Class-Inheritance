/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18.03.2019
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Laba5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button9 = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 23);
			this.label5.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(172, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 23);
			this.label6.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(12, 207);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(245, 74);
			this.panel3.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(117, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 23);
			this.label3.TabIndex = 6;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Выбран объект:";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 35);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(98, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Площадь";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(3, 64);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(98, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "Площадь (В)";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(3, 93);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(98, 23);
			this.button6.TabIndex = 2;
			this.button6.Text = "Диагональ";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.CausesValidation = false;
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(3, 122);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(98, 23);
			this.button7.TabIndex = 3;
			this.button7.Text = "Объём";
			this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.label4.Location = new System.Drawing.Point(3, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Действия";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Location = new System.Drawing.Point(150, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(107, 161);
			this.panel2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(14, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Окружность";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(14, 93);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Прямоугольник";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(14, 122);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Параллелепипед";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Выбор объекта";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(14, 35);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(103, 23);
			this.button8.TabIndex = 5;
			this.button8.Text = "Точка";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(132, 189);
			this.panel1.TabIndex = 0;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(14, 151);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(103, 23);
			this.button9.TabIndex = 6;
			this.button9.Text = "Квадрат";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 293);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Наследование классов";
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button9;
		
		
	}
}

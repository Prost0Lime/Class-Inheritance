/*
 * Created by SharpDevelop.
 * User: user
 * Date: 18.03.2019
 * Time: 11:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Laba5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
			
		Dot Tod;
		Circle circ = new Circle(3);
		Rectangle rec = new Rectangle(6, 10);
		Parall pr = new Parall (3,4,7);
		Kvadrat kv = new Kvadrat (4);
		
		void Button8Click(object sender, EventArgs e)
		{
			Tod = new Dot();
			label3.Text ="Точка";
			button6.Enabled = false;
			button7.Enabled = false;
		}
																	
		void Button1Click(object sender, EventArgs e)			// Выбор Объекта
		{
			Tod = circ;
			label3.Text ="Окружность";
			button6.Enabled = false;
			button7.Enabled = false;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Tod = rec;
			label3.Text ="Прямоугольник";
			button6.Enabled = true;
			button7.Enabled = false;
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Tod = pr;
			label3.Text ="Параллелепипед";
			button6.Enabled = false;
			button7.Enabled = true;
		}
		void Button9Click(object sender, EventArgs e)
		{
			Tod = kv;
			label3.Text = "Квадрат";
			button6.Enabled = false;
			button7.Enabled = false;
		}
		
		void Button4Click(object sender, EventArgs e)			// Действия с объектом
		{														//Площадь (A)
			if (Tod is Parall){
				label5.Text = "Площадь Параллелепипида";
				label6.Text = ((Parall)Tod).getArea().ToString();
			}else if (Tod is Rectangle){
				label5.Text = "Площадь Прямоугольника";
				label6.Text = ((Rectangle)Tod).getArea().ToString();
			}else if (Tod is Circle){
				label5.Text = "Площадь Окружности";
				label6.Text = ((Circle)Tod).getArea().ToString();
			}else if (Tod is Kvadrat){
				label5.Text = "Площадь Квадрата";
				label6.Text = ((Kvadrat)Tod).getArea().ToString();
			}else if (Tod is Dot){
				label5.Text = "Площадь Точки";
				label6.Text = ((Dot)Tod).getArea().ToString();
			}else
				MessageBox.Show("Объект не выбран");	
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			
			try{
				label6.Text = Tod.getAreaVirtual().ToString();				//Площадь (В)
				
				if (Tod is Parall){
					label5.Text = "Площадь(B) Параллелепипида";
				}else  if (Tod is Rectangle){
					label5.Text = "Площадь(B) Прямоугольника";
				}else if (Tod is Circle){
					label5.Text = "Площадь(B) Окружности";
				}else if (Tod is Kvadrat){
					label5.Text = "Площадь(В) Квадрата";
				}else
					label5.Text = "Площадь(В) Точки";
				
			}catch(NullReferenceException){
				MessageBox.Show("Объект не выбран");
			}
			
		
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			label5.Text = "Диагональ";
			label6.Text = ((Rectangle)Tod).getDiagonal().ToString();
		}
		
		void Button7Click(object sender, EventArgs e)
		{	
			Tod = pr;
			label5.Text = "Объём параллелепипеда";
			label6.Text = ((Parall)Tod).getObem().ToString();}
		}
		
			
	}
	
	public class Dot{							// Базовый класс
		public double getArea(){ return 0;}
		public virtual double getAreaVirtual(){ return 0; }
	}											
												// Производные

	public class Rectangle:Dot{ 				// Прямоугольник
		private double sideA, sideB;
		
		public  Rectangle(double A, double B){ 
			sideA = A;
			sideB = B;
		}
		
		public new double getArea(){
			return sideA * sideB;
		}
		
		public override double getAreaVirtual(){
			return sideA * sideB;
		}
		
		public double getDiagonal(){
			return Math.Sqrt(sideA * sideA + sideB * sideB);
		}
		
	}
	public class Circle : Dot{					//Окружность
		protected double radius;
		
		public Circle(){
			radius = 1;
		}
		
		public Circle(double r){ 
			radius = r;
		}
		
		public new double getArea(){
			return Math.PI * radius * radius;
		}
		
		public override double getAreaVirtual(){
			return Math.PI * radius * radius;
		}
	}
												

		public class Parall : Dot{				//Параллелепипед 
		private double a, b, c;
		
		public double getA() { return a;}
		public double getB() { return b;}
		public double getC() { return c;}
		
		
		public Parall (double aa, double bb, double cc) {a = aa; b = bb; c = cc;}
	//	public Parall () {a = 3; b = 4; c = 5;}

		public new double getArea () {
			return 2*getC()*(getA()+getB());
		}
		public override double getAreaVirtual () {
			return 2*getC()*(getA()+getB());
		}
		public double getObem () {
			return getA()*getB()*getC();
		}
		}
												
												
		public class Kvadrat : Dot{				//Квадрат
		private double d; 
		
		public double getD() { return d;}
		
		public Kvadrat (double dd) {d = dd;}
		
		public new double getArea () {
			return getD()*getD();
		}
		public override double getAreaVirtual () {
			return getD()*getD();
		}
		
												
												}



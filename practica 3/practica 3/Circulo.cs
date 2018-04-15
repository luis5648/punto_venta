/*
 * Created by SharpDevelop.
 * User: Luis
 * Date: 15/03/2018
 * Time: 06:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica_3
{

	public partial class Circulo : Form
	{
		public Circulo()
		{

			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void button1_Click(object sender, EventArgs e)
		{
			
			float radio,centro;
			
			Graphics papel;
			papel = pictureBox1.CreateGraphics();
			Pen lapiz = new Pen(Color.Black);
			
			radio = Convert.ToSingle(this.textBox3.Text);
			centro = Convert.ToSingle(this.textBox1.Text);
			
			
			papel.DrawEllipse(lapiz,centro,centro,radio,radio);
			
		}
	}
}

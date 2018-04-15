/*
 * Created by SharpDevelop.
 * User: Luis
 * Date: 15/03/2018
 * Time: 06:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_3
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void button1_Click(object sender, EventArgs e)
		{
			Circulo c = new Circulo();
			this.Hide();
			c.Show();
		}
		void button2_Click(object sender, EventArgs e)
		{
			Precipitaciones p = new Precipitaciones();
			this.Hide();
			p.Show();
		}
		void button3_Click(object sender, EventArgs e)
		{
			Rostro r = new Rostro();
			this.Hide();
			r.Show();
		//muestra el siguiente formulario
		}
	}
}

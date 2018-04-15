/*
 * Created by SharpDevelop.
 * User: Luis
 * Date: 15/03/2018
 * Time: 06:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica_3
{
	/// <summary>
	/// Description of Precipitaciones.
	/// </summary>
	public partial class Precipitaciones : Form
	{
		public Precipitaciones()
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
	Graphics hoja;
            hoja = pictureBox1.CreateGraphics();
            Pen dibujo = new Pen(Color.Black);

            hoja.FillRectangle(new SolidBrush(Color.Indigo), 15, 15, 150, 40);
            hoja.FillRectangle(new SolidBrush(Color.Gray), 15, 75, 175, 40);
            hoja.FillRectangle(new SolidBrush(Color.Green), 15, 130, 120, 40);
            hoja.FillRectangle(new SolidBrush(Color.Black), 15, 185, 130, 40);
		}
	}
}

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
	/// Description of Rostro.
	/// </summary>
	public partial class Rostro : Form
	{
		public Rostro()
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
            Pen dib = new Pen(Color.Black);

            hoja.FillEllipse(new SolidBrush(Color.Indigo), 200, 65, 135, 170);
            hoja.DrawEllipse(dib, 255, 145, 20, 20);
            hoja.DrawEllipse(dib, 230, 125, 20, 20);
            hoja.DrawEllipse(dib, 280, 125, 20, 20);
            hoja.FillEllipse(new SolidBrush(Color.DarkOrange),190, 125, 10, 40);
            hoja.FillEllipse(new SolidBrush(Color.DarkOrange),335, 125, 10, 40);
            hoja.DrawLine(dib, 290, 200, 250, 200);
		}
	}
}

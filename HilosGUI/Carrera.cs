using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HilosGUI
{
    public partial class Carrera : Form
    {

        delegate void delega(PictureBox pic, int y, int veloz);
        
        public Carrera()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //EJECUTA VARIOS HILOS
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form2_Paint(object sender, PaintEventArgs e) 
        {
            
            // PINTADO DE LINEAS

            Pen p1= new Pen(Color.Black,8);//color negro, grosor linea 8

            Graphics p=CreateGraphics();

            //DIBUJAR LINEA UNO

            p.DrawLine(p1,new Point(20,100), new Point(570,100));

            p.DrawLine(p1, new Point(20, 200), new Point(570, 200));

            p.DrawLine(p1, new Point(20, 300), new Point(570, 300));
            

        }

        private void INICIAR_Click(object sender, EventArgs e)
        {
       
            INICIAR.Enabled=false;
            Thread[] hilos = new Thread[3];

            for(int i=0;i<hilos.Length;i++)
            {
                hilos[i]=new Thread(metodo);
                hilos[i].Name="H"+i;
                hilos[i].Start();
            }
            INICIAR.Enabled=true;
        }

        public void metodo()
        {
            delega d = new delega(mover);

            if (Thread.CurrentThread.Name.Equals("H2"))
            {

                d.Invoke(camaro, camaro.Location.Y, 30);

            }
            else if (Thread.CurrentThread.Name.Equals("H1"))
            {

                d.Invoke(mustan, mustan.Location.Y, 20);

            }
            else if (Thread.CurrentThread.Name.Equals("H0"))
            {

                d.Invoke(lombor, lombor.Location.Y, 10);
                
            }

        }
        public void mover(PictureBox pic,int y,int veloz)
        {
            for (int i = 25; i < 450; i++)
            {
                pic.Location = new Point(i, y);

                //CONTROL DE VELO+CIDAD

                if (Thread.CurrentThread.Name.Equals("H2"))
                {
                    Thread.Sleep(veloz);
                }
                else if (Thread.CurrentThread.Name.Equals("H1"))
                {
                    Thread.Sleep(veloz); 
                }
                else if (Thread.CurrentThread.Name.Equals("H0"))
                {

                    Thread.Sleep(veloz);

                }
            
            }



        }

        private void lombor_Click(object sender, EventArgs e)
        {

        }

        private void mustan_Click(object sender, EventArgs e)
        {

        }

        private void camaro_Click(object sender, EventArgs e)
        {

        }

        private void camaro_Click_1(object sender, EventArgs e)
        {

        }
    }
}



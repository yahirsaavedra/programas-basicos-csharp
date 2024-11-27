using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ProyectoFinal_U4
{
    public partial class AppFiguras : Form
    {
        private Thread estrella;
        private Thread triangulo;
        private Thread mueveEstrella;
        private Thread mueveTriangulo;
        private Graphics graphics;
        private bool dibujarEstrella;
        private bool dibujarTriangulo;
        private bool moverTriangulo;
        private bool moverEstrella;
        private delegate void m();
        private delegate void n();
        private Point[] puntosEstrella = new Point[] { new Point(200+150, 125+100), new Point(200+91, 125+69), new Point(200+102, 125+134),
                                                       new Point(200+54, 125+180), new Point(200+120, 125+190), new Point(200+149, 125+250),
                                                       new Point(200+179, 125+190), new Point(200+245, 125+180), new Point(200+197, 125+134),
                                                       new Point(200+208, 125+69)};
        private Point[] puntosTriangulo = new Point[] { new Point(250+375, 160), new Point(250+300, 310), new Point(250+450, 310) };

        public AppFiguras()
        {
            InitializeComponent();
            dibujarEstrella = false;
            dibujarTriangulo = false;
        }

        private void AppFiguras_Load(object sender, EventArgs e)
        {


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.Black);
            if (dibujarEstrella)
            {
                graphics.DrawPolygon(pen, puntosEstrella);
            }
            if (dibujarTriangulo)
            {
                graphics.DrawPolygon(pen, puntosTriangulo);
            }
        }

        private void hiloEstrella()
        {
            dibujarEstrella = true;
            Invalidate();
            Thread.Sleep(500);
        }

        private void hiloTriangulo()
        {
            dibujarTriangulo = true;
            Invalidate();
            Thread.Sleep(500);
        }

        private void movimientoEstrella()
        {
            while (moverEstrella)
            {
                double angulo = DateTime.Now.Ticks / 10000000.0; // Ángulo actual del movimiento

                int centroX = 100; // Posición X del centro del círculo
                int centroY = 400; // Posición Y del centro del círculo
                int radio = 3; // Radio del círculo

                int x = centroX + (int)(radio * Math.Cos(angulo)); // Cálculo de la posición X en el círculo
                int y = centroY + (int)(radio * Math.Sin(angulo)); // Cálculo de la posición Y en el círculo

                try
                {
                    this.Invoke(new m(() =>
                    {
                        // Actualizar las coordenadas de los puntos de la estrella
                        for (int i = 0; i < puntosEstrella.Length; i++)
                        {
                            puntosEstrella[i].X = x + puntosEstrella[i].X - centroX;
                            puntosEstrella[i].Y = y + puntosEstrella[i].Y - centroY;
                        }

                        this.Invalidate();
                    }));
                } catch (Exception e) { };

                Thread.Sleep(10);
            }
        }

        private void movimientoTriangulo()
        {
            while (moverTriangulo)
            {
                double x = Math.Sin(DateTime.Now.Ticks / 3000000.0) * 100 + 150;
                double y = Math.Cos(DateTime.Now.Ticks / 7000000.0) * 100 + 150;

                double xOffset = Math.Sin(DateTime.Now.Ticks / 3000000.0) * 50;
                double yOffset = Math.Cos(DateTime.Now.Ticks / 7000000.0) * 50;

                try
                {
                    this.Invoke(new n(() =>
                    {
                        puntosTriangulo[0] = new Point((int)(220 + 300 + xOffset), (int)(310 + yOffset));
                        puntosTriangulo[1] = new Point((int)(220 + 450 + xOffset), (int)(310 + yOffset));
                        puntosTriangulo[2] = new Point((int)(220 + 375 + xOffset), (int)(160 + yOffset));

                        this.Invalidate();
                    }));
                } catch (Exception e) { };


                Thread.Sleep(10);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            if (!dibujarEstrella)
            {
                estrella = new Thread(hiloEstrella);
                estrella.Start();
            }
            estrella.Join();
            if (!dibujarTriangulo)
            {
                triangulo = new Thread(hiloTriangulo);
                triangulo.Start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mueveEstrella = new Thread(movimientoEstrella);
            mueveTriangulo = new Thread(movimientoTriangulo);
            dibujarEstrella = false;
            dibujarTriangulo = false;
            moverEstrella = false;
            moverTriangulo = false;
            mueveEstrella.Abort();
            mueveTriangulo.Abort();
            Invalidate();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            mueveEstrella = new Thread(movimientoEstrella);
            mueveTriangulo = new Thread(movimientoTriangulo);
            moverEstrella = true;
            moverTriangulo = true;
            mueveEstrella.Start();
            mueveTriangulo.Start();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            mueveEstrella = new Thread(movimientoEstrella);
            mueveTriangulo = new Thread(movimientoTriangulo);
            moverEstrella = false;
            moverTriangulo = false;
            mueveEstrella.Abort();
            mueveTriangulo.Abort();
            Application.Exit();
        }
    }
}


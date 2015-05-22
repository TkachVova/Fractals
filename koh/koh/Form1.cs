using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koh
{
    public partial class Form1 : Form
    {
        
        static Pen pen1;
        static Graphics g;
        static Pen pen2;
        

        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Text = "5";
            maskedTextBox2.Text = "5";
            maskedTextBox3.Text = "15";
            maskedTextBox4.Text = "1.0";
            maskedTextBox5.Text = "-1.0";
            maskedTextBox6.Text = "-1.0";
        }
  
        private void DrawKoh(object sender, EventArgs e)
        {
            //Выбираем цвета зарисовки 
            pen1 = new Pen(Color.Green, 1); 
            pen2 = new Pen(Color.Green, 1);
            //Объявляем объект "g" класса Graphics
            g = CreateGraphics();
            g.Clear(Color.Black);//Зарисовка экрана черным фоном
 
            //Определим коорднаты исходного треугольника
            var point1 = new PointF(200, 200);
            var point2 = new PointF(500, 200);
            var point3 = new PointF(350, 400);

            //Зарисуем треугольник
            g.DrawLine(pen1, point1, point2);
            g.DrawLine(pen1, point2, point3);
            g.DrawLine(pen1, point3, point1);

            int numberOfIter = int.Parse(maskedTextBox1.Text);
            //Вызываем функцию Fractal для того, чтобы
            //нарисовать три кривых Коха на сторонах треугольника
            KohFractal(point1, point2, point3, numberOfIter);
            KohFractal(point2, point3, point1, numberOfIter);
            KohFractal(point3, point1, point2, numberOfIter);
           }


        //рекурсивная функция рисования кривой Коха
        static int KohFractal(PointF p1, PointF p2, PointF p3, int iter)
        {
            //n -количество итераций
            if (iter > 0)  //условие выхода из рекурсии
            {
                //средняя треть отрезка
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                //координаты вершины угла
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                //рисуем его
                g.DrawLine(pen1, p4, pn);
                g.DrawLine(pen1, p5, pn);
                g.DrawLine(pen2, p4, p5);

      
                //рекурсивно вызываем функцию нужное число раз
                KohFractal(p4, pn, p5, iter - 1);
                KohFractal(pn, p5, p4, iter - 1);
                KohFractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1);
                KohFractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1);

            }
            return iter;
        }


        static void DrawTriangle(int level, PointF top, PointF left, PointF right)
        {
            //проверяем, закончили ли мы построение
            if (level == 0)
            {
                PointF[] points = new PointF[3]
                {
                    top, right, left
                };
                //рисуем фиолетовый треугольник
                g.FillPolygon(Brushes.Green, points);

                //g.DrawLine(pen1, left, top);
                //g.DrawLine(pen1, top, right);
                //g.DrawLine(pen1, left, right);
            }
            else
            {
                //вычисляем среднюю точку
                var leftMid = MidPoint(top, left); //левая сторона
                var rightMid = MidPoint(top, right); //правая сторона
                var topMid = MidPoint(left, right); // основание
                //рекурсивно вызываем функцию для каждого и 3 треугольников
                DrawTriangle(level - 1, top, leftMid, rightMid);
                DrawTriangle(level - 1, leftMid, left, topMid);
                DrawTriangle(level - 1, rightMid, topMid, right);
            }
        }

        //функция вычисления координат средней точки
        static PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2f, (p1.Y + p2.Y) / 2f);
        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            pen1 = new Pen(Color.Green, 1);
            g = CreateGraphics();
            g.Clear(Color.Black);//Зарисовка экрана черным фоном
            PointF topPoint = new PointF(400/2 + 100, 50);
            PointF leftPoint = new PointF(0 + 100, 450);
            PointF rightPoint = new PointF(400 + 100, 450);
            //вызываем функцию отрисовки
            DrawTriangle(int.Parse(maskedTextBox2.Text), topPoint, leftPoint, rightPoint);
        }

        private void mendelbrotButton_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Black);//Зарисовка экрана черным фоном
            Bitmap image = Mendelbort.createImage(double.Parse(maskedTextBox4.Text), double.Parse(maskedTextBox5.Text), double.Parse(maskedTextBox5.Text), int.Parse(maskedTextBox3.Text));
            g.DrawImage(image, 140, 50);
        }



    }
}

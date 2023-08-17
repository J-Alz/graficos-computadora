using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra;

namespace CC
{
    internal class Fuerzas: Vector
    {
        Color color = Color.Red;
        public Fuerzas()
        {
            Graphics g = Graphics.FromImage(Bmp);
            g.DrawImageUnscaled(new Segmento(-0.8, 0, 0, 0.6).Bmp,0,0);
            g.DrawImageUnscaled(new Segmento(-0.8, 0, 0, -0.6).Bmp, 0, 0);
            g.DrawImageUnscaled(new Segmento(-0, 0.6, 0, -0.6).Bmp, 0, 0);

            g.DrawImageUnscaled(new Segmento(6.8, 0, 6, 0.6).Bmp, 0, 0);
            g.DrawImageUnscaled(new Segmento(6.8, 0, 6, -0.6).Bmp, 0, 0);
            g.DrawImageUnscaled(new Segmento(6, 0.6, 6, -0.6).Bmp, 0, 0);
        }
        //double m = 0.7; //masa
        //double g = -3.8; // gravedad
        //double k = 1.0; //elasticidad
        //double l = 14; //longitud
        public Fuerzas e(double n)
        {          
            Graphics gr = Graphics.FromImage(Bmp);

            Matrix<double> a = DenseMatrix.OfArray(crearMatrixA((int)n));
            Vector<double> benY = DenseVector.OfArray(crearVectorB((int)n));
            Vector<double> benX = DenseVector.OfArray(crearVectorBenX((int)n));

            const double m = 1;
            const double k = 15;

            double posXInitial = 0;
            double posYInitial = 0;

            const double mgk = m * 9.8 / k;

            var x = a.Solve(benX);
            var y = a.Solve(benY);

            for (var i = 0; i < x.Count; i++)
            {
                var posXFinal = x[i];
                var posYFinal = y[i] * mgk;
                gr.DrawImageUnscaled(new Segmento(posXInitial, posYInitial, posXFinal, posYFinal).Bmp,0,0);
                gr.DrawImageUnscaled(new Figura().Circulo(Color.Red, 0.1, x[i], y[i] * mgk).Bmp, 0, 0);

                posXInitial = posXFinal;
                posYInitial = posYFinal;
            }

            gr.DrawImageUnscaled(new Segmento(posXInitial, posYInitial, 6, 0).Bmp,0,0);

            return this;
        }
        public static double[,] crearMatrixA(int n)
        {
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = -2;
                    }
                    else if (Math.Abs(i - j) == 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        public static double[] crearVectorBenX(int n)
        {
            double[] vector = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (i == (n - 1))
                {
                    vector[i] = -6;
                }
                else
                {
                    vector[i] = 0;
                }

            }

            return vector;
        }

        public static double[] crearVectorB(int n)
        {
            double[] vector = new double[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = 1;
            }

            return vector;
        }
    }
}

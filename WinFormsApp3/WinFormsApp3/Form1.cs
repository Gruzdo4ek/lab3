using System.Numerics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private double x1, y1, z1, x2, y2, z2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!TryParseValues())
                return;

            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            Vector sum = vector1 + vector2;
            rez1.Text = $"{sum}";
        }

        private void button_subract_Click(object sender, EventArgs e)
        {
            if (!TryParseValues())
                return;

            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            Vector difference = vector1 - vector2;
            rez1.Text = $"{difference}";

        }

        private void button_scalar_Click(object sender, EventArgs e)
        {
            if (!TryParseValues())
                return;

            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            double scalarProduct = vector1 * vector2;
            rez1.Text = $"{scalarProduct}";
        }

        private void button_vector_Click(object sender, EventArgs e)
        {
            if (!TryParseValues())
                return;

            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            Vector vectorProduct = vector1 ^ vector2;
            rez1.Text = $"{vectorProduct}";
        }

        private void button_size_Click(object sender, EventArgs e)
        {
            if (!TryParseValues())
                return;

            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            double size1 = vector1.Size();
            double size2 = vector2.Size();

            rez1.Text = $"Длина 1: {size1:F2}";
            rez2.Text = $"Длина 2: {size2:F2}";
        }
        private bool TryParseValues()
        {
            if (!double.TryParse(this.x1Box.Text, out x1) ||
                !double.TryParse(this.y1Box.Text, out y1) ||
                !double.TryParse(this.z1Box.Text, out z1) ||
                !double.TryParse(this.x2Box.Text, out x2) ||
                !double.TryParse(this.y2Box.Text, out y2) ||
                !double.TryParse(this.z2Box.Text, out z2))
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rez2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Vector
    {
        private double[] components;

        public double X => components[0];
        public double Y => components[1];
        public double Z => components[2];

        public Vector(double X, double Y, double Z)
        {
            components = new double[] { X, Y, Z };
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        public static Vector operator +(Vector v1, Vector v2)
        {
            double[] result = new double[v1.components.Length];
            for (int i = 0; i < v1.components.Length; i++)
            {
                result[i] = v1.components[i] + v2.components[i];
            }

            return new Vector(result[0], result[1], result[2]);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            double[] result = new double[v1.components.Length];
            for (int i = 0; i < v1.components.Length; i++)
            {
                result[i] = v1.components[i] - v2.components[i];
            }
            return new Vector(result[0], result[1], result[2]);
        }

        public static double operator *(Vector v1, Vector v2)
        {
            double result = 0;
            for (int i = 0; i < v1.components.Length; i++)
            {
                result += v1.components[i] * v2.components[i];
            }
            return result;
        }

        public double Size()
        {
            double sum = 0;
            foreach (double component in components)
            {
                sum += component * component;
            }
            return Math.Sqrt(sum);
        }

        public static Vector operator ^(Vector v1, Vector v2)
        {
            double[] result = new double[3];
            result[0] = v1.components[1] * v2.components[2] - v1.components[2] * v2.components[1];
            result[1] = v1.components[2] * v2.components[0] - v1.components[0] * v2.components[2];
            result[2] = v1.components[0] * v2.components[1] - v1.components[1] * v2.components[0];

            return new Vector(result[0], result[1], result[2]);
        }

    }
}
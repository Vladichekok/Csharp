using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace WindowsFormsApp2Kyrsach
{
    public partial class Form1 : Form
    {
        private int arraySize1 = 0;
        private int arraySize2 = 0;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1 = new Panel();
            panel1.Location = new Point(10, 10);
            panel1.Size = new Size(400, 200);
            this.Controls.Add(panel1);

            panel2 = new Panel();
            panel2.Location = new Point(panel1.Right + 10, panel1.Top);
            panel2.Size = new Size(400, 200);
            this.Controls.Add(panel2);

            panel3 = new Panel();
            panel3.Location = new Point(panel1.Left, Math.Max(panel1.Bottom, panel2.Bottom) + 10);
            panel3.Size = new Size(panel2.Right - panel1.Left, 600);
            this.Controls.Add(panel3);

            CreateArray(panel1, arraySize1);
            CreateArray(panel2, arraySize2);
        }

        private void CreateArray(Panel panel, int arraySize)
        {
            panel.Controls.Clear();
            int counter = 0;
            TextBox[] ArrayNodes = new TextBox[arraySize * arraySize];
            int squareSize = 30;

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    var tb = new TextBox();
                    tb.Location = new Point(5 + (j * (squareSize + 2)), 30 + (i * (squareSize + 2)));
                    tb.Name = string.Format("Node_{0}{1}", i, j);
                    tb.Visible = true;
                    tb.Width = squareSize;
                    tb.Height = squareSize;
                    panel.Controls.Add(tb);
                    ArrayNodes[counter] = tb;
                    counter++;
                }
            }
        }

        private void button1_plus_Click(object sender, EventArgs e)
        {
            arraySize1++;
            CreateArray(panel1, arraySize1);
        }

        private void button2_minus_Click(object sender, EventArgs e)
        {
            if (arraySize1 > 0)
            {
                arraySize1--;
                CreateArray(panel1, arraySize1);
            }
        }

        private void button3_plus_Click(object sender, EventArgs e)
        {
            arraySize2++;
            CreateArray(panel2, arraySize2);
        }

        private void button4_minus_Click(object sender, EventArgs e)
        {
            if (arraySize2 > 0)
            {
                arraySize2--;
                CreateArray(panel2, arraySize2);
            }
        }

        private void button5_1_plus_2_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromPanel(panel1, arraySize1);
            int[,] matrix2 = GetMatrixFromPanel(panel2, arraySize2);
            int[,] resultMatrix = AddMatrices(matrix1, matrix2);
            CreateArray(panel3, resultMatrix.GetLength(0));
            FillPanelWithMatrix(panel3, resultMatrix);
        }

        private int[,] GetMatrixFromPanel(Panel panel, int arraySize)
        {
            int[,] matrix = new int[arraySize, arraySize];
            int counter = 0;

            foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
            {
                int row = counter / arraySize;
                int col = counter % arraySize;
                matrix[row, col] = int.Parse(textBox.Text);
                counter++;
            }

            return matrix;
        }

        private void FillPanelWithMatrix(Panel panel, int[,] matrix)
        {
            int arraySize = matrix.GetLength(0);
            int counter = 0;

            foreach (TextBox textBox in panel.Controls.OfType<TextBox>())
            {
                int row = counter / arraySize;
                int col = counter % arraySize;
                textBox.Text = matrix[row, col].ToString();
                counter++;
            }
        }

        private int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (rows1 != rows2 || cols1 != cols2)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int[,] resultMatrix = new int[rows1, cols1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        private void button6_1_minus_2_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromPanel(panel1, arraySize1);
            int[,] matrix2 = GetMatrixFromPanel(panel2, arraySize2);
            int[,] resultMatrix = SubtractMatrices(matrix1, matrix2);
            CreateArray(panel3, resultMatrix.GetLength(0));
            FillPanelWithMatrix(panel3, resultMatrix);
        }

        private int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (rows1 != rows2 || cols1 != cols2)
            {
                throw new ArgumentException("Matrices must have the same dimensions.");
            }

            int[,] resultMatrix = new int[rows1, cols1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        private void button7_1_multiply_2_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromPanel(panel1, arraySize1);
            int[,] matrix2 = GetMatrixFromPanel(panel2, arraySize2);
            int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
            CreateArray(panel3, resultMatrix.GetLength(0));
            FillPanelWithMatrix(panel3, resultMatrix);
        }

        private int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);

            int[,] resultMatrix = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            return resultMatrix;
        }
        private void button8_rank_1_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromPanel(panel1, arraySize1);
            Matrix<double> mathNetMatrix1 = ConvertToMathNetMatrix(matrix1);
            int rank = mathNetMatrix1.Rank();
            MessageBox.Show($"Rank of Matrix 1: {rank}");
        }

        private void button9_rank_2_Click(object sender, EventArgs e)
        {
            int[,] matrix2 = GetMatrixFromPanel(panel2, arraySize2);
            Matrix<double> mathNetMatrix2 = ConvertToMathNetMatrix(matrix2);
            int rank = mathNetMatrix2.Rank();
            MessageBox.Show($"Rank of Matrix 2: {rank}");
        }

        private Matrix<double> ConvertToMathNetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] values = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    values[i, j] = (double)matrix[i, j];
                }
            }

            return Matrix<double>.Build.DenseOfArray(values);
        }

        private void button10_transpon_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromPanel(panel1, arraySize1);
            Matrix<double> mathNetMatrix1 = ConvertToMathNetMatrix(matrix1);
            Matrix<double> transposedMatrix1 = mathNetMatrix1.Transpose();
            int[,] resultMatrix1 = ConvertTo2DArray(transposedMatrix1);
            CreateArray(panel1, resultMatrix1.GetLength(0));
            FillPanelWithMatrix(panel1, resultMatrix1);
        }
        private void button11_transpon_Click(object sender, EventArgs e)
        {
            int[,] matrix2 = GetMatrixFromPanel(panel2, arraySize2);
            Matrix<double> mathNetMatrix2 = ConvertToMathNetMatrix(matrix2);
            Matrix<double> transposedMatrix2 = mathNetMatrix2.Transpose();
            int[,] resultMatrix2 = ConvertTo2DArray(transposedMatrix2);
            CreateArray(panel2, resultMatrix2.GetLength(0));
            FillPanelWithMatrix(panel2, resultMatrix2);
        }
        private int[,] ConvertTo2DArray(Matrix<double> matrix)
        {
            int rows = matrix.RowCount;
            int cols = matrix.ColumnCount;
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = (int)matrix[i, j];
                }
            }
            return result;
        }

        private void button12_Opr_1_Click(object sender, EventArgs e)
        {
            int[,] matrix1 = GetMatrixFromPanel(panel1, arraySize1);
            Matrix<double> mathNetMatrix1 = ConvertToMathNetMatrix(matrix1);
            double determinant1 = mathNetMatrix1.Determinant();
            MessageBox.Show($"Determinant of Matrix 1: {determinant1}");
        }

        private void button13_Opr_2_Click(object sender, EventArgs e)
        {
            int[,] matrix2 = GetMatrixFromPanel(panel2, arraySize2);
            Matrix<double> mathNetMatrix2 = ConvertToMathNetMatrix(matrix2);
            double determinant2 = mathNetMatrix2.Determinant();
            MessageBox.Show($"Determinant of Matrix 2: {determinant2}");
        }
    }
}
Задание №2

namespace SquareMatrix.Sort.SpiralOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(100);
                }
            }

            Console.WriteLine("Получилась следующая матрица: ");
            matrixOutput(n, matrix);

            // создаем массив
            int[] ar = GetArray(matrix);
            Console.WriteLine("Получился такой массив:");
            arrayOutput(ar);

            // сортируем массив
            Array.Sort(ar);
            Array.Reverse(ar);
            Console.WriteLine("После сортировки:");
            arrayOutput(ar);

            // преобразуем матрицу
            matrix = SpiralConvertion(ar);

            Console.WriteLine("Результат: ");
            matrixOutput(n, matrix);
            Console.ReadKey();
        }

        public static void matrixOutput(int n, int[,] mx)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0, 4}", mx[i, j].ToString()));
                }
                Console.WriteLine();
            }
        }

        public static void arrayOutput(int[] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                Console.Write(ar[i].ToString() + ", ");
            }

            Console.Write(ar[ar.Length - 1].ToString());
            Console.WriteLine();
        }

        public static int[] GetArray(int[,] mx)
        {
            int k = 0;
            int[] ar = new int[mx.Length];

            for (int i = 0; i < mx.GetLength(0); i++)
            {
                for (int j = 0; j < mx.GetLength(1); j++)
                {
                    ar[k++] = mx[i, j];
                }
            }

            return ar;
        }

        public static int[,] SpiralConvertion(int[] arr)
        {
            var n = (int)Math.Sqrt(arr.Length);
            var matrix = new int[n, n];

            int m = n / 2 + n % 2,
                len = n,
                count = 0;

            for (int i = 0; i < m; i++)
            {
                // Верх
                for (int j = 0; j < len; j++)
                {
                    matrix[i, i + j] = arr[count++];
                }

                // Право
                for (int j = 1; j < len; j++)
                {
                    matrix[i + j, n - i - 1] = arr[count++];
                }

                len -= 2;
                // Низ
                for (int j = len; j >= 0; j--)
                {

                    matrix[n - i - 1, i + j] = arr[count++];
                }

                // Лево
                for (int j = len; j >= 1; j--)
                {
                    matrix[i + j, i] = arr[count++];
                }
            }

            return matrix;
        }
    }
}

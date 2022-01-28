using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Five();
            Console.ReadKey();
        }
        static void One()
        {
            int z = 1, x = 3, c = 4;
            Console.WriteLine("Дан вектор X длины 3 с элементами: ");
            Console.WriteLine("x" + 1.ToString() + " = " + z);
            Console.WriteLine("x" + 2.ToString() + " = " + x);
            Console.WriteLine("x" + 3.ToString() + " = " + c);
        }
        static void Two()
        {
            int[] arr = new int[3]
            {
                1,3,4
            };
            Console.WriteLine("Дан вектор X длины 3 с элементами: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("x" + (i + 1).ToString() + " = " + arr[i].ToString());
            }
        }
        static void Three()
        {
            Random random = new Random();
            int[] arr1 = new int[3];
            for(int i=0;i < arr1.Length; i++)
            {
                arr1[i] = random.Next();
            }
            Console.WriteLine("Дан вектор X длины 3 с элементами: ");
            for(int i = 0; i < arr1.Length ; i++)
            {
                Console.WriteLine("x" + (i + 1).ToString() + " = " + arr1[i].ToString());
            }
        }
        static void Four()
        {
            Random random = new Random();
            Random zxc = new Random();
            int[] arr1 = new int[3];
            arr1[1] = random.Next();
            arr1[2] = random.Next();
            arr1[0] = random.Next();
            Console.WriteLine("Дан вектор X длины 3 с элементами: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("x" + (i + 1).ToString() + " = " + arr1[i].ToString());
            }
        }
        static void Five()
        {
            int[] arr = new int[3];
            Random random = new Random();
            var array = new int[3];
            //-----------------------
            array[0] = random.Next(0, 2);
            int x = 1;
            while (x < 3)
            {
                bool z = false;
                array[x] = random.Next(0, 3);
                for(int j = 0; j < x; j++)
                {
                    if (array[x] == array[j])
                    {
                        z = true;
                        break;
                    }
                }
                if (z)
                {
                    array[x] = random.Next(0, 2);
                }
                else
                {
                    x++;
                }
            }
            //-----------------------
            Console.WriteLine("Дан вектор X длины 3 с элементами: ");
            for (int i = 0; i < arr.Length; i++)
            {
                var index = array[i];
                arr[index] = random.Next(20);
                Console.WriteLine("x" + (index + 1).ToString() + " = " + arr[index].ToString());
            }
            
        }
        static void Six(int N)
        {
            int[] vectorX = new int[N];
            Random random = new Random();
            for(int i = 0; i < N; i++)
            {
                vectorX[i] = random.Next(0, 20);
            }
            Console.WriteLine($"Дан вектор X длины {N} с элементами: ");
            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine("x_" + i.ToString() + " = " + vectorX[i].ToString());
            }
        }
        static void Seven(int N)
        {
            int[] vectorX = new int[N];
            int[] vectorY = new int[N];
            int[] vectorZ = new int[N];
            Random random = new Random();
            for(int i = 0; i < N; i++)
            {
                vectorX[i] = random.Next(0, 20);
                vectorY[i] = random.Next(0, 20);
            }
            for(int i = 0; i < N; i++)
            {
                vectorZ[i] = vectorX[i] * vectorY[i];
            }
            Console.WriteLine($"Вектор Z длины {N} с элементами:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("z_" + i.ToString() + " = " + vectorZ[i].ToString());
            }
        }
        static void Eight(int N)
        {
            int[] vectorX = new int[N];
            int[] vectorY = new int[N];
            int[] vectorZ = new int[N];
            int s = 0;
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                vectorX[i] = random.Next(0, 20);
                vectorY[i] = random.Next(0, 20);
            }
            for (int i = 0; i < N; i++)
            {
                vectorZ[i] = vectorX[i] * vectorY[i];
            }
            for (int i = 0; i < N; i++) 
            {
                s += vectorZ[i];
            }
            Console.WriteLine($"Скалярное произведение векторов X и Y: {s}");
        }
    }
}

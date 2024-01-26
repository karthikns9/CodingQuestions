namespace Patterns
{
    public class Program
    {
        
        //* * * * * *
        //* * * * * *
        //* * * * * *
        //* * * * * *
        //* * * * * *
        //* * * * * *
        public static void Pattern1(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //* 
        //* * 
        //* * *
        //* * * *
        //* * * * *
        public static void Pattern2(int n)
        {
            for (int i = 1; i <=  n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //1
        //1 2
        //1 2 3
        //1 2 3 4
        //1 2 3 4 5
        public static void Pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        //1
        //2 2
        //3 3 3
        //4 4 4 4
        //5 5 5 5 5
        public static void Pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        //*****
        //****
        //***
        //**
        //*
        public static void Pattern5(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n-row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //12345
        //1234
        //123
        //12
        //1
        public static void Pattern6(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
        }

        //     *     
        //    ***    
        //   *****   
        //  *******  
        // ********* 
        //***********
        public static void Pattern7(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col < (2*n); col++)
                {
                    if (n - row <= col && n + row >= col)
                    {
                       Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            // alternate approach
            //for (int i = 0; i < N; i++)
            //{
            //    // For printing the spaces before stars in each row
            //    for (int j = 0; j < N - i - 1; j++)
            //    {
            //        cout << " ";
            //    }

            //    // For printing the stars in each row
            //    for (int j = 0; j < 2 * i + 1; j++)
            //    {

            //        cout << "*";
            //    }

            //    // For printing the spaces after the stars in each row
            //    for (int j = 0; j < N - i - 1; j++)
            //    {
            //        cout << " ";
            //    }
        }

        //***********
        // *********
        //  *******
        //   ***** 
        //    ***    
        //     *
        public static void Pattern8(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Print leading spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print '*' characters
                for (int k = 0; k < 2 * n - (2 * i + 1); k++)
                {
                    Console.Write("*");
                }

                // Print trailing spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }

        //*
        //* *
        //* * *
        //* * * *
        //* * * * *
        //* * * *
        //* * *
        //* *
        //*
        public static void Pattern9(int n)
        {
            int totalRows = 2 * n - 1;
            for (int i = 1; i <= totalRows; i++)
            {
                if(i <= n)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for (int j = 1; j <= 2 * n - i; j++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }

        //1
        //01
        //101
        //0101
        //10101
        public static void Pattern10(int n)
        {
            int startNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    startNumber = 0;
                }
                else
                {
                    startNumber = 1;
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(startNumber);
                    startNumber = 1 - startNumber;
                }
                Console.WriteLine();
            }
        }

        //1       1
        //1 2     2 1
        //1 2 3   3 2 1
        //1 2 3 4 4 3 2 1
        public static void Pattern11(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                for (int j = 1; j <= 2 * (n-1); j++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        //1
        //2 3
        //4 5 6
        //7 8 9 10
        //11 12 13 14 15
        public static void Pattern12(int n)
        {
            int start = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(start + " ");
                    start++;
                }
                Console.WriteLine();
            }
        }

        //A
        //A B
        //A B C
        //A B C D
        //A B C D E
        public static void Pattern13(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (char j = 'A'; j <= 'A' + i -1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        //A B C D E
        //A B C D
        //A B C
        //A B
        //A
        public static void Pattern14(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (char j = 'A'; j <= 'A' + n - i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        //A
        //BB
        //CCC
        //DDDD
        //EEEEE
        public static void Pattern15(int n)
        {
            char startChar = 'A';
            for (int i = 1; i <= n; i++)
            {
                for (char j = 'A'; j <= 'A' + i -1; j++)
                {
                    Console.Write(startChar);
                }
                startChar++;
                Console.WriteLine();
            }
        }

        //E
        //D E
        //C D E
        //B C D E
        //A B C D E
        public static void Pattern16(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (char j = (char)('E' - i + 1); j <= 'E'; j++)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
        }


        //**********
        //****  ****
        //***    ***
        //**      **
        //*        *
        //*        *
        //**      **
        //***    ***
        //****  ****
        //**********
        public static void Pattern17(int n)
        {
            int spaces = 0;
            for (int i = 1; i <= n; i++)
            {

                //begining starts
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");
                }

                //spaces
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                //ending starts
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");
                }

                spaces += 2;
                Console.WriteLine();
            }

            spaces = 2 * n - 2;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                spaces -= 2;
                Console.WriteLine();
            }
        }

        //*        *
        //**      **
        //***    ***
        //****  ****
        //**********
        //****  ****
        //***    ***
        //**      **
        //*        *
        public static void Pattern18(int n)
        {
            int spaces = 2 * n - 2;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                spaces += -2;
                Console.WriteLine();
            }

            spaces = 2;
            for (int i = 1; i <= n-1; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("*");
                }
                spaces += 2;
                Console.WriteLine();
            }

            // initialising the spaces.
            //int spaces = 2 * n - 2;

            //// Outer loop for printing row.
            //for (int i = 1; i <= 2 * n - 1; i++)
            //{

            //    // stars for first half
            //    int stars = i;

            //    // stars for the second half.
            //    if (i > n) stars = 2 * n - i;

            //    //for printing the stars
            //    for (int j = 1; j <= stars; j++)
            //    {
            //        cout << "*";
            //    }

            //    //for printing the spaces
            //    for (int j = 1; j <= spaces; j++)
            //    {
            //        cout << " ";
            //    }

            //    //for printing the stars
            //    for (int j = 1; j <= stars; j++)
            //    {
            //        cout << "*";
            //    }

            //    // As soon as the stars for each iteration are printed, we move to the
            //    // next row and give a line break otherwise all stars
            //    // would get printed in 1 line.
            //    cout << endl;
            //    if (i < n) spaces -= 2;
            //    else spaces += 2;
            //}
        }

        //****
        //*  *
        //*  *
        //****
        public static void Pattern19(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();

            }
        }

        static void Main(string[] args)
        {
            Pattern19(4);
        }
    }
}

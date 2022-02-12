namespace TicTacToe
{
    class Board 
    {
        private string VerticalLine = "|";
        private string horizontalLines = "---";
        private string crossSign = "+";
        private int cells = 9;
        private int cellIndex = 1;

        public Board () 
        {
            while (cellIndex <= cells)
            {
                // Print one cell per iteration
                Console.Write($" {cellIndex} ");
                if (18 % cellIndex != 0 || cellIndex < 3) Console.Write($"{VerticalLine}");

                switch (cellIndex)
                {
                    case 3:
                    case 6:
                    Console.WriteLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(horizontalLines);
                        if (i != 2) Console.Write(crossSign); // Don't print at last cell
                    }
                    Console.WriteLine();
                    break;
                }
                cellIndex++;
            }
            Console.WriteLine();
        }
    }
}
using System.Text;

public class Pattern
{
    public void printPattern1(int rows, int cols = -1)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }

        if (cols <= 0)
        {
            cols = rows;
        }

        StringBuilder outputBuilder = new StringBuilder();

        for (int i = 0; i < rows; i++)
        {
            outputBuilder.Clear();

            for (int j = 0; j < cols; j++)
            {
                outputBuilder.Append("*");
            }

            Console.WriteLine(outputBuilder.ToString());
        }
    }

    public void printPattern2(int rows)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }
        StringBuilder builder = new();

        for (int i = 1; i <= rows; i++)
        {
            builder.Clear();
            for (int j = 0; j < i; j++)
            {
                builder.Append("*");
            }
            Console.WriteLine(builder.ToString());
        }
    }

    public void printPattern3(int rows)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }
        StringBuilder builder = new();

        for (int i = 1; i <= rows; i++)
        {
            builder.Clear();
            for (int j = 1; j < i + 1; j++)
            {
                builder.Append(j);
            }
            Console.WriteLine(builder.ToString());
        }
    }

    public void printPattern4(int rows)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }
        StringBuilder builder = new();

        for (int i = 1; i <= rows; i++)
        {
            builder.Clear();
            for (int j = 0; j < i; j++)
            {
                builder.Append(i);
            }
            Console.WriteLine(builder.ToString());
        }
    }

    public void printPattern5(int rows)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }
        StringBuilder builder = new();

        for (int i = rows; i > 0; i--)
        {
            builder.Clear();
            for (int j = 0; j < i; j++)
            {
                builder.Append("*");
            }
            Console.WriteLine(builder.ToString());
        }
    }


    public void printPattern6(int rows)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }
        StringBuilder builder = new();

        for (int i = rows; i > 0; i--)
        {
            builder.Clear();
            for (int j = 1; j < i + 1; j++)
            {
                builder.Append(j);
            }
            Console.WriteLine(builder.ToString());
        }
    }


    public void printPattern7(int rows)
    {
        if (rows <= 0)
        {
            throw new ArgumentException("Invalid number of rows. Rows must be greater than 0.");
        }
        for (int i = 0; i < rows; i++)
        {
            // Print leading spaces
            for (int j = 0; j < rows - i - 1; j++)
            {
                Console.Write("");
            }

            // Print asterisks
            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("");
            }

            for (int j = 0; j < rows - i - 1; j++)
            {
                Console.Write("0");
            }

            // Move to the next line
            Console.WriteLine();
        }
    }

    public void printPattern8(int rows){
        for (int i = 0; i < rows; i++)
        {
            
            // Print asterisks
            for (int k = 2 * i + 1; k > 0 ; k++)
            {
                Console.Write("");
            }

            // Move to the next line
            Console.WriteLine();
            for (int j = rows - i - 1; j > 0; j++)
            {
                Console.Write("0");
            }

            
        }
    }




}
int k = 0;
int p = 0;
string text;

Console.Write("введите размерность таблицы(не меньше 1, и не больше 6.): ");
var input = Console.ReadLine();
var parsed = int.TryParse(input, out var n);
while (p == 0)
{
if (parsed == true && n <= 6 && n >= 1)
{
p = 1;
}
else
{
Console.Write("введите размерность таблицы(не меньше 1, и не больше 6.): ");
input = Console.ReadLine();
parsed = int.TryParse(input, out n);
}

}

do
{
    Console.Write("введите произвольный текст: ");
    text = Console.ReadLine();
    k = text.Length >= 1
        ? k = 1
        : k = 0;
        
}
while (k == 0);

int width = 0;
int height = 0;
height = n * 2 -1;
width = text.Length+n*2 + 2;
if (width < 40)
{
    for (int i = 0; i < width; i++)
    {
        Console.Write("+");
    }
    Console.WriteLine(" ");
    for (int i = 0; i < height; i++)
    {
        Console.Write("+");
        if (i == (n / 2) + 1)
        {
            for (int d = 0; d < n; d++)
            {
                Console.Write(" ");
            }
            Console.Write(text);
            for (int t = 0; t < n; t++)
            {
                Console.Write(" ");
            }
        }
        else
        {
            for (int j = 0; j < width - 2; j++)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("+");
    }
    for (int i = 0; i < width; i++)
    {
        Console.Write("+");
    }


    //вторая задача

    Console.WriteLine(" ");
    for (int i = 0; i < height; i++)
    {
        Console.Write("+");
        for (int j = 0; j < width / 2 - 1; j++)
        {
            if (i % 2 == 0)
            {
                Console.Write(" ");
                Console.Write("+");
            }
            else
            {
                Console.Write("+");
                Console.Write(" ");
            }
        }
        Console.WriteLine("+");
    }




    for (int i = 0; i < width; i++)
    {
        Console.Write("+");
    }
    Console.WriteLine(" ");
    //3 задача не решена 
    /*for (int j = 0; j < width; j++)
    {
        float q = j;
        int zero = 0;
        float kero = width;
        int width1 = 0;
        int kero1 = 0;
        Console.Write("+");
        if (j < width / 2 - 1)
        {
            while (zero < j)
            {
                zero++;
                Console.Write(" ");
            }
            Console.Write("+");
            while ((width1 != width - 2 * zero - 4))
            {
                Console.Write(" ");
                width1++;

            }
            Console.Write("+");
        }
        Console.WriteLine(" ");


    }
    for (int i = 0; i < width; i++)
    {
        Console.Write("+");
    }*/

}
else
{
    Console.WriteLine("Ширина >40");
}
//первая задача

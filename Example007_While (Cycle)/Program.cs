Console.Clear();
//Console.SetCursorPosition(10, 4); // Устанавливает курсор на координаты 10, 4
//Console.WriteLine("+"); // Ставит символ в указанной координате 

int xa = 40, ya = 1, // определили координаты 3х точек
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); // установили курсов на координаты и поставили в них "+"
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2; // x = (40 + 40) / 2 = 40
        y = (y + ya) / 2; // y = (1 + 1) / 2 = 1
    }
    if (what == 1)
    {
        x = (x + xb) / 2; // x = (40 + 1) / 2 = 20
        y = (y + yb) / 2; // y = (1 + 30) /2 = 15
    }
    if (what == 2)
    {
        x = (x + xc) / 2; // x = (40 + 80) / 2 = 60
        y = (y + yc) / 2; // y = (1 + 30) /2 = 15
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;

}

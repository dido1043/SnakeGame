Console.WriteLine("Do you want play? \n (Y/N)");

var response = Console.ReadLine();
if (response == "N" || response != "Y")
    return;


Console.WriteLine();
Console.WriteLine();
bool gameLive = true;
ConsoleKeyInfo consoleKey; // holds whatever key is pressed

int x = 0;
int y = 4;

int dx = 1;
int dy = 0;

int consoleWidthLimit = 79;
int consoleHeightLimit = 24;

int delay = 50;

while (gameLive)
{
    Console.Write("");
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Arrows move up/down/right/left.,  'c' is for clear,  'esc'is for quit.");
    Console.SetCursorPosition(x, y);


    if (Console.KeyAvailable)
    {
        consoleKey = Console.ReadKey(true);

        switch (consoleKey.Key)            
        {
            //Colors
            case ConsoleKey.R:
                    Console.ForegroundColor = ConsoleColor.Red;
                break;
            case ConsoleKey.G:
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            case ConsoleKey.Y:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case ConsoleKey.B:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
                //Movings
            case ConsoleKey.UpArrow:
                dx = 0;
                dy = -1;
                break;
            case ConsoleKey.DownArrow:
                dx = 0;
                dy = 1;
                break;
            case ConsoleKey.LeftArrow:
                dx = -1;
                dy = 0;
                break;
            case ConsoleKey.RightArrow:
                dx = 1;
                dy = 0;
                break;
            case ConsoleKey.C:
                Console.Clear();
                break;
            case ConsoleKey.Escape:
                gameLive = false;
                break;
        }
    }
    Console.SetCursorPosition(x, y);
    x += dx;
    if (x > consoleWidthLimit)
        x = 0;
    if (x < 0)
        x = consoleWidthLimit;

    y += dy;
    if (y > consoleHeightLimit)
        y = 4;
    if (y < 4)
        y = consoleHeightLimit;

    Console.SetCursorPosition(x, y);
    Console.Write('*');
    Thread.Sleep(delay);
}
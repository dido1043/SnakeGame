/*Console.WriteLine("Do you want play? \n (Y/N)");

var response = Console.ReadLine();
if (response == "N" || response != "Y")
    return;
*/
char ch = '*';
bool gameLive = true;
ConsoleKeyInfo consoleKey; // holds whatever key is pressed

int x = 0;
int y = 2;

int dx = 1;
int dy = 0;

int delay = 50;

while (gameLive)
{
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Arrows move up/down/right/left.,  'c' is for clear,  'esc'is for quit.");
    Console.SetCursorPosition(x, y);

    if (Console.KeyAvailable)
    {
        consoleKey = Console.ReadKey(true);

        switch (consoleKey.Key)
        {
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

}
// To change the scene: go to "Variables" and edit the scene variable. Each number in the scene variable
// corresponds to a certain object. The list of objects is at "Reminders" > "Object Types".

#region Reminders

#region Object Types
// 0: Nothing
// 1: Surface
// 2: Controllable
// 3: Push +Col
// 4: Push -Col
// 5: End Block
#endregion

#endregion

#region Variables
int[,] scene = new int[8, 8]
{
    {0,0,0,0,2,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,0,4,4,0,0,0},
    {0,0,0,0,0,0,0,0},
    {0,0,5,0,0,5,0,0}
};
bool stopb = false;
int stepc = 0;
#endregion

#region Code

Console.WriteLine("Crappy Box Simulator");
while(!stopb)
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (scene[i, j] == 2)
            {
                if (scene[i + 1, j] == 0)
                {
                    scene[i, j] = 0;
                    scene[i + 1, j] = 2;
                    Console.WriteLine("Moved!");
                }
                if (scene[i + 1, j] == 3)
                {
                    scene[i, j] = 0;
                    scene[i, j + 1] = 2;
                }
                if (scene[i + 1, j] == 4)
                {
                    scene[i, j] = 0;
                    scene[i, j - 1] = 2;
                }
                if (scene[i + 1, j] == 5)
                {
                    stopb = true;
                }
            }
        }
        Console.WriteLine("\n");
    }
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(scene[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
    stepc++;
}
Console.WriteLine($"Ended: took {stepc} steps to get to the finish block");

#endregion
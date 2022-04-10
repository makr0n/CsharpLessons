

int[,,] GenerateArray(int numberOfRows, int numberOfColumns, int numberOfDepth)
{
    int[,,] returnArray = new int[numberOfRows, numberOfColumns, numberOfDepth];
    int[] numbersOfArray = new int[100];

    for (int i = 0; i < returnArray.GetLength(0); i++)
    {
        for (int j = 0; j < returnArray.GetLength(1); j++)
        {
            for (int k = 0; k < returnArray.GetLength(2); k++)
            {

                returnArray[i, j, k] = new Random().Next(0, 100);
            }
        }
    }
    return returnArray;
}

void Print3DArray(int[,,] incomingArray)
{
    int[,,] incomingArray = new int[numberOfRows, numberOfColumns, numberOfDepth];
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(2); k++)
            {
                incomingArray[i, j, k] = new Random().Next(0, 100);
            }
        }
    }
}


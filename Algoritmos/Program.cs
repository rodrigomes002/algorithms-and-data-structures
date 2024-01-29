int hourglassSum(List<List<int>> arr)
{
    int hourGlassA = 0;
    int hourGlassB = 0;

    for (int i = 0; i < 6; i++)
    {

        if (i < 3)
        {
            hourGlassA += i;
        }

        for (int j = 0; j < 6; j++)
        {

            if (i < 3)
            {
                hourGlassA += j;
            }
        }
    }

    return hourGlassA + hourGlassB;
}


var sum = hourglassSum(new List<List<int>>()
{
    new List<int> { 1, 1, 1, 0, 0, 0 },
    new List<int> { 0, 1, 0, 0, 0, 0 },
    new List<int> { 1, 1, 1, 0, 0, 0 },
    new List<int> { 0, 0, 2, 4, 4, 0 },
    new List<int> { 0, 0, 0, 2, 0, 0 },
    new List<int> { 0, 0, 1, 2, 4, 0 },
});


Console.WriteLine(sum);

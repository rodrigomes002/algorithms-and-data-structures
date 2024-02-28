int[] Merge(int[] nums1, int m, int[] nums2, int n)
{
    for (int j = 0, i = m; j < n; j++)
    {
        nums1[i] = nums2[j];
        i++;
    }
    Array.Sort(nums1);

    return nums1;
}

int[] nums1 = new int[1] { 0 };
int[] nums2 = new int[1] { 1 };

var result = Merge(nums1, 0, nums2, 1);

foreach (var item in result)
{
    Console.WriteLine(item);
}
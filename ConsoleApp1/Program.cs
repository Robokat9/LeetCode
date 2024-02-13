
using System.IO.Pipes;

class HelloWorld
{


    static void Main()
    {
        int maj = 0;
        string res = "";
        int[] arr = { 1, 3 };
        int[] arr1 = { 2 };
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int[] nums = [2, 2, 1, 1, 1, 2, 2,3,3,3,3,3,3];
        //int max = MaxArea(height);
        string str1 = "ABC";
        string str2 = "ABCABC";
        string[] words = ["ada", "car", "ada", "racecar", "cool"];
       
        maj = MajorityElement(nums);

        //res = FirstPalindrome(words);
        //res = GcdOfStrings(str1, str2);
        //int[] numsrr = FindErrorNums(arr);
        //string str = MergeAlternately("abc34567", "qwerr");
        //double m = FindMedianSortedArrays(arr, arr1);
        //int k = RemoveDuplicates(arr);
    }
    public static int[] FindErrorNums(int[] nums)
    {
        int current = 0;
        int find = 0;
        int[] numsr = new int[2];
        int temp = 0;
        int count = nums.Length;
        for (int i = 0; i < count - 1; i++)
        {
            if (count == 2)
            {
                if (nums[i] - nums[i + 1] == 0)
                {
                    if (nums[i] == 1)
                    {
                        numsr[0] = nums[i];
                        numsr[1] = nums[i] + 1;
                    }
                    else
                    {
                        numsr[0] = nums[i];
                        numsr[1] = nums[i] - 1;
                    }
                }
            }
            if (count > 2)
            {
                if (nums[i] < nums[i + 1])
                {
                    temp = nums[i];
                }
                if (nums[i] - nums[i + 1] == 0)
                {
                    if (temp != nums[i] - 1)
                    {
                        numsr[0] = nums[i];
                        numsr[1] = nums[i] - 1;

                    }
                    else
                    {

                        numsr[0] = nums[i];
                        numsr[1] = nums[i] + 1;
                    }

                }
            }
        }
        Console.WriteLine(numsr);
        return numsr;

    }

    public static string MergeAlternately(string word1, string word2)
    {
        string str = "";
        int len1 = word1.Length;
        int len2 = word2.Length;

        for (int i = 0; i < Math.Min(len1, len2); i++)
        {
            str += word1[i];
            str += word2[i];

        }
        if (len1 < len2)
        {
            for (int i = 0; i < len2 - len1; i++)
                str += word2[i + len1];
        }

        if (len1 > len2)
        {
            for (int i = 0; i < len1 - len2; i++)
                str += word1[i + len2];
        }

        return str;
    }

    public static int RemoveDuplicates(int[] nums)
    {
        int[] res;
        int k;
        res = nums.Distinct().ToArray();
        k = nums.Length - res.Length;

        for (int i = 0; i < k; i++)
        {
            nums[i] = res[i];
            Console.WriteLine(nums[i]);
        }
        return res.Length;
    }

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double res = 0.0;
        int[] mass = nums1.Concat(nums2).ToArray();
        Array.Sort(mass);
        int m = mass.Length / 2;
        if ((m != 0) && (mass.Length % 2 == 0))
        {
            res = (mass[m - 1] + mass[m]) / 2.0;
        }
        if (mass.Length % 2 != 0)
        {
            res = mass[m];
        }
        return res;
    }

    public static int MaxArea(int[] nums)
    {
        int max = 0;
        int len = nums.Length;
        int n1, n2;
        int[,] res = new int[len, len];


        for (int i = 0; i < len; i++)
        {
            n1 = nums[i];
            for (int j = 0; j < n1; j++)
            {

            }
        }


        return max;
    }

    public static string GcdOfStrings(string word1, string word2)
    {
        string res = "";
        int len1 = word1.Length;
        int len2 = word2.Length;
        for (int i = 0; i < Math.Max(len1, len2); i++)
        {

        }





        return res;
    }

    public static string FirstPalindrome(string[] words)
    {
        string res = "";
        int count = words.Count();
        for (int i = 0; i < count; i++)
        {
            res = "";
            Console.WriteLine(words[i]);
            char[] charArray1 = words[i].ToCharArray();
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            int dd = words[i].Length / 2;
            int dm = words[i].Length % 2;
            for (int j = 0; j < dd; j++)
            {
                if (charArray1[j] == charArray[j])
                {
                    res += charArray1[j];
                }

            }
            if (res.Length == dd)
            {

                res = new string(charArray);
                Console.WriteLine(res);
                return res;

            }
            else
            {
                res = "";
            }



        }
        Console.WriteLine(res);
        return res;
    }

    public static int MajorityElement(int[] nums)
    {
        int res = 0;
        int r;
        int count = 0;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    dict.Add(nums[i], j - i);
                    i = j - 1;
                    break;
                }
                if (j == nums.Length - 1)
                {
                    dict.Add(nums[i], j - i + 1);
                    i = j;
                }
            }
        }
        return dict.Count;
    }
}
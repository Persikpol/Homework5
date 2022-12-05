// Task 34
int size = 15;
int[] arr = new int[size];


void FillArray(int[] nums)
{
    Random rand = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rand.Next(100, 1000);
        Console.Write(nums[i] + "  ");
    }
}

void CounterPos(int[] nums)
{
    int counter = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0) 
        {
            counter++;
        }
    }
    Console.WriteLine("Количество четных элементов " + counter);
}

FillArray(arr);
CounterPos(arr);

// Task 36

int[] Arr = new int[size];

void FillArr(int[] nums)
{
    Random rand = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rand.Next(0, 100);
        Console.Write(nums[i] + "  ");
    }
}

void Sum(int[] nums)
{
    int sum = 0;
    for (int i = 1; i < nums.Length; i = i + 2)
    {
        sum += nums[i];
    }
    Console.WriteLine("Сумма элементов с нечетным индексом = " + sum);
}

FillArr(Arr);
Sum(Arr);

// Task 38

double[] array = new double[size];
double Min = 0;
double Max = 0;

void FillArray1(double[] nums)
{
    Random rand = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = Convert.ToDouble(rand.Next(0, 100));
        Console.Write(nums[i] + "  ");
    }
}

double MaxNumber(double[] nums)
{
    double Max = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > Max)
        {
            Max = nums[i];
        }
    }
    Console.WriteLine("Maximum - " + Max);
    return Max;
}

double MinNumber(double[] nums)
{
    double Min = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] < Min)
        {
            Min = nums[i];
        }
    }
    Console.WriteLine("Minimum - " + Min);
    return Min;
}


FillArray1(array);
MaxNumber(array);
MinNumber(array);
Console.WriteLine($"Разница = {MaxNumber(array) - MinNumber(array)}" );
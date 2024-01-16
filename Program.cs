//1) Записать в текстовый файл массив на 10 случайных цифр через запятую

string randNumsJson = "..\\..\\..\\randNums.json";
string randNumsTxt = "..\\..\\..\\randNums.txt";

if (!File.Exists(randNumsTxt))
{
    CreateAndWriteToTxtFile(randNumsTxt);
}
else
{
    Console.WriteLine($"File '{randNumsTxt}' already exists.");
}

if (!File.Exists(randNumsJson))
{
    CreateAndWriteToJsonFile(randNumsJson);
}
else
{
    Console.WriteLine($"File '{randNumsJson}' already exists.");
}


static void CreateAndWriteToTxtFile(string filePath)
{
    string nums = CreateRandomNums();

    File.WriteAllText(filePath, nums);
    Console.WriteLine("file successfuly created");
}

static void CreateAndWriteToJsonFile(string filePath)
{
      string nums = CreateRandomNums();

    File.WriteAllText(filePath, $"{{ \"nums\" : [{nums}] }}");
    Console.WriteLine("file successfuly created");
}

static string CreateRandomNums()
{
    Random random = new Random();
    int[] randomNums = Enumerable.Range(0, 10).Select(e => random.Next(0, 10)).ToArray();
    string randomNumsStr = string.Join(",", randomNums);

    return randomNumsStr;
}

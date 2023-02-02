int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}
Console.WriteLine("ENTER STRING:");
string x=Console.ReadLine();
char c;
string z="0";
int sum = 0;
for(int i = 0; i < x.Length; i++)
{
    c = x[i];
    if (Char.IsNumber(c))
    {
        z += c;
        
    }
    else
    {
       
        sum += int.Parse(z);
        z="0";
    }
}
Console.WriteLine(sum+int.Parse(z));
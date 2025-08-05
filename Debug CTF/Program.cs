// See https://aka.ms/new-console-template for more information
using System.Text;
string solution = "lqixpivwca";
string loop = Math.PI.ToString().Replace(".", "");
for (int i=0;i<loop.Length;++i)
{
    solution = transform(solution, int.Parse(loop[i].ToString()));
}
Console.WriteLine(solution);
string transform(string encoded,int direction) {
    byte[] binary = Encoding.UTF8.GetBytes(encoded);
    binary=Array.ConvertAll(binary, x => {  return (byte)(((x-97+direction)%26)+97); });
    return Encoding.UTF8.GetString(binary);
}


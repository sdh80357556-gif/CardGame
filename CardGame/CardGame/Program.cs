using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using static System.Runtime.InteropServices.JavaScript.JSType;

int n =0;
int s = 0;
Random random = new Random();


int index = random.Next(0, 16);

int[,] matrix =
{
    { 1, 1, 2, 2},
    { 3, 3, 4, 4},
    { 5, 5, 6, 6},
    { 7, 7, 8, 8}

};

for (int i = 0; i< 100; i++)
{
    int first = random.Next(0, 4);
    int secound = random.Next(0, 4);
    int tree = random.Next(0, 4);
    int foul = random.Next(0, 4);

    int temp = matrix[first, secound];
    matrix[first, secound] = matrix[tree, foul];
    matrix[tree, foul] = temp;

}


Console.WriteLine($"=== 카드 짝 맞추기 게임 ===");
Console.WriteLine();

for (int row = 0; row < 4; row++)
{
    for (int col = 0; col < 4; col++)
    {
       
        Console.Write($"{matrix[row, col]}");
    }
    Console.WriteLine();
}
int attempts = 0;
int find = 0;
int sum = 10;
int sum2 = 4;

int low;

Console.Write($"시도 횟수 : {attempts}/{sum} ");
Console.WriteLine($"| 찾은 쌍 : {find}/{sum2} ");
Console.WriteLine();
Console.Write($"첫 번째 카드를 선택하세요 (행 열):");
Console.Write($"첫 번째 카드를 선택하세요 (행 열):{low = int.Parse(Console.ReadLine())}");

// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Enter the perimeter of the square:");
string? input = ReadLine();

if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int perimeter))
{
    int side = perimeter / 4;
    for (int row = 0; row < side; row++)
    {
        for (int col = 0; col < side; col++)
        {
            Write("*");
        }
        WriteLine();
    }
}

WriteLine("Enter the perimeter of the right triangle:");
string? triangleInput = ReadLine();

if (!string.IsNullOrWhiteSpace(triangleInput) && int.TryParse(triangleInput, out int trianglePerimeter))
{
    int side = trianglePerimeter / 4;
    for (int row = 0 + 2; row < side; row++)
    {
        for (int col = 0 + 5; col <= row; col++)
        {
            Write("*");
        }
        WriteLine();
    }
}

WriteLine("Enter the perimeter of the right flipped triangle:");
string? flippedTriangleInput = ReadLine();

if (!string.IsNullOrWhiteSpace(flippedTriangleInput) && int.TryParse(flippedTriangleInput, out int flippedTrianglePerimeter))
{
    int side = flippedTrianglePerimeter / 4;
    for (int row = 0 +5; row < side; row++)
    {
        for (int col = 0 +2; col <= row; col++)
        {
            Write("*");
        }
        WriteLine();
    }
}

WriteLine("Enter the perimeter of the diamond:");
string? diamondInput = ReadLine();

if (!string.IsNullOrWhiteSpace(diamondInput) && int.TryParse(diamondInput, out int diamondPerimeter))
{
    int side = diamondPerimeter / 4;
    for (int row = 0; row < side; row++)
    {
        for (int col = 0; col <= row; col++)
        {
            Write("*");
        }
        WriteLine();
    }
}

WriteLine("Enter the perimeter of the hollow square:");
string? hollowSquareInput = ReadLine();

if (!string.IsNullOrWhiteSpace(hollowSquareInput) && int.TryParse(hollowSquareInput, out int hollowSquarePerimeter))
{
    int side = hollowSquarePerimeter / 4;
    for (int row = 0 -1; row < side; row++)
    {
        for (int col = 0 -1; col <= row; col++)
        {
            Write(" ");
        }
        WriteLine();
    }

    for (int row = 0; row < side; row++) 
    {
        for (int col = 0; col <= row; col++)
        {
            Write("*");
        }
        WriteLine();
    }
}

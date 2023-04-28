Console.WriteLine("Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

int points_number = 2;

int[][] points = new int[points_number][];
for (int i = 0; i < points_number; i++) points[i] = GetPointCoords(i + 1);

double squares_sum = GetCoordSquare(points[0][0], points[1][0]) + GetCoordSquare(points[0][1], points[1][1]) + GetCoordSquare(points[0][2], points[1][2]);
double distance = Math.Sqrt(squares_sum);
distance = Math.Round(distance, 2);

Console.WriteLine($"Расстояние между точками: {distance}");



static int[] GetPointCoords(int point_nr)
{
    int[] coords = new int[3];
    Console.Write($"Введите координату X для точки {point_nr}: ");
    coords[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату Y для точки {point_nr}: ");
    coords[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату Z для точки {point_nr}: ");
    coords[2] = Convert.ToInt32(Console.ReadLine());
    return coords;
}

static double GetCoordSquare(int coord1, int coord2) => Math.Pow(coord1 - coord2, 2);
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равно 0 и Y не равно 0, и выдает номер четверти плоскости,
// в которой находится эта точка.
// Оси:
// 2  1
// 3  4

System.Console.WriteLine ("--> ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("--> ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) System.Console.WriteLine ("1 quarter");
else if (x < 0 && y > 0) System.Console.WriteLine ("2 quarter");
else if (x < 0 && y < 0) System.Console.WriteLine ("3 quarter");
else if (x > 0 && y < 0) System.Console.WriteLine ("4 quarter");

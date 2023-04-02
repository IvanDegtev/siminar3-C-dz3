﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int ax = ReadInt ("Координата х первой точки");
int ay = ReadInt ("Координата y первой точки");
int ac = ReadInt ("Координата с первой точки");
int bx = ReadInt ("Координата х второй точки");
int by = ReadInt ("Координата y второй точки");
int bc = ReadInt ("Координата с второй точки");

int koordX = (ax - bx);
int koordY = (ay - by);
int koordC = (ac - bc);
double W = Math.Sqrt(Math.Pow(koordX,2) + Math.Pow(koordY,2) + Math.Pow(koordC,2));
System.Console.Write($"Показать результат {W:f2}");
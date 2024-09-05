// See https://aka.ms/new-console-template for more information
using Data_structures_exercise;
using Data_structures_exercise.Model;
using Data_structures_exercise.servis;

Console.WriteLine("Hello, World!");
BST bST = await RunFunctions.RanDefence();
await RunFunctions.RanThreats(bST);

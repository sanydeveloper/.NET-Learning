// See https://aka.ms/new-console-template for more information
// This line prints "Hello, World" 
// Console.WriteLine("Hello, World!");

//Pattern Matching

// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Testing Pattern class...");

//         Console.WriteLine($"Or(true, false): {Pattern.Or(true, false)}");
//         Console.WriteLine($"And(true, false): {Pattern.And(true, false)}");
//         Console.WriteLine($"Xor(true, false): {Pattern.Xor(true, false)}");
//     }
// }

// public class Pattern
// {
//     public static bool Or(bool left, bool right) =>
//         (left, right) switch
//         {
//             (true, true) => true,
//             (true, false) => true,
//             (false, true) => true,
//             (false, false) => false,
//         };

//     public static bool And(bool left, bool right) =>
//         (left, right) switch
//         {
//             (true, true) => true,
//             (true, false) => false,
//             (false, true) => false,
//             (false, false) => false,
//         };

//     public static bool Xor(bool left, bool right) =>
//         (left, right) switch
//         {
//             (true, true) => false,
//             (true, false) => true,
//             (false, true) => true,
//             (false, false) => false,
//         };
// }

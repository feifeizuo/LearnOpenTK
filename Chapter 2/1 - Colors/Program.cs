﻿namespace LearnOpenTK
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            using (var window = new Window(800, 600, "LearnOpenTK - Colors"))
            {
                window.Run(60.0);
            }
        }
    }
}
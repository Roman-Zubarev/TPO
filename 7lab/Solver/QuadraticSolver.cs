﻿namespace Solver
{
    public class QuadraticSolver
    {
        public static double[] Solve(double a,double b, double c)
        {
            var discriminant = b * b - 4  * a * c;

            if (discriminant > 0) {
                var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if(discriminant == 0)
            {
                return new double[] {-b / (2 * a) };
            }
            else return new double[0];
        }
    }
}
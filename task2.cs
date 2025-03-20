// Task 2:  3D Vector Class with Overloaded Operators
// Task: Create a Vector3D class representing a three-dimensional vector. Implement the following:

// 1. Override ToString()
// Format: "(X, Y, Z)"

// 2. Overload Arithmetic Operators
// + to add vectors.
// - to subtract vectors.
// * to multiply by a scalar.
// / to divide by a scalar (handle division by zero).

// 3. Overload Equality Operators (==, !=)
// Two vectors are equal if all components are equal.

// 4. Implement Equals() and GetHashCode() Consistently

// 5. Overload true and false Operators
// A vector is "true" if it's non-zero, otherwise "false".

// 6. Overload >, <, >=, <= Based on Magnitude

// using System.Numerics;
// using System.Text;

// class Vector3D
// {
   
//     double X {get;}
//     double Y {get;}
//     double Z {get;}
  
//     public Vector3D(double x, double y, double z)
//     {
//         this.X = x;
//         this.Y = y;
//         this.Z = z;
//     }


//     public override string ToString()
//     {
//         return $"X parameter is {this.X}\nY parameter is {this.Y}\nZ parameter is {this.Z}";
//     }

//     public static Vector3D operator +(Vector3D v, Vector3D v2)
//     {
//         return new Vector3D(v.X  + v2.X, v.Y + v2.Y, v.Z + v2.Z);
//     }

//     public static Vector3D operator -(Vector3D v, Vector3D v2)
//     {
//         return new Vector3D(v.X  - v2.X, v.Y - v2.Y, v.Z - v2.Z);
//     }

//     public static Vector3D operator *(Vector3D v, Vector3D v2)
//     {
//         return new Vector3D(v.X * v2.X, v.Y * v2.Y, v.Z * v2.Z);
//     }

//     public static Vector3D operator /(Vector3D v, Vector3D v2)
//     {
//         if (v2.X == 0 || v2.Y == 0 || v2.Z == 0)
//         {
//             throw new ArgumentException("One of this is zero");
//         }
//         else
//         {
//             return new Vector3D(v.X / v2.X, v.Y / v2.Y, v.Z / v2.Z);
//         } 
//     }

//     public static bool operator ==(Vector3D v, Vector3D v2)
//     {
//         return v.X == v2.X && v.Y == v2.Y && v.Z == v2.Z;
//     }

//     public static bool operator !=(Vector3D v, Vector3D v2)
//     {
//         return !(v == v2);
//     }

//     public override bool Equals(object? obj)
//     {
//         return base.Equals(obj);
//     }

//     public override int GetHashCode()
//     {
//         return base.GetHashCode();
//     }

//     public double Magnitude() {
//         return Math.Sqrt(X * X + Y * Y + Z * Z);
//     }

//     public static bool operator true(Vector3D v1)
//     {
//         return v1.Magnitude() > 0;
//     }

//     public static bool operator false(Vector3D v1)
//     {
//        return v1.Magnitude() < 0;
//     }

//     public static bool operator <(Vector3D v1, Vector3D v2)
//     {
//         return (v1.X + v1.Y + v1.Z) < (v2.X + v2.Y + v2.Z);
//     }

//     public static bool operator >(Vector3D v1, Vector3D v2)
//     {
//         return (v1.X + v1.Y + v1.Z) > (v2.X + v2.Y + v2.Z);
//     }

//     public static bool operator <=(Vector3D v1, Vector3D v2)
//     {
//         return (v1.X + v1.Y + v1.Z) <= (v2.X + v2.Y + v2.Z);
//     }

//     public static bool operator >=(Vector3D v1, Vector3D v2)
//     {
//         return (v1.X + v1.Y + v1.Z) >= (v2.X + v2.Y + v2.Z);
//     }


// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Vector3D v1 = new Vector3D(4.0, 5.0, 8.0);
//         Vector3D v2 = new Vector3D(3.0, 4.0, 2.0);

//         Console.WriteLine($"First vector is\n{v1.ToString()}");
//         Console.WriteLine($"Second vector is\n{v2.ToString()}");
//         Vector3D v3 = v1 + v2;
//         Console.WriteLine($"Sum of vectors is\n{v3.ToString()}");
//         v3 = v1 - v2;
//         Console.WriteLine($"Subtractin of vectors is\n{v3.ToString()}");
//         v3 = v1 * v2;
//         Console.WriteLine($"Multiply of vectors is\n{v3.ToString()}");
//         v3 = v1 / v2;
//         Console.WriteLine($"Divide of vectors is\n{v3.ToString()}");
//         Console.WriteLine($"Object are equal {v1.Equals(v2)}");
//         if (v1) 
//         {
//             Console.WriteLine("Vector is true");
//         }
//         Console.WriteLine($"First vector is < than Second {v1 < v2}");
//         Console.WriteLine($"First vector is > than Second {v1 > v2}");
//         Console.WriteLine($"First vector is <= than Second {v1 <= v2}");
//         Console.WriteLine($"First vector is >= than Second {v1 >= v2}");

//     }
// }
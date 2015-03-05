namespace Question1 {
    /// <summary>
    /// Enum containing the three types of Triangles given for this example
    /// </summary>
    public enum TriangleType {
        Scalene,
        Isosceles,
        Equilateral,
        Invalid
    }
    /// <summary>
    /// Class containing the integer values for the three sides of the Triangle
    /// </summary>
    public class Triangle {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle() { }

        public Triangle(int side1, int side2, int side3) {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public bool IsValid() {
            return IsValid(Side1, Side2, Side3);
        }

        internal static bool IsValid(int side1, int side2, int side3) {
            return side1 + side2 > side3
                && side1 + side3 > side2
                && side2 + side3 > side1;
        }

        public TriangleType? GetTriangleType() {
            if (Side1 == Side2 && Side2 == Side3) {
                return TriangleType.Equilateral;
            }

            if (!IsValid()) return TriangleType.Invalid;

            if (Side1 == Side2 && Side2 != Side3) {
                return TriangleType.Isosceles;
            }

            return TriangleType.Scalene;
        }
    }
}

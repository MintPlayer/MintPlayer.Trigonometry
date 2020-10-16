namespace System.Trigonometry
{
    public static class Math
    {
        /// <summary>Inverse hyperbolic sine</summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AsinH(double d)
        {
            var asinh = System.Math.Log(d + System.Math.Sqrt(1 + System.Math.Pow(d, 2)));
            return asinh;
        }

        /// <summary>Inverse hyperbolic cosine</summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AcosH(double d)
        {
            var acosh = System.Math.Log(d + System.Math.Sqrt(d + 1) * System.Math.Sqrt(d - 1));
            return acosh;
        }

        /// <summary>Inverse hyperbolic tangent</summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AtanH(double d)
        {
            var atanh = System.Math.Log((1 + d) / (1 - d)) / 2;
            return atanh;
        }

        /// <summary>Inverse hyperbolic cosecant</summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AcosecH(double d)
        {
            var acosech = System.Math.Log(1 / d + System.Math.Sqrt(1 / System.Math.Pow(d, 2) + 1));
            return acosech;
        }

        /// <summary>Inverse hyperbolic secant</summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AsecH(double d)
        {
            var asech = System.Math.Log(1 / d + System.Math.Sqrt(1 / d + 1) * System.Math.Sqrt(1 / d - 1));
            return asech;
        }

        /// <summary>Inverse hyperbolic contangent</summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static double AcotanH(double d)
        {
            var acotanh = System.Math.Log((d + 1) / (d - 1)) / 2;
            return acotanh;
        }
    }
}

using System;


namespace R5T.T0202.Extensions
{
    public static class StringsExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToCompilerAnomaly(string)"/>
        public static ICompilerAnomaly ToCompilerAnomaly(this string value)
        {
            return Instances.StringOperator_Extensions.ToCompilerAnomaly(value);
        }
    }
}

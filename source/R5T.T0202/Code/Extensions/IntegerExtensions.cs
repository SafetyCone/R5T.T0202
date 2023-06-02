using System;


namespace R5T.T0202.Extensions
{
    public static class IntegerExtensions
    {
        /// <inheritdoc cref="IIntegerOperator.ToWarning(int)"/>
        public static IWarning ToWarning(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToWarning(value);
        }
    }
}

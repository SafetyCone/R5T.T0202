using System;

using R5T.T0132;


namespace R5T.T0202.Extensions
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IWarning"/>
        public IWarning ToWarning(int value)
        {
            var output = new Warning(value);
            return output;
        }
    }
}

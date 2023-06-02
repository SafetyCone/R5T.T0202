using System;

using R5T.T0132;


namespace R5T.T0202.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ICompilerAnomaly"/>
        public ICompilerAnomaly ToCompilerAnomaly(string value)
        {
            var output = new CompilerAnomaly(value);
            return output;
        }
    }
}

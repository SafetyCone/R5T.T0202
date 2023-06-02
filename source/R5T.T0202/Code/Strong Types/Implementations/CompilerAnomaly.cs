using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0202
{
    /// <inheritdoc cref="ICompilerAnomaly"/>
    [StrongTypeImplementationMarker]
    public class CompilerAnomaly : TypedBase<string>, IStrongTypeMarker,
        ICompilerAnomaly
    {
        public CompilerAnomaly(string value)
            : base(value)
        {
        }
    }
}
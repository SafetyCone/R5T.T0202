using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0202
{
    /// <inheritdoc cref="IWarning"/>
    [StrongTypeImplementationMarker]
    public class Warning : TypedBase<int>, IStrongTypeMarker,
        IWarning
    {
        public Warning(int value)
            : base(value)
        {
        }
    }
}
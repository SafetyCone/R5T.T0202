using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0202
{
    /// <summary>
    /// Strongly-types a integer as a .NET compiler warning number.
    /// This type is useful for specifying warning numbers in C# project files.
    /// </summary>
    [StrongTypeMarker]
    public interface IWarning : IStrongTypeMarker,
        ITyped<int>
    {
    }
}
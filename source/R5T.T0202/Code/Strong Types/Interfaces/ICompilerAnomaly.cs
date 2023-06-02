using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0202
{
    /// <summary>
    /// Strongly-types a string as a compiler anomaly.
    /// A compiler anomaly is a compiler warning or error, such as those reported in the Visual Studio error list.
    /// A compiler anomaly consists of an alphabetic prefix, with a numeric suffix (examples: CS1587 - a warning, CS0041 - an error).
    /// <see href="https://gist.github.com/thomaslevesque/43e4950a65961e2194e4ce082d64bc31"/>
    /// </summary>
    [StrongTypeMarker]
    public interface ICompilerAnomaly : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
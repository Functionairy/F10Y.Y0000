using System;

using F10Y.T0001;


namespace F10Y.Y0000
{
	/// <summary>
	/// C#/.NET Standard 2.1 documentation library.
	/// </summary>
	[DocumentationsMarker]
	public static partial class Documentation
	{
        /// <summary>
        /// When equating two reference type instances, if one or both of the instances are null then a simple null check has determined whether the instances are equal.
        /// In the case where one instance is null, but the other isn't, a null check has determined equality and the instances are not equal.
        /// If both are null, then the null check has determined equality and the instances are equal.
        /// Only in the case where both are not null does a null check not determine equality.
        /// </summary>
        public static readonly object NullCheckDeterminesEquality;
    }
}
// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.IO;
using System.Xml.Serialization;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that deserialize an Xml as &lt;T&gt;.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The desieralize Xml as &lt;T&gt;</returns>
    public static T DeserializeXml<T>(this string @this)
    {
        var x = new XmlSerializer(typeof (T));
        var r = new StringReader(@this);

        return (T) x.Deserialize(r);
    }
}
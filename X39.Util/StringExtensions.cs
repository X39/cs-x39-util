// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable RedundantNameQualifier

using System.Runtime.CompilerServices;

namespace X39.Util;

/// <summary>
/// Contains utility classes for <see cref="System.String"/>
/// </summary>
public static partial class StringExtensionMethods
{
    /// <inheritdoc cref="Convert.ToBoolean(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Boolean ToBoolean(this string value, IFormatProvider provider)
    {
        return Convert.ToBoolean(value, provider);
    }
    /// <inheritdoc cref="Convert.ToBoolean(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Boolean ToBoolean(this string value)
    {
        return Convert.ToBoolean(value);
    }   
    /// <inheritdoc cref="Convert.ToSByte(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.SByte ToSByte(this string value, IFormatProvider provider)
    {
        return Convert.ToSByte(value, provider);
    }
    /// <inheritdoc cref="Convert.ToSByte(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.SByte ToSByte(this string value)
    {
        return Convert.ToSByte(value);
    }   
    /// <inheritdoc cref="Convert.ToInt16(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Int16 ToInt16(this string value, IFormatProvider provider)
    {
        return Convert.ToInt16(value, provider);
    }
    /// <inheritdoc cref="Convert.ToInt16(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Int16 ToInt16(this string value)
    {
        return Convert.ToInt16(value);
    }   
    /// <inheritdoc cref="Convert.ToInt32(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Int32 ToInt32(this string value, IFormatProvider provider)
    {
        return Convert.ToInt32(value, provider);
    }
    /// <inheritdoc cref="Convert.ToInt32(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Int32 ToInt32(this string value)
    {
        return Convert.ToInt32(value);
    }   
    /// <inheritdoc cref="Convert.ToInt64(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Int64 ToInt64(this string value, IFormatProvider provider)
    {
        return Convert.ToInt64(value, provider);
    }
    /// <inheritdoc cref="Convert.ToInt64(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Int64 ToInt64(this string value)
    {
        return Convert.ToInt64(value);
    }   
    /// <inheritdoc cref="Convert.ToByte(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Byte ToByte(this string value, IFormatProvider provider)
    {
        return Convert.ToByte(value, provider);
    }
    /// <inheritdoc cref="Convert.ToByte(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Byte ToByte(this string value)
    {
        return Convert.ToByte(value);
    }   
    /// <inheritdoc cref="Convert.ToUInt16(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.UInt16 ToUInt16(this string value, IFormatProvider provider)
    {
        return Convert.ToUInt16(value, provider);
    }
    /// <inheritdoc cref="Convert.ToUInt16(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.UInt16 ToUInt16(this string value)
    {
        return Convert.ToUInt16(value);
    }   
    /// <inheritdoc cref="Convert.ToUInt32(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.UInt32 ToUInt32(this string value, IFormatProvider provider)
    {
        return Convert.ToUInt32(value, provider);
    }
    /// <inheritdoc cref="Convert.ToUInt32(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.UInt32 ToUInt32(this string value)
    {
        return Convert.ToUInt32(value);
    }   
    /// <inheritdoc cref="Convert.ToUInt64(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.UInt64 ToUInt64(this string value, IFormatProvider provider)
    {
        return Convert.ToUInt64(value, provider);
    }
    /// <inheritdoc cref="Convert.ToUInt64(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.UInt64 ToUInt64(this string value)
    {
        return Convert.ToUInt64(value);
    }   
    /// <inheritdoc cref="Convert.ToSingle(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Single ToSingle(this string value, IFormatProvider provider)
    {
        return Convert.ToSingle(value, provider);
    }
    /// <inheritdoc cref="Convert.ToSingle(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Single ToSingle(this string value)
    {
        return Convert.ToSingle(value);
    }   
    /// <inheritdoc cref="Convert.ToDouble(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Double ToDouble(this string value, IFormatProvider provider)
    {
        return Convert.ToDouble(value, provider);
    }
    /// <inheritdoc cref="Convert.ToDouble(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Double ToDouble(this string value)
    {
        return Convert.ToDouble(value);
    }   
    /// <inheritdoc cref="Convert.ToDecimal(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Decimal ToDecimal(this string value, IFormatProvider provider)
    {
        return Convert.ToDecimal(value, provider);
    }
    /// <inheritdoc cref="Convert.ToDecimal(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Decimal ToDecimal(this string value)
    {
        return Convert.ToDecimal(value);
    }   
    /// <inheritdoc cref="Convert.FromBase64String(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.Byte[] FromBase64String(this string value)
    {
        return Convert.FromBase64String(value);
    }   
    /// <inheritdoc cref="Convert.ToDateTime(string, IFormatProvider)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.DateTime ToDateTime(this string value, IFormatProvider provider)
    {
        return Convert.ToDateTime(value, provider);
    }
    /// <inheritdoc cref="Convert.ToDateTime(string)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [Pure]
    public static System.DateTime ToDateTime(this string value)
    {
        return Convert.ToDateTime(value);
    }   
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.SplomLib.DimensionLib.AxisLib
{
    /// <summary>
    ///     Sets the axis type for this dimension&#39;s generated x and y axes. Note
    ///     that the axis <c>type</c> values set in layout take precedence over this
    ///     attribute.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear,
        [EnumMember(Value=@"log")]
        Log,
        [EnumMember(Value=@"date")]
        Date,
        [EnumMember(Value=@"category")]
        Category
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ContourLib
{
    /// <summary>
    ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
    ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
    ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
    ///     when <c>x</c> is not provided).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum XTypeEnum
    {
        [EnumMember(Value=@"array")]
        Array,
        [EnumMember(Value=@"scaled")]
        Scaled
    }
}
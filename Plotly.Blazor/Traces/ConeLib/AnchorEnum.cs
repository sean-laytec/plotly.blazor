/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ConeLib
{
    /// <summary>
    ///     Sets the cones&#39; anchor with respect to their x/y/z positions. Note that
    ///     <c>cm</c> denote the cone&#39;s center of mass which corresponds to 1/4
    ///     from the tail to tip.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum AnchorEnum
    {
        [EnumMember(Value=@"cm")]
        Cm = 0,
        [EnumMember(Value=@"tip")]
        Tip,
        [EnumMember(Value=@"tail")]
        Tail,
        [EnumMember(Value=@"center")]
        Center
    }
}
/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.FunnelAreaLib.TitleLib
{
    /// <summary>
    ///     Specifies the location of the <c>title</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum PositionEnum
    {
        [EnumMember(Value=@"top center")]
        TopCenter = 0,
        [EnumMember(Value=@"top left")]
        TopLeft,
        [EnumMember(Value=@"top right")]
        TopRight
    }
}
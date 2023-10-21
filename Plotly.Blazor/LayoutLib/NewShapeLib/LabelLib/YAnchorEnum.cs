/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.NewShapeLib.LabelLib
{
    /// <summary>
    ///     Sets the label&#39;s vertical position anchor This anchor binds the specified
    ///     <c>textposition</c> to the <c>top</c>, <c>middle</c> or <c>bottom</c> of
    ///     the label text. For example, if <c>textposition</c> is set to &#39;top right&#39;
    ///     and <c>yanchor</c> to <c>top</c> then the top-most portion of the label
    ///     text lines up with the top-most edge of the new shape.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"middle")]
        Middle,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}
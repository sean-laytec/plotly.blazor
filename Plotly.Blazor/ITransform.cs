/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Blazor
{
    /// <summary>
    ///     The transform interface.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    public interface ITransform
    {
        /// <summary>
        ///     The type of the transform.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum? Type { get; }

    }
}
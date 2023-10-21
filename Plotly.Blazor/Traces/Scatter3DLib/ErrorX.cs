/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.Scatter3DLib
{
    /// <summary>
    ///     The ErrorX class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Serializable]
    public class ErrorX : IEquatable<ErrorX>
    {
        /// <summary>
        ///     Sets the data corresponding the length of each error bar. Values are plotted
        ///     relative to the underlying data.
        /// </summary>
        [JsonPropertyName(@"array")]
        public IList<object> Array { get; set;} 

        /// <summary>
        ///     Sets the data corresponding the length of each error bar in the bottom (left)
        ///     direction for vertical (horizontal) bars Values are plotted relative to
        ///     the underlying data.
        /// </summary>
        [JsonPropertyName(@"arrayminus")]
        public IList<object> ArrayMinus { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>arrayminus</c>.
        /// </summary>
        [JsonPropertyName(@"arrayminussrc")]
        public string ArrayMinusSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>array</c>.
        /// </summary>
        [JsonPropertyName(@"arraysrc")]
        public string ArraySrc { get; set;} 

        /// <summary>
        ///     Sets the stoke color of the error bars.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Gets or sets the CopyZStyle.
        /// </summary>
        [JsonPropertyName(@"copy_zstyle")]
        public bool? CopyZStyle { get; set;} 

        /// <summary>
        ///     Determines whether or not the error bars have the same length in both direction
        ///     (top/bottom for vertical bars, left/right for horizontal bars.
        /// </summary>
        [JsonPropertyName(@"symmetric")]
        public bool? Symmetric { get; set;} 

        /// <summary>
        ///     Sets the thickness (in px) of the error bars.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public decimal? Thickness { get; set;} 

        /// <summary>
        ///     Gets or sets the TraceRef.
        /// </summary>
        [JsonPropertyName(@"traceref")]
        public int? TraceRef { get; set;} 

        /// <summary>
        ///     Gets or sets the TraceRefMinus.
        /// </summary>
        [JsonPropertyName(@"tracerefminus")]
        public int? TraceRefMinus { get; set;} 

        /// <summary>
        ///     Determines the rule used to generate the error bars. If *constant`, the
        ///     bar lengths are of a constant value. Set this constant in <c>value</c>.
        ///     If <c>percent</c>, the bar lengths correspond to a percentage of underlying
        ///     data. Set this percentage in <c>value</c>. If <c>sqrt</c>, the bar lengths
        ///     correspond to the square of the underlying data. If <c>data</c>, the bar
        ///     lengths are set with data set <c>array</c>.
        /// </summary>
        [JsonPropertyName(@"type")]
        public Plotly.Blazor.Traces.Scatter3DLib.ErrorXLib.TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Sets the value of either the percentage (if <c>type</c> is set to <c>percent</c>)
        ///     or the constant (if <c>type</c> is set to <c>constant</c>) corresponding
        ///     to the lengths of the error bars.
        /// </summary>
        [JsonPropertyName(@"value")]
        public decimal? Value { get; set;} 

        /// <summary>
        ///     Sets the value of either the percentage (if <c>type</c> is set to <c>percent</c>)
        ///     or the constant (if <c>type</c> is set to <c>constant</c>) corresponding
        ///     to the lengths of the error bars in the bottom (left) direction for vertical
        ///     (horizontal) bars
        /// </summary>
        [JsonPropertyName(@"valueminus")]
        public decimal? ValueMinus { get; set;} 

        /// <summary>
        ///     Determines whether or not this set of error bars is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the cross-bar at both ends of the error bars.
        /// </summary>
        [JsonPropertyName(@"width")]
        public decimal? Width { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is ErrorX other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] ErrorX other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Equals(Array, other.Array) ||
                    Array != null && other.Array != null &&
                    Array.SequenceEqual(other.Array)
                ) &&
                (
                    Equals(ArrayMinus, other.ArrayMinus) ||
                    ArrayMinus != null && other.ArrayMinus != null &&
                    ArrayMinus.SequenceEqual(other.ArrayMinus)
                ) &&
                (
                    ArrayMinusSrc == other.ArrayMinusSrc ||
                    ArrayMinusSrc != null &&
                    ArrayMinusSrc.Equals(other.ArrayMinusSrc)
                ) && 
                (
                    ArraySrc == other.ArraySrc ||
                    ArraySrc != null &&
                    ArraySrc.Equals(other.ArraySrc)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    CopyZStyle == other.CopyZStyle ||
                    CopyZStyle != null &&
                    CopyZStyle.Equals(other.CopyZStyle)
                ) && 
                (
                    Symmetric == other.Symmetric ||
                    Symmetric != null &&
                    Symmetric.Equals(other.Symmetric)
                ) && 
                (
                    Thickness == other.Thickness ||
                    Thickness != null &&
                    Thickness.Equals(other.Thickness)
                ) && 
                (
                    TraceRef == other.TraceRef ||
                    TraceRef != null &&
                    TraceRef.Equals(other.TraceRef)
                ) && 
                (
                    TraceRefMinus == other.TraceRefMinus ||
                    TraceRefMinus != null &&
                    TraceRefMinus.Equals(other.TraceRefMinus)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    ValueMinus == other.ValueMinus ||
                    ValueMinus != null &&
                    ValueMinus.Equals(other.ValueMinus)
                ) && 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Array != null) hashCode = hashCode * 59 + Array.GetHashCode();
                if (ArrayMinus != null) hashCode = hashCode * 59 + ArrayMinus.GetHashCode();
                if (ArrayMinusSrc != null) hashCode = hashCode * 59 + ArrayMinusSrc.GetHashCode();
                if (ArraySrc != null) hashCode = hashCode * 59 + ArraySrc.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (CopyZStyle != null) hashCode = hashCode * 59 + CopyZStyle.GetHashCode();
                if (Symmetric != null) hashCode = hashCode * 59 + Symmetric.GetHashCode();
                if (Thickness != null) hashCode = hashCode * 59 + Thickness.GetHashCode();
                if (TraceRef != null) hashCode = hashCode * 59 + TraceRef.GetHashCode();
                if (TraceRefMinus != null) hashCode = hashCode * 59 + TraceRefMinus.GetHashCode();
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Value != null) hashCode = hashCode * 59 + Value.GetHashCode();
                if (ValueMinus != null) hashCode = hashCode * 59 + ValueMinus.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ErrorX and the right ErrorX.
        /// </summary>
        /// <param name="left">Left ErrorX.</param>
        /// <param name="right">Right ErrorX.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ErrorX left, ErrorX right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ErrorX and the right ErrorX.
        /// </summary>
        /// <param name="left">Left ErrorX.</param>
        /// <param name="right">Right ErrorX.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ErrorX left, ErrorX right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ErrorX</returns>
        public ErrorX DeepClone()
        {
            return this.Copy();
        }
    }
}
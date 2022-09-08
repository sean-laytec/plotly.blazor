/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The ActiveSelection class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class ActiveSelection : IEquatable<ActiveSelection>
    {
        /// <summary>
        ///     Sets the color filling the active selection&#39; interior.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Sets the opacity of the active selection.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is ActiveSelection other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] ActiveSelection other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FillColor == other.FillColor ||
                    FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ActiveSelection and the right ActiveSelection.
        /// </summary>
        /// <param name="left">Left ActiveSelection.</param>
        /// <param name="right">Right ActiveSelection.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ActiveSelection left, ActiveSelection right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ActiveSelection and the right ActiveSelection.
        /// </summary>
        /// <param name="left">Left ActiveSelection.</param>
        /// <param name="right">Right ActiveSelection.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ActiveSelection left, ActiveSelection right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ActiveSelection</returns>
        public ActiveSelection DeepClone()
        {
            return this.Copy();
        }
    }
}
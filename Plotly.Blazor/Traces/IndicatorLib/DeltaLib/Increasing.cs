/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.IndicatorLib.DeltaLib
{
    /// <summary>
    ///     The Increasing class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Serializable]
    public class Increasing : IEquatable<Increasing>
    {
        /// <summary>
        ///     Sets the color for increasing value.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the symbol to display for increasing value
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public string Symbol { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Increasing other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Increasing other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Symbol == other.Symbol ||
                    Symbol != null &&
                    Symbol.Equals(other.Symbol)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Symbol != null) hashCode = hashCode * 59 + Symbol.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Increasing and the right Increasing.
        /// </summary>
        /// <param name="left">Left Increasing.</param>
        /// <param name="right">Right Increasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Increasing left, Increasing right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Increasing and the right Increasing.
        /// </summary>
        /// <param name="left">Left Increasing.</param>
        /// <param name="right">Right Increasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Increasing left, Increasing right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Increasing</returns>
        public Increasing DeepClone()
        {
            return this.Copy();
        }
    }
}
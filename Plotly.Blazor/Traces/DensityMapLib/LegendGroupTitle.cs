/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.DensityMapLib
{
    /// <summary>
    ///     The LegendGroupTitle class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class LegendGroupTitle : IEquatable<LegendGroupTitle>
    {
        /// <summary>
        ///     Sets this legend group&#39;s title font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.DensityMapLib.LegendGroupTitleLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the title of the legend group.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is LegendGroupTitle other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] LegendGroupTitle other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left LegendGroupTitle and the right LegendGroupTitle.
        /// </summary>
        /// <param name="left">Left LegendGroupTitle.</param>
        /// <param name="right">Right LegendGroupTitle.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (LegendGroupTitle left, LegendGroupTitle right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left LegendGroupTitle and the right LegendGroupTitle.
        /// </summary>
        /// <param name="left">Left LegendGroupTitle.</param>
        /// <param name="right">Right LegendGroupTitle.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (LegendGroupTitle left, LegendGroupTitle right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>LegendGroupTitle</returns>
        public LegendGroupTitle DeepClone()
        {
            return this.Copy();
        }
    }
}
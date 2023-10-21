/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.VolumeLib
{
    /// <summary>
    ///     The SpaceFrame class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [Serializable]
    public class SpaceFrame : IEquatable<SpaceFrame>
    {
        /// <summary>
        ///     Sets the fill ratio of the <c>spaceframe</c> elements. The default fill
        ///     value is 1 meaning that they are entirely shaded. Applying a <c>fill</c>
        ///     ratio less than one would allow the creation of openings parallel to the
        ///     edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public decimal? Fill { get; set;} 

        /// <summary>
        ///     Displays/hides tetrahedron shapes between minimum and maximum iso-values.
        ///     Often useful when either caps or surfaces are disabled or filled with values
        ///     less than 1.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is SpaceFrame other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] SpaceFrame other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fill == other.Fill ||
                    Fill != null &&
                    Fill.Equals(other.Fill)
                ) && 
                (
                    Show == other.Show ||
                    Show != null &&
                    Show.Equals(other.Show)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Fill != null) hashCode = hashCode * 59 + Fill.GetHashCode();
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left SpaceFrame and the right SpaceFrame.
        /// </summary>
        /// <param name="left">Left SpaceFrame.</param>
        /// <param name="right">Right SpaceFrame.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (SpaceFrame left, SpaceFrame right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left SpaceFrame and the right SpaceFrame.
        /// </summary>
        /// <param name="left">Left SpaceFrame.</param>
        /// <param name="right">Right SpaceFrame.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (SpaceFrame left, SpaceFrame right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>SpaceFrame</returns>
        public SpaceFrame DeepClone()
        {
            return this.Copy();
        }
    }
}
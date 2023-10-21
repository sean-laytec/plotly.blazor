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

namespace Plotly.Blazor.Transforms
{
    /// <summary>
    ///     The Sort class.
    ///     Implements the <see cref="ITransform" />.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.0.0")]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Sort : ITransform, IEquatable<Sort>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum? Type { get; } = TransformTypeEnum.Sort;

        /// <summary>
        ///     Determines whether this sort transform is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     Sets the sort transform order.
        /// </summary>
        [JsonPropertyName(@"order")]
        public Plotly.Blazor.Transforms.SortLib.OrderEnum? Order { get; set;} 

        /// <summary>
        ///     Sets the target by which the sort transform is applied. If a string, <c>target</c>
        ///     is assumed to be a reference to a data array in the parent trace object.
        ///     To sort about nested variables, use <c>.</c> to access them. For example,
        ///     set <c>target</c> to <c>marker.size</c> to sort about the marker size array.
        ///     If an array, <c>target</c> is then the data array by which the sort transform
        ///     is applied.
        /// </summary>
        [JsonPropertyName(@"target")]
        public string Target { get; set;} 

        /// <summary>
        ///     Sets the target by which the sort transform is applied. If a string, <c>target</c>
        ///     is assumed to be a reference to a data array in the parent trace object.
        ///     To sort about nested variables, use <c>.</c> to access them. For example,
        ///     set <c>target</c> to <c>marker.size</c> to sort about the marker size array.
        ///     If an array, <c>target</c> is then the data array by which the sort transform
        ///     is applied.
        /// </summary>
        [JsonPropertyName(@"target")]
        [Array]
        public IList<string> TargetArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>target</c>.
        /// </summary>
        [JsonPropertyName(@"targetsrc")]
        public string TargetSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Sort other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Sort other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Order == other.Order ||
                    Order != null &&
                    Order.Equals(other.Order)
                ) && 
                (
                    Target == other.Target ||
                    Target != null &&
                    Target.Equals(other.Target)
                ) && 
                (
                    Equals(TargetArray, other.TargetArray) ||
                    TargetArray != null && other.TargetArray != null &&
                    TargetArray.SequenceEqual(other.TargetArray)
                ) &&
                (
                    TargetSrc == other.TargetSrc ||
                    TargetSrc != null &&
                    TargetSrc.Equals(other.TargetSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Enabled != null) hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Order != null) hashCode = hashCode * 59 + Order.GetHashCode();
                if (Target != null) hashCode = hashCode * 59 + Target.GetHashCode();
                if (TargetArray != null) hashCode = hashCode * 59 + TargetArray.GetHashCode();
                if (TargetSrc != null) hashCode = hashCode * 59 + TargetSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Sort and the right Sort.
        /// </summary>
        /// <param name="left">Left Sort.</param>
        /// <param name="right">Right Sort.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Sort left, Sort right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Sort and the right Sort.
        /// </summary>
        /// <param name="left">Left Sort.</param>
        /// <param name="right">Right Sort.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Sort left, Sort right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Sort</returns>
        public Sort DeepClone()
        {
            return this.Copy();
        }
    }
}
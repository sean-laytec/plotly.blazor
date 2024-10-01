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

namespace Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib
{
    /// <summary>
    ///     The Font class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Font : IEquatable<Font>
    {
        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public IList<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>color</c>.
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     HTML font family - the typeface that will be applied by the web browser.
        ///     The web browser will only be able to apply a font if it is available on
        ///     the system which it operates. Provide multiple font families, separated
        ///     by commas, to indicate the preference in which to apply fonts if they aren&#39;t
        ///     available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com
        ///     or on-premise) generates images on a server, where only a select number
        ///     of fonts are installed and supported. These include <c>Arial</c>, <c>Balto</c>,
        ///     &#39;Courier New&#39;, &#39;Droid Sans&#39;, &#39;Droid Serif&#39;, &#39;Droid
        ///     Sans Mono&#39;, &#39;Gravitas One&#39;, &#39;Old Standard TT&#39;, &#39;Open
        ///     Sans&#39;, <c>Overpass</c>, &#39;PT Sans Narrow&#39;, <c>Raleway</c>, &#39;Times
        ///     New Roman&#39;.
        /// </summary>
        [JsonPropertyName(@"family")]
        public string Family { get; set;} 

        /// <summary>
        ///     HTML font family - the typeface that will be applied by the web browser.
        ///     The web browser will only be able to apply a font if it is available on
        ///     the system which it operates. Provide multiple font families, separated
        ///     by commas, to indicate the preference in which to apply fonts if they aren&#39;t
        ///     available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com
        ///     or on-premise) generates images on a server, where only a select number
        ///     of fonts are installed and supported. These include <c>Arial</c>, <c>Balto</c>,
        ///     &#39;Courier New&#39;, &#39;Droid Sans&#39;, &#39;Droid Serif&#39;, &#39;Droid
        ///     Sans Mono&#39;, &#39;Gravitas One&#39;, &#39;Old Standard TT&#39;, &#39;Open
        ///     Sans&#39;, <c>Overpass</c>, &#39;PT Sans Narrow&#39;, <c>Raleway</c>, &#39;Times
        ///     New Roman&#39;.
        /// </summary>
        [JsonPropertyName(@"family")]
        [Array]
        public IList<string> FamilyArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>family</c>.
        /// </summary>
        [JsonPropertyName(@"familysrc")]
        public string FamilySrc { get; set;} 

        /// <summary>
        ///     Sets the kind of decoration line(s) with text, such as an <c>under</c>,
        ///     <c>over</c> or <c>through</c> as well as combinations e.g. <c>under+over</c>,
        ///     etc.
        /// </summary>
        [JsonPropertyName(@"lineposition")]
        public Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.LinePositionFlag? LinePosition { get; set;} 

        /// <summary>
        ///     Sets the kind of decoration line(s) with text, such as an <c>under</c>,
        ///     <c>over</c> or <c>through</c> as well as combinations e.g. <c>under+over</c>,
        ///     etc.
        /// </summary>
        [JsonPropertyName(@"lineposition")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.LinePositionFlag?> LinePositionArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>lineposition</c>.
        /// </summary>
        [JsonPropertyName(@"linepositionsrc")]
        public string LinePositionSrc { get; set;} 

        /// <summary>
        ///     Sets the shape and color of the shadow behind text. <c>auto</c> places minimal
        ///     shadow and applies contrast text font color. See https://developer.mozilla.org/en-US/docs/Web/CSS/text-shadow
        ///     for additional options.
        /// </summary>
        [JsonPropertyName(@"shadow")]
        public string Shadow { get; set;} 

        /// <summary>
        ///     Sets the shape and color of the shadow behind text. <c>auto</c> places minimal
        ///     shadow and applies contrast text font color. See https://developer.mozilla.org/en-US/docs/Web/CSS/text-shadow
        ///     for additional options.
        /// </summary>
        [JsonPropertyName(@"shadow")]
        [Array]
        public IList<string> ShadowArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>shadow</c>.
        /// </summary>
        [JsonPropertyName(@"shadowsrc")]
        public string ShadowSrc { get; set;} 

        /// <summary>
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        public decimal? Size { get; set;} 

        /// <summary>
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        [Array]
        public IList<decimal?> SizeArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>size</c>.
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string SizeSrc { get; set;} 

        /// <summary>
        ///     Sets whether a font should be styled with a normal or italic face from its
        ///     family.
        /// </summary>
        [JsonPropertyName(@"style")]
        public Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.StyleEnum? Style { get; set;} 

        /// <summary>
        ///     Sets whether a font should be styled with a normal or italic face from its
        ///     family.
        /// </summary>
        [JsonPropertyName(@"style")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.StyleEnum?> StyleArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>style</c>.
        /// </summary>
        [JsonPropertyName(@"stylesrc")]
        public string StyleSrc { get; set;} 

        /// <summary>
        ///     Sets capitalization of text. It can be used to make text appear in all-uppercase
        ///     or all-lowercase, or with each word capitalized.
        /// </summary>
        [JsonPropertyName(@"textcase")]
        public Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.TextCaseEnum? TextCase { get; set;} 

        /// <summary>
        ///     Sets capitalization of text. It can be used to make text appear in all-uppercase
        ///     or all-lowercase, or with each word capitalized.
        /// </summary>
        [JsonPropertyName(@"textcase")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.TextCaseEnum?> TextCaseArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>textcase</c>.
        /// </summary>
        [JsonPropertyName(@"textcasesrc")]
        public string TextCaseSrc { get; set;} 

        /// <summary>
        ///     Sets the variant of the font.
        /// </summary>
        [JsonPropertyName(@"variant")]
        public Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.VariantEnum? Variant { get; set;} 

        /// <summary>
        ///     Sets the variant of the font.
        /// </summary>
        [JsonPropertyName(@"variant")]
        [Array]
        public IList<Plotly.Blazor.Traces.ScatterMapBoxLib.HoverLabelLib.FontLib.VariantEnum?> VariantArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>variant</c>.
        /// </summary>
        [JsonPropertyName(@"variantsrc")]
        public string VariantSrc { get; set;} 

        /// <summary>
        ///     Sets the weight (or boldness) of the font.
        /// </summary>
        [JsonPropertyName(@"weight")]
        public int? Weight { get; set;} 

        /// <summary>
        ///     Sets the weight (or boldness) of the font.
        /// </summary>
        [JsonPropertyName(@"weight")]
        [Array]
        public IList<int?> WeightArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>weight</c>.
        /// </summary>
        [JsonPropertyName(@"weightsrc")]
        public string WeightSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Font other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Font other)
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
                    Equals(ColorArray, other.ColorArray) ||
                    ColorArray != null && other.ColorArray != null &&
                    ColorArray.SequenceEqual(other.ColorArray)
                ) &&
                (
                    ColorSrc == other.ColorSrc ||
                    ColorSrc != null &&
                    ColorSrc.Equals(other.ColorSrc)
                ) && 
                (
                    Family == other.Family ||
                    Family != null &&
                    Family.Equals(other.Family)
                ) && 
                (
                    Equals(FamilyArray, other.FamilyArray) ||
                    FamilyArray != null && other.FamilyArray != null &&
                    FamilyArray.SequenceEqual(other.FamilyArray)
                ) &&
                (
                    FamilySrc == other.FamilySrc ||
                    FamilySrc != null &&
                    FamilySrc.Equals(other.FamilySrc)
                ) && 
                (
                    LinePosition == other.LinePosition ||
                    LinePosition != null &&
                    LinePosition.Equals(other.LinePosition)
                ) && 
                (
                    Equals(LinePositionArray, other.LinePositionArray) ||
                    LinePositionArray != null && other.LinePositionArray != null &&
                    LinePositionArray.SequenceEqual(other.LinePositionArray)
                ) &&
                (
                    LinePositionSrc == other.LinePositionSrc ||
                    LinePositionSrc != null &&
                    LinePositionSrc.Equals(other.LinePositionSrc)
                ) && 
                (
                    Shadow == other.Shadow ||
                    Shadow != null &&
                    Shadow.Equals(other.Shadow)
                ) && 
                (
                    Equals(ShadowArray, other.ShadowArray) ||
                    ShadowArray != null && other.ShadowArray != null &&
                    ShadowArray.SequenceEqual(other.ShadowArray)
                ) &&
                (
                    ShadowSrc == other.ShadowSrc ||
                    ShadowSrc != null &&
                    ShadowSrc.Equals(other.ShadowSrc)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Equals(SizeArray, other.SizeArray) ||
                    SizeArray != null && other.SizeArray != null &&
                    SizeArray.SequenceEqual(other.SizeArray)
                ) &&
                (
                    SizeSrc == other.SizeSrc ||
                    SizeSrc != null &&
                    SizeSrc.Equals(other.SizeSrc)
                ) && 
                (
                    Style == other.Style ||
                    Style != null &&
                    Style.Equals(other.Style)
                ) && 
                (
                    Equals(StyleArray, other.StyleArray) ||
                    StyleArray != null && other.StyleArray != null &&
                    StyleArray.SequenceEqual(other.StyleArray)
                ) &&
                (
                    StyleSrc == other.StyleSrc ||
                    StyleSrc != null &&
                    StyleSrc.Equals(other.StyleSrc)
                ) && 
                (
                    TextCase == other.TextCase ||
                    TextCase != null &&
                    TextCase.Equals(other.TextCase)
                ) && 
                (
                    Equals(TextCaseArray, other.TextCaseArray) ||
                    TextCaseArray != null && other.TextCaseArray != null &&
                    TextCaseArray.SequenceEqual(other.TextCaseArray)
                ) &&
                (
                    TextCaseSrc == other.TextCaseSrc ||
                    TextCaseSrc != null &&
                    TextCaseSrc.Equals(other.TextCaseSrc)
                ) && 
                (
                    Variant == other.Variant ||
                    Variant != null &&
                    Variant.Equals(other.Variant)
                ) && 
                (
                    Equals(VariantArray, other.VariantArray) ||
                    VariantArray != null && other.VariantArray != null &&
                    VariantArray.SequenceEqual(other.VariantArray)
                ) &&
                (
                    VariantSrc == other.VariantSrc ||
                    VariantSrc != null &&
                    VariantSrc.Equals(other.VariantSrc)
                ) && 
                (
                    Weight == other.Weight ||
                    Weight != null &&
                    Weight.Equals(other.Weight)
                ) && 
                (
                    Equals(WeightArray, other.WeightArray) ||
                    WeightArray != null && other.WeightArray != null &&
                    WeightArray.SequenceEqual(other.WeightArray)
                ) &&
                (
                    WeightSrc == other.WeightSrc ||
                    WeightSrc != null &&
                    WeightSrc.Equals(other.WeightSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                if (Family != null) hashCode = hashCode * 59 + Family.GetHashCode();
                if (FamilyArray != null) hashCode = hashCode * 59 + FamilyArray.GetHashCode();
                if (FamilySrc != null) hashCode = hashCode * 59 + FamilySrc.GetHashCode();
                if (LinePosition != null) hashCode = hashCode * 59 + LinePosition.GetHashCode();
                if (LinePositionArray != null) hashCode = hashCode * 59 + LinePositionArray.GetHashCode();
                if (LinePositionSrc != null) hashCode = hashCode * 59 + LinePositionSrc.GetHashCode();
                if (Shadow != null) hashCode = hashCode * 59 + Shadow.GetHashCode();
                if (ShadowArray != null) hashCode = hashCode * 59 + ShadowArray.GetHashCode();
                if (ShadowSrc != null) hashCode = hashCode * 59 + ShadowSrc.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                if (SizeArray != null) hashCode = hashCode * 59 + SizeArray.GetHashCode();
                if (SizeSrc != null) hashCode = hashCode * 59 + SizeSrc.GetHashCode();
                if (Style != null) hashCode = hashCode * 59 + Style.GetHashCode();
                if (StyleArray != null) hashCode = hashCode * 59 + StyleArray.GetHashCode();
                if (StyleSrc != null) hashCode = hashCode * 59 + StyleSrc.GetHashCode();
                if (TextCase != null) hashCode = hashCode * 59 + TextCase.GetHashCode();
                if (TextCaseArray != null) hashCode = hashCode * 59 + TextCaseArray.GetHashCode();
                if (TextCaseSrc != null) hashCode = hashCode * 59 + TextCaseSrc.GetHashCode();
                if (Variant != null) hashCode = hashCode * 59 + Variant.GetHashCode();
                if (VariantArray != null) hashCode = hashCode * 59 + VariantArray.GetHashCode();
                if (VariantSrc != null) hashCode = hashCode * 59 + VariantSrc.GetHashCode();
                if (Weight != null) hashCode = hashCode * 59 + Weight.GetHashCode();
                if (WeightArray != null) hashCode = hashCode * 59 + WeightArray.GetHashCode();
                if (WeightSrc != null) hashCode = hashCode * 59 + WeightSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Font and the right Font.
        /// </summary>
        /// <param name="left">Left Font.</param>
        /// <param name="right">Right Font.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Font left, Font right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Font and the right Font.
        /// </summary>
        /// <param name="left">Left Font.</param>
        /// <param name="right">Right Font.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Font left, Font right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Font</returns>
        public Font DeepClone()
        {
            return this.Copy();
        }
    }
}
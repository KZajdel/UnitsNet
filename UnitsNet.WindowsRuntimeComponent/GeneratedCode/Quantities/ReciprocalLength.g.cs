//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Reciprocal (Inverse) Length is used in various fields of science and mathematics. It is defined as the inverse value of a length unit.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Reciprocal_length
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class ReciprocalLength : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ReciprocalLengthUnit? _unit;

        static ReciprocalLength()
        {
            BaseDimensions = new BaseDimensions(-1, 0, 0, 0, 0, 0, 0);
            BaseUnit = ReciprocalLengthUnit.InverseMeter;
            MaxValue = new ReciprocalLength(double.MaxValue, BaseUnit);
            MinValue = new ReciprocalLength(double.MinValue, BaseUnit);
            QuantityType = QuantityType.ReciprocalLength;
            Units = Enum.GetValues(typeof(ReciprocalLengthUnit)).Cast<ReciprocalLengthUnit>().Except(new ReciprocalLengthUnit[]{ ReciprocalLengthUnit.Undefined }).ToArray();
            Zero = new ReciprocalLength(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.ReciprocalLength, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit InverseMeter.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public ReciprocalLength()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private ReciprocalLength(double value, ReciprocalLengthUnit unit)
        {
            if (unit == ReciprocalLengthUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of ReciprocalLength, which is InverseMeter. All conversions go via this value.
        /// </summary>
        public static ReciprocalLengthUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of ReciprocalLength
        /// </summary>
        public static ReciprocalLength MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of ReciprocalLength
        /// </summary>
        public static ReciprocalLength MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the ReciprocalLength quantity.
        /// </summary>
        public static ReciprocalLengthUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit InverseMeter.
        /// </summary>
        public static ReciprocalLength Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public ReciprocalLengthUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => ReciprocalLength.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ReciprocalLength.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseCentimeter"/>
        /// </summary>
        public double InverseCentimeters => As(ReciprocalLengthUnit.InverseCentimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseFoot"/>
        /// </summary>
        public double InverseFeet => As(ReciprocalLengthUnit.InverseFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseInch"/>
        /// </summary>
        public double InverseInches => As(ReciprocalLengthUnit.InverseInch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseMeter"/>
        /// </summary>
        public double InverseMeters => As(ReciprocalLengthUnit.InverseMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseMicroinch"/>
        /// </summary>
        public double InverseMicroinches => As(ReciprocalLengthUnit.InverseMicroinch);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseMil"/>
        /// </summary>
        public double InverseMils => As(ReciprocalLengthUnit.InverseMil);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseMile"/>
        /// </summary>
        public double InverseMiles => As(ReciprocalLengthUnit.InverseMile);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseMillimeter"/>
        /// </summary>
        public double InverseMillimeters => As(ReciprocalLengthUnit.InverseMillimeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseUsSurveyFoot"/>
        /// </summary>
        public double InverseUsSurveyFeet => As(ReciprocalLengthUnit.InverseUsSurveyFoot);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ReciprocalLengthUnit.InverseYard"/>
        /// </summary>
        public double InverseYards => As(ReciprocalLengthUnit.InverseYard);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseCentimeter, new CultureInfo("en-US"), false, true, new string[]{"cm⁻¹", "1/cm"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseFoot, new CultureInfo("en-US"), false, true, new string[]{"ft⁻¹", "1/ft"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseInch, new CultureInfo("en-US"), false, true, new string[]{"in⁻¹", "1/in"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseMeter, new CultureInfo("en-US"), false, true, new string[]{"m⁻¹", "1/m"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseMicroinch, new CultureInfo("en-US"), false, true, new string[]{"µin⁻¹", "1/µin"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseMil, new CultureInfo("en-US"), false, true, new string[]{"mil⁻¹", "1/mil"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseMile, new CultureInfo("en-US"), false, true, new string[]{"mi⁻¹", "1/mi"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseMillimeter, new CultureInfo("en-US"), false, true, new string[]{"mm⁻¹", "1/mm"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseUsSurveyFoot, new CultureInfo("en-US"), false, true, new string[]{"ftUS⁻¹", "1/ftUS"});
            unitAbbreviationsCache.PerformAbbreviationMapping(ReciprocalLengthUnit.InverseYard, new CultureInfo("en-US"), false, true, new string[]{"yd⁻¹", "1/yd"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ReciprocalLengthUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(ReciprocalLengthUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseCentimeters(double inversecentimeters)
        {
            double value = (double) inversecentimeters;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseCentimeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseFeet(double inversefeet)
        {
            double value = (double) inversefeet;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseFoot);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseInches(double inverseinches)
        {
            double value = (double) inverseinches;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseInch);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseMeters(double inversemeters)
        {
            double value = (double) inversemeters;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseMeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMicroinch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseMicroinches(double inversemicroinches)
        {
            double value = (double) inversemicroinches;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseMicroinch);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMil"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseMils(double inversemils)
        {
            double value = (double) inversemils;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseMil);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMile"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseMiles(double inversemiles)
        {
            double value = (double) inversemiles;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseMile);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseMillimeters(double inversemillimeters)
        {
            double value = (double) inversemillimeters;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseMillimeter);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseUsSurveyFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseUsSurveyFeet(double inverseussurveyfeet)
        {
            double value = (double) inverseussurveyfeet;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseUsSurveyFoot);
        }

        /// <summary>
        ///     Creates a <see cref="ReciprocalLength"/> from <see cref="ReciprocalLengthUnit.InverseYard"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ReciprocalLength FromInverseYards(double inverseyards)
        {
            double value = (double) inverseyards;
            return new ReciprocalLength(value, ReciprocalLengthUnit.InverseYard);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReciprocalLengthUnit" /> to <see cref="ReciprocalLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReciprocalLength unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ReciprocalLength From(double value, ReciprocalLengthUnit fromUnit)
        {
            return new ReciprocalLength((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ReciprocalLength Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static ReciprocalLength Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<ReciprocalLength, ReciprocalLengthUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ReciprocalLength result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out ReciprocalLength result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<ReciprocalLength, ReciprocalLengthUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ReciprocalLengthUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static ReciprocalLengthUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<ReciprocalLengthUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out ReciprocalLengthUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out ReciprocalLengthUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<ReciprocalLengthUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is ReciprocalLength objReciprocalLength)) throw new ArgumentException("Expected type ReciprocalLength.", nameof(obj));

            return CompareTo(objReciprocalLength);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(ReciprocalLength other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is ReciprocalLength objReciprocalLength))
                return false;

            return Equals(objReciprocalLength);
        }

        public bool Equals(ReciprocalLength other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another ReciprocalLength within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(ReciprocalLength other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current ReciprocalLength.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((ReciprocalLengthUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ReciprocalLengthUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this ReciprocalLength to another ReciprocalLength with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A ReciprocalLength with the specified unit.</returns>
        public ReciprocalLength ToUnit(ReciprocalLengthUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new ReciprocalLength(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case ReciprocalLengthUnit.InverseCentimeter: return _value * 1e2;
                case ReciprocalLengthUnit.InverseFoot: return _value / 0.3048;
                case ReciprocalLengthUnit.InverseInch: return _value / 2.54e-2;
                case ReciprocalLengthUnit.InverseMeter: return _value;
                case ReciprocalLengthUnit.InverseMicroinch: return _value / 2.54e-8;
                case ReciprocalLengthUnit.InverseMil: return _value / 2.54e-5;
                case ReciprocalLengthUnit.InverseMile: return _value / 1609.34;
                case ReciprocalLengthUnit.InverseMillimeter: return _value * 1e3;
                case ReciprocalLengthUnit.InverseUsSurveyFoot: return _value * 3937 / 1200;
                case ReciprocalLengthUnit.InverseYard: return _value / 0.9144;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(ReciprocalLengthUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case ReciprocalLengthUnit.InverseCentimeter: return baseUnitValue / 1e2;
                case ReciprocalLengthUnit.InverseFoot: return baseUnitValue * 0.3048;
                case ReciprocalLengthUnit.InverseInch: return baseUnitValue * 2.54e-2;
                case ReciprocalLengthUnit.InverseMeter: return baseUnitValue;
                case ReciprocalLengthUnit.InverseMicroinch: return baseUnitValue * 2.54e-8;
                case ReciprocalLengthUnit.InverseMil: return baseUnitValue * 2.54e-5;
                case ReciprocalLengthUnit.InverseMile: return baseUnitValue * 1609.34;
                case ReciprocalLengthUnit.InverseMillimeter: return baseUnitValue / 1e3;
                case ReciprocalLengthUnit.InverseUsSurveyFoot: return baseUnitValue * 1200 / 3937;
                case ReciprocalLengthUnit.InverseYard: return baseUnitValue * 0.9144;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}

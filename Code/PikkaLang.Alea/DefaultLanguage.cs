/********************************************************************************
*  File:             MockLanguage.cs                                            *
*  Contents:         Class MockLanguage                                         *
*  Author:           Alex Konnen                     (alex@viassol.eu)          *
*  Date:             2010-07-30                                                 *
*  Version:          []                                                         *
*  Copyright:        Viassol                         (webmaster@viassol.eu)     *
********************************************************************************/

using Pikkatech.MathScope.Domain.Stochastics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PikkaLang.Alea
{
	/// <summary>
	/// Simple language applicable to a great extent in most cases.
	/// </summary>
	public class DefaultLanguage : AbstractLanguage
	{
		#region Construction
		/// <summary>
		/// Initializes the element dictionaries with empirical distributions.
		/// </summary>
		protected override void Initialize()
		{
			_vowels						= new Dictionary<string,double>()
																			{
																				{"a",	0.2483},
																				{"e",	0.1985},
																				{"i",	0.1599},
																				{"o",	0.1854},
																				{"u",	0.1272},
																				{"ay",	0.0470},
																				{"ey",	0.0047},
																				{"oy",	0.0023},
																				{"au",	0.0235},
																				{"eu",	0.0023},
																				{"ou",	0.0005}
																			};

			_consonants					= new Dictionary<string,double>()
																			{
																				{"b",	0.017200},
																				{"c",	0.002194},
																				{"d",	0.054230},
																				{"f",	0.012852},
																				{"g",	0.028212},
																				{"h",	0.010971},
																				{"j",	0.010031},
																				{"k",	0.075233},
																				{"l",	0.101251},
																				{"m",	0.057052},
																				{"n",	0.154227},
																				{"p",	0.056738},
																				{"q",	0.007523},
																				{"r",	0.102818},
																				{"s",	0.104699},
																				{"t",	0.102505},
																				{"v",	0.042005},
																				{"y",	0.045767},
																				{"z",	0.011285},
																				{"st",	0.002411},
																				{"sp",	0.000482},
																				{"sk",	0.000241},
																				{"str",	0.000031}
																			};

			_syllables					= new Dictionary<SyllabicType,double>()
																			{
																				{SyllabicType.V,	0.1000},
																				{SyllabicType.CV,	0.2000},
																				{SyllabicType.VC,	0.5000},
																				{SyllabicType.CVC,	0.2000}
																			};

			InnerPunctuation			= new Dictionary<string,double>()
																			{
																				{" ",	0.9320},
																				{", ",	0.0466},
																				{"; ",	0.0093},
																				{"-",	0.0047},
																				{" - ", 0.0028},
																				{": ",	0.0047}
																			};

			FinalPunctuation			= new Dictionary<string,double>()
																			{
																				{".", 0.9090},
																				{"!", 0.0454},
																				{"?", 0.0454}
																			};

			_wordLengthDistribution		= new Dictionary<int,double>()
																			{
																				{1, 0.0294},
																				{2, 0.0588},
																				{3, 0.0882},
																				{4, 0.1176},
																				{5, 0.2353},
																				{6, 0.2941},
																				{7, 0.1471},
																				{8, 0.0294}
																			};

			_phraseLengthDistribution	= new Dictionary<int,double>()
																			{
																				{1, 0.0028},
																				{2, 0.0142},
																				{3, 0.0284},
																				{4, 0.2841},
																				{5, 0.2272},
																				{6, 0.3409},
																				{7, 0.1705},
																				{8, 0.0568},
																				{9, 0.0142},
																				{10, 0.0028}
																			};

			UpdateRandomizers(false);
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DefaultLanguage() : base()
		{
			this.Name	= "Default";
		}
		#endregion
	}
}

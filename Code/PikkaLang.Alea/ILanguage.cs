/********************************************************************************
*  File:             ILanguage.cs                                               *
*  Contents:         Class ILanguage                                            *
*  Author:           Alex Konnen                     (alex@viassol.eu)          *
*  Date:             2010-07-30                                                 *
*  Version:          []                                                         *
*  Copyright:        Viassol                         (webmaster@viassol.eu)     *
********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PikkaLang.Alea
{
	public interface ILanguage
	{
		string										Name						{get;set;}

		/// <summary>
		/// Vowels and all vowel-like atomic items of the language:
		/// vowels properly, dipthongs, triphtongs.
		/// The key is the atomic text element, the value its relative frequency in the texts.
		/// </summary>
		Dictionary<string, double>					Vowels						{get;set;}

		/// <summary>
		/// Consonants and all onsonant-like atomic items of the language:
		/// consonants properly, double and triple consonants.
		/// The key is the atomic text element, the value its relative frequency in the texts.
		/// </summary>
		Dictionary<string, double>					Consonants					{get;set;}

		Dictionary<SyllabicType, double>			Syllables					{get;set;}

		Dictionary<int, double>						WordLengthDistribution		{get;set;}

		Dictionary<int, double>						PhraseLengthDistribution	{get;set;}

		XElement									ToXElement();

		void										FromXElement(XElement x);


		SimpleWord									GetSimpleWord(int nLength);
		SimpleWord									GetSimpleWord();
		SimpleWord									GetSimpleWord(Dictionary<int, double> dctLengthDistribution);
		SimpleWord									GetSimpleWord(Dictionary<int, int> dctLengthDistribution);

		SimplePhrase								CreateSimplePhrase
																	(
																		Dictionary<int, double> dctNumberOfWordDistribution, 
																		Dictionary<int, double> dctWordLengthDistribution
																	);

		SimplePhrase								CreateSimplePhrase
																	(
																		Dictionary<int, int> dctNumberOfWordDistribution, 
																		Dictionary<int, int> dctWordLengthDistribution
																	);

		SimplePhrase								CreateSimplePhrase(int nWords, Dictionary<int, double> dctWordLengthDistribution);
		SimplePhrase								CreateSimplePhrase(int nWords, Dictionary<int, int> dctWordLengthDistribution);
		SimplePhrase								CreateSimplePhrase();
	}
}

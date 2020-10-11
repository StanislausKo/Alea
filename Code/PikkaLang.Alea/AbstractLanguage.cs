/********************************************************************************
*  File:             AbstractLanguage.cs                                        *
*  Contents:         Class AbstractLanguage                                     *
*  Author:           Alex Konnen                     (alex@viassol.eu)          *
*  Date:             2010-07-30                                                 *
*  Version:          []                                                         *
*  Copyright:        Viassol                         (webmaster@viassol.eu)     *
********************************************************************************/

using Pikkatech.Domain.Tools;
using Pikkatech.MathScope.Domain.Stochastics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PikkaLang.Alea
{
	public abstract class AbstractLanguage	: ILanguage
	{
		#region Static members
		internal static string	_version	= "1.0";
		#endregion

		#region Members
		protected Dictionary<string,		double>	_vowels;
		protected Dictionary<string,		double>	_consonants;
		protected Dictionary<SyllabicType,	double>	_syllables;
		protected Dictionary<string,		double>	_innerPunctuation;
		protected Dictionary<string,		double>	_finalPunctuation;
		protected Dictionary<int,			double>	_wordLengthDistribution;
		protected Dictionary<int,			double>	_phraseLengthDistribution;

		protected DiscreteRandomizer		_randomizerSyllables;
		protected DiscreteRandomizer		_randomizerVowels;
		protected DiscreteRandomizer		_randomizerConsonants;
		protected DiscreteRandomizer		_randomizerInnerPunctuation;
		protected DiscreteRandomizer		_randomizerFinalPunctuation;
		protected DiscreteRandomizer		_randomizerWordLength;
		protected DiscreteRandomizer		_randomizerPhraseLength;
		#endregion

		#region Properties
		public string						Name {get;set;}

		public Dictionary<string, double> Vowels
		{
			get	{return _vowels;}
			set	{_vowels = value;}
		}

		public Dictionary<string, double> Consonants
		{
			get
			{
				return _consonants;
			}
			set
			{
				_consonants = value;
			}
		}

		public Dictionary<SyllabicType, double> Syllables
		{
			get
			{
				return _syllables;
			}
			set
			{
				_syllables = value;
			}
		}

		public Dictionary<string, double> InnerPunctuation
		{
			get { return _innerPunctuation; }
			set { _innerPunctuation = value; }
		}

		public Dictionary<string, double> FinalPunctuation
		{
			get { return _finalPunctuation; }
			set { _finalPunctuation = value; }
		}

		public Dictionary<int, double> WordLengthDistribution
		{
			get { return _wordLengthDistribution; }
			set { _wordLengthDistribution = value; }
		}

		public Dictionary<int, double> PhraseLengthDistribution
		{
			get { return _phraseLengthDistribution; }
			set { _phraseLengthDistribution = value; }
		}

		public void Clear()
		{
			_vowels.Clear();
			_consonants.Clear();
			_syllables.Clear();
			_innerPunctuation.Clear();
			_finalPunctuation.Clear();
			_wordLengthDistribution.Clear();
			_phraseLengthDistribution.Clear();

			foreach (SyllabicType st in Enum.GetValues(typeof(SyllabicType)))
			{
				_syllables.Add(st, 0.0);
			}

			_syllables.Remove(SyllabicType.Unknown);
		}
		#endregion

		protected abstract void Initialize();

		#region Construction
		public AbstractLanguage()
		{
			Initialize();
		}
		#endregion

		public Syllable GetSyllable()
		{
			int				iSyllable		= _randomizerSyllables.Random();
			SyllabicType	syllabicType	= (SyllabicType)iSyllable;

			switch (syllabicType)
			{
				case SyllabicType.V:
					return new Syllable(syllabicType, GetVowel());

				case SyllabicType.CV:
					return new Syllable(syllabicType, GetConsonant() + GetVowel());

				case SyllabicType.VC:
					return new Syllable(syllabicType, GetVowel() + GetConsonant());

				case SyllabicType.CVC:
					return new Syllable(syllabicType, GetConsonant() + GetVowel() + GetConsonant());

				case SyllabicType.Unknown:
				default:
					return new Syllable();
			}
		}

		#region Word Functionality
		public SimpleWord GetSimpleWord(Dictionary<int, double> dctLengthDistribution)
		{
			DiscreteRandomizer randomizer	= new DiscreteRandomizer(dctLengthDistribution.Values.ToArray());
			int nIndex						= randomizer.Random();
			int nLength						= dctLengthDistribution.Keys.ToArray()[nIndex];

			return GetSimpleWord(nLength);
		}

		public SimpleWord GetSimpleWord(Dictionary<int, int> dctLengthDistribution)
		{
			DiscreteRandomizer randomizer	= new DiscreteRandomizer(dctLengthDistribution.Values.ToArray());
			
			int nIndex						= randomizer.Random();
			
			int nLength						= dctLengthDistribution.Keys.ToArray()[nIndex];

			return GetSimpleWord(nLength);
		}

		public SimpleWord GetSimpleWord(int nLength)
		{
			SimpleWord sw	= new SimpleWord();

			while (sw.ToString().Length <= nLength)
			{
				Syllable s	= GetSyllable();
				sw.Syllables.Add(s);
			}

			return sw;
		}

		public SimpleWord GetSimpleWord()
		{
			return GetSimpleWord(this._wordLengthDistribution);
		}
		#endregion

		#region Phrase Functionality		
		/// <summary>
		/// Creates a simple phrase.
		/// </summary>
		/// <param name="numberOfWordDistribution">The distribution of word number in a phrase.</param>
		/// <param name="wordLengthDistribution">The distribution of the length of a phrase.</param>
		/// <returns></returns>
		public SimplePhrase CreateSimplePhrase
												(
													Dictionary<int, double> numberOfWordDistribution, 
													Dictionary<int, double> wordLengthDistribution
												)
		{
			try
			{
				DiscreteRandomizer randomizer	= new DiscreteRandomizer(numberOfWordDistribution.Values.ToArray());
				int nIndex						= randomizer.Random();
				int nWords						= numberOfWordDistribution.Keys.ToArray()[nIndex];

				return CreateSimplePhrase(nWords, wordLengthDistribution);
			}
			catch (Exception)
			{
				return null;
			}
		}

		/// <summary>
		/// Creates a simple phrase.
		/// </summary>
		/// <param name="numberOfWordDistribution">The distribution of word number in a phrase.</param>
		/// <param name="wordLengthDistribution">The distribution of the length of a phrase.</param>
		/// <returns></returns>
		public SimplePhrase CreateSimplePhrase
											(
												Dictionary<int, int> numberOfWordDistribution, 
												Dictionary<int, int> wordLengthDistribution
											)
		{
			DiscreteRandomizer randomizer	= new DiscreteRandomizer(numberOfWordDistribution.Values.ToArray());
			int nIndex						= randomizer.Random();
			int nWords						= numberOfWordDistribution.Keys.ToArray()[nIndex];

			return CreateSimplePhrase(nWords, wordLengthDistribution);
		}

		/// <summary>
		/// Creates a simple phrase with a given number of words.
		/// </summary>
		/// <param name="words">The words.</param>
		/// <param name="wordLengthDistribution">The word length distribution.</param>
		/// <returns></returns>
		public SimplePhrase CreateSimplePhrase(int words, Dictionary<int, double> wordLengthDistribution)
		{
			SimplePhrase	sp	= new SimplePhrase();

			for (int i = 0; i < words; i++)
			{
				SimpleWord sw	= GetSimpleWord(wordLengthDistribution);
				sp.Parts.Add(sw);

				if (i < words - 1)
				{
					int iInnerPunctuation	= _randomizerInnerPunctuation.Random();
					PunctuationSign ps		= new PunctuationSign();
					ps.Value				= _innerPunctuation.Keys.ToArray()[iInnerPunctuation];
					sp.Parts.Add(ps);
				}
			}

			int iFinalPunctuation			= _randomizerFinalPunctuation.Random();
			PunctuationSign psFinal			= new PunctuationSign();
			psFinal.Value					= _finalPunctuation.Keys.ToArray()[iFinalPunctuation];

			sp.Parts.Add(psFinal);

			return sp;
		}

		/// <summary>
		/// Creates a simple phrase with a given number of words.
		/// </summary>
		/// <param name="words">The words.</param>
		/// <param name="wordLengthDistribution">The word length distribution.</param>
		/// <returns></returns>
		public SimplePhrase CreateSimplePhrase(int nWords, Dictionary<int, int> wordLengthDistribution)
		{
			SimplePhrase	sp	= new SimplePhrase();

			for (int i = 0; i < nWords; i++)
			{
				SimpleWord sw	= GetSimpleWord(wordLengthDistribution);
				sp.Parts.Add(sw);

				if (i < nWords - 1)
				{
					int iInnerPunctuation	= _randomizerInnerPunctuation.Random();
					PunctuationSign ps		= new PunctuationSign();
					ps.Value					= _innerPunctuation.Keys.ToArray()[iInnerPunctuation];
					sp.Parts.Add(ps);
				}
			}

			int iFinalPunctuation			= _randomizerFinalPunctuation.Random();
			PunctuationSign psFinal			= new PunctuationSign();
			psFinal.Value					= _finalPunctuation.Keys.ToArray()[iFinalPunctuation];

			sp.Parts.Add(psFinal);

			return sp;
		}

		/// <summary>
		/// Creates a simple phrase with default phrase length and word length distributions.
		/// </summary>
		/// <returns></returns>
		public SimplePhrase CreateSimplePhrase()
		{
			return CreateSimplePhrase(this._phraseLengthDistribution, _wordLengthDistribution);
		}
		#endregion

		public bool IsVowel(string s)
		{
			return this._vowels.ContainsKey(s);
		}

		public bool IsConsonant(string s)
		{
			return this._consonants.ContainsKey(s);
		}

		protected string GetVowel()
		{
			int iRandom	= _randomizerVowels.Random();
			return _vowels.Keys.ToArray()[iRandom];
		}

		protected string GetConsonant()
		{
			int iRandom	= _randomizerConsonants.Random();
			return _consonants.Keys.ToArray()[iRandom];
		}

		#region XML
		public XElement ToXElement()
		{
			XElement x	= new XElement
										(
											"AleaLanguage", 
											new XAttribute("Name", this.Name), 
											new XAttribute("Version", _version), 
											new XAttribute("LastModified", DateTime.Now)
										);

			XElement xWordLengthDistribution	= new XElement("WordLengthDistribution");
			XElement xPhraseLengthDistribution	= new XElement("PhraseLengthDistribution");
			XElement xVowels					= new XElement("Vowels");
			XElement xConsonants				= new XElement("Consonants");
			XElement xSyllables					= new XElement("Syllables");
			XElement xInternalPunctuation		= new XElement("InternalPunctuation");
			XElement xFinalPunctuation			= new XElement("FinalPunctuation");

			x.Add(xWordLengthDistribution);
			x.Add(xPhraseLengthDistribution);
			x.Add(xVowels);
			x.Add(xConsonants);
			x.Add(xSyllables);
			x.Add(xInternalPunctuation);
			x.Add(xFinalPunctuation);

			foreach (int key in this._wordLengthDistribution.Keys)
			{
				xWordLengthDistribution.Add(new XElement("WordLength", new XAttribute("Value", key), new XAttribute("Frequency", this._wordLengthDistribution[key])));
			}

			foreach (int key in this._phraseLengthDistribution.Keys)
			{
				xPhraseLengthDistribution.Add(new XElement("PhraseLength", new XAttribute("Value", key), new XAttribute("Frequency", this._phraseLengthDistribution[key])));
			}

			foreach (string key in this._vowels.Keys)
			{
				xVowels.Add(new XElement("Vowel", new XAttribute("Value", key), new XAttribute("Frequency", this._vowels[key])));
			}

			foreach (string key in this._consonants.Keys)
			{
				xConsonants.Add(new XElement("Consonant", new XAttribute("Value", key), new XAttribute("Frequency", this._consonants[key])));
			}

			foreach (SyllabicType key in this._syllables.Keys)
			{
				xSyllables.Add(new XElement("Syllable", new XAttribute("Value", key), new XAttribute("Frequency", this._syllables[key])));
			}

			foreach (string key in this._innerPunctuation.Keys)
			{
				xInternalPunctuation.Add(new XElement("Sign", new XAttribute("Value", key), new XAttribute("Frequency", this._innerPunctuation[key])));
			}

			foreach (string key in this._finalPunctuation.Keys)
			{
				xFinalPunctuation.Add(new XElement("Sign", new XAttribute("Value", key), new XAttribute("Frequency", this._finalPunctuation[key])));
			}

			return x;
		}

		public void FromXElement(XElement x)
		{
			this.Name							= XmlTools.GetStringAttributeValue(x, "Name");

			XElement xWordLengthDistribution	= x.Element("WordLengthDistribution");
			XElement xPhraseLengthDistribution	= x.Element("PhraseLengthDistribution");
			XElement xVowels					= x.Element("Vowels");
			XElement xConsonants				= x.Element("Consonants");
			XElement xSyllables					= x.Element("Syllables");
			XElement xInternalPunctuation		= x.Element("InternalPunctuation");
			XElement xFinalPunctuation			= x.Element("FinalPunctuation");

			this._wordLengthDistribution.Clear();
			this._phraseLengthDistribution.Clear();
			this._vowels.Clear();
			this._consonants.Clear();
			this._syllables.Clear();
			this._innerPunctuation.Clear();
			this._finalPunctuation.Clear();

			foreach (XElement xItem in xWordLengthDistribution.Elements("WordLength"))
			{
				try
				{
					int	value			= Int32.Parse(xItem.Attribute("Value").Value);
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._wordLengthDistribution.Add(value, frequency);
				}
				catch {}
			}

			foreach (XElement xItem in xPhraseLengthDistribution.Elements("PhraseLength"))
			{
				try
				{
					int	value			= Int32.Parse(xItem.Attribute("Value").Value);
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._phraseLengthDistribution.Add(value, frequency);
				}
				catch {}
			}

			foreach (XElement xItem in xVowels.Elements("Vowel"))
			{
				try
				{
					string	value		= xItem.Attribute("Value").Value;
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._vowels.Add(value, frequency);
				}
				catch {}
			}

			foreach (XElement xItem in xConsonants.Elements("Consonant"))
			{
				try
				{
					string	value		= xItem.Attribute("Value").Value;
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._consonants.Add(value, frequency);
				}
				catch {}
			}

			foreach (XElement xItem in xSyllables.Elements("Syllable"))
			{
				try
				{
					SyllabicType type	= (SyllabicType)Enum.Parse(typeof(SyllabicType), xItem.Attribute("Value").Value);
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._syllables.Add(type, frequency);
				}
				catch {}
			}

			foreach (XElement xItem in xInternalPunctuation.Elements("Sign"))
			{
				try
				{
					string	value		= xItem.Attribute("Value").Value;
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._innerPunctuation.Add(value, frequency);
				}
				catch {}
			}

			foreach (XElement xItem in xFinalPunctuation.Elements("Sign"))
			{
				try
				{
					string	value		= xItem.Attribute("Value").Value;
					double frequency	= Double.Parse(xItem.Attribute("Frequency").Value);
					this._finalPunctuation.Add(value, frequency);
				}
				catch {}
			}

			this.UpdateRandomizers();
		}
		#endregion

		#region Public Modifiers
		/// <summary>
		/// Resets the randomizers with respect to the corresponding language elements.
		/// </summary>
		/// <param name="isNormalized">
		///		Flag showing wheather the values of the dictionary are already normalized.
		/// </param>
		public void UpdateRandomizers(bool isNormalized)
		{
			try
			{
				_randomizerSyllables		= new DiscreteRandomizer(_syllables.Values.ToArray(),					isNormalized);
				_randomizerVowels			= new DiscreteRandomizer(_vowels.Values.ToArray(),						isNormalized);
				_randomizerConsonants		= new DiscreteRandomizer(_consonants.Values.ToArray(),					isNormalized);
				_randomizerInnerPunctuation	= new DiscreteRandomizer(InnerPunctuation.Values.ToArray(),				isNormalized);
				_randomizerFinalPunctuation	= new DiscreteRandomizer(FinalPunctuation.Values.ToArray(),				isNormalized);
				_randomizerWordLength		= new DiscreteRandomizer(_wordLengthDistribution.Values.ToArray());
				_randomizerPhraseLength		= new DiscreteRandomizer(_phraseLengthDistribution.Values.ToArray());
			}
			catch (Exception)	
			{
			}
		}

		/// <summary>
		/// Resets the randomizers with respect to the corresponding language elements supposing that the values are normalized.
		/// </summary>
		public void UpdateRandomizers()
		{
			UpdateRandomizers(true);
		}
		#endregion
	}
}

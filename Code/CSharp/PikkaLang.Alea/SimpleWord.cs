/********************************************************************************
*  File:             SimpleWord.cs                                              *
*  Contents:         Class SimpleWord                                           *
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
	/// <summary>
	/// Simple word, contains only the list of (basic) syllables.
	/// </summary>
	public class SimpleWord : IWord
	{
		#region IWord Members
		public List<Syllable> Syllables {get; set;} = new List<Syllable>();
		#endregion

		public override string ToString()
		{
			string result = "";

			foreach (Syllable syllable in this.Syllables)
			{
				result	+= syllable.Value;
			}

			return result;
		}

		#region XML
		public XElement ToXElement()
		{
			XElement x	= new XElement("Word");

			foreach (Syllable syllable in this.Syllables)
			{
				x.Add(syllable.ToXElement());
			}

			return x;
		}

		public static SimpleWord FromXElement(XElement x)
		{
			SimpleWord word	= new SimpleWord();

			foreach (XElement xSyllable in x.Elements("Syllable"))
			{
				word.Syllables.Add(Syllable.FromXElement(xSyllable));
			}

			return word;
		}
		#endregion
	}
}

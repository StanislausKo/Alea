/********************************************************************************
*  File:             SimplePhrase.cs                                            *
*  Contents:         Class SimplePhrase                                         *
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
	/// 
	/// </summary>
	public class SimplePhrase
	{
		#region Access
		/// <summary>
		/// List of the words.
		/// </summary>
		public List<IPhrasePart> Parts {get;set;} = new List<IPhrasePart>();
		#endregion

		#region Overridden
		public override string ToString()
		{
			StringBuilder sb	= new StringBuilder();
			
			foreach (IPhrasePart part in Parts)
			{
				sb.Append(part);
			}

			string strResult	= sb.ToString();
			strResult			= strResult.Substring(0, 1).ToUpper() + strResult.Substring(1);

			return strResult;
		}
		#endregion

		#region XML
		public XElement ToXElement()
		{
			XElement x	= new XElement("Phrase");

			foreach (IPhrasePart item in this.Parts)
			{
				x.Add(item.ToXElement());
			}

			return x;
		}

		public static SimplePhrase FromXElement(XElement x)
		{
			SimplePhrase phrase	= new SimplePhrase();

			foreach (XElement xItem in x.Elements())
			{
				IPhrasePart phrasePart = null;

				switch (xItem.Name.ToString())
				{
					case "Word":
						phrasePart	= SimpleWord.FromXElement(xItem);
						break;

					case "PunctuationSign":
						phrasePart	= PunctuationSign.FromXElement(xItem);
						break;

					default:
						break;
				}

				if (phrasePart != null)
				{
					phrase.Parts.Add(phrasePart);
				}
			}

			return phrase;
		}
		#endregion
	}
}

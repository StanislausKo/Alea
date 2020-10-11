/********************************************************************************
*  File:             Syllable.cs                                                *
*  Contents:         Class Syllable                                             *
*  Author:           Alex Konnen                     (alex@viassol.eu)          *
*  Date:             2010-07-30                                                 *
*  Version:          []                                                         *
*  Copyright:        Viassol                         (webmaster@viassol.eu)     *
********************************************************************************/

using Pikkatech.Domain.Tools;
using System.Xml.Linq;

namespace PikkaLang.Alea
{
	public class Syllable
	{
		#region Properties
		/// <summary>
		/// Syllable string
		/// </summary>
		public string		Value			{get;set;}

		/// <summary>
		/// Syllable type
		/// </summary>
		public SyllabicType	SyllableType	{get;set;}
		#endregion

		#region Construction
		public Syllable(SyllabicType type, string text)
		{
			this.SyllableType	= type;
			this.Value			= text;
		}

		public Syllable(SyllabicType type) : this(type, "")	{}

		public Syllable() : this(SyllabicType.Unknown)					{}
		#endregion

		public bool IsEmpty()
		{
			return this.Value.Length < 1;
		}

		public override string ToString()
		{
			return this.Value;
		}

		#region XML
		public XElement ToXElement()
		{
			return new XElement("Syllable", new XAttribute("Type", this.SyllableType), new XAttribute("Text", this.Value));
		}

		public static Syllable FromXElement(XElement x)
		{
			Syllable syllable		= new Syllable();

			syllable.SyllableType	= XmlTools.GetEnumAttributeValue<SyllabicType>(x, "Type");
			syllable.Value			= XmlTools.GetStringAttributeValue(x, "Value");

			return syllable;
		}
		#endregion
	}
}

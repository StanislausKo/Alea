/********************************************************************************
*  File:             PunctuationSign.cs                                         *
*  Contents:         Class PunctuationSign                                      *
*  Author:           Alex Konnen                     (alex@viassol.eu)          *
*  Date:             2010-07-30                                                 *
*  Version:          []                                                         *
*  Copyright:        Viassol                         (webmaster@viassol.eu)     *
********************************************************************************/

using Pikkatech.Domain.Tools;
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
	public class PunctuationSign : IPhrasePart
	{
		public string Value			{get;set;}

		public override string ToString()
		{
			return this.Value;
		}

		#region XML
		public XElement ToXElement()
		{
			return new XElement("PunctuationSign", new XAttribute("Text", this.Value));
		}

		public static PunctuationSign FromXElement(XElement x)
		{
			PunctuationSign sign	= new PunctuationSign();
			sign.Value				= XmlTools.GetStringAttributeValue(x, "Value");
			return sign;
		}
		#endregion
	}
}

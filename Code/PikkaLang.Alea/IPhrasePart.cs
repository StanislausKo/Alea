/********************************************************************************
*  File:             IPhrasePart.cs                                             *
*  Contents:         Class IPhrasePart                                          *
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
	public interface IPhrasePart
	{
		#region XML
		XElement ToXElement();
		#endregion
	}
}

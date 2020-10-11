/********************************************************************************
*  File:             IWord.cs                                                   *
*  Contents:         Class IWord                                                *
*  Author:           Alex Konnen                     (alex@viassol.eu)          *
*  Date:             2010-07-30                                                 *
*  Version:          []                                                         *
*  Copyright:        Viassol                         (webmaster@viassol.eu)     *
********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PikkaLang.Alea
{
	public interface IWord : IPhrasePart
	{
		List<Syllable>		Syllables			{get;set;}
	}
}

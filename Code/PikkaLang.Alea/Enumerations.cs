using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikkaLang.Alea
{
	/// <summary>
	/// Syllable type
	/// </summary>
	public enum SyllabicType
	{
		/// <summary>
		/// Unknown syllable type.
		/// </summary>
		Unknown	= -1,

		/// <summary>
		/// Vocalic syllable
		/// </summary>
		V	= 0,

		/// <summary>
		/// "CV" syllable, e.g. 'cu'
		/// </summary>
		CV	= 1,

		/// <summary>
		/// "VC" syllable
		/// </summary>
		VC	= 2,

		/// <summary>
		/// "CVC" syllable.
		/// </summary>
		CVC	= 3
	}
}

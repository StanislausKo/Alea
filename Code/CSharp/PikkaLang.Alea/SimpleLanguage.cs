using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikkaLang.Alea
{
	public class SimpleLanguage : AbstractLanguage
	{
		public SimpleLanguage()
		{
		}

		protected override void Initialize()
		{
			this._vowels					= new Dictionary<string, double>();
			this._consonants				= new Dictionary<string, double>();
			this._syllables					= new Dictionary<SyllabicType, double>();
			this.InnerPunctuation			= new Dictionary<string, double>();	
			this.FinalPunctuation			= new Dictionary<string, double>();	
			this._wordLengthDistribution	= new Dictionary<int, double>();
			this._phraseLengthDistribution	= new Dictionary<int, double>();

			this.UpdateRandomizers(false);
		}
	}
}

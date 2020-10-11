using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using PikkaLang.Alea;

namespace Alea
{
	public partial class PasswordGeneratorDialog : Form
	{
		AbstractLanguage	_language;
		bool				_useOwnLanguage	= false;
		AleaForm			_aleaForm		= null;

		public PasswordGeneratorDialog(bool bUseOwnLanguage, AleaForm form)
		{
			InitializeComponent();

			_useOwnLanguage		= bUseOwnLanguage;
			_aleaForm				= form;

			if (_aleaForm != null)
			{
				_language			= _aleaForm._language;
			}

			if (!_useOwnLanguage)
			{
				return;
			}

			_language.Consonants	= new Dictionary<string,double>
			{
				{"b", 1},
				{"d", 1},
				{"f", 3},
				{"g", 2},
				{"h", 3},
				{"k", 2},
				{"l", 5},
				{"m", 8},
				{"n", 8},
				{"p", 5},
				{"r", 8},
				{"s", 10},
				{"t", 5},
				{"v", 3},
				{"z", 1}
			};

			_language.Vowels		= new Dictionary<string,double>
			{
				{"a", 5},
				{"e", 10},
				{"i", 5},
				{"o", 8},
				{"u", 1},
			};

			_language.Syllables	= new Dictionary<SyllabicType,double>
			{
				{SyllabicType.CV, 5},
				{SyllabicType.VC, 5},
				{SyllabicType.V,  1}
			};

			_language.InnerPunctuation	= new Dictionary<string,double>
			{
				{" ", 1}
			};

			_language.FinalPunctuation	= new Dictionary<string,double>
			{
				{" ", 1}
			};

			_language.WordLengthDistribution	= new Dictionary<int,double>
			{
				{4, 1}
			};

			_language.UpdateRandomizers(false);
		}

		public PasswordGeneratorDialog(AleaForm form)	: this(false, form) {}

		public PasswordGeneratorDialog()				: this(true, null) {}

		private void OnGenerate(object sender, EventArgs e)
		{
			Regex rx	= new Regex("[A-Z][a-z]*|[0-9]+");

			MatchCollection matches	= rx.Matches(m_tbPattern.Text);

			string strResult		= "";

			foreach (Match match in matches)
			{
				if (Char.IsLetter(match.Value[0]))
				{
					_language.WordLengthDistribution.Clear();
					_language.WordLengthDistribution.Add(match.Value.Length, 1);

					string strSegment	= _language.GetSimpleWord(match.Value.Length).ToString();

					strResult			+= strSegment.Substring(0, 1).ToUpper() + strSegment.Substring(1);
				}
				else
				{
					Random random		= new Random((int)DateTime.Now.Ticks);

					int nMax			= 1;

					for (int i = 0; i < match.Value.Length; i++)
					{
						nMax			*= 10;
					}

					int nSegment		= random.Next(nMax);

					strResult			+= nSegment.ToString();
				}

				m_tbPasswo.Text			= strResult;
			}
		}

		private void OnCopy(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(m_tbPasswo.Text);
		}

		private void OnClose(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

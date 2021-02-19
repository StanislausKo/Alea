using PikkaLang.Alea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Alea
{
	public partial class AleaForm : Form
	{
		#region Memners
		internal AbstractLanguage	_language			= new DefaultLanguage();
		private string				_languageFileName	= null;
		#endregion

		#region Construction
		public AleaForm()
		{
			InitializeComponent();
			this.SetTitle();
			this._lblInfo.Text				= $"Language: {this._language.Name}";
			this._nudNumberOfPhrases.Value	= 10;
		}
		#endregion

		#region Menu Event Handlers
		private void OnLanguageNew(object sender, EventArgs e)
		{
			SettingsDialog dlg	= new SettingsDialog();

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				this._language		= dlg.Language;
				this._lblInfo.Text	= $"Language: {this._language.Name}";
			}
		}

		private void OnLanguageLoad(object sender, EventArgs e)
		{
			OpenFileDialog	ofd			= new OpenFileDialog();
			ofd.Filter					= "Alea files (*.alea)|*.alea|XML files (*.xml)|*.xml";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				this._languageFileName	= ofd.FileName;

				XElement x				= XElement.Load(this._languageFileName);

				this._language			= new SimpleLanguage();
				this._language.FromXElement(x);
				this._lblInfo.Text		= $"Language: {this._language.Name}";
			}
		}

		private void OnLanguageSave(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(this._languageFileName))
			{
				XElement x	= this._language.ToXElement();
				x.Save(this._languageFileName);
			}
			else
			{
				this.OnLanguageSaveAs(sender, e);
			}
		}

		private void OnLanguageSaveAs(object sender, EventArgs e)
		{
			SaveFileDialog sfd	= new SaveFileDialog();
			sfd.Filter			= "Alea files (*.alea)|*.alea|XML files (*.xml)|*.xml";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				this._languageFileName	= sfd.FileName;
				this.OnLanguageSave(sender, e);
			}
		}

		private void OnLanguageDefault(object sender, EventArgs e)
		{
			this._language		= new DefaultLanguage();
			this._lblInfo.Text	= $"Language: {this._language.Name}";
		}

		private void OnLanguageQuit(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnTextGenerate(object sender, EventArgs e)
		{
			this._txResult.Clear();

			for (int i = 0; i < (int)this._nudNumberOfPhrases.Value; i++)
			{
				SimplePhrase phrase	= this._language.CreateSimplePhrase();

				if (phrase != null)
				{
					this._txResult.AppendText(phrase.ToString() + " ");
				}
			}
		}

		private void OnTextToClipboard(object sender, EventArgs e)
		{
			Clipboard.SetText(this._txResult.Text);
		}

		private void OnTextSave(object sender, EventArgs e)
		{
			SaveFileDialog	sfd	= new SaveFileDialog();
			sfd.Filter			= "Text files (*.txt)|*.txt|All files(*.*)|*.*";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer	= new StreamWriter(sfd.FileName))
				{
					writer.Write(this._txResult.Text);
				}
			}
		}

		private void OnToolsCreatePassword(object sender, EventArgs e)
		{
			PasswordGeneratorDialog dlg	= new PasswordGeneratorDialog(this);
			dlg.ShowDialog();
		}

		private void OnToolsSettings(object sender, EventArgs e)
		{
			SettingsDialog dlg									= new SettingsDialog();
			dlg.m_tbLanguageName.Text							= _language.Name;
			dlg.m_udNumberOfPhrases.Value						= (int)this._nudNumberOfPhrases.Value;

			SetIntegerData(_language.WordLengthDistribution,	dlg.m_dgvWordLength);
			SetIntegerData(_language.PhraseLengthDistribution,	dlg.m_dgvPhraseLength);

			SetStringData(_language.Vowels,						dlg.m_dgvVowels);
			SetStringData(_language.Consonants,					dlg.m_dgvConsonants);
			SetSyllableTypeData(_language.Syllables,			dlg.m_dgvSyllableTypes);
			SetStringData(_language.InnerPunctuation,			dlg.m_dgvInnerPunctuation);
			SetStringData(_language.FinalPunctuation,			dlg.m_dgvFinalPunctuation);

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				 _language.Name									= dlg.m_tbLanguageName.Text;

				this._nudNumberOfPhrases.Value					= (int)dlg.m_udNumberOfPhrases.Value;

				GetIntegerData(dlg.m_dgvWordLength,				_language.WordLengthDistribution);
				GetIntegerData(dlg.m_dgvPhraseLength,			_language.PhraseLengthDistribution);

				GetStringData(dlg.m_dgvVowels,					_language.Vowels);
				GetStringData(dlg.m_dgvConsonants,				_language.Consonants);
				GetSyllableTypeData(dlg.m_dgvSyllableTypes,		_language.Syllables);
				GetStringData(dlg.m_dgvInnerPunctuation,		_language.InnerPunctuation);
				GetStringData(dlg.m_dgvFinalPunctuation,		_language.FinalPunctuation);

				_language.UpdateRandomizers();
			}
		}

		private void OnHelpAbout(object sender, EventArgs e)
		{
			AleaAboutBox	aboutBox	= new AleaAboutBox();
			aboutBox.ShowDialog();
		}
		#endregion

		#region Private Auxiliary
		private void SetTitle()
		{
			Assembly asm = Assembly.GetAssembly(this.GetType());

			string strProduct = asm.GetName().Name;
			string version = asm.GetName().Version.ToString();

			string description					= null;
			string company						= null;

			object ada							= asm.GetCustomAttributes(true).FirstOrDefault(z=>z.GetType() == typeof(AssemblyDescriptionAttribute));

			if (ada != null)
			{
				description						= (ada as AssemblyDescriptionAttribute).Description;
			}

			object aca							= asm.GetCustomAttributes(true).FirstOrDefault(z=>z.GetType() == typeof(AssemblyCompanyAttribute));

			if (aca != null)
			{
				company							= (aca as AssemblyCompanyAttribute).Company;
			}

			string title						= strProduct;

			if (!String.IsNullOrEmpty(description))
			{
				title							+= $" ({description})";
			}

			string result						= $"{title}. Version {version}";

			if (!String.IsNullOrEmpty(company))
			{
				result							+= $" ({company})";
			}

			this.Text	= result;
		}

		private void SetIntegerData(Dictionary<int, double> dctData, DataGridView dgv)
		{
			foreach (int iKey in dctData.Keys)
			{
				dgv.Rows.Add(iKey, (int)(10000 * dctData[iKey]));
			}
		}

		private void GetIntegerData(DataGridView dgv, Dictionary<int, double> dctData)
		{
			dctData.Clear();
			double dSum					= 0;

			foreach (DataGridViewRow row in dgv.Rows)
			{
				double dValue			= Convert.ToDouble(row.Cells[1].Value);
				dSum					+= dValue;
			}

			foreach (DataGridViewRow row in dgv.Rows)
			{
				int iKey				= Convert.ToInt32(row.Cells[0].Value);
				double dValue			= Convert.ToDouble(row.Cells[1].Value);

				try
				{
					dctData.Add(iKey, dValue / dSum);
				}
				catch(Exception) {}
			}
		}

		private void SetStringData(Dictionary<string, double> dctData, DataGridView dgv)
		{
			foreach (string strKey in dctData.Keys)
			{
				dgv.Rows.Add(strKey, (int)(10000 * dctData[strKey]));
			}
		}

		private void GetStringData(DataGridView dgv, Dictionary<string, double> dctData)
		{
			dctData.Clear();

			double dSum					= 0;

			foreach (DataGridViewRow row in dgv.Rows)
			{
				double dValue			= Convert.ToDouble(row.Cells[1].Value);
				dSum					+= dValue;
			}

			foreach (DataGridViewRow row in dgv.Rows)
			{
				string strKey			= row.Cells[0].Value as string;
				double dValue			= Convert.ToDouble(row.Cells[1].Value);

				try
				{
					dctData.Add(strKey, dValue / dSum);
				}
				catch(Exception) {}
			}
		}

		private void SetSyllableTypeData(Dictionary<SyllabicType, double> dctData, DataGridView dgv)
		{
			foreach (SyllabicType eKey in dctData.Keys)
			{
				dgv.Rows.Add(eKey, (int)(10000 * dctData[eKey]));
			}
		}

		private void GetSyllableTypeData(DataGridView dgv, Dictionary<SyllabicType, double> dctData)
		{
			dctData.Clear();
			double dSum						= 0;

			foreach (DataGridViewRow row in dgv.Rows)
			{
				double dValue			= Convert.ToDouble(row.Cells[1].Value);
				dSum					+= dValue;
			}

			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (row.Cells[0].Value != null)
				{
					string strValue		= row.Cells[0].Value.ToString();
					SyllabicType eKey	= (SyllabicType)Enum.Parse(typeof(SyllabicType), strValue);
					double dValue		= Convert.ToDouble(row.Cells[1].Value);

					try
					{
						dctData.Add(eKey, dValue / dSum);
					}
					catch(Exception) {}
				}
			}
		}
		#endregion
	}
}

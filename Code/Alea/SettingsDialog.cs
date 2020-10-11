using PikkaLang.Alea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alea
{
	public partial class SettingsDialog : Form
	{
		public SettingsDialog()
		{
			InitializeComponent();
		}

		public SimpleLanguage Language
		{
			get
			{
				try
				{
					SimpleLanguage language	= new SimpleLanguage();

					language.Name			= this.m_tbLanguageName.Text;

					foreach (DataGridViewRow row in this.m_dgvConsonants.Rows)
					{
						try
						{
							string value		= row.Cells[0].Value.ToString();
							double frequency	= Double.Parse(row.Cells[1].Value.ToString());
							language.Consonants.Add(value, frequency);
						}
						catch (Exception)
						{

						}
					}

					foreach (DataGridViewRow row in this.m_dgvVowels.Rows)
					{
						try
						{
							string value		= row.Cells[0].Value.ToString();
							double frequency	= Double.Parse(row.Cells[1].Value.ToString());
							language.Vowels.Add(value, frequency);
						}
						catch (Exception)
						{

						}
					}

					foreach (DataGridViewRow row in this.m_dgvSyllableTypes.Rows)
					{
						try
						{
							string value				= row.Cells[0].Value.ToString();
							SyllabicType syllabicType	= (SyllabicType)Enum.Parse(typeof(SyllabicType), value);
							double frequency			= Double.Parse(row.Cells[1].Value.ToString());
							language.Syllables.Add(syllabicType, frequency);
						}
						catch (Exception)
						{

						}
					}

					foreach (DataGridViewRow row in this.m_dgvWordLength.Rows)
					{
						try
						{
							int value					= Int32.Parse(row.Cells[0].Value.ToString());
							double frequency			= Double.Parse(row.Cells[1].Value.ToString());
							language.WordLengthDistribution.Add(value, frequency);
						}
						catch (Exception)
						{

						}
					}

					foreach (DataGridViewRow row in this.m_dgvPhraseLength.Rows)
					{
						try
						{
							int value					= Int32.Parse(row.Cells[0].Value.ToString());
							double frequency			= Double.Parse(row.Cells[1].Value.ToString());
							language.PhraseLengthDistribution.Add(value, frequency);
						}
						catch (Exception)
						{

						}
					}
					
					foreach (DataGridViewRow row in this.m_dgvInnerPunctuation.Rows)
					{
						try
						{
							string value		= row.Cells[0].Value.ToString();
							double frequency	= Double.Parse(row.Cells[1].Value.ToString());
							language.InnerPunctuation.Add(value, frequency);
						}
						catch (Exception)
						{

						}
					}

					foreach (DataGridViewRow row in this.m_dgvFinalPunctuation.Rows)
					{
						try
						{
							string value		= row.Cells[0].Value.ToString();
							double frequency	= Double.Parse(row.Cells[1].Value.ToString());
							language.FinalPunctuation.Add(value, frequency);
						}
						catch (Exception)
						{

						}
					}

					language.WordLengthDistribution		= this.Normalize(language.WordLengthDistribution);
					language.PhraseLengthDistribution	= this.Normalize(language.PhraseLengthDistribution);
					language.Vowels						= this.Normalize(language.Vowels);
					language.Consonants					= this.Normalize(language.Consonants);
					language.Syllables					= this.Normalize(language.Syllables);
					language.InnerPunctuation			= this.Normalize(language.InnerPunctuation);
					language.FinalPunctuation			= this.Normalize(language.FinalPunctuation);

					language.UpdateRandomizers();

					return language;
				}
				catch (Exception ex)
				{
					return null;
				}
			}
		}

		private Dictionary<int, double> Normalize(Dictionary<int, double> source)
		{
			Dictionary<int, double> target	= new Dictionary<int, double>();

			double sum	= source.Values.Sum();

			if (sum == 0)
			{
				return source;
			}

			foreach (int key in source.Keys)
			{
				target.Add(key, source[key]	/ sum);
			}

			return target;
		}

		private Dictionary<string, double> Normalize(Dictionary<string, double> source)
		{
			Dictionary<string, double> target	= new Dictionary<string, double>();

			double sum	= source.Values.Sum();

			if (sum == 0)
			{
				return source;
			}

			foreach (string key in source.Keys)
			{
				target.Add(key, source[key]	/ sum);
			}

			return target;
		}

		private Dictionary<SyllabicType, double> Normalize(Dictionary<SyllabicType, double> source)
		{
			Dictionary<SyllabicType, double> target	= new Dictionary<SyllabicType, double>();

			double sum	= source.Values.Sum();

			if (sum == 0)
			{
				return source;
			}

			foreach (SyllabicType key in source.Keys)
			{
				target.Add(key, source[key]	/ sum);
			}

			return target;
		}
	}
}

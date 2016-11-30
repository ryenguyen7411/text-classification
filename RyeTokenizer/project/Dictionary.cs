using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LollipopUI
{
	public static class Dictionary
	{
		public static ArrayList m_words1 = new ArrayList();
		public static ArrayList m_words2 = new ArrayList();
		public static ArrayList m_words3 = new ArrayList();
		public static ArrayList m_words4 = new ArrayList();

		public static ArrayList m_stopWords = new ArrayList();

		public static void LoadWordsList(string path)
		{
			var _filestream = new System.IO.FileStream(path,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _file = new System.IO.StreamReader(_filestream, System.Text.Encoding.UTF8, true, 128);

			string _word = null;
			while ((_word = _file.ReadLine()) != null)
			{
				int _countSyllable = CountSyllable(_word);

				switch (_countSyllable)
				{
					case 1:
						m_words1.Add(_word);
						break;
					case 2:
						m_words2.Add(_word);
						break;
					case 3:
						m_words3.Add(_word);
						break;
					case 4:
						m_words4.Add(_word);
						break;
					default:
						m_words4.Add(_word);
						break;
				}
			}

			_file.Dispose();
			_filestream.Dispose();
		}

		public static void LoadStopWords(string path)
		{
			var _filestream = new System.IO.FileStream(path,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _file = new System.IO.StreamReader(_filestream, System.Text.Encoding.UTF8, true, 128);

			string _word = null;
			while ((_word = _file.ReadLine()) != null)
			{
				m_stopWords.Add(_word);

				int _countSyllable = CountSyllable(_word);

				switch (_countSyllable)
				{
					case 1:
						m_words1.Remove(_word);
						break;
					case 2:
						m_words2.Remove(_word);
						break;
					case 3:
						m_words3.Remove(_word);
						break;
					case 4:
						m_words4.Remove(_word);
						break;
					default:
						m_words4.Remove(_word);
						break;
				}
			}

			_file.Dispose();
			_filestream.Dispose();
		}

		public static void Sync(string path, string newPath)
		{
			var _readStream = new System.IO.FileStream(path,
										  System.IO.FileMode.Open,
										  System.IO.FileAccess.Read,
										  System.IO.FileShare.ReadWrite);
			var _reader = new System.IO.StreamReader(_readStream, System.Text.Encoding.UTF8, true, 128);

			ArrayList _wordList = new ArrayList();

			string _word = null;
			while ((_word = _reader.ReadLine()) != null)
			{
				_wordList.Add(_word);
			}

			_reader.Dispose();
			_readStream.Dispose();


			Dictionary<string, int> _distinctWordsCounting = (_wordList.ToArray(typeof(string)) as string[]).GroupBy(x => x)
									  .ToDictionary(g => g.Key,
													g => g.Count());


			var _writeStream = new System.IO.FileStream(newPath,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			foreach (KeyValuePair<string, int> _distinctWord in _distinctWordsCounting)
			{
				_writer.WriteLine(_distinctWord.Key);
			}

			_writer.Dispose();
			_writeStream.Dispose();
		}

		public static int CountSyllable(string word)
		{
			return word.Split(' ').Length;
		}

		public static bool IsInDictionary(string word)
		{
			int _countSyllable = CountSyllable(word);

			switch (_countSyllable)
			{
				case 1:
					if (m_words1.Contains(word))
						return true;
					break;
				case 2:
					if (m_words2.Contains(word))
						return true;
					break;
				case 3:
					if (m_words3.Contains(word))
						return true;
					break;
				case 4:
					if (m_words4.Contains(word))
						return true;
					break;
				default:
					if (m_words4.Contains(word))
						return true;
					break;
			}

			return false;
		}

		public static bool IsInStopWordList(string word)
		{
			if (m_stopWords.Contains(word))
				return true;

			return false;
		}

		public static void AddWord(string path, string word)
		{
			var _writeStream = new System.IO.FileStream(path,
										  System.IO.FileMode.Append,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			_writer.WriteLine(word);

			_writer.Dispose();
			_writeStream.Dispose();
		}

        public static void AddWord(string path, Word word)
        {
            var _writeStream = new System.IO.FileStream(path,
                                          System.IO.FileMode.Append,
                                          System.IO.FileAccess.Write,
                                          System.IO.FileShare.ReadWrite);
            var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

            _writer.WriteLine(word.m_content + ":" + word.m_weight);

            _writer.Dispose();
            _writeStream.Dispose();
        }

        public static void SplitWord1Syl(string path)
		{
			var _writeStream = new System.IO.FileStream(path,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			foreach (string _word in m_words1)
			{
				_writer.WriteLine(_word);
			}

			_writer.Dispose();
			_writeStream.Dispose();
		}

		public static void SyncWordFormat(string path, char delimiter = ' ')
		{
			var _writeStream = new System.IO.FileStream(path,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
			var _writer = new System.IO.StreamWriter(_writeStream, System.Text.Encoding.UTF8, 128);

			foreach (string _word in m_words1)
			{
				_writer.WriteLine(_word);
			}

			foreach (string _word in m_words2)
			{
				string _temp = _word.Replace(" ", "_");
				_writer.WriteLine(_temp);
			}

			foreach (string _word in m_words3)
			{
				string _temp = _word.Replace(" ", "_");
				_writer.WriteLine(_temp);
			}

			foreach (string _word in m_words4)
			{
				string _temp = _word.Replace(" ", "_");
				_writer.WriteLine(_temp);
			}

			_writer.Dispose();
			_writeStream.Dispose();
		}
	}

	public class Tokenizer
	{
		private string FormatString(string content, bool toLower = true)
		{
			content = content.Replace("&nbsp;", " ");
			content = content.Replace("&gt", " ");
			content = content.Replace("&lt", " ");

			content = content.Replace("\n", " ");
			content = content.Replace("\r", " ");
			content = content.Replace("\t", " ");

			content = content.Replace(". ", " ");
			content = content.Replace(" .", " ");
			content = content.Replace(",", " ");
			content = content.Replace(";", " ");
			content = content.Replace("!", " ");
			content = content.Replace("'", " ");

			content = content.Replace(":", " ");
			content = content.Replace("?", " ");
			content = content.Replace("\"", " ");
			content = content.Replace("”", " ");

			content = content.Replace("/", " ");
			content = content.Replace("\\", " ");
			content = content.Replace("(", " ");
			content = content.Replace(")", " ");

			content = content.Replace("[", " ");
			content = content.Replace("]", " ");
			content = content.Replace("{", " ");
			content = content.Replace("}", " ");

			content = content.Replace("-", " ");
			content = content.Replace("…", " ");
			content = content.Replace("..", " ");
			content = content.Replace("•", " ");

			content = content.Replace("+", " ");
			content = content.Replace("*", " ");
			content = content.Replace("/", " ");
			content = content.Replace("=", " ");

			content = Regex.Replace(content, @"\s+", " ");
			content = content.Trim();

			return content.ToLower();
		}

		public ArrayList Tokenizing(string content, bool retrieveWordsNotTokenized = false, string outputPathForRetrieving = null)
		{
			content = FormatString(content);
			ArrayList _wordsTokenized = new ArrayList();
			ArrayList _wordsNotTokenized = new ArrayList();

			ArrayList _wordsSplited = new ArrayList();
			_wordsSplited.AddRange(content.Split(' '));

			while (_wordsSplited.Count > 0)
			{
				for(int i = 4; i >= 1; i--)
				{
					string _word = string.Join(" ", (_wordsSplited.ToArray(typeof(string)) as string[]).Take(i));

					if (Dictionary.IsInDictionary(_word))
					{
						_wordsTokenized.Add(_word);
						_wordsSplited.RemoveRange(0, (_wordsSplited.Count < i) ? _wordsSplited.Count : i);
						break;
					}
					else if(i == 1)
					{
						_wordsNotTokenized.Add(_word);
						_wordsSplited.RemoveRange(0, i);
					}
				}
			}

			if(retrieveWordsNotTokenized == true)
			{
				try
				{
					int _wordsCount = _wordsNotTokenized.Count;
					Dictionary<string, int> _distinctWordsCounting = (_wordsNotTokenized.ToArray(typeof(string)) as string[]).GroupBy(x => x)
											  .ToDictionary(g => g.Key,
															g => g.Count());

					foreach (KeyValuePair<string, int> _word in _distinctWordsCounting)
					{
						if (!Dictionary.IsInStopWordList(_word.Key) && _word.Value >= 40)
						{
							Dictionary.AddWord("technical-dict.txt", _word.Key);
						}
					}

					var _writetream = new System.IO.FileStream(outputPathForRetrieving,
										  System.IO.FileMode.Create,
										  System.IO.FileAccess.Write,
										  System.IO.FileShare.ReadWrite);
					var _writer = new System.IO.StreamWriter(_writetream, System.Text.Encoding.UTF8, 128);

					
					_writer.Write(string.Join(Environment.NewLine, _distinctWordsCounting.Keys.ToArray()));
					
					_writer.Dispose();
					_writetream.Dispose();
				}
				catch
				{
					MessageBox.Show("Could not retrieve untokenized words. The output path is invalid. Aborting...");
				}
			}

			return _wordsTokenized;
		}
	}

	public class Word
	{
		public string m_content;
		public float m_weight;

		public Word(string content, float weight)
		{
			m_content = content;
			m_weight = weight;
		}

		public static string Join(string delimiter, ArrayList listWords)
		{
			string _result = "";

			foreach(Word _word in listWords)
			{
				_result += _word.m_content + '|' + _word.m_weight + Environment.NewLine;
			}

			return _result;
		}
	}

	public class Indexer
	{
		public ArrayList Indexing(string title, string description, ArrayList words)
		{
			ArrayList _wordsIndexed = new ArrayList();
			Tokenizer _tokenizer = new Tokenizer();

			string[] _wordsInTitle = (_tokenizer.Tokenizing(title).ToArray(typeof(string)) as string[]).Distinct().ToArray();
            string[] _wordsInDesc = (_tokenizer.Tokenizing(description).ToArray(typeof(string)) as string[]).Distinct().ToArray();

   //         foreach (string _word in _wordsInTitle)
			//{
			//	_wordsIndexed.Add(new Word(_word, 1));
			//}

   //         foreach (string _word in _wordsInDesc)
   //         {
   //             if (!_wordsIndexed.Contains(_word))
   //                 _wordsIndexed.Add(new Word(_word, 1));
   //         }

			int _wordsCount = words.Count;
			Dictionary<string, int> _distinctWordsCounting = (words.ToArray(typeof(string)) as string[]).GroupBy(x => x)
									  .ToDictionary(g => g.Key,
													g => g.Count());
			
			foreach (KeyValuePair<string, int> _word in _distinctWordsCounting)
			{
				if (!_wordsIndexed.Contains(_word.Key))
				{
					float _termFrequency = (float)_word.Value / _wordsCount;
					_wordsIndexed.Add(new Word(_word.Key, _termFrequency));
				}
			}

			return _wordsIndexed;
		}

        public static void CalculateIDF(ref List<List<Word>> documents)
        {
            foreach(List<Word> document in documents)
            {
                foreach(Word word in document)
                {
                    word.m_weight *= IDF(documents, word);
                }

                document.Sort((x, y) => y.m_weight.CompareTo(x.m_weight));
            }
        }

        public static float IDF(List<List<Word>> documents, Word word)
        {
            int D = documents.Count;
            int d = 0;

            foreach (List<Word> document in documents)
            {
                if (document.Contains(word))
                    d++;
            }

            return (float)Math.Log10(((float) D) / d);
        }
    }
}

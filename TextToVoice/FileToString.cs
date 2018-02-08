using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Text
{
	public class FileToString
	{

		private string filePath;

		public FileToString(string FilePath)
		{
			filePath = FilePath;
		}

		public string ReadText()
		{
			string extension = System.IO.Path.GetExtension(filePath);
			string readText = "";

			if (extension.ToLower() == ".doc" || extension.ToLower() == ".docx")
			{
				readText = readTextFromMSWord();
			}
			else if (extension.ToLower() == ".pdf" )
			{
				readText = readTextFromPDF();
			}
			else
			{
				readText = File.ReadAllText(filePath);
			}		

			return readText;
		}

		private string readTextFromMSWord()
		{

			List<string> data = new List<string>();
			Application app = new Application();

			object fileName = filePath;

			Document doc = app.Documents.Open(ref fileName);

			foreach (Paragraph objParagraph in doc.Paragraphs)
				data.Add(objParagraph.Range.Text.Trim());

			doc.Close();
			app.Quit();

			return data.Aggregate((prev, next) => prev + "\r\n" + next);
		}

		private string readTextFromPDF()
		{
			using (PdfReader reader = new PdfReader(filePath))
			{
				StringBuilder text = new StringBuilder();

				for (int i = 1; i <= reader.NumberOfPages; i++)
				{
					text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
				}
				return text.ToString();
			}
		}
	}
}

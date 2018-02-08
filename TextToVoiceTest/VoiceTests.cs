using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextToVoiceTest
{
	[TestClass]
	public class VoiceTests
	{
		[TestMethod]
		public void TextToSpeechTest()
		{

			Text.TextToVoice TextToVoice = new Text.TextToVoice();
			TextToVoice.ReadOutText = "This is a test";
			TextToVoice.Speak();
			
		}
	}
}

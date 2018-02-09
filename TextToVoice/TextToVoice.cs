using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Text
{
	public class TextToVoice 
	{

		public int Rate { get; set; }
		public string ReadOutText { get; set; }

		public void Speak()
		{
			SpeechSynthesizer synth = new SpeechSynthesizer();
			synth.Rate = this.Rate;
			synth.Speak(ReadOutText);
		
		}

		public bool MakeMP3(string outputLocation)
		{

			try
			{
				SpeechSynthesizer synth = new SpeechSynthesizer();

				synth.SetOutputToWaveFile(outputLocation);

				synth.Rate = this.Rate;

				synth.Speak(ReadOutText);

				return true;
			}
			catch (Exception ex)
			{

				return false;
			}
			
		}

	}
}

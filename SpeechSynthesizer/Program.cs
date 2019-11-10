using System;
using System.Speech.Synthesis;

    public class SpeechSynth
    {
        public static void Main()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            string startupText = "Enter text and press enter to hear me speak what you write:" + Environment.NewLine;
            Console.WriteLine(startupText);

        synth.Speak(startupText);

        while (true)
        {
            synth.Speak(Console.ReadLine());
        }

    }
    }

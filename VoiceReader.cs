using System;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;

public class VoiceReader //lector de voz
{
    private SpeechSynthesizer synthesizer;
    private MediaElement mediaElement;

    public VoiceReader()
    {
        synthesizer = new SpeechSynthesizer();
        mediaElement = new MediaElement();
    }

    public async void LeerTexto(string texto)
    {
        var stream = await synthesizer.SynthesizeTextToStreamAsync(texto);
        mediaElement.SetSource(stream, stream.ContentType);
        mediaElement.Play();
    }

    public void DetenerLectura()
    {
        mediaElement.Stop();
    }
    
}


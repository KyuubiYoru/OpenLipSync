namespace OpenLipSync.Inference.Audio;

/// <summary>
/// Configuration for audio processing parameters loaded from model config.
/// </summary>
public class AudioProcessingConfig
{
    public int SampleRate { get; set; }
    public int HopLengthSamples { get; set; }
    public int WindowLengthSamples { get; set; }
    public int NFft { get; set; }
    public int NMels { get; set; }
    public float FMin { get; set; }
    public float FMax { get; set; }
    public float Fps { get; set; }
    
    public static AudioProcessingConfig FromModelConfig(ModelConfig modelConfig)
    {
        var audio = modelConfig.Audio ?? throw new ArgumentException("Model config missing audio section");
        
        return new AudioProcessingConfig
        {
            SampleRate = audio.SampleRate,
            HopLengthSamples = audio.SampleRate * audio.HopLengthMs / 1000,
            WindowLengthSamples = audio.SampleRate * audio.WindowLengthMs / 1000,
            NFft = audio.NFft,
            NMels = audio.NMels,
            FMin = audio.Fmin,
            FMax = audio.Fmax,
            Fps = audio.Fps
        };
    }
}
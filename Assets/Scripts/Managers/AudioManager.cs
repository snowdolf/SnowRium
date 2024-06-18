using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public AudioClip backgroundMusic;
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayBackgroundMusic()
    {
        if (backgroundMusic != null)
        {
            _audioSource.Stop();
            _audioSource.clip = backgroundMusic;
            _audioSource.Play();
        }
        else
        {
            Debug.LogWarning("[AudioManager] Background music is not set.");
        }
    }

    public void PlaySound(AudioClip clip, float soundEffectVolume, float soundEffectPitchVariance)
    {
        _audioSource.volume = soundEffectVolume;
        _audioSource.pitch = 1f + Random.Range(-soundEffectPitchVariance, soundEffectPitchVariance);
        _audioSource.PlayOneShot(clip);
    }

    public void StopBackgroundMusic()
    {
        _audioSource.Stop();
    }
}
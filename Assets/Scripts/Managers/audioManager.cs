
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSO _audio;
    public static audioManager Instance;
    [SerializeField] AudioMixer _mixer;

    [SerializeField]
    private AudioSource _musicSource, _SFXSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayAchievment()
    {

        _SFXSource.clip = _audio.SFX[0].Sound;
        _SFXSource.Play();

    }
    public void PlayJump()
    {
        _SFXSource.clip = _audio.SFX[1].Sound;
        _SFXSource.Play();

    }
    public void PlayDie()
    {
        _SFXSource.clip = _audio.SFX[2].Sound;
        _SFXSource.Play();


    }
    public void ChangeMasterVolume(float val)
    {
        _mixer.SetFloat("Master", (val * 100) - 80);
    }
    public void ChangeSFXVolume(float val)
    {
        _mixer.SetFloat("SFX", (val * 100) - 80);

    }
    public void ChangeMusicVolume(float val)
    {
        _mixer.SetFloat("Music", (val * 100) - 80);

    }


}

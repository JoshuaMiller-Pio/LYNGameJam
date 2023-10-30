
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSO _audio;
    public static audioManager Instance;
    [SerializeField] AudioMixer _mixer;

    [SerializeField]
    private AudioSource?  _musicSource, _SFXSource;

    void Awake()
    {
            Instance = this;
        _musicSource.volume = 0.5f;
        _SFXSource.volume = 0.5f;
    }
    
    void changeVolume()
    {
        _mixer.SetFloat("SFX", -30f);
        _mixer.SetFloat("Music", -30f);
    }
    public void PlayPickUp()
    {

        _SFXSource.clip = _audio.SFX[0].Sound;
        _SFXSource.Play();

    }
    public void PlayQuizFailed()
    {
        _SFXSource.clip = _audio.SFX[1].Sound;
        _SFXSource.Play();

    }
    public void PlayQuizSolved()
    {
        _SFXSource.clip = _audio.SFX[2].Sound;
        _SFXSource.Play();


    }
    public void PlayClick()
    {
        _SFXSource.clip = _audio.SFX[3].Sound;
        _SFXSource.Play();
    } 
    public void PlayExit()
    {
        _SFXSource.clip = _audio.SFX[4].Sound;
        _SFXSource.Play();
    }
    public void PlayQuestion()
    {
        _SFXSource.clip = _audio.SFX[5].Sound;
        _SFXSource.Play();
    }
    public void PlayLevelSelected()
    {
        _SFXSource.clip = _audio.SFX[6].Sound;
        _SFXSource.Play();
    }







    public void PlayMainMenu()
    {
        _musicSource.clip = _audio.BGMusic[0].Sound;
        _musicSource.Play();
    }
    public void PlayLevel1()
    {
        _musicSource.clip = _audio.BGMusic[1].Sound;
        _musicSource.Play();
    }
    public void PlayWin()
    {
        _musicSource.clip = _audio.BGMusic[2].Sound;
        _musicSource.Play();
    }




    public void ChangeMasterVolume(float val)
    {
        float convertedVolume = Mathf.Lerp(-65f, 0f, val);
        _mixer.SetFloat("Master", convertedVolume);
    }
    public void ChangeSFXVolume(float val)
    {
        float convertedVolume = Mathf.Lerp(-65f, 0f, val);
        _mixer.SetFloat("SFX", convertedVolume);

    }
    public void ChangeMusicVolume(float val)
    {
        float convertedVolume = Mathf.Lerp(-65f, 0f, val);
        _mixer.SetFloat("Music", convertedVolume);

    }


}


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

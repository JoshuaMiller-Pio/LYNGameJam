using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class AuidioClips
{
    public string name;
    public AudioClip Sound;
}

[CreateAssetMenu(fileName = "AudiSO", menuName = "AudioSO/AudioSO")]
public class AudioSO : ScriptableObject
{
    [Header("SFX")]
    public List<AuidioClips> SFX = new List<AuidioClips>();

    [Header("BackGround Music")]
    public List<AuidioClips> BGMusic = new List<AuidioClips>();

}

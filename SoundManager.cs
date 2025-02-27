using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource myAudioSource;
    public AudioClip[] myAudioClips;

    public void PlayAudio(int clipNumber){
        myAudioSource.clip = myAudioClips[clipNumber];
        myAudioSource.Play();
    }

    public void StopAudio(){
        myAudioSource.Stop();
    }

    public void SetVolume(float volumeNumber){
        myAudioSource.volume = volumeNumber;
    }

    public void adjustVolume(float volumeIncrement){
        myAudioSource.volume += volumeIncrement;
    }

}

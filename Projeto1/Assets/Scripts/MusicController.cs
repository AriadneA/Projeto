using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    private static MusicController instance;
    public AudioSource BGM;
    public AudioClip track0;
    public AudioClip track1;
    
    void Awake(){
        if(instance == null){
          instance = this;
          DontDestroyOnLoad(instance);
        }else{
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex >= 0 && SceneManager.GetActiveScene().buildIndex < 6){
            if(BGM.clip != track0){
                 changeBGM(track0);
            }
        }
        if(SceneManager.GetActiveScene().buildIndex >= 6 && SceneManager.GetActiveScene().buildIndex < 11){
            if(BGM.clip != track1){
                 changeBGM(track1);
            }
        }
    }
    public void changeBGM(AudioClip music){
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}

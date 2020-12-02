using UnityEngine.Audio;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public Sound[] sounds;
    public AudioClip clip;
    public void BGM()
    {

        Play("Intro");
    }
    

    public void Play(string name)
    {
        for (int i = 0; i < sounds.Length; i++) {
            if (sounds[i].name == name&& !sounds[i].playing)
            {
                sounds[i].source = gameObject.AddComponent<AudioSource>();
                sounds[i].source.clip = sounds[i].clip;
                sounds[i].source.volume = sounds[i].volume;
                sounds[i].source.pitch = sounds[i].pitch;
                sounds[i].source.loop = sounds[i].loop;
                sounds[i].source.Play();
                sounds[i].playing = true;
                
            }
        }
    }
    public void Play(string name,GameObject obj)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].name == name && !sounds[i].playing)
            {
                sounds[i].source = obj.AddComponent<AudioSource>();
                sounds[i].source.clip = sounds[i].clip;
                sounds[i].source.volume = sounds[i].volume;
                sounds[i].source.pitch = sounds[i].pitch;
                sounds[i].source.loop = sounds[i].loop;
                sounds[i].source.Play();
                sounds[i].playing = true;

            }
        }
    }


    public void Stop(string name,GameObject obj)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].name == name && sounds[i].playing)
            {
                
                sounds[i].source.Stop();
                Destroy(obj.GetComponent<AudioSource>());
                sounds[i].playing = false;


            }
        }
    }
    public void Stop(string name)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].name == name && sounds[i].playing)
            {
                sounds[i].source.Stop();
                Destroy(gameObject.GetComponent<AudioSource>());
                sounds[i].playing = false;


            }
        }
    }



}

//make a Sound class
[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume=0.5f;
    [Range(0.1f, 3f)]
    public float pitch=1f;
    public bool loop;
    public bool playing = false;
    [HideInInspector]
    public AudioSource source;
}

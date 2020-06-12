	using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;

	

	public Sound[] sounds;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			
		}
	}
	void Update(){
		if(ScenesManager.IsMuted==1)
     {
      
     Mute("MainMenu"); 
     Mute("Playing"); 
     Mute("Win"); 
     Mute("Lost");
	 
     
     }
     if(ScenesManager.IsMuted==0){
       
       
     UnMuteMusic("MainMenu"); 
     UnMuteGameplay("Playing"); 
     UnMuteMusic("Win"); 
     UnMuteMusic("Lost");
       }

	if(ScenesManager.IsMutedSFX==1)
     {
      
     
     Mute("RectClick"); 
     Mute("RoundClick"); 
     Mute("BounceNew");    
     Mute("Out");
	 Mute("Wood");
	 Mute("Boom");
	 Mute("Metal");
	 
     
     }
     if(ScenesManager.IsMutedSFX==0){
       
       
     UnMuteSfx("RectClick"); 
     UnMuteSfx("RoundClick"); 
     UnMuteMusic("BounceNew");    
     UnMuteSfx("Out"); 
	 UnMuteGameplay("Wood");
	 UnMuteGameplay("Boom");
	 UnMuteGameplay("Metal"); 
       

     }
     

	}

	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume;
		

		s.source.Play();
	}

public void Stop(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		

		s.source.Stop();
	}

	public void Mute(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		

		s.source.volume = 0;
	}

	public void UnMuteMusic(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		

		s.source.volume = 0.3f;
	}

	public void UnMuteGameplay(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		

		s.source.volume = 0.5f;
	}

    public void UnMuteSfx(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}
		

		s.source.volume = 1f;
	}

	
	


	



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class OnOffToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { SaveManager.Load();
        
      GameObject m_Toggle2 = GameObject.FindWithTag("ToggleS");
   Toggle m_Toggle  = m_Toggle2.GetComponent<Toggle>();
   GameObject sfx_Toggle2 = GameObject.FindWithTag("ToggleSfx");
   Toggle sfx_Toggle  = sfx_Toggle2.GetComponent<Toggle>();

   if(ScenesManager.IsMuted==1)
   m_Toggle.isOn=false;
   if(ScenesManager.IsMuted==0)
   m_Toggle.isOn=true;
    if(ScenesManager.IsMutedSFX==1)
   sfx_Toggle.isOn=false;
   if(ScenesManager.IsMutedSFX==0)
   sfx_Toggle.isOn=true;
    }

 
    // Update is called once per frame
    void Update()
    {GameObject m_Toggle2 = GameObject.FindWithTag("ToggleS");
   Toggle m_Toggle  = m_Toggle2.GetComponent<Toggle>();
   GameObject sfx_Toggle2 = GameObject.FindWithTag("ToggleSfx");
   Toggle sfx_Toggle  = sfx_Toggle2.GetComponent<Toggle>();
        if(ScenesManager.IsMuted==1)
   m_Toggle.isOn=false;
   if(ScenesManager.IsMuted==0)
   m_Toggle.isOn=true;
    if(ScenesManager.IsMutedSFX==1)
   sfx_Toggle.isOn=false;
   if(ScenesManager.IsMutedSFX==0)
   sfx_Toggle.isOn=true;
    
    }
}

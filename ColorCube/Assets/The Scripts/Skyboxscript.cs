using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyboxscript : MonoBehaviour
{
    public Material BlueSky;
    public Material Crhistmas;
    public Material DarkSky;
    public Material Gradient;
    public Material Halloween;
    public Material Magical;
    public Material Moon;
    public Material Planets;
    public Material Rainbow;
    public Material Water;
    // Start is called before the first frame update
    void Start()
    {
       if (Model.Name == "1-Moon")
      RenderSettings.skybox = Moon;
      if (Model.Name == "2- Water")
      RenderSettings.skybox = Water;
      if (Model.Name == "3- Blue sky")
      RenderSettings.skybox = BlueSky;
      if (Model.Name == "4- Dark sky with the stars")
      RenderSettings.skybox = DarkSky;
      if (Model.Name == "5- Magical")
      RenderSettings.skybox = Magical;
      if (Model.Name == "6- Rainbow Sky")
      RenderSettings.skybox = Rainbow;
      if (Model.Name == "7-Halloween")
      RenderSettings.skybox = Halloween;
      if (Model.Name == "8- Gradient Colors")
      RenderSettings.skybox = Gradient;
      if (Model.Name == "9- Christmas")
      RenderSettings.skybox = Crhistmas;
      if (Model.Name == "10- Planets space")
      RenderSettings.skybox = Planets;
      else
      RenderSettings.skybox = Moon;

    }

    // Update is called once per frame
    void Update()
    {
          
    }
}

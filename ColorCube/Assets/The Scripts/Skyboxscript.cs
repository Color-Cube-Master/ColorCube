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
    public Material First;

    // Start is called before the first frame update
    void Start()
    {
       if (Model.Name == "1-Moon")
      RenderSettings.skybox = Moon;
      else if (Model.Name == "2- Water")
      RenderSettings.skybox = Water;
      else if (Model.Name == "3- Blue sky")
      RenderSettings.skybox = BlueSky;
      else if (Model.Name == "4- Dark sky with the stars")
      RenderSettings.skybox = DarkSky;
      else if (Model.Name == "5- Magical")
      RenderSettings.skybox = Magical;
      else if (Model.Name == "6- Rainbow Sky")
      RenderSettings.skybox = Rainbow;
      else if (Model.Name == "7-Halloween")
      RenderSettings.skybox = Halloween;
      else if (Model.Name == "8- Gradient Colors")
      RenderSettings.skybox = Gradient;
      else if (Model.Name == "9- Christmas")
      RenderSettings.skybox = Crhistmas;
      else if (Model.Name == "10- Planets space")
      RenderSettings.skybox = Planets;
      else{
      RenderSettings.skybox = First;}

    }

    // Update is called once per frame
    void Update()
    {
          
    }
}

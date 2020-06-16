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
       if (ModelT.Name == "Moon")
      RenderSettings.skybox = Moon;
      else if (ModelT.Name == " Water")
      RenderSettings.skybox = Water;
      else if (ModelT.Name == "Blue sky")
      RenderSettings.skybox = BlueSky;
      else if (ModelT.Name == "Dark sky with the stars")
      RenderSettings.skybox = DarkSky;
      else if (ModelT.Name == "Magical")
      RenderSettings.skybox = Magical;
      else if (ModelT.Name == "Rainbow Sky")
      RenderSettings.skybox = Rainbow;
      else if (ModelT.Name == "Halloween")
      RenderSettings.skybox = Halloween;
      else if (ModelT.Name == "Gradient Colors")
      RenderSettings.skybox = Gradient;
      else if (ModelT.Name == "Christmas")
      RenderSettings.skybox = Crhistmas;
      else if (ModelT.Name == "Planets space")
      RenderSettings.skybox = Planets;
      else{
      RenderSettings.skybox = First;}

    }

    // Update is called once per frame
    void Update()
    {
          
    }
}

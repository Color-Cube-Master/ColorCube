using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGenerator : MonoBehaviour {

	public Texture2D[] map;
	private static int i = 0;
	//public Maps [] Levels;
	public ColorToPrefab[] colorMappings;

	// Use this for initialization
	void Start () {
		GenerateLevel();
	}
	
	void GenerateLevel()
	{
		for (int x = 0; x < map[i].width; x++)
		{
			for (int y = 0; y < map[i].height; y++)
			{
				GenerateTile(x, y);
			}
		}
	}

	void GenerateTile(int x, int y)
	{
		Color pixelColor = map[i].GetPixel(x, y);

		if (pixelColor.a == 0)
		{
			// The pixel is transparrent. Let's ignore it!

			return;
		}



		foreach (ColorToPrefab colorMapping in colorMappings)
		{
			if (colorMapping.color.Equals(pixelColor))
			{
				Vector3 position = new Vector3(x, 0, y);
				Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);

			}
		//	Debug.Log(pixelColor);
		}
	}

public void Restart()
	{


		SceneManager.LoadScene("Old level editor");
		if (i < map.Length-1 && i >= 0)
		{
			
			i += 1;

		}
		else
		{
			i = 0;
			

		}

	}
}



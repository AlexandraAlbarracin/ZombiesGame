using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    private RawImage image;
    private Renderer rend;
    Color color = Color.red;
    void Start()
    {
        rend = GetComponent<Renderer>();
        image = GetComponent<RawImage>();
        Texture2D texture = image.texture as Texture2D;

        for (int x = 0; x < texture.width; x++)
        {
            for (int y = 0; y < texture.height; y++)
            {
                if (x % 2 == 0 && y % 2 == 0)
                {
                    texture.SetPixel(x, y, color);
                }
                else
                    texture.SetPixel(x, y, texture.GetPixel(x, y));
            }
        }
        texture.Apply();
        rend.material.mainTexture = texture;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

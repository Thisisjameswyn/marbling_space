using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPaintController : MonoBehaviour
{
  Camera cam;
  [SerializeField]
  GameObject paintParticle;
  Renderer paintParticleRenderer;
  Color32 currentColor;
  Color32[] currentColors = new Color32[5];



  Color32[,] colorPallets = { { new Color32(217, 162, 130, 255), new Color32(140, 89, 77, 255), new Color32(166, 166, 166, 255), new Color32(64, 64, 64, 255), new Color32(13, 13, 13, 255) }, { new Color32(115, 48, 60, 255), new Color32(16, 23, 38, 255), new Color32(140, 100, 77, 255), new Color32(217, 187, 169, 255), new Color32(76, 99, 83, 255) }, { new Color32(242, 135, 117, 255), new Color32(247, 194, 137, 255), new Color32(234, 228, 143, 255), new Color32(249, 217, 192, 255), new Color32(249, 246, 228, 255) }, { new Color32(213, 94, 45, 255), new Color32(216, 216, 214, 255), new Color32(47, 93, 140, 255), new Color32(160, 179, 193, 255), new Color32(249, 249, 249, 255) }, { new Color32(87, 67, 1, 255), new Color32(168, 99, 38, 255), new Color32(141, 147, 101, 255), new Color32(217, 178, 156, 255), new Color32(140, 3, 3, 255) }, { new Color32(40, 27, 36, 255), new Color32(60, 75, 77, 255), new Color32(242, 171, 48, 255), new Color32(216, 125, 13, 255), new Color32(137, 10, 3, 255) }, { new Color32(31, 43, 133, 255), new Color32(203, 231, 250, 255), new Color32(107, 32, 132, 255), new Color32(167, 219, 200, 255), new Color32(102, 199, 167, 255) } };
  int colorArrayPos = 0;
  int palletArrayPos = 0;
  // Start is called before the first frame update
  void Start()
  {
    cam = this.GetComponent<Camera>();
    ColorSwap();
    currentColor = currentColors[0];
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButton(1))
    {
      Vector2 screenPos = Input.mousePosition;
      Vector2 worldPosition = cam.GetComponent<Camera>().ScreenToWorldPoint(screenPos);

      GameObject currentPaint = Instantiate(paintParticle, worldPosition, Quaternion.identity);
      Renderer currentPaintRender = currentPaint.GetComponent<Renderer>();
      currentPaintRender.material.color = currentColor;
    }

    if (Input.mouseScrollDelta.y > 0)
    {
      if (colorArrayPos < 4)
      {
        colorArrayPos += 1;
      }
      else
      {
        colorArrayPos = 0;
      }
      currentColor = currentColors[colorArrayPos];
      Debug.Log(currentColors[colorArrayPos]);
    }
    else if (Input.mouseScrollDelta.y < 0)
    {
      if (colorArrayPos > 0)
      {
        colorArrayPos -= 1;
      }
      else
      {
        colorArrayPos = 4;
      }
      currentColor = currentColors[colorArrayPos];
      Debug.Log(currentColors[colorArrayPos]);
    }
  }

  public void ColorSwap()
  {
    for (int i = 0; i < 5; i++)
    {
      currentColors[i] = colorPallets[palletArrayPos, i];
    }
    currentColor = currentColors[0];
    if (palletArrayPos < 7)
    {
      palletArrayPos++;
    }
    else
    {
      palletArrayPos = 0;
    }
  }
}
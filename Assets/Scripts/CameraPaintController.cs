using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPaintController : MonoBehaviour
{
  Camera cam;
  [SerializeField]
  GameObject paintParticle;
  Renderer paintParticleRenderer;
  Color currentColor;
  Color[] myColors = { new Color(31, 43, 133, 255), new Color(203, 231, 250, 255), new Color(107, 32, 132, 255), new Color(167, 219, 200, 255), new Color(102, 199, 167, 255) };

  Color[,] myColorPallets = { { new Color(217, 162, 130, 255), new Color(140, 89, 77, 255), new Color(166, 166, 166, 255), new Color(64, 64, 64, 255), new Color(13, 13, 13, 255) }, { new Color(115, 48, 60, 255), new Color(16, 23, 38, 255), new Color(140, 100, 77, 255), new Color(217, 187, 169, 255), new Color(76, 99, 83, 255) }, { new Color(242, 135, 117, 255), new Color(247, 194, 137, 255), new Color(234, 228, 143, 255), new Color(249, 217, 192, 255), new Color(249, 246, 228, 255) }, { new Color(213, 94, 45, 255), new Color(216, 216, 214, 255), new Color(47, 93, 140, 255), new Color(160, 179, 193, 255), new Color(249, 249, 249, 255) }, { new Color(87, 67, 1, 255), new Color(168, 99, 38, 255), new Color(141, 147, 101, 255), new Color(217, 178, 156, 255), new Color(140, 3, 3, 255) }, { new Color(40, 27, 36, 255), new Color(60, 75, 77, 255), new Color(242, 171, 48, 255), new Color(216, 125, 13, 255), new Color(137, 10, 3, 255) }, { new Color(31, 43, 133, 255), new Color(203, 231, 250, 255), new Color(107, 32, 132, 255), new Color(167, 219, 200, 255), new Color(102, 199, 167, 255) } };
  int arrayPos = 0;
  // Start is called before the first frame update
  void Start()
  {
    cam = this.GetComponent<Camera>();
    // paintParticleRenderer = paintParticle.GetComponent<Renderer>();
    currentColor = myColors[0];
    // myColorPallets = {{myColors},{myColors},{myColors},{myColors},{myColors},{myColors},{myColors}};
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
      arrayPos += 1;
      currentColor = myColors[arrayPos];
      Debug.Log(myColors[arrayPos]);
    }
    else if (Input.mouseScrollDelta.y < 0)
    {
      arrayPos -= 1;
      currentColor = myColors[arrayPos];
      Debug.Log(myColors[arrayPos]);
    }
  }
}
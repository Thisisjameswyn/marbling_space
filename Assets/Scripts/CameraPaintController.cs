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

  Color[] myColors = { Color.black, Color.blue, Color.green, Color.red, Color.white, Color.yellow };
  int arrayPos = 0;
  // Start is called before the first frame update
  void Start()
  {
    cam = this.GetComponent<Camera>();
    // paintParticleRenderer = paintParticle.GetComponent<Renderer>();
    currentColor = myColors[0];
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
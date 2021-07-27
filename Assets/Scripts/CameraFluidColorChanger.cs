using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFluidColorChanger : MonoBehaviour
{
  // Start is called before the first frame update
  GameObject paintParticlePrefab;
  Renderer paintParticleRenderer;
  void Start()
  {
    paintParticlePrefab = (GameObject)Resources.Load("prefabs/FluidParticle_NoGrav", typeof(GameObject));
    paintParticleRenderer = paintParticlePrefab.GetComponent<Renderer>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.mouseScrollDelta.y > 0)
    {
      Debug.Log("color up!");
      paintParticleRenderer.sharedMaterial.color = Color.black;
    }
    else if (Input.mouseScrollDelta.y < 0)
    {
      Debug.Log("color down!");
      paintParticleRenderer.sharedMaterial.color = Color.green;
    }
  }

  void ColorChange()
  {

  }
}


//allow user to select a set of complimentary colors to draw with
//on mouse wheel scroll change between the four colors

//have an array of 4 colors
//add each color to the array
//have ui element that tracks
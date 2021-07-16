using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class GridComponent : MonoBehaviour
{
  public int xSize, ySize;
  // Start is called before the first frame update
  private void Awake()
  {
    Generate();
  }

  private Vector3[] vertices;

  private void Generate()
  {
    vertices = new Vector3[(xSize + 1) * (ySize + 1)];
  }

  private void OnDrawGizmos() 
  {
    if(vertices == null)
    {
      return;
    }
    Gizmos.color = Color.black;
    for (int i = 0; i < vertices.Length; i++)
    {
        Gizmos.DrawSphere(vertices[i], 0.1f);
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
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
  private Mesh mesh;

  private void Generate()
  {
    GetComponent<MeshFilter>().mesh = mesh = new Mesh();
    vertices = new Vector3[(xSize + 1) * (ySize + 1)];
    for (int i = 0, y = 0; y <= ySize; y++) //Grab x y coords and build grid
    {
      for (int x = 0; x <= xSize; x++, i++)
      {
        vertices[i] = new Vector3(x, y);
      }
    }
    mesh.vertices = vertices;
  }

  private void OnDrawGizmos()
  {
    if (vertices == null)
    {
      return;
    }
    Gizmos.color = Color.black;
    for (int i = 0; i < vertices.Length; i++)
    {
      Gizmos.DrawSphere(vertices[i], 0.1f); //Draw a black dot for each vertice
    }
  }
}



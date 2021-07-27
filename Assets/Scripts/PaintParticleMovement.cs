using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintParticleMovement : MonoBehaviour
{
  Camera cam;
  [SerializeField]
  GameObject painterParticle;
  // Start is called before the first frame update
  void Start()
  {
    cam = this.GetComponent<Camera>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButton(0))
    {
      Vector2 screenPos = Input.mousePosition;
      Vector2 worldPosition = cam.GetComponent<Camera>().ScreenToWorldPoint(screenPos);

      painterParticle.transform.position = worldPosition;
    }
  }
}

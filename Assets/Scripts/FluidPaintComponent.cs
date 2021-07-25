using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidPaintComponent : MonoBehaviour
{
  [SerializeField]
  float force = 10f;
  Rigidbody2D myRb;
  // Start is called before the first frame update
  void Start()
  {
    myRb = this.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    Vector2 controlInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    myRb.AddForce(controlInput * force);
  }
}
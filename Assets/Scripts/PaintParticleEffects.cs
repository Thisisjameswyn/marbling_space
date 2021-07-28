using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidPaintComponent : MonoBehaviour
{
  Rigidbody2D myRb;
  // Start is called before the first frame update
  void Start()
  {
    myRb = this.GetComponent<Rigidbody2D>();
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.tag == "fluid")
    {
      Rigidbody2D fluidRB = other.GetComponent<Rigidbody2D>();
      fluidRB.WakeUp();
    }
  }
}
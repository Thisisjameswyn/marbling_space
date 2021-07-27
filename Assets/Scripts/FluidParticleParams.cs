using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidParticleParams : MonoBehaviour
{
  Rigidbody2D myRb;
  [SerializeField]
  float KinematicTime;
  private void Awake()
  {
    myRb = this.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    if (myRb.isKinematic == true)
    {
      Timer();
    }
  }

  void Timer()
  {
    Debug.Log("called");
    float _timer = 0;
    _timer += Time.deltaTime;
    if (_timer >= KinematicTime)
    {
      myRb.isKinematic = true;
    }
  }
}

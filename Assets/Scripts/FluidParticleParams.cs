using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluidParticleParams : MonoBehaviour
{
  Rigidbody2D myRb;
  [SerializeField]
  float sleepTime;
  float _timer = 0;
  private void Awake()
  {
    myRb = this.GetComponent<Rigidbody2D>();
    myRb.WakeUp();
  }

  // Update is called once per frame
  void Update()
  {
    if (myRb.IsAwake())
    {
      _timer += Time.deltaTime;
      if (_timer >= sleepTime)
      {
        myRb.Sleep();
        _timer = 0;
      }
    }
  }
}

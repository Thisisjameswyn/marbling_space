using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWipe : MonoBehaviour
{
  // Start is called before the first frame update
  public void RestartScene()
  {
    SceneManager.LoadScene("SampleScene");
  }
}
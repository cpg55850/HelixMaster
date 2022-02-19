using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bar")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }

        if (other.tag == "Finish")
        {
            Debug.Log("You Won");
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
}

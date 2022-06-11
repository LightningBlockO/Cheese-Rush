using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCheeseRush : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}

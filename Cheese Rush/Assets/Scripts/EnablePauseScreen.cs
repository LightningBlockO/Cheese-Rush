using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnablePauseScreen : MonoBehaviour
{
    public GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pauseScreen.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            pauseScreen.SetActive(false);
        }
    }
}

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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0;

            
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }

    }
}

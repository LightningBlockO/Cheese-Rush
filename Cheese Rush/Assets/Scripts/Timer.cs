using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;

    private bool timerRunning = true;

    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        DoTimer();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            timerRunning = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            timerRunning = true;

        }
    }
    //Adds one second to time on collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("BlueC"))
        {
            timerRunning = true;
            timeRemaining += 2;
            Debug.Log("Hit");
            Destroy(other.gameObject);
        }
    }

    public void DisplayTimer(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    

    public void DoTimer()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTimer(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                SceneManager.LoadScene("Lose Screen");
            }
        }
    }
}
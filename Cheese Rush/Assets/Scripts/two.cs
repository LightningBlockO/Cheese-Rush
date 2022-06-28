using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class two : MonoBehaviour
{
    public Text myScore;

    [SerializeField]
    private int score = 0;
    public Timer tM;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Cheese"))
        {
            score += 25;
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        if (other.name.Contains("Blue Cheese"))
        {
            score += 25;
            tM.timeRemaining += 1;
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        if (other.name.Contains("Red Cheese"))
        {
            score += 125;
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        if (score >= 2000)
        {
            SceneManager.LoadScene("Win Screen"); //new 2000 win texture to replace win screen
        }
        myScore.text = score.ToString();
    }
}

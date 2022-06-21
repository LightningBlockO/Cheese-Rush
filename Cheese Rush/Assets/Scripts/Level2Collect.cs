using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2Collect : MonoBehaviour
{
    public Text myScore;

    [SerializeField]
    private int score = 0;
    public Timer tM;

    private void OnTriggerEnter(Collider other)
    {
        myScore.text = score.ToString();
        if (other.name.Contains("Cheese"))
        {
            score += 25;
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        if (other.name.Contains("Blue Cheese"))
        {
            score += 50;
            tM.timeRemaining += 1;
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        //if (other.name.Contains("Red Cheese"))
        //{
        //    score += 150;
        //    gameObject.GetComponent<AudioSource>().Play();
        //    Destroy(other.gameObject);
        //}
        if (score >= 750)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTwoCheeseCollect : MonoBehaviour
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
        if (score >= 750)
        {
            SceneManager.LoadScene("Win Screen Level 2");
        }
        myScore.text = score.ToString();
    }
}

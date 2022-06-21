using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelOneCheeseCollect : MonoBehaviour
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
        if (score >= 500)
        {
            SceneManager.LoadScene("Win Screen Level 1");
        }
        myScore.text = score.ToString();
    }
}

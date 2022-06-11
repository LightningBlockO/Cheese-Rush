using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheeseCollect : MonoBehaviour
{
    public Text myScore;

    [SerializeField]
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        myScore.text = score.ToString();
        if (other.name.Contains("Cheese"))
        {
            score += 50;
            gameObject.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
        if (score >= 1000)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}

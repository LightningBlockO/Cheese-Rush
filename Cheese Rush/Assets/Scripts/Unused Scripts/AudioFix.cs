using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFix : MonoBehaviour
{
    public AudioSource aD;
    // Start is called before the first frame update
    void Start()
    {
        aD = GameObject.FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Cheese(Clone)"))
        {
            aD.Play();
            Debug.Log("Boom");
        }
        if (other.name.Equals("Blue Cheese(Clone)"))
        {
            aD.Play();
            Debug.Log("Boom");
        }
        if (other.name.Equals("Red Cheese(Clone)"))
        {
            aD.Play();
            Debug.Log("Boom");
        }
    }
   

}

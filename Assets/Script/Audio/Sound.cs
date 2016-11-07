using UnityEngine;
using System.Collections;


public class Sound : MonoBehaviour
{

    private AudioSource sound01;
    //private AudioSource sound02;
    //private AudioSource sound03;

    bool Flag = false;

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound01 = audioSources[0];
        //sound02 = audioSources[1];
        //sound03 = audioSources[2];


        foreach (var i in audioSources)
        {
            print(i.clip);
        }
    }


    public void OnTriggerEnter(Collider other)
    {


        //if (GameObject4.gameFlags == "easy")
        //{
            if (!Flag)
            {

                sound01.PlayOneShot(sound01.clip);
				Destroy (other.gameObject);
                Flag = true;
            }
        //}
        /*
        if (GameObject4.gameFlags == "normal")
        {
            if (!Flag)
            {

                sound02.PlayOneShot(sound02.clip);
                print("kakumei");

                Flag = true;
            }
        }
        if (GameObject4.gameFlags == "hard")
        {
            if (!Flag)
            {

                sound03.PlayOneShot(sound03.clip);
                print("kusikosu");

                Flag = true;
            }
        }
        */
    }

}

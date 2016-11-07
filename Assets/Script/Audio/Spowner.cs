using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class Spowner : MonoBehaviour {

    public int inote = 0;
    public IList notes = null;
    public int bpm = 0;
    public string keysound;
    public double sounds;

    public Transform A;
	public Transform B;
	public Transform C;
    public Transform D;
    public Transform E;
    public Transform F;
    public Transform G;
    public Transform H;
    public Transform Sound;
    TextAsset asset = null;

    private Vector3 vec3;

	//ランダムにノーツを生成するための配列
	//public GameObject[] Notes;
	//public int number;

    // Use this for initialization
    void Start () {
        inote = 0;
        keysound = null;
        sounds = 0;

        //if (GameObject4.gameFlags == "easy")
        //{

            asset = (TextAsset)Resources.Load("closethelight_techno");
            string json = asset.text;
            notes = (IList)Json.Deserialize(json);
			bpm = 175; //alien: 140, close the light: 175, nether :320

        //}
        /*
        if (GameObject4.gameFlags == "normal")
        {

            asset = (TextAsset)Resources.Load("normal-kakumei");
            string json = asset.text;
            notes = (IList)Json.Deserialize(json);
            bpm = 145;
        }
        if (GameObject4.gameFlags == "hard")
        {

            asset = (TextAsset)Resources.Load("hard-kusikosu");
            string json = asset.text;
            notes = (IList)Json.Deserialize(json);
            bpm = 150;
        }
        */
        vec3 = new Vector3(0, 0, (float)bpm/3);


    }

    // Update is called once per frame
    void Update () {
        while (inote < notes.Count)
        {
            IDictionary note = (IDictionary)notes[inote];
            if (60 * 4 * (double)note["start"] > bpm * (Time.timeSinceLevelLoad))
            {
                break;
            }
            keysound = (string)note["key"];
            sounds = (double)note["start"];
            CreateNote(keysound);
            startSound(sounds);
            inote++;
        }
    }

    private void CreateNote(string keysound)
    {
		//ランダムにノーツを生成するとき用
		//number = Random.Range(0,Notes.Length);

        switch (keysound)
        {
            case "0":
                Instantiate(A, vec3, Quaternion.identity);
			//Instantiate(Notes[number], vec3, Quaternion.identity);

                break;
            case "1":
                Instantiate(B, vec3, Quaternion.identity);
                break;
            case "2":
                Instantiate(C, vec3, Quaternion.identity);
                break;
            case "3":
                Instantiate(D, vec3, Quaternion.identity);
                break;
            case "4":
                Instantiate(E, vec3, Quaternion.identity);
                break;
            case "5":
                Instantiate(F, vec3, Quaternion.identity);
                break;
            case "6":
                Instantiate(G, vec3, Quaternion.identity);
                break;
            case "7":
                Instantiate(H, vec3, Quaternion.identity);
                break;

            default: break;
        }
    }

    private void startSound(double sounds)
    {
        /*
        if (GameObject4.gameFlags == "normal" || GameObject4.gameFlags == "hard")
        {
            if (sounds == 1.0)
            {
                print("soundtest");

                Instantiate(Sound, new Vector3(15, 15, 0), Quaternion.identity);
            }
        }
        */
        //if (GameObject4.gameFlags == "easy")
        //{
		if (sounds == 0.0)//alien: 0.0, close the light: 0.0, nether : 1.0
            {
                Instantiate(Sound, new Vector3(0, 0, 30), Quaternion.identity);
            }
        //}
    }

}
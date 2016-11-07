using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class Spowner2 : MonoBehaviour {

    public int inote = 0;
    public IList notes = null;
    public int bpm = 0;
    public string keysound;
    public double sounds;

	/*
    public Transform A;
	public Transform B;
	public Transform C;
    public Transform D;
    public Transform E;
    public Transform F;
    public Transform G;
    public Transform H;
	*/
    public Transform Sound;
    TextAsset asset = null;

    private Vector3 vec3;

	//ランダムにノーツを生成するための配列
	public GameObject[] Notes1;
	public GameObject[] Notes2;
	public GameObject[] Notes3;
	public GameObject[] Notes4;
	public GameObject[] Notes5;
	public GameObject[] Notes6;
	public GameObject[] Notes7;
	public GameObject[] Notes8;

	public int number1;
	public int number2;
	public int number3;
	public int number4;
	public int number5;
	public int number6;
	public int number7;
	public int number8;

    // Use this for initialization
    void Start () {
        inote = 0;
        keysound = null;
        sounds = 0;

        //if (GameObject4.gameFlags == "easy")
        //{

		asset = (TextAsset)Resources.Load("nether_techno");
            string json = asset.text;
            notes = (IList)Json.Deserialize(json);
			bpm = 320; //alien: 140, close the light: 175, nether :320

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
		number1 = Random.Range(0,Notes1.Length);
		number2 = Random.Range(0,Notes2.Length);
		number3 = Random.Range(0,Notes3.Length);
		number4 = Random.Range(0,Notes4.Length);
		number5 = Random.Range(0,Notes5.Length);
		number6 = Random.Range(0,Notes6.Length);
		number7 = Random.Range(0,Notes7.Length);
		number8 = Random.Range(0,Notes8.Length);

        switch (keysound)
        {
            case "0":
                //Instantiate(A, vec3, Quaternion.identity);
				Instantiate(Notes1[number1], vec3, Quaternion.identity);

                break;
            case "1":
                //Instantiate(B, vec3, Quaternion.identity);
				Instantiate(Notes2[number2], vec3, Quaternion.identity);

                break;
            case "2":
                //Instantiate(C, vec3, Quaternion.identity);
				Instantiate(Notes3[number3], vec3, Quaternion.identity);
			    
				break;
            case "3":
                //Instantiate(D, vec3, Quaternion.identity);
				Instantiate(Notes4[number4], vec3, Quaternion.identity);
			    
				break;
            case "4":
                //Instantiate(E, vec3, Quaternion.identity);
				Instantiate(Notes5[number5], vec3, Quaternion.identity);
			    
				break;
            case "5":
                //Instantiate(F, vec3, Quaternion.identity);
				Instantiate(Notes6[number6], vec3, Quaternion.identity);
			    
				break;
            case "6":
                //Instantiate(G, vec3, Quaternion.identity);
				Instantiate(Notes7[number7], vec3, Quaternion.identity);
			    
				break;
            case "7":
                //Instantiate(H, vec3, Quaternion.identity);
				Instantiate(Notes8[number8], vec3, Quaternion.identity);
			    
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
		if (sounds == 1.0)//alien: 0.0, close the light: 0.0, nether : 1.0
            {
                Instantiate(Sound, new Vector3(0, 0, 30), Quaternion.identity);
            }
        //}
    }

}
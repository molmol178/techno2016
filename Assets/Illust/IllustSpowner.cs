using UnityEngine;
using System.Collections;

public class IllustSpowner : MonoBehaviour {


	private Vector3 vec3;

	//ランダムにノーツを生成するための配列
	public GameObject[] Notes;
	public int number;
	private GameObject Score;
	private Score score;

	private bool flag;

	// Use this for initialization
	void Start () {
		vec3 = new Vector3(-100, 0,20);

		Score = GameObject.FindGameObjectWithTag("Score");
		score = Score.GetComponent<Score>();

		flag = true;
	}
	
	// Update is called once per frame
	void Update () {
		number = Random.Range(0,Notes.Length);
		if (score.getScore () < -50 && score.getScore () >= -60) {
			if (flag == true) {
				Instantiate (Notes [number], vec3, Quaternion.identity);
				flag = false;
			}
		}
	}
}

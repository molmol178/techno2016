using UnityEngine;
using System.Collections;

public class IllustCutIn : MonoBehaviour {
	private float init_x = -100;
	private float times = 0.0f;
	private Vector3 posi;
	private int is_move = 1;
	private float stop_time = 3f;
	private float slide_speed = 4f;

	private GameObject illust;

	// Use this for initialization
	void Start () {

		posi = transform.localPosition;
		posi.x = init_x; 

		 illust = GameObject.FindWithTag ("Illust");

	}
	
	// Update is called once per frame
	void Update () {
			//StartCoroutine("move");
		times += Time.deltaTime;
		if (times > stop_time) {
			is_move = 1;
		}
		if (is_move == 1) {
			move ();
		}

	}
	void move(){
		posi.x += slide_speed;
		transform.localPosition = posi;
		if (Mathf.Abs (posi.x) < slide_speed / 2) {
			is_move = 0;
			times = 0.0f;
		}
		if (posi.x > -init_x) {
			Destroy (illust);
		}
	}
}

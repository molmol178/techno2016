using UnityEngine;
using System.Collections;

public class GreatHantei : MonoBehaviour
{
    private bool greatanotate;
    private bool goodFlag;
    private ParticleSystem greatParticle;
    private ButtonElem btn;

    private GameObject ScoreBoad;
    private Score score;

    public Vector3 defaultSize= new Vector3(5f , 5f , 1f); 

    void Start()
    {
        greatParticle = GetComponent<ParticleSystem>();
        btn = this.GetComponent<ButtonElem>();
        ScoreBoad = GameObject.FindGameObjectWithTag("Score");
        score = ScoreBoad.GetComponent<Score>();
        //defaultSize = transform.localScale;
    }

    /// <summary>
    /// ボタンの当たり判定
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerStay(Collider other)
    {

        if (btn.isEnter())
        {
            //print("Greeeeeeeeeeeeeeeeaaaaaaaaaaaat");
            if (other.gameObject.tag == "Great")
            {
                score.setScore(5);
                greatParticle.Play();
                greatanotate = true;
            }
            if (other.gameObject.tag == "Good")
            {
                score.setScore(3);
                goodFlag = true;
            }
            if (other.gameObject.transform.root.tag == "Quad")
            {
                Destroy(other.gameObject.transform.root.gameObject);
            }
        }
    }

    /// <summary>
    /// Greatゲッター
    /// </summary>
    /// <returns></returns>
    public bool isGreat()
    {
        return greatanotate;
    }

    /// <summary>
    /// Goodゲッター
    /// </summary>
    /// <returns></returns>
    public bool isGood()
    {
        return goodFlag;
    }

    /// <summary>
    /// 初期化
    /// </summary>
    public void initialize()
    {
        greatanotate = false;
        goodFlag = false;
    }
}


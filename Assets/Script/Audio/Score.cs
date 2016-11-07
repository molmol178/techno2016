using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public GUIText Scotx;
    private int score;

    void Awake()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Scotx.text = getScore().ToString();
        //		print ("count");
    }

    /// <summary>
    /// ゲッター
    /// </summary>
    /// <returns></returns>
    public int getScore()
    {
        return score;
    }

    /// <summary>
    /// スコア加算
    /// </summary>
    /// <param name="point"></param>
    public void setScore( int point)
    {
        score += point;
    }

    /// <summary>
    /// スコア減算
    /// </summary>
    /// <param name="point"></param>
    public void downScore( int point)
    {
        score -= point;
    }
}

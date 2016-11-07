using UnityEngine;

public class KinectPointer : MonoBehaviour
{
    
    //位置調整用
    private GameObject KinectMan;
    private Transform[] KinectTrans;
    private Vector3 pos_;


    /// <summary>
    /// 変数の初期化
    /// </summary>
    void Start()
    {
        //Kinectマンの位置調整
        KinectMan = GameObject.Find("KinectPointMan");
        KinectTrans = KinectMan.GetComponentsInChildren<Transform>();
    }

    /// <summary>
    /// いくぜ
    /// </summary>
    void Update()
    {
        //Kinectの位置調整
        foreach (Transform fixedPos in KinectTrans)
        {
            pos_ = fixedPos.transform.position;
            pos_.z = 0;
            fixedPos.transform.position = pos_;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour
{
    public lighton GetLighton;
    public GhostMove GetStop;
    public GhostNumbar GetGhost;
    public soundcontler GetSound;

    [SerializeField] GameObject Nos;
    public int Descount = 3;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = Descount;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Light")
        {
            //3秒後にオブジェクトを消す
            InvokeRepeating("Destroycont",1,1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Light")
        {
            //ライトが出たならキャンセルする
            CancelInvoke();
            count = Descount;
        }
    }

    public void Destroycont()
    {
        count--;
        //カウント０で消えて、抽選を開始
        if (count <= 0)
        {
            Destroy(this.gameObject);
            GetSound.Ac1();
            Nos.SetActive(true);
            //抽選中はライトとカウントを止める
            GetLighton.Lightoff();
            CancelInvoke();
            //ghostの動きも止める
            GetStop.OnStopped();
            GetGhost.CountBotton();
        }
        //触れている途中でライトが消えてもキャンセルする
        if (GetLighton.Geton())
        {
            CancelInvoke();
            count = Descount;
        }
    }
}

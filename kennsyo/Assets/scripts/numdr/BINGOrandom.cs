using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BINGOrandom : MonoBehaviour
{
    public GhostNumbar numbar;
    public Goll GetGoll;
    public tateretu GetTate;
    public soundcontler Getsound;

    public int start;
    public int end ;
    int count = 5;

    List<int> numbers = new List<int>();
  
    public Text No1; int a; public float o5;
    public Text No2; int b; public float g4;
    public Text No3; int c; public float n3;
    public Text No4; int d; public float i2;
    public Text No5; int e; public float b1;
    int Bnumbar;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }
        while (count-- > 0)
        {
            //ランダムに数字を抽選、出た数字を消す
            int index = Random.Range(0, numbers.Count);
            int ransu = numbers[index];
            numbers.RemoveAt(index);
            //抽選された数字を記録
            if (count == 0) {a = ransu; No5.text = ransu.ToString();}
            if (count == 4) {b = ransu; No4.text = ransu.ToString();}
            if (count == 3) {c = ransu; No3.text = ransu.ToString();}
            if (count == 2) {d = ransu; No2.text = ransu.ToString();}
            if (count == 1) {e = ransu; No1.text = ransu.ToString();}
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void Numbars()
    {
        Bnumbar = numbar.Getnumbar();
        //ゴーストを倒した時の数字と同じ数字なら消す
        if (a == Bnumbar)
        {
            Getsound.Ac4();
            Destroy(No5.gameObject);  
            a = 0;
            //十字方向のカウントをそれぞれ増やす
            GetTate.Tateretu(); 　GetGoll.OY();
            //斜めならGollのnanameカウントを増やす
            if (o5== 5)  GetGoll.Naname();             
            if (o5== 1) GetGoll.Naname2();               
        }
        if (b == Bnumbar)
        {
            Getsound.Ac4();
            Destroy(No4.gameObject);  
            b = 0; 
            GetTate.Tateretu();　GetGoll.GY();
            if (g4 == 4) GetGoll.Naname();          
            if (g4 == 2) GetGoll.Naname2();      
        }
        if (c == Bnumbar)
        {
            Getsound.Ac4();
            Destroy(No3.gameObject);
            c = 0;
            GetTate.Tateretu(); GetGoll.NY();
            if (n3 == 3)
            {
                GetGoll.Naname();
                GetGoll.Naname2();
            }
        }
        if (d == Bnumbar)
        {
            Getsound.Ac4();
            Destroy(No2.gameObject);
            d = 0; 
            GetTate.Tateretu(); GetGoll.IY();
            if (i2 == 2)  GetGoll.Naname();            
            if (i2 == 4) GetGoll.Naname2();          
        }
        if (e == Bnumbar)
        {
            Getsound.Ac4();
            Destroy(No1.gameObject);
            e = 0; 
            GetTate.Tateretu(); GetGoll.BY();
            if (b1 == 1)GetGoll.Naname();
            if (b1 == 5)GetGoll.Naname2();         
        }
    }
}
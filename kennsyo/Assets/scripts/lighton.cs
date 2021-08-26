using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lighton : MonoBehaviour
{
    [SerializeField] GameObject raito;

    public UIManager iManager;
    public int BatteryCount;
    public int Batterypuls;
    public soundcontler GetSound;

    bool On;
    public bool Geton()
    {
        return On;
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        raito.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("z"))Lighton();
        if(Input.GetKeyDown("x"))Lightoff();
    }
    private void OnTriggerEnter(Collider other)
    {
        //休憩地点で電池を回復
        if(other.gameObject.tag == "Batteryplus")
        {
            GetSound.Ac5();
            BatteryCount = Batterypuls;
        }
    }
    public void Lighton()
    {
        GetSound.Ac3();
        if(BatteryCount >=0)
        {
            raito.SetActive(true);
            //2秒ごとに電池を減らす
            InvokeRepeating("Battery", 2, 2);
            //ボタンの切り替え
            iManager.SetOnBotton();
            On = false;
        }
    }
    public void Lightoff()
    {
        raito.SetActive(false);
        //電池を減らすのを止める
        CancelInvoke();
        //ボタンの切り替え
        iManager.SetOffBotton();
        //ゴーストの消滅カウントを止める
        On = true;
    }
    void Battery()
    {
        BatteryCount --;             
        //電池切れならライトを消す
        if (BatteryCount <= 0) Lightoff();
    }

    private void OnGUI()
    {
        string label = "";
        for (int L = 0; L < BatteryCount; L++) label = label + "+";
        GUI.Label(new Rect(50, 65, 100, 30),label);
    }
}

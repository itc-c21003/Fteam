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
        //�x�e�n�_�œd�r����
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
            //2�b���Ƃɓd�r�����炷
            InvokeRepeating("Battery", 2, 2);
            //�{�^���̐؂�ւ�
            iManager.SetOnBotton();
            On = false;
        }
    }
    public void Lightoff()
    {
        raito.SetActive(false);
        //�d�r�����炷�̂��~�߂�
        CancelInvoke();
        //�{�^���̐؂�ւ�
        iManager.SetOffBotton();
        //�S�[�X�g�̏��ŃJ�E���g���~�߂�
        On = true;
    }
    void Battery()
    {
        BatteryCount --;             
        //�d�r�؂�Ȃ烉�C�g������
        if (BatteryCount <= 0) Lightoff();
    }

    private void OnGUI()
    {
        string label = "";
        for (int L = 0; L < BatteryCount; L++) label = label + "+";
        GUI.Label(new Rect(50, 65, 100, 30),label);
    }
}

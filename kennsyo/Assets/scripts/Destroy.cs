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
            //3�b��ɃI�u�W�F�N�g������
            InvokeRepeating("Destroycont",1,1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Light")
        {
            //���C�g���o���Ȃ�L�����Z������
            CancelInvoke();
            count = Descount;
        }
    }

    public void Destroycont()
    {
        count--;
        //�J�E���g�O�ŏ����āA���I���J�n
        if (count <= 0)
        {
            Destroy(this.gameObject);
            GetSound.Ac1();
            Nos.SetActive(true);
            //���I���̓��C�g�ƃJ�E���g���~�߂�
            GetLighton.Lightoff();
            CancelInvoke();
            //ghost�̓������~�߂�
            GetStop.OnStopped();
            GetGhost.CountBotton();
        }
        //�G��Ă���r���Ń��C�g�������Ă��L�����Z������
        if (GetLighton.Geton())
        {
            CancelInvoke();
            count = Descount;
        }
    }
}

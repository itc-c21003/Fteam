using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject OnPanel;
    [SerializeField] GameObject OffPanel;

    public void SetOnBotton()
    {
        //on,off‚Ìƒ{ƒ^ƒ“‚ð“ü‚ê‘Ö‚¦‚é
        OnPanel.SetActive(false);
        OffPanel.SetActive(true);
    }
        public void SetOffBotton()
    {
        OffPanel.SetActive(false);
        OnPanel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        OffPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

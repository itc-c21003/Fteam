using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Animator animator;
    [SerializeField] VariableJoystick  m_VariableJoystick;
    [SerializeField] float m_Speed = 1;
    private CharacterController m_Controller;
    private Vector3 m_Direction;

    public soundcontler Getsound;
    // Start is called before the first frame update
    void Start()
    {
        m_Controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Direction != new Vector3(0, 0, 0))
        {
            transform.localRotation = Quaternion.LookRotation(m_Direction);
        }
        m_Controller.Move(m_Direction * m_Speed * Time.deltaTime);
        animator.SetBool("run", m_Direction != new Vector3(0, 0, 0));
    }
    public void FixedUpdate()
    { 
        m_Direction = Vector3.forward * m_VariableJoystick.Vertical + Vector3.right * m_VariableJoystick.Horizontal;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goll")
        {
            SceneManager.LoadScene("cria");
        }
    }
}

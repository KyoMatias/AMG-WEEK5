using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{

    [SerializeField] private GameObject m_mainCamera;
     [SerializeField] private GameObject m_menuCamera;
     [SerializeField] private GameObject m_menuUI;
     [SerializeField] private GameObject PlayerUI;

    [SerializeField]private Animator camerapan;
    [SerializeField] private Animator menupan;

    public delegate void PlayAnim();
    public static PlayAnim PlayAnimation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        m_menuCamera.SetActive(true);
        m_mainCamera.SetActive(false);
        PlayerUI.SetActive(false);
    }

    // Update is called once per frame

    public void TestAnimation()
    {
        camerapan.Play("camerapan");
        menupan.Play("StowAway");
        StartCoroutine(ActivatePlayerCam());
    }

    IEnumerator ActivatePlayerCam()
    {
        Cursor.lockState = CursorLockMode.Locked;
        yield return new WaitForSeconds(1.7f);
        m_mainCamera.SetActive(true);
        m_menuCamera.SetActive(false);
        m_menuUI.SetActive(false);
        PlayerUI.SetActive(true);
        yield return null;
    }



    public void ExitGame()
    {
        Application.Quit();
    }
}

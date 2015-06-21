using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour
{   
    public Button BackButton;
    public Button BackBtn;
    public GameObject modalPanelObject;
    public GameObject ReitingPanelObject;
    private static ModalPanel modalPanel;
    private static ModalPanel ReitingPanel;

    public static ModalPanel Instance()
    {
        if (!modalPanel)
        {
            {
                modalPanel = FindObjectOfType(typeof(ModalPanel)) as ModalPanel;
                if (!modalPanel)
                    Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
            }
            return modalPanel;
        }
        else
        {
            {
                ReitingPanel = FindObjectOfType(typeof(ModalPanel)) as ModalPanel;
                if (!ReitingPanel)
                    Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
            }
            return ReitingPanel;
        }
    }

    public void Choice(UnityAction backEvent)
    {
        {
            modalPanelObject.SetActive(true);
            BackButton.onClick.RemoveAllListeners();
            BackButton.onClick.AddListener(backEvent);
            BackButton.onClick.AddListener(ClosePanel);
            BackButton.gameObject.SetActive(true);
        }
    }
    public void Choice1(UnityAction backEvent)
    {  
        {
            ReitingPanelObject.SetActive(true);
            BackBtn.onClick.RemoveAllListeners();
            BackBtn.onClick.AddListener(backEvent);
            BackBtn.onClick.AddListener(ClosePanel1);
            BackBtn.gameObject.SetActive(true);
        }
    }

    void ClosePanel()
    {
        modalPanelObject.SetActive(false);
    }

    void ClosePanel1()
    {
        ReitingPanelObject.SetActive(false);
    }

}

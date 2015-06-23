using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class STower : MonoBehaviour {
    public Button Button;
    public Transform Btn1;
    public Transform Btn2;
    public Transform Btn3;
    public Transform Btn4;
    public Transform Btn5;
    public Transform Btn6;
    public Transform Btn7;
    public GameObject TowerPanelObject;
    private static STower TowerPanel;
    public string btn;


    public static STower Instance()
    {
        if (!TowerPanel)
        {
            TowerPanel = FindObjectOfType(typeof(STower)) as STower;
            if (!TowerPanel)
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
        }
        return TowerPanel;
    }

    public void buttonSetup(string button)
    {
        switch (button)
        {
           case "Btn1":
                TowerPanelObject.transform.SetParent(Btn1, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
           case "Btn2":
                TowerPanelObject.transform.SetParent(Btn2, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
           case "Btn3":
                TowerPanelObject.transform.SetParent(Btn3, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
           case "Btn4":
                TowerPanelObject.transform.SetParent(Btn4, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
           case "Btn5":
                TowerPanelObject.transform.SetParent(Btn5, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
           case "Btn6":
                TowerPanelObject.transform.SetParent(Btn6, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
           case "Btn7":
                TowerPanelObject.transform.SetParent(Btn7, true);
                TowerPanelObject.transform.localPosition = Vector2.zero;
                break;
        }

    }


    public void Choice(UnityAction noEvent)
    {
        TowerPanelObject.SetActive(true);
        Button.onClick.RemoveAllListeners();
        Button.onClick.AddListener(noEvent);
        Button.onClick.AddListener(ClosePanel);
        Button.gameObject.SetActive(true);
        
    }

    void ClosePanel()
    {
        TowerPanelObject.SetActive(false);
    }

}

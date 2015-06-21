using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class STower : MonoBehaviour {
    public Button Button;
    public Button Button1;
    public GameObject TowerPanelObject;
    private static STower TowerPanel;

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

    public void Choice(UnityAction noEvent)
    {
        {
           
            TowerPanelObject.SetActive(true);
            Button.onClick.RemoveAllListeners();
            Button.onClick.AddListener(noEvent);
            Button.onClick.AddListener(ClosePanel);
            Button.gameObject.SetActive(true);
        }
    }

    void ClosePanel()
    {
        TowerPanelObject.SetActive(false);
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class Pause_level : MonoBehaviour {
    public Button NoButton;
    public GameObject PausePanelObject;
    private static Pause_level PausePanel;

    public static Pause_level Instance()
    {
        if (!PausePanel)
        {
            PausePanel = FindObjectOfType(typeof(Pause_level)) as Pause_level;
            if (!PausePanel)
                Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
        }
        return PausePanel;
    }

    public void Choice(UnityAction noEvent)
    {
        {
            PausePanelObject.SetActive(true);
            NoButton.onClick.RemoveAllListeners();
            NoButton.onClick.AddListener(noEvent);
            NoButton.onClick.AddListener(ClosePanel);
            NoButton.gameObject.SetActive(true);
        }
    }

    void ClosePanel()
    {
        PausePanelObject.SetActive(false);
    }

}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class Panel_Level : MonoBehaviour {
        public GameObject MenuPanelObject;
        public Button YesButton;
        public Button NoButton;
        private static Panel_Level MenuPanel;
        public static Panel_Level Instance()
        {
            if (!MenuPanel)
            {
                MenuPanel = FindObjectOfType(typeof(Panel_Level)) as Panel_Level;
                if (!MenuPanel)
                    Debug.LogError("There needs to be one active ModalPanel script on a GameObject in your scene.");
            }
            return MenuPanel;
        }

        public void Choice(UnityAction yesEvent, UnityAction noEvent)
        {
            {
                MenuPanelObject.SetActive(true);
                YesButton.onClick.RemoveAllListeners();
                YesButton.onClick.AddListener(yesEvent);
                YesButton.onClick.AddListener(ClosePanel);
                NoButton.onClick.RemoveAllListeners();
                NoButton.onClick.AddListener(noEvent);
                NoButton.onClick.AddListener(ClosePanel);
                YesButton.gameObject.SetActive(true);
                NoButton.gameObject.SetActive(true);
            }
        }
        void ClosePanel()
        {
            MenuPanelObject.SetActive(false);
        }
}



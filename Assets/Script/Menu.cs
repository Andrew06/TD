using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class Menu : MonoBehaviour {
    public bool CanMute;
    public Button Button;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    private ModalPanel modalPanel;
    private ModalPanel ReitingPanel;
    public Sprite sprite;
    public Sprite sprite1;
	// Use this for initialization

    void Start () {
        AudioListener.pause = false; 
        CanMute = true;
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void Awake()
    {
        modalPanel = ModalPanel.Instance();
        ReitingPanel = ModalPanel.Instance();
    }

    void BackFunction()
    {
        Debug.Log("Click BackButton ");
    }
    public void ClickButton(string buttonID)
    {
        switch (buttonID)
        {
            case "Button":
                modalPanel.Choice(BackFunction);
                break;
            case "Button 1":
                ReitingPanel.Choice1(BackFunction);
                break;
            case "Button 2":
                Application.Quit();
                break;
            case "Button 3":
                Application.LoadLevelAsync(1);
                break;
            case "Button 4":
                if (CanMute)
                {
                    AudioListener.pause = true;
                    Button4.GetComponent<Image>().sprite = sprite;
                    CanMute = false;
                }
                else
                {
                    AudioListener.pause = false;
                    Button4.GetComponent<Image>().sprite = sprite1;
                    CanMute = true;
                }
                break;
        }
    }

}

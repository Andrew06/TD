using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class Level1 : MonoBehaviour {
    public bool CanMute;
    public Button Button;
    public Button Button1;
    public Button Button2;
    public Sprite sprite;
    public Sprite sprite1;
    private Panel_Level MenuPanel;
    private Pause_level PausePanel;
    private STower TowerPanel;
    

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
        MenuPanel = Panel_Level.Instance();
        PausePanel = Pause_level.Instance();
        TowerPanel = STower.Instance();
    }

    void YesFunction()
    {
        Application.LoadLevelAsync(0);  
    }

    void NoFunction()
    {
    }

    void BackFunction()
    {
        Button2.GetComponent<Image>().sprite = sprite;
    }

    public void Click(Button button)
    {
        TowerPanel.buttonSetup(button); 
        TowerPanel.Choice(NoFunction); 
   }


    public void ClickButton(string buttonID)
    {
        switch (buttonID)
        {
            case "Button":
              if (CanMute)
                {
                    AudioListener.pause = true;
                    Button.GetComponent<Image>().sprite = sprite;
                    CanMute = false;
                }
                else
                {
                    AudioListener.pause = false;
                    Button.GetComponent<Image>().sprite = sprite1;
                    CanMute = true;
                }
                break;
            case "Button 1":
                MenuPanel.Choice(YesFunction, NoFunction);
                break;
            case "Button 2":
                PausePanel.Choice(BackFunction);
                Button2.GetComponent<Image>().sprite = sprite1;
                break;
        }
    }
}

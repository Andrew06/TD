using UnityEngine;
using System.Collections;

public class Loadscene : MonoBehaviour {
    private int pRounded;

    void Start()
    {
        StartCoroutine("launchLevel");
    }

    IEnumerator launchLevel()
    {
        AsyncOperation async = Application.LoadLevelAsync(2);
        while (async.isDone == false)
        {
            float p = async.progress * 100f;
            pRounded = Mathf.RoundToInt(p);
            string perc = pRounded.ToString();

            Debug.Log("Прогресс загрузки: " + perc + " %.");

            yield return true;
        }
    }

}

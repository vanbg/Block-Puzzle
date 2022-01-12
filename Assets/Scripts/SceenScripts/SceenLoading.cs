using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceenLoading : MonoBehaviour
{
    [SerializeField]
    private Image _progetBar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadAsyncOperation());
    }

    IEnumerator loadAsyncOperation()
    {
        //
        AsyncOperation gamelevel = SceneManager.LoadSceneAsync(1);
        
        while(gamelevel.progress < 1)
        {
            _progetBar.fillAmount = gamelevel.progress;
            yield return new WaitForEndOfFrame();
        }    

      
        
    }    
}

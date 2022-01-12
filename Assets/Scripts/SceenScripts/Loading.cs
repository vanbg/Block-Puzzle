using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(0);
    }
}

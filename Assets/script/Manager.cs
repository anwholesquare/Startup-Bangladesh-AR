using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public void amphi()
    {
        SceneManager.LoadScene("virtualroom1", LoadSceneMode.Single);
    }
    public void lab()
    {
        SceneManager.LoadScene("virtualroom2", LoadSceneMode.Single);
    }
    public void cowork()
    {
        SceneManager.LoadScene("virtualroom3", LoadSceneMode.Single);
    }
    public void openspace()
    {
        SceneManager.LoadScene("virtualroom4", LoadSceneMode.Single);
    }
    

    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape)) {

                // Quit the application
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
            }
        }
    }
}

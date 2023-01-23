using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuScript : MonoBehaviour
{
    [SerializeField] Button settings;
    [SerializeField] Button demo;

    // Start is called before the first frame update
    void Start()
    {
        //adds a listener to the Settings button
        settings.onClick.AddListener(goToSettings);
        demo.onClick.AddListener(goToDemo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToSettings ()
    {
        SceneManager.LoadScene(1);
    }

    public void goToDemo ()
    {
        //changes the scene to the demo scene
        SceneManager.LoadScene(2);
    }
}

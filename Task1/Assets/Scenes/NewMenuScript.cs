using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using FlexUI;


public class NewMenuScript : MonoBehaviour
{
    [SerializeField] Button settings;
    [SerializeField] Button demo;

    // FlexUI addition
    [SerializeField] RectTransform backgroundTrans;
    [SerializeField] RectTransform titileTrans;
    [SerializeField] RectTransform startTrans;
    [SerializeField] RectTransform settingsTrans;


    // Start is called before the first frame update
    void Start()
    {
        //adds a listener to the Settings button
        settings.onClick.AddListener(goToSettings);
        demo.onClick.AddListener(goToDemo);

        menuSetup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goToSettings()
    {
        SceneManager.LoadScene(1);
    }

    public void goToDemo()
    {
        //changes the scene to the demo scene
        SceneManager.LoadScene(2);
    }

    public void menuSetup()
    {
        Flex backgroundObj = new Flex(backgroundTrans, 1);
        Flex titleObj = new Flex(titileTrans, 1.5f);
        Flex startObj = new Flex(startTrans, 1);
        Flex settingsObj = new Flex(settingsTrans, 1);

        backgroundObj.addChild(titleObj);
        backgroundObj.addChild(startObj);
        backgroundObj.addChild(settingsObj);

        backgroundObj.setVerticalPadding(3,1,3,1);
        backgroundObj.setHorizontalPadding(1, 1, 1, 1);
        backgroundObj.setSpacingFlex(2, 1);

        startObj.setSelfHorizontalPadding(0.3f, 1, 0.3f, 1);
        settingsObj.setSelfHorizontalPadding(0.3f, 1, 0.3f, 1);


        backgroundObj.setSize(new Vector2(Screen.width, Screen.height));
    }


}

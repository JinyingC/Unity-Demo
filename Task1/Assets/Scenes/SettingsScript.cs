using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Text language;
    [SerializeField] Button lan1;
    [SerializeField] Button lan2;
    [SerializeField] Text volume;
    [SerializeField] Slider volumeSlide;
    [SerializeField] Button back;

    int vol = 0;
    bool isEnglish = true;

    // Start is called before the first frame update
    void Start()
    {
        lan1.onClick.AddListener(setLanEng);
        lan2.onClick.AddListener(setLanFrench);
        //Go back to menu
        back.onClick.AddListener(goBack);

        setLanEng();
        volumeSlide.onValueChanged.AddListener(delegate { setVolume(); });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setLanEng ()
    {
        //change the text
        title.text = "Settings";
        language.text = "Language : English";
        volume.text = "Volume : " + vol;
    }

    public void setLanFrench ()
    {
        title.text = "Paramètre";
        language.text = "Langue : Français";
        volume.text = "Volume : " + vol;

        // change the text displayed
        lan1.transform.GetChild(0).GetComponent<Text>().text = "Englais";
        lan2.transform.GetChild(0).GetComponent<Text>().text = "Français";
        back.transform.GetChild(0).GetComponent<Text>().text = "Retourne";
    }

    public void goBack ()
    {
        SceneManager.LoadScene(0);
    }

    public void setVolume ()
    {
        vol = (int) volumeSlide.value;

        if (isEnglish == true)
        {
            //english
            volume.text = "Volume : " + vol;
        } else
        {
            //french
            volume.text = "Volume : " + vol;
        }
    }
}

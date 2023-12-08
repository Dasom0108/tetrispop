using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option : MonoBehaviour
{
    FullScreenMode screenMode;
    public TMP_Dropdown resolutionsDropdown;
    public Toggle fullscreenBtn;
    List<Resolution> resolutions = new List<Resolution>();
    public int resolutionNum;
    void Start()
    {
        InitUI();
    }

    void InitUI()
    {
        for(int i = 0; i < Screen.resolutions.Length; i++)
        {
            if(Screen.resolutions[i].refreshRate == 60)
            {
                resolutions.Add(Screen.resolutions[i]);
            }
        }
        resolutionsDropdown.options.Clear();

        int optionNum = 0;
        foreach(Resolution item in resolutions)
        {
            TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();
            option.text = item.width + "x" + item.height + " ";
            resolutionsDropdown.options.Add(option);

            if(item.width == Screen.width && item.height == Screen.height)
            {
                resolutionsDropdown.value = optionNum;
            }
            optionNum++;
        }

        resolutionsDropdown.RefreshShownValue();

        fullscreenBtn.isOn = Screen.fullScreenMode.Equals(FullScreenMode.FullScreenWindow) ? true : false;
    }

    public void DropboxOptionchange(int x)
    {
        resolutionNum = x;
    }

    public void FullScreen(bool isFull)
    {
        screenMode = isFull ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
    }

    public void Ok()
    {
        Screen.SetResolution(resolutions[resolutionNum].width, resolutions[resolutionNum].height, screenMode);
    }

}

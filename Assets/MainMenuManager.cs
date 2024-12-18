using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Button playbutton;
    public Button exitbutton;
    public void PlayGame(){
        SceneManager.LoadScene("Gameplay");
        }
    public void ExitGame(){
        Application.Quit();
        }
}

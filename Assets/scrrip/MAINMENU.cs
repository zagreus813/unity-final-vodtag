using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.scrrip
{
    public class MAINMENU : MonoBehaviour
    {
        public void playGmae()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        public void playGmae2()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        public void playGmae3()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        public void QuitGame()
        {
            Debug.Log("Quit!!!");
            Application.Quit();
        }
    }
}
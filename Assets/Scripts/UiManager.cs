using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class UiManager: MonoBehaviour
    {
        [SerializeField] private GameObject pausepanel;
        private bool ispaused;

        public void LoadFirstScene()
        {
            SceneManager.LoadScene(0);
        }
        
        public void LoadSecondScene()
        {
            SceneManager.LoadScene(1);
        }
        
        public void LoadThirdScene()
        {
            SceneManager.LoadScene(2);
        }
        
        public void ReloadScene()
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }

        public void ExitGame()
        {
            Application.Quit(); 
        }

        public void Pause()
        {
            pausepanel.SetActive(true);
            Time.timeScale = 0;
            ispaused = true;
        }

        public void UnPause()
        {
            Time.timeScale = 1;
            pausepanel.SetActive(false);
            ispaused = false;
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if (ispaused)
                {
                    UnPause();
                }
                else
                {
                    Pause();
                }
            }
        }
    }
}
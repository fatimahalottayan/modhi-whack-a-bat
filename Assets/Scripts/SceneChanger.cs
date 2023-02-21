using UnityEngine;
using UnityEngine.SceneManagement;

    public class SceneChanger : MonoBehaviour
    {

        public void PlayGameButtonClicked(int roomNum)
        {
            // a better way is to use index 
            SceneManager.LoadScene(roomNum);
        }


        public void BackToMain()
        {
        // a better way is to use index 
          SceneManager.LoadScene(0);

        }


        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }




using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScence(string senceName) 
    {
        //場景管理器 讀取場景(場景名稱)
        SceneManager.LoadScene(senceName);
    
    }

    public void QuitGame()
    {
        //應用程式 離開()
        Application.Quit();

    }
}

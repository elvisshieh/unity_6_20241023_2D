using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScence(string senceName) 
    {
        //�����޲z�� Ū������(�����W��)
        SceneManager.LoadScene(senceName);
    
    }

    public void QuitGame()
    {
        //���ε{�� ���}()
        Application.Quit();

    }
}

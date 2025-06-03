using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadMarkerBasedScene()
    {
        SceneManager.LoadScene("MarkerBasedScene");
    }

    public void LoadMarkerlessScene()
    {
        SceneManager.LoadScene("MarkerlessScene");
    }
}

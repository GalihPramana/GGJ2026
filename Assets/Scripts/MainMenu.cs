using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelcredit;
    public GameObject btnplay;
    public GameObject btncredit;
    public GameObject btnexit;
    public GameObject frame;
    public GameObject judul;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelcredit.activeSelf)
            {
               close();
            }
            else
            {
                exit();
            }
        }
    }
    public void play()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void credit()
    {
        panelcredit.SetActive(true);
        btnplay.SetActive(false);
        btncredit.SetActive(false);
        btnexit.SetActive(false);
        frame.SetActive(true);
        judul.SetActive(false);

    }
    public void close()
    {
        panelcredit.SetActive(false);
        btnplay.SetActive(true);
        btncredit.SetActive(true);
        btnexit.SetActive(true);
        frame.SetActive(true);
        judul.SetActive(true);
    }
    public void exit()
    {
        Application.Quit();
    }
}

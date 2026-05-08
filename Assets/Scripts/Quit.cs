using UnityEngine;

public class Quit : MonoBehaviour
{
    public GameObject Panel;
    public void OnCancel()
    {
        
        if(Panel.activeSelf)
        {
            Panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }else
        {
            Panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void quits()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class savePoint : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            optionalsaves.SavePoint = gameObject;
            Debug.Log(optionalsaves.SavePoint.transform.position);
        }
        
        if(this.tag == "win")
        {
            Debug.Log("WHY");
            SceneManager.LoadScene("win");
        }
    }
}

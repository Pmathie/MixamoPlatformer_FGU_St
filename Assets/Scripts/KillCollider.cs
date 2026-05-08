using UnityEngine;

public class Kill : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(optionalsaves.SavePoint.transform.position);
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerController>().enabled = false;
            other.GetComponent<CharacterController>().enabled = false;
            other.transform.position = optionalsaves.SavePoint.transform.position + new Vector3(0, 2, 0);
            other.GetComponent<CharacterController>().enabled = true;
            other.GetComponent<PlayerController>().enabled = true;
        }
    }
}

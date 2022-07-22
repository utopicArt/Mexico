using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Message : MonoBehaviour
{
    public TextMeshProUGUI dialogTMP;
    public GameObject messageContainer;
    public string dialogText;

    void Start()
    {
        if (dialogText.Length > 100)
        {
            dialogText = dialogText.Substring(0, 100);
        }
        dialogTMP.text = dialogText;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        dialogTMP.text = dialogText;
        Vector3 dialogPosition = new Vector3(
            gameObject.transform.position.x,
            gameObject.transform.position.y + 0.5f,
            gameObject.transform.position.z);
        messageContainer.transform.position = dialogPosition;
        messageContainer.SetActive(true);
        Debug.Log("Entro al objeto");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        messageContainer.SetActive(false);
        Debug.Log("Salio del objeto");
    }
}

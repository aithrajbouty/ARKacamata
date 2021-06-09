using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{

    [SerializeField]
    private GameObject kacamata;
    private GameObject faceAttachment;
    public Sprite activeButtonImage;
    public Sprite inactiveButtonImage;
    public Button button;

    private bool isActivated;

    private void Start()
    {
        /*faceAttachment = GameObject.Find("FaceAttachment");
        GameObject kacamata_oval1 = faceAttachment.transform.Find("kacamata_oval1").gameObject;
        
        if (kacamata_oval1.activeSelf == true)
        {
            kacamata_oval1.SetActive(false);
        }*/

        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
    }

    private void TurnOnAndOff()
    {
        isActivated ^= true;
        kacamata.SetActive(isActivated);

        button = gameObject.GetComponent<Button>();

        if (isActivated == true)
        {
            button.image.sprite = activeButtonImage;
        }
        else if (isActivated == false)
        {
            button.image.sprite = inactiveButtonImage;
        }
    }
}

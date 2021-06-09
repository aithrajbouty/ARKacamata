using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveLoadObject : MonoBehaviour
{
    private GameObject kacamata;

    private bool isActivated;

    private void Start()
    {

        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
    }

    private void TurnOnAndOff()
    {
        Kacamata1Data data = SaveSystem.LoadKacamata1();
        kacamata = GameObject.Find(data.nama);

        isActivated ^= true;
        kacamata.SetActive(isActivated);
    }
}

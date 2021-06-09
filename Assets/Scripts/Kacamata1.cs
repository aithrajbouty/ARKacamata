using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kacamata1 : MonoBehaviour
{
    public string nama;
    [SerializeField] private GameObject kacamata;

    public void SaveKacamata1()
    {
        nama = kacamata.name;
        SaveSystem.SaveKacamata(this);
    }

}

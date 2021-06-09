using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Kacamata1Data
{
    public string nama;

    public Kacamata1Data (Kacamata1 kacamata1)
    {
        nama = kacamata1.nama;
    }
}

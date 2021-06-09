using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material kacamata_material;
    [SerializeField] public Color kacamata_warna;

    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeMaterial);
    }

    void ChangeMaterial()
    {
        kacamata_material.color = kacamata_warna;
    }
}

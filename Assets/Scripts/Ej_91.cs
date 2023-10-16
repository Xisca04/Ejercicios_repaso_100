using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_91 : MonoBehaviour
{
    // Ej 91 -- Random array de VFX y colores

    public Material[] _materials;
    private int _material;
    public Material mat;

    public AudioClip[] _sounds;
    private int _sound;

    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        SpawnSoundAndColor();
    }

    private void SpawnSoundAndColor()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RandomSound();
            RandomColor();
        }
    }
    private void RandomSound()
    {
        _sound =  Random.Range(0, _sounds.Length);
    }

    private void RandomColor()
    {
        _material = Random.Range(0, _materials.Length);
        
    }
}

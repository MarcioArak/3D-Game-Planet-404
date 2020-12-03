using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenCrate : MonoBehaviour
{
    [SerializeField]
    Transform crate;

    Animator anim;
    public GameObject collectible;
    private bool opened = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //var keyboard = Keyboard.current;
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("Open");
            if (!opened)
            {
                opened = true;
                SpawnObject();
            }
        }
    }

    void SpawnObject()
    {
        // Instantiate object and place it near crate
        GameObject collect = Instantiate(collectible);
        collect.transform.position = setSpawnPosition();
    }

    Vector3 setSpawnPosition()
    {
        Vector3 pos = this.transform.position;
        pos.x += 0.1f;
        pos.y += 0.5f;
        pos.z += .8f;

        return pos;
    }
}   

/*
if (keyboard != null)
{
    if (Input.GetKey(KeyCode.F))
    {
        Debug.Log("hi");
        gameObject.SetActive(false);
    }
}*/
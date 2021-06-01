using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreation : MonoBehaviour
{

    private List<GameObject> models;

    //default index of the model
    private int selectionIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        models = new List<GameObject>();
        foreach(Transform t in transform)
        {
            models.Add(t.gameObject);
            t.gameObject.SetActive(false);
        }

        models[selectionIndex].SetActive(true);
    }


    public void Select(int index)
    {
        if (index == selectionIndex)
            return;

        if (index < 0 || index >= models.Count)
            return;
        

        models[selectionIndex].SetActive(false);
        selectionIndex = index;
        models[selectionIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //idk why this isnt working smh
        //transform.Rotate(new Vector3(0.0f, Input.GetAxis("Mouse Y"), 0.0f));
        if (Input.GetKeyDown(KeyCode.A))
            Select(2);
    }
}

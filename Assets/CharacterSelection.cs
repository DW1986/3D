using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour {

    private GameObject[] CharacterList;

    private void Start()
    {
        CharacterList = new GameObject[transform.childCount];
        
        for (int i = 0; i < transform.childCount; i++)
            CharacterList[i] = transform.GetChild(i).gameObject;

        foreach(GameObject go in CharacterList)        
            go.SetActive(false);

        if (CharacterList[0])
            CharacterList[0].SetActive(true);
    }
}

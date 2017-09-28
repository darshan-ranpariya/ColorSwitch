using System.Collections.Generic;
using UnityEngine;

public class ObjectSpwanManager : MonoBehaviour {

    public GameObject[] circlePrefabs;
    public GameObject colorChanger;
    public Transform parent;

    private List<GameObject> spwanedPrefabList; 

    private Vector3 spwanPos = Vector3.zero;
    private float distance;

    private void Start()
    {
        spwanedPrefabList = new List<GameObject>();
        spwanPos.y = 10f;
    }

    public void spwanRandomObject()
    {
        distance = Random.Range(3f, 4.5f);
        spwanPos.y = spwanPos.y + distance;
        Instantiate(colorChanger, spwanPos, Quaternion.identity, parent);

        distance = Random.Range(3f, 4.5f);
        spwanPos.y = spwanPos.y + distance;
        if (spwanedPrefabList.Count <= 4)
        {
            GameObject goInst = Instantiate(circlePrefabs[Random.Range(0, 4)], spwanPos, Quaternion.identity, parent);
            spwanedPrefabList.Add(goInst);
        }
        else
        {
            for (int i = 0; i < spwanedPrefabList.Count; i++)
            {
                if (!spwanedPrefabList[i].activeInHierarchy)
                {
                    spwanedPrefabList[i].transform.position = spwanPos;
                    spwanedPrefabList[i].SetActive(true);
                }
            }
        }
    }
}

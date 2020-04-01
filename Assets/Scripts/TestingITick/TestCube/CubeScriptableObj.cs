using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewModel", menuName = "CreateModel/Cube", order = 0)]
public class CubeScriptableObj : ScriptableObject
{

    public float speed;

    public GameObject prefab;

    public GameObject Target;
    

    void mat()
    {

        float maxDistance = 5;
        Vector3 player = Vector3.zero;
        Vector3 Enemy = Vector3.zero;
        var distance = Vector3.SqrMagnitude(player - Enemy);

        if (distance > maxDistance * maxDistance) Debug.Log("Hurrah");

        Vector3.Distance(player, Enemy);
        Vector3.Magnitude(player);
    }
}

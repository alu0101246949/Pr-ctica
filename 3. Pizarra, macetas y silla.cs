using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizarraMacetaSillas : MonoBehaviour
{
    public Transform blackboard;
    public Transform[] pots;
    public Transform[] chairs;
    public float triggerDistance = 5.0f;    // Distancia de activación
    public float chairMoveAmount = 1.0f;
    public float chairFixedDistance = 2.0f; // Distancia fija para acercar las sillas
    public float min = -10f;
    public float max = 10f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(blackboard.position, transform.position);
        // if (triggerDistance > dist)
        {
            MovePotsRandomly();
            MoveChairsCloser();
        }

    }

    void MovePotsRandomly()
    {
        foreach (var pot in pots)
        {
            pot.position = new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        }
    }

    void MoveChairsCloser()
    {
        foreach (var chair in chairs)
        {
            // chair.position = Vector3.MoveTowards(chair.position, transform.position, chairMoveAmount * Time.deltaTime);
            Vector3 directionToMonster = (transform.position - chair.position).normalized;
            Vector3 newPosition = chair.position + directionToMonster * chairFixedDistance * Time.deltaTime;
            chair.position = newPosition;
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControler : MonoBehaviour
{
    public Camera Cam;
    RaycastHit hit;

    public NavMeshAgent Agent;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray, out hit)){
                Agent.SetDestination(hit.point);

            }
        }

    }
}

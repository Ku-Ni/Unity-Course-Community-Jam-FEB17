using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private GameObject playerModel;

    // Use this for initialization
    void Start() {
        playerModel = GameObject.FindGameObjectWithTag("PlayerModel");

        if (!playerModel)
            throw new UnityException("Could not find object tagged as PlayerModel");
    }

    // Update is called once per frame
    void Update() {
        float zRotation = playerModel.transform.rotation.z;
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space Down - zRotation:" + zRotation);
            if (zRotation == 0f || zRotation == 1f) {
                Spin();
            }
        }
    }


    private void Spin() {
        Debug.Log("Spinning");
        if (playerModel.transform.rotation.z == 0)
            iTween.RotateTo(playerModel, new Vector3(0f, 0f, 180f), 3f);
        else {
            iTween.RotateTo(playerModel, new Vector3(0f, 360, 0), 3f);
        }
            

    }
}

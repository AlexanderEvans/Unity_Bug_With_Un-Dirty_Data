using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightAutoPopulate : MonoBehaviour
{
#pragma warning disable CS0649
    [SerializeField]
    Rigidbody2D myRB;
#pragma warning restore CS0649
    public string target;

    // Update is called once per frame
    void Update() 
    {
        myRB.velocity = Vector2.right;
    }
    private void OnValidate()
    {
#if UNITY_EDITOR
        //only populate this if we aren't in a prefab(must be in scene) and we want to auto populate, and don't run in play mode
        //as OnValidate() won't exist in builds and isn't called consistently on scene reloads
        if (gameObject.scene != new UnityEngine.SceneManagement.Scene() && !Application.isPlaying)
        {
            Debug.Log("AutoPopulating: " + this);
            GameObject go = GameObject.Find(target);
            if (go != null)
                myRB = go.GetComponent<Rigidbody2D>();
            else
                Debug.LogError(target + " not found!");
        }
#endif
    }
}

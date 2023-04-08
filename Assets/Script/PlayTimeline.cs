using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour
{
    [SerializeField]private InputActionReference playReference;
    [SerializeField] private PlayableDirector director;

    void Start()
    {
        playReference.action.performed += OnPlayTimeline;
    }

    private void OnDisable()
    {
        playReference.action.performed -= OnPlayTimeline;
    }

    void OnPlayTimeline(InputAction.CallbackContext context)
    {
        Debug.Log("Press Button");
        director.Play();
    }


}

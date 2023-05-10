using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EcsRunner
{
    public class AnimationsController : MonoBehaviour
    {
        
        private Animator animator;
        private string  currentState;
        private Vector3 playerPosition;

        //Animation states
        const string PLAYER_IDLE = "PLAYER_IDLE";
        const string PLAYER_RUN = "PLAYER_RUN";
        const string PLAYER_FALLING = "PLAYER_FALLING";

        
        void Start()
        {
            
            animator = GetComponent<Animator>();
        }

        void Update(){

            playerPosition = transform.parent.position;
            //ANIMATION WHEN RUNNING
            if(playerPosition.x > 25.1f){ChangeAnimationState(PLAYER_RUN);}
            //ANIMATION WHEN FALLING
            if(playerPosition.y < 1.05f){animator.CrossFade("PLAYER_FALLING", 0.05f); }

        }

        
        void ChangeAnimationState(string newState)
        {
            //stop the same animation from interrupting itself 
            if(currentState == newState){return;}

            //play the animation
            animator.Play(newState);

            //reassign the current state
            currentState = newState;
        }
    }
}

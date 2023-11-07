using UnityEngine;

namespace PlayerSystem
{
    public class PlayerModel
    {
        private float _moveSpeed;
        private float _jumpForce;
        private Vector3 _endValueOfJump;
        private int _numJumps;
        private float _jumpDuration;

        public PlayerModel(float moveSpeed, float jumpForce, Vector3 endValueOfJump, int numJumps, float jumpDuration)
        {
            _moveSpeed = moveSpeed;
            _jumpForce = jumpForce;
            _endValueOfJump = endValueOfJump;
            _numJumps = numJumps;
            _jumpDuration = jumpDuration;
        }
        
        


    }
}

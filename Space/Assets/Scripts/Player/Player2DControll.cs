namespace Assets.Scripts.Player
{
    using JetBrains.Annotations;

    using UnityEngine;

    [RequireComponent(typeof(Rigidbody2D))]
    public class Player2DControll : MonoBehaviour
    {
        public float ForwardMovingForce = 1;
        public float RotationForce = 1;

        [NotNull]
        private Rigidbody2D m_rigidbody2D;

        // Use this for initialization
        private void Start()
        {
            this.m_rigidbody2D = this.GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.m_rigidbody2D.AddForce(new Vector2(0, this.ForwardMovingForce));
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.m_rigidbody2D.transform.Rotate(0, 0, this.RotationForce);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.m_rigidbody2D.AddForce(new Vector2(0, -this.ForwardMovingForce));
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.m_rigidbody2D.transform.Rotate(0, 0, -this.RotationForce);
            }
        }
    }
}
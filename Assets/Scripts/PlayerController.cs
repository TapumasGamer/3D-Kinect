using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float HorizontalMove;
    public float VerticalMove;
    public CharacterController Player;
    public float PlayerSpeed;
    public float Gravedad = 9.8f;
    public float VelocidadCaida;
    public Camera MainCamera;
    public float JumpForce;
    


    private Vector3 playerInput;
    private Vector3 CamForward;
    private Vector3 CamRight;
    private Vector3 movePlayer;


    void Start()
    {
        Player = GetComponent<CharacterController>();
    }
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(HorizontalMove, 0, VerticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        CamDirection();

        movePlayer = playerInput.x * CamRight + playerInput.z * CamForward;

        movePlayer = movePlayer * PlayerSpeed;

        Player.transform.LookAt(Player.transform.position + movePlayer);

        SetGravedad();

        PlayerSkills();

        Player.Move(movePlayer * Time.deltaTime);
    }
    void CamDirection()
    {
        CamForward = MainCamera.transform.forward;
        CamRight = MainCamera.transform.right;

        CamForward.y = 0;
        CamRight.y = 0;

        CamForward = CamForward.normalized;
        CamRight = CamRight.normalized;

    }
    public void PlayerSkills()
    {
        if (Player.isGrounded && Input.GetButtonDown("Jump"))
        {
            VelocidadCaida = JumpForce;
            movePlayer.y = VelocidadCaida;
        }
    }
    void SetGravedad()
    {
        if (Player.isGrounded)
        {
            VelocidadCaida = -(Player.velocity.magnitude + 1f);
            movePlayer.y = VelocidadCaida;
        }
        else
        {
            VelocidadCaida -= Gravedad * Time.deltaTime;
            movePlayer.y = VelocidadCaida;
        }
    }
}